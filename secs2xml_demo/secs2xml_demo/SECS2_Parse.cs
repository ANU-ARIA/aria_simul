using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

namespace secs2xml
{   
    class SECS2_Parse
    {
        private string m_data = string.Empty;
        public string m_stx = "<SECS2_XML_MESSAGE>";
        public string m_etx = "</SECS2_XML_MESSAGE>";

        public static string eq = "";

        public SECS2_Parse()
        {
        }

        public string MakeXml(SECS2_XML_MESSAGE _packet)
        {
            string sXml = "";

            XmlSerializer serializer = new XmlSerializer(typeof(SECS2_XML_MESSAGE));
            TextWriter writer = new StringWriter();
            serializer.Serialize(writer, _packet);
            sXml = writer.ToString();

            return sXml;
        }

        public void ParseXml(string _sXml, ref SECS2_XML_MESSAGE _rPacket)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SECS2_XML_MESSAGE));
            TextReader reader = new StringReader(_sXml);
            _rPacket = (SECS2_XML_MESSAGE)serializer.Deserialize(reader);
        }


        public void set_recv_data(string _data)
        {
            m_data += _data;
        }

        public List<string> parsing_data()
        {

            List<string> parsed_msg = new List<string>();
            int stx_pos = -1;
            int etx_pos = -1;

            // stx 없으면 처리 하지 않는다.
            stx_pos = m_data.IndexOf(m_stx);
            if (stx_pos < 0)
            {
                return parsed_msg;
            }

            // 데이터 중 가장 왼쪽에 있는 stx보다 더 왼쪽에 있는 데이터들은 쓰레기다.
            m_data = m_data.Remove(0, stx_pos);

            stx_pos = m_data.IndexOf(m_stx);
            etx_pos = m_data.IndexOf(m_etx);
            // etx 없으면 처리 하지 않는다.
            if (etx_pos < 0)
            {
                return parsed_msg;
            }


            // etx보다 먼저 나오는 2번째 stx가 있으면 1번째 stx ~ 2번째 stx 사이는 쓰레기다.
            // 전부 검사해서 stx ~ etx 정상적인 data 가려낸다.
            while (true)
            {
                // stx, etx 위치 다시 계산.
                stx_pos = m_data.IndexOf(m_stx);
                etx_pos = m_data.IndexOf(m_etx);

                int sstx = m_data.IndexOf(m_stx, stx_pos + 1);
                if (sstx > 0 && sstx < etx_pos)
                {
                    m_data = m_data.Remove(0, sstx);
                }
                else
                {
                    break;
                }
            }


            // 메시지 추출 위해 stx, etx 위치 다시 계산.
            stx_pos = m_data.IndexOf(m_stx);
            etx_pos = m_data.IndexOf(m_etx);

            // 맨 왼쪽 msg 추출.
            string msg = m_data.Substring(stx_pos + m_stx.Length, etx_pos - m_etx.Length);
            parsed_msg.Add(msg);
            m_data = m_data.Remove(stx_pos, etx_pos + m_etx.Length);


            // 명령이 연달아 들어 올 경우 대비 재귀 호출하여 처리 한다.
            while (true)
            {
                List<string> slist = parsing_data();
                if (slist.Count == 0)
                    break;

                foreach (var inner_msg in slist)
                {
                    parsed_msg.Add(inner_msg);
                }
            }

            return parsed_msg;
        }
    }
}

