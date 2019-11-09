using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace secs2xml
{
    public enum eTCP_TYPE { Server = 0, Client = 1 }

    public enum eACKC6 { Accepted = 0, NotAccepted = 1 }
    public enum eHCACK {
        Acknowledge = 0, Command_does_not_exist = 1,
        Cannot_perform_now = 2, parameter_is_invalid = 3, Acknowledge_will_be_performed = 4,
        Rejected = 5, No_object_exists = 6
    }

    public enum eCMD { link_test_req = 1, link_test_rsp = 2, user = 3, separate_req = 5 };

    class HostCmd_LotStart_Params
    {
        private string sHostCmd_Field;
        private List<SECS2_XML_MESSAGEBODYCMD_PARAM> _CmdParams_Field = new List<SECS2_XML_MESSAGEBODYCMD_PARAM>();

        public HostCmd_LotStart_Params(string _sHostCmd, string _sLotId, string _sModel, int nPdCount, string _sLineId, string _sColor)
        {
            sHostCmd_Field = _sHostCmd;
            // Lot id
            SECS2_XML_MESSAGEBODYCMD_PARAM paramLotId = new SECS2_XML_MESSAGEBODYCMD_PARAM();
            paramLotId.CPNAME = "LOT_ID";
            paramLotId.CPVALUE = _sLotId;
            _CmdParams_Field.Add(paramLotId);

            // prod model
            SECS2_XML_MESSAGEBODYCMD_PARAM paramProdModel = new SECS2_XML_MESSAGEBODYCMD_PARAM();
            paramProdModel.CPNAME = "PROD_MODEL";
            paramProdModel.CPVALUE = _sModel;
            _CmdParams_Field.Add(paramProdModel);

            // prod count
            SECS2_XML_MESSAGEBODYCMD_PARAM paramProdCount = new SECS2_XML_MESSAGEBODYCMD_PARAM();
            paramProdCount.CPNAME = "PROD_COUNT";
            paramProdCount.CPVALUE = nPdCount.ToString();
            _CmdParams_Field.Add(paramProdCount);
            // Line Number
            SECS2_XML_MESSAGEBODYCMD_PARAM param_LineNum = new SECS2_XML_MESSAGEBODYCMD_PARAM();
            param_LineNum.CPNAME = "LINE_ID";
            param_LineNum.CPVALUE = _sLineId;
            _CmdParams_Field.Add(param_LineNum);

            // prod color
            SECS2_XML_MESSAGEBODYCMD_PARAM param_Color = new SECS2_XML_MESSAGEBODYCMD_PARAM();
            param_Color.CPNAME = "PROD_COLOR";
            param_Color.CPVALUE = _sColor;
            _CmdParams_Field.Add(param_Color);
        }

        public string HOSTCMD
        {
            get { return sHostCmd_Field; }
        }
        public List<SECS2_XML_MESSAGEBODYCMD_PARAM> CMD_PARAMS
        {
            get { return _CmdParams_Field; }
        }
    }

    class TCP_Socket
    {
        private static int m_nSystemByte = 0;

        public eTCP_TYPE m_TCP_TYPE;
        public string m_sIpAddress;
        public int m_nPort;

        static private SECS2_Parse m_parser = new SECS2_Parse();
        public delegate void recv_callback(string _msg);

        static recv_callback m_recv_callback;
        private Thread m_recv_thread;        

        static TcpListener m_listener;
        static TcpClient m_tc;
        static NetworkStream m_stream;

        public TCP_Socket(recv_callback _recv_callback = null)
        {
            m_recv_callback = _recv_callback;            
        }

        public int Init_Comm(eTCP_TYPE _Type, string _ip, int _nPort=54321)
        {
            m_TCP_TYPE = _Type;
            m_sIpAddress = _ip;
            m_nPort = _nPort;
            // server
            if (_Type == eTCP_TYPE.Server)
            {
                m_listener = new TcpListener(IPAddress.Any, _nPort);
                m_listener.Start();
                m_listener.BeginAcceptTcpClient(tcp_client_async_callback, new object());
            }
            else // client
            {
                IPEndPoint client_add = new IPEndPoint(IPAddress.Parse(_ip), _nPort);
                m_tc = new TcpClient(client_add);
            }

            ThreadStart ts = new ThreadStart(run);
            m_recv_thread = new Thread(ts);
            m_recv_thread.Start();

            return 0;
        }

        public int MakeSystemByte()
        {
            if (m_nSystemByte > 9999999) m_nSystemByte = 0;
            return m_nSystemByte++;
        }
        public void analyze_xml(string _rcv_msg, ref SECS2_XML_MESSAGE _it)
        {            
            m_parser.ParseXml(_rcv_msg, ref _it);  
        }

        private int do_Send(SECS2_XML_MESSAGE _packet)
        {
            int nErr = 0;

            string sMsg = m_parser.MakeXml(_packet);

            // socket stream writer로 write 해준다.
            // client_stream.Wirte( sMsg );
            byte[] s_buff = Encoding.Default.GetBytes(sMsg);
            m_stream.Write(s_buff, 0, sMsg.Length);

            return nErr;
        }

        public int Send_S2F41_HostCommand(string _HostCmd, List<SECS2_XML_MESSAGEBODYCMD_PARAM> _CmdParams)
        {
            int nErr = 0;

            SECS2_XML_MESSAGE Packet = new SECS2_XML_MESSAGE(MakeSystemByte(), (byte)eCMD.user, 2, 41);

            Packet.BODY.RCMD = _HostCmd;

            Packet.BODY.PARAMETERS = new SECS2_XML_MESSAGEBODYCMD_PARAM[_CmdParams.Count()];
            int i = 0;
            foreach (SECS2_XML_MESSAGEBODYCMD_PARAM it in _CmdParams )
            {
                // Packet.BODY.PARAMETERS[i].CPNAME  = it.CPNAME;
                // Packet.BODY.PARAMETERS[i].CPVALUE = it.CPVALUE;
                Packet.BODY.PARAMETERS[i] = it;
                i++;
            }

            nErr = do_Send(Packet);

            return nErr;
        }
        public int Send_S2F42_HostCmdAck(eHCACK _nHCACK)
        {
            int nErr = 0;
            SECS2_XML_MESSAGE Packet = new SECS2_XML_MESSAGE(MakeSystemByte(), (byte)eCMD.user, 2, 42);

            Packet.BODY.HCACK = (int)_nHCACK;

            nErr = do_Send(Packet);
            return nErr;
        }
        public int Send_S6F12_EventReportAck(eACKC6 _nACKC6)
        {
            int nErr = 0;
            SECS2_XML_MESSAGE Packet = new SECS2_XML_MESSAGE(MakeSystemByte(), (byte)eCMD.user, 6, 12);

            Packet.BODY.ACKC6 = (int)_nACKC6;

            nErr = do_Send(Packet);
            return nErr;
        }


        private static void tcp_client_async_callback(IAsyncResult ar)
        {
            m_tc = m_listener.EndAcceptTcpClient(ar);
        }

        public void close()
        {
            // (6) 스트림과 TcpClient 객체 
            if (m_stream != null)
                m_stream.Close();

            if (m_tc != null)
                m_tc.Close();

            if (m_recv_thread != null)
            {
                m_recv_thread.Abort();
            }
        }

        private static void run()
        {
            while (true)
            {
                Thread.Sleep(10);
                try
                {

                    if (m_tc == null || m_tc.Connected == false)
                        continue;

                    m_stream = m_tc.GetStream();

                    byte[] buff = new byte[1024];

                    // (4) 클라이언트가 연결을 끊을 때까지 데이타 수신
                    int nbytes;
                    while ((nbytes = m_stream.Read(buff, 0, buff.Length)) > 0)
                    {
                        string recv_text = Encoding.UTF8.GetString(buff);
                        m_parser.set_recv_data(recv_text);

                        List<string> parsed_msg = m_parser.parsing_data();
                        foreach (var msg in parsed_msg)
                        {
                            // m_recv_callback 존재 할 경우 호출.
                            m_recv_callback?.Invoke(msg);
                        }
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine( "SocketException: {0}", e );
                }
                finally
                {
                    if (m_listener != null)
                    {
                        m_listener.BeginAcceptTcpClient(tcp_client_async_callback, new object());
                    }
                }
            }
        }
    }
}


