namespace SerialAPP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearR = new System.Windows.Forms.Button();
            this.ClearS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobCheck = new System.Windows.Forms.ComboBox();
            this.cobStop = new System.Windows.Forms.ComboBox();
            this.cobData = new System.Windows.Forms.ComboBox();
            this.cobBaud = new System.Windows.Forms.ComboBox();
            this.cobPort = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unicode2 = new System.Windows.Forms.RadioButton();
            this.utf2 = new System.Windows.Forms.RadioButton();
            this.ascii2 = new System.Windows.Forms.RadioButton();
            this.hex2 = new System.Windows.Forms.RadioButton();
            this.Send = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.unicode1 = new System.Windows.Forms.RadioButton();
            this.utf1 = new System.Windows.Forms.RadioButton();
            this.ascii1 = new System.Windows.Forms.RadioButton();
            this.hex1 = new System.Windows.Forms.RadioButton();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 597);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearR);
            this.groupBox2.Controls.Add(this.ClearS);
            this.groupBox2.Location = new System.Drawing.Point(3, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "清空消息";
            // 
            // ClearR
            // 
            this.ClearR.Location = new System.Drawing.Point(29, 40);
            this.ClearR.Name = "ClearR";
            this.ClearR.Size = new System.Drawing.Size(121, 43);
            this.ClearR.TabIndex = 3;
            this.ClearR.Text = "清空接收区";
            this.ClearR.UseVisualStyleBackColor = true;
            this.ClearR.Click += new System.EventHandler(this.ClearR_Click);
            // 
            // ClearS
            // 
            this.ClearS.Location = new System.Drawing.Point(175, 40);
            this.ClearS.Name = "ClearS";
            this.ClearS.Size = new System.Drawing.Size(121, 43);
            this.ClearS.TabIndex = 4;
            this.ClearS.Text = "清空发送区";
            this.ClearS.UseVisualStyleBackColor = true;
            this.ClearS.Click += new System.EventHandler(this.ClearS_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(43, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 45);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobCheck);
            this.groupBox1.Controls.Add(this.cobStop);
            this.groupBox1.Controls.Add(this.cobData);
            this.groupBox1.Controls.Add(this.cobBaud);
            this.groupBox1.Controls.Add(this.cobPort);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(173, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(173, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(170, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(170, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(173, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "端口";
            // 
            // cobCheck
            // 
            this.cobCheck.FormattingEnabled = true;
            this.cobCheck.Items.AddRange(new object[] {
            "None"});
            this.cobCheck.Location = new System.Drawing.Point(21, 198);
            this.cobCheck.Name = "cobCheck";
            this.cobCheck.Size = new System.Drawing.Size(121, 23);
            this.cobCheck.TabIndex = 4;
            // 
            // cobStop
            // 
            this.cobStop.FormattingEnabled = true;
            this.cobStop.Items.AddRange(new object[] {
            "1",
            "None"});
            this.cobStop.Location = new System.Drawing.Point(21, 157);
            this.cobStop.Name = "cobStop";
            this.cobStop.Size = new System.Drawing.Size(121, 23);
            this.cobStop.TabIndex = 3;
            // 
            // cobData
            // 
            this.cobData.FormattingEnabled = true;
            this.cobData.Items.AddRange(new object[] {
            "8"});
            this.cobData.Location = new System.Drawing.Point(21, 117);
            this.cobData.Name = "cobData";
            this.cobData.Size = new System.Drawing.Size(121, 23);
            this.cobData.TabIndex = 2;
            // 
            // cobBaud
            // 
            this.cobBaud.FormattingEnabled = true;
            this.cobBaud.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cobBaud.Location = new System.Drawing.Point(21, 75);
            this.cobBaud.Name = "cobBaud";
            this.cobBaud.Size = new System.Drawing.Size(121, 23);
            this.cobBaud.TabIndex = 1;
            // 
            // cobPort
            // 
            this.cobPort.FormattingEnabled = true;
            this.cobPort.Location = new System.Drawing.Point(21, 33);
            this.cobPort.Name = "cobPort";
            this.cobPort.Size = new System.Drawing.Size(121, 23);
            this.cobPort.TabIndex = 0;
            this.cobPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cobPort_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(329, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 597);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNum2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.unicode2);
            this.groupBox4.Controls.Add(this.utf2);
            this.groupBox4.Controls.Add(this.ascii2);
            this.groupBox4.Controls.Add(this.hex2);
            this.groupBox4.Controls.Add(this.Send);
            this.groupBox4.Controls.Add(this.txtSend);
            this.groupBox4.Location = new System.Drawing.Point(5, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(737, 152);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据发送区";
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNum2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum2.ForeColor = System.Drawing.Color.Green;
            this.txtNum2.Location = new System.Drawing.Point(479, 112);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.ReadOnly = true;
            this.txtNum2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNum2.Size = new System.Drawing.Size(45, 25);
            this.txtNum2.TabIndex = 7;
            this.txtNum2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "发送字节数：";
            // 
            // unicode2
            // 
            this.unicode2.AutoSize = true;
            this.unicode2.Location = new System.Drawing.Point(250, 118);
            this.unicode2.Name = "unicode2";
            this.unicode2.Size = new System.Drawing.Size(84, 19);
            this.unicode2.TabIndex = 5;
            this.unicode2.Text = "Unicode";
            this.unicode2.UseVisualStyleBackColor = true;
            // 
            // utf2
            // 
            this.utf2.AutoSize = true;
            this.utf2.Location = new System.Drawing.Point(163, 118);
            this.utf2.Name = "utf2";
            this.utf2.Size = new System.Drawing.Size(68, 19);
            this.utf2.TabIndex = 4;
            this.utf2.Text = "UTF-8";
            this.utf2.UseVisualStyleBackColor = true;
            // 
            // ascii2
            // 
            this.ascii2.AutoSize = true;
            this.ascii2.Checked = true;
            this.ascii2.Location = new System.Drawing.Point(77, 118);
            this.ascii2.Name = "ascii2";
            this.ascii2.Size = new System.Drawing.Size(68, 19);
            this.ascii2.TabIndex = 3;
            this.ascii2.TabStop = true;
            this.ascii2.Text = "ASCII";
            this.ascii2.UseVisualStyleBackColor = true;
            // 
            // hex2
            // 
            this.hex2.AutoSize = true;
            this.hex2.Location = new System.Drawing.Point(6, 118);
            this.hex2.Name = "hex2";
            this.hex2.Size = new System.Drawing.Size(52, 19);
            this.hex2.TabIndex = 2;
            this.hex2.Text = "Hex";
            this.hex2.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Enabled = false;
            this.Send.Location = new System.Drawing.Point(626, 111);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(105, 33);
            this.Send.TabIndex = 1;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(6, 24);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(725, 81);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNum1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.unicode1);
            this.groupBox3.Controls.Add(this.utf1);
            this.groupBox3.Controls.Add(this.ascii1);
            this.groupBox3.Controls.Add(this.hex1);
            this.groupBox3.Controls.Add(this.txtReceive);
            this.groupBox3.Location = new System.Drawing.Point(5, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 423);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据接收区";
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNum1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNum1.ForeColor = System.Drawing.Color.Green;
            this.txtNum1.Location = new System.Drawing.Point(598, 23);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.ReadOnly = true;
            this.txtNum1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNum1.Size = new System.Drawing.Size(42, 25);
            this.txtNum1.TabIndex = 7;
            this.txtNum1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "接收字节数：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "自动换行";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // unicode1
            // 
            this.unicode1.AutoSize = true;
            this.unicode1.Location = new System.Drawing.Point(379, 25);
            this.unicode1.Name = "unicode1";
            this.unicode1.Size = new System.Drawing.Size(84, 19);
            this.unicode1.TabIndex = 4;
            this.unicode1.Text = "Unicode";
            this.unicode1.UseVisualStyleBackColor = true;
            // 
            // utf1
            // 
            this.utf1.AutoSize = true;
            this.utf1.Location = new System.Drawing.Point(293, 25);
            this.utf1.Name = "utf1";
            this.utf1.Size = new System.Drawing.Size(68, 19);
            this.utf1.TabIndex = 3;
            this.utf1.Text = "UTF-8";
            this.utf1.UseVisualStyleBackColor = true;
            // 
            // ascii1
            // 
            this.ascii1.AutoSize = true;
            this.ascii1.Checked = true;
            this.ascii1.Location = new System.Drawing.Point(219, 25);
            this.ascii1.Name = "ascii1";
            this.ascii1.Size = new System.Drawing.Size(68, 19);
            this.ascii1.TabIndex = 2;
            this.ascii1.TabStop = true;
            this.ascii1.Text = "ASCII";
            this.ascii1.UseVisualStyleBackColor = true;
            // 
            // hex1
            // 
            this.hex1.AutoSize = true;
            this.hex1.Location = new System.Drawing.Point(161, 25);
            this.hex1.Name = "hex1";
            this.hex1.Size = new System.Drawing.Size(52, 19);
            this.hex1.TabIndex = 1;
            this.hex1.Text = "Hex";
            this.hex1.UseVisualStyleBackColor = true;
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReceive.Location = new System.Drawing.Point(6, 58);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReceive.Size = new System.Drawing.Size(725, 359);
            this.txtReceive.TabIndex = 0;
            this.txtReceive.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobCheck;
        private System.Windows.Forms.ComboBox cobStop;
        private System.Windows.Forms.ComboBox cobData;
        private System.Windows.Forms.ComboBox cobBaud;
        private System.Windows.Forms.ComboBox cobPort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearR;
        private System.Windows.Forms.Button ClearS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.RichTextBox txtSend;
        private System.Windows.Forms.RichTextBox txtReceive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton unicode2;
        private System.Windows.Forms.RadioButton utf2;
        private System.Windows.Forms.RadioButton ascii2;
        private System.Windows.Forms.RadioButton hex2;
        private System.Windows.Forms.RadioButton unicode1;
        private System.Windows.Forms.RadioButton utf1;
        private System.Windows.Forms.RadioButton ascii1;
        private System.Windows.Forms.RadioButton hex1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

