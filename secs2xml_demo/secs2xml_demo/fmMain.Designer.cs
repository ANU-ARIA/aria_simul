namespace secs2xml_demo
{
    partial class fmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_S2F41 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbS2F41_RCMD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbS2F41_PRODCOUNT = new System.Windows.Forms.TextBox();
            this.cbS2F41_PRODCOLOR = new System.Windows.Forms.ComboBox();
            this.tbS2F41_LINEID = new System.Windows.Forms.TextBox();
            this.tbS2F41_PRODMODEL = new System.Windows.Forms.TextBox();
            this.tbS2F41_LOTID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_HCACK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox_ACKC6 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.textBox_IPAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_Local = new System.Windows.Forms.CheckBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_Server = new System.Windows.Forms.CheckBox();
            this.tabControl_S2F41.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_S2F41
            // 
            this.tabControl_S2F41.Controls.Add(this.tabPage1);
            this.tabControl_S2F41.Controls.Add(this.tabPage2);
            this.tabControl_S2F41.Controls.Add(this.tabPage3);
            this.tabControl_S2F41.Controls.Add(this.tabPage4);
            this.tabControl_S2F41.Location = new System.Drawing.Point(1, 80);
            this.tabControl_S2F41.Name = "tabControl_S2F41";
            this.tabControl_S2F41.Padding = new System.Drawing.Point(6, 20);
            this.tabControl_S2F41.SelectedIndex = 0;
            this.tabControl_S2F41.Size = new System.Drawing.Size(493, 411);
            this.tabControl_S2F41.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_S2F41.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cbS2F41_RCMD);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbS2F41_PRODCOUNT);
            this.tabPage1.Controls.Add(this.cbS2F41_PRODCOLOR);
            this.tabPage1.Controls.Add(this.tbS2F41_LINEID);
            this.tabPage1.Controls.Add(this.tbS2F41_PRODMODEL);
            this.tabPage1.Controls.Add(this.tbS2F41_LOTID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 56);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "S2F41";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbS2F41_RCMD
            // 
            this.cbS2F41_RCMD.FormattingEnabled = true;
            this.cbS2F41_RCMD.Items.AddRange(new object[] {
            "LOT_START",
            "LOT_STOP"});
            this.cbS2F41_RCMD.Location = new System.Drawing.Point(164, 28);
            this.cbS2F41_RCMD.Name = "cbS2F41_RCMD";
            this.cbS2F41_RCMD.Size = new System.Drawing.Size(256, 20);
            this.cbS2F41_RCMD.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "REMOTE CMD";
            // 
            // tbS2F41_PRODCOUNT
            // 
            this.tbS2F41_PRODCOUNT.Location = new System.Drawing.Point(164, 148);
            this.tbS2F41_PRODCOUNT.Name = "tbS2F41_PRODCOUNT";
            this.tbS2F41_PRODCOUNT.Size = new System.Drawing.Size(256, 21);
            this.tbS2F41_PRODCOUNT.TabIndex = 9;
            this.tbS2F41_PRODCOUNT.Text = "10";
            // 
            // cbS2F41_PRODCOLOR
            // 
            this.cbS2F41_PRODCOLOR.FormattingEnabled = true;
            this.cbS2F41_PRODCOLOR.Items.AddRange(new object[] {
            "RED",
            "BLUE"});
            this.cbS2F41_PRODCOLOR.Location = new System.Drawing.Point(164, 232);
            this.cbS2F41_PRODCOLOR.Name = "cbS2F41_PRODCOLOR";
            this.cbS2F41_PRODCOLOR.Size = new System.Drawing.Size(256, 20);
            this.cbS2F41_PRODCOLOR.TabIndex = 8;
            // 
            // tbS2F41_LINEID
            // 
            this.tbS2F41_LINEID.Location = new System.Drawing.Point(164, 185);
            this.tbS2F41_LINEID.Name = "tbS2F41_LINEID";
            this.tbS2F41_LINEID.Size = new System.Drawing.Size(256, 21);
            this.tbS2F41_LINEID.TabIndex = 7;
            this.tbS2F41_LINEID.Text = "L#1";
            // 
            // tbS2F41_PRODMODEL
            // 
            this.tbS2F41_PRODMODEL.Location = new System.Drawing.Point(164, 110);
            this.tbS2F41_PRODMODEL.Name = "tbS2F41_PRODMODEL";
            this.tbS2F41_PRODMODEL.Size = new System.Drawing.Size(256, 21);
            this.tbS2F41_PRODMODEL.TabIndex = 6;
            this.tbS2F41_PRODMODEL.Text = "CHOCOPI-ARIA";
            // 
            // tbS2F41_LOTID
            // 
            this.tbS2F41_LOTID.Location = new System.Drawing.Point(164, 65);
            this.tbS2F41_LOTID.Name = "tbS2F41_LOTID";
            this.tbS2F41_LOTID.Size = new System.Drawing.Size(256, 21);
            this.tbS2F41_LOTID.TabIndex = 5;
            this.tbS2F41_LOTID.Text = "LOT_CHOCOPI-123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "PROD COLOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "LINE ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PROD COUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROD MODEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOT ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox_HCACK);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 56);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(485, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "S2F42";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_HCACK
            // 
            this.comboBox_HCACK.FormattingEnabled = true;
            this.comboBox_HCACK.Items.AddRange(new object[] {
            "0 : Acknowledge",
            "1 : Command_does_not_exist",
            "2 : Cannot_perform_now",
            "3 : parameter_is_invalid",
            "4 : Acknowledge_will_be_performed",
            "5 : Rejected",
            "6 : No_object_exists"});
            this.comboBox_HCACK.Location = new System.Drawing.Point(186, 161);
            this.comboBox_HCACK.Name = "comboBox_HCACK";
            this.comboBox_HCACK.Size = new System.Drawing.Size(256, 20);
            this.comboBox_HCACK.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "HCACK";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 56);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(485, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "S6F11";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "send";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.comboBox_ACKC6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 56);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(485, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "S6F12";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 48);
            this.button4.TabIndex = 13;
            this.button4.Text = "send";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_ACKC6
            // 
            this.comboBox_ACKC6.FormattingEnabled = true;
            this.comboBox_ACKC6.Items.AddRange(new object[] {
            "0 : Accepted",
            "1 : NotAccepted"});
            this.comboBox_ACKC6.Location = new System.Drawing.Point(186, 161);
            this.comboBox_ACKC6.Name = "comboBox_ACKC6";
            this.comboBox_ACKC6.Size = new System.Drawing.Size(256, 20);
            this.comboBox_ACKC6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "ACKC6";
            // 
            // listBox_Log
            // 
            this.listBox_Log.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox_Log.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Log.ForeColor = System.Drawing.Color.GreenYellow;
            this.listBox_Log.FormattingEnabled = true;
            this.listBox_Log.ItemHeight = 14;
            this.listBox_Log.Location = new System.Drawing.Point(1, 497);
            this.listBox_Log.Name = "listBox_Log";
            this.listBox_Log.Size = new System.Drawing.Size(1061, 186);
            this.listBox_Log.TabIndex = 3;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(378, 30);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 4;
            this.button_Connect.Text = "connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(482, 30);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect.TabIndex = 5;
            this.button_Disconnect.Text = "disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // textBox_IPAddress
            // 
            this.textBox_IPAddress.Location = new System.Drawing.Point(94, 32);
            this.textBox_IPAddress.Name = "textBox_IPAddress";
            this.textBox_IPAddress.Size = new System.Drawing.Size(93, 21);
            this.textBox_IPAddress.TabIndex = 7;
            this.textBox_IPAddress.Text = "127.0.0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "IP";
            // 
            // checkBox_Local
            // 
            this.checkBox_Local.AutoSize = true;
            this.checkBox_Local.Checked = true;
            this.checkBox_Local.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Local.Location = new System.Drawing.Point(292, 37);
            this.checkBox_Local.Name = "checkBox_Local";
            this.checkBox_Local.Size = new System.Drawing.Size(51, 16);
            this.checkBox_Local.TabIndex = 8;
            this.checkBox_Local.Text = "local";
            this.checkBox_Local.UseVisualStyleBackColor = true;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(193, 32);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(93, 21);
            this.textBox_Port.TabIndex = 10;
            this.textBox_Port.Text = "54321";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "PORT";
            // 
            // checkBox_Server
            // 
            this.checkBox_Server.AutoSize = true;
            this.checkBox_Server.Checked = true;
            this.checkBox_Server.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Server.Location = new System.Drawing.Point(18, 37);
            this.checkBox_Server.Name = "checkBox_Server";
            this.checkBox_Server.Size = new System.Drawing.Size(60, 16);
            this.checkBox_Server.TabIndex = 11;
            this.checkBox_Server.Text = "Server";
            this.checkBox_Server.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1062, 692);
            this.Controls.Add(this.checkBox_Server);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox_Local);
            this.Controls.Add(this.textBox_IPAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.listBox_Log);
            this.Controls.Add(this.tabControl_S2F41);
            this.Name = "fmMain";
            this.Text = "SECS2 XML DEMO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmMain_FormClosed);
            this.tabControl_S2F41.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_S2F41;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbS2F41_RCMD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbS2F41_PRODCOUNT;
        private System.Windows.Forms.ComboBox cbS2F41_PRODCOLOR;
        private System.Windows.Forms.TextBox tbS2F41_LINEID;
        private System.Windows.Forms.TextBox tbS2F41_PRODMODEL;
        private System.Windows.Forms.TextBox tbS2F41_LOTID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_HCACK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_ACKC6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.TextBox textBox_IPAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_Local;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_Server;
    }
}

