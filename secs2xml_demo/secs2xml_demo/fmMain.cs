using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using secs2xml;

namespace secs2xml_demo
{
    public partial class fmMain : Form
    {

        TCP_Socket m_tcp_comm;
        public fmMain()
        {
            InitializeComponent();
            m_tcp_comm = new TCP_Socket(on_receive_tcp);
        }

        // Callback 함수.
        private void on_receive_tcp(string _msg)
        {
            SECS2_XML_MESSAGE item = new SECS2_XML_MESSAGE();
            m_tcp_comm.analyze_xml(_msg, ref item);
            if (item.HEAD.Stream == 2)
            {
                if (item.HEAD.Function == 41)
                {
                }
                else if (item.HEAD.Function == 42)
                {                    
                }
            }
            else if (item.HEAD.Stream == 6)
            {
                if (item.HEAD.Function == 11)
                {
                    if (item.BODY.CEID == 1) // production complete, 1개 제품 생산 완료.
                    {
                    }
                    else if (item.BODY.CEID == 2) // Lot Started
                    {
                    }
                    else if (item.BODY.CEID == 3) // Lot Complete
                    {
                    }
                    else if (item.BODY.CEID == 4) // Env Updated
                    {
                    }
                }
                else if (item.HEAD.Function == 12)
                {                    
                }
            }
            listBox_Log.Items.Add(_msg);
        }

        // send s2f41
        private void button1_Click(object sender, EventArgs e)
        {
            HostCmd_LotStart_Params Params = new HostCmd_LotStart_Params(
                cbS2F41_RCMD.Text,
                tbS2F41_LOTID.Text,
                tbS2F41_PRODMODEL.Text,
                Int32.Parse(tbS2F41_PRODCOUNT.Text),
                tbS2F41_LINEID.Text,
                cbS2F41_PRODCOLOR.Text
                );           

            m_tcp_comm.Send_S2F41_HostCommand(Params.HOSTCMD, Params.CMD_PARAMS);
        }

        // sned s6f12
        private void button4_Click(object sender, EventArgs e)
        {
            eACKC6 _ackc6 = (eACKC6)comboBox_ACKC6.SelectedIndex;
            m_tcp_comm.Send_S6F12_EventReportAck(_ackc6);
        }
        // send s2f42
        private void button2_Click(object sender, EventArgs e)
        {
            eHCACK _hcack = (eHCACK)comboBox_HCACK.SelectedIndex;
            m_tcp_comm.Send_S2F42_HostCmdAck(_hcack);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            eTCP_TYPE _Type = checkBox_Server.Checked ? eTCP_TYPE.Server : eTCP_TYPE.Client;
            string _ip = textBox_IPAddress.Text;
            int _port = Int32.Parse(textBox_Port.Text);
            m_tcp_comm.Init_Comm(_Type, _ip, _port);
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            m_tcp_comm.close();
        }

        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_tcp_comm.close();
        }
    }
}
