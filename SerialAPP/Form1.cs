using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialAPP
{
    public partial class Form1 : Form
    {
        private SerialPort SP = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// 初始化串口参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cobPort.Items.AddRange(SerialPort.GetPortNames());
            if (cobPort.Items.Count > 0)
            {
                cobPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("未发现端口！", "串口工具", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cobBaud.SelectedIndex = 4;
            cobData.SelectedIndex = 0;
            cobStop.SelectedIndex = 0;
            cobCheck.SelectedIndex = 0;

            SP.DataReceived += new SerialDataReceivedEventHandler(SP_DataReceived);
        }
        /// <summary>
        /// 串口接收函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[SP.BytesToRead];
            SP.Read(data, 0, data.Length);
            PrintData(data);
            txtNum1.Text = data.Length.ToString();
        }

        private void PrintData(byte[] data)
        {
            if (hex1.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                AppendTorichTextBox(sb.ToString());
            }
            else if (ascii1.Checked)
            {
                AppendTorichTextBox(new ASCIIEncoding().GetString(data));
            }
            else if (utf1.Checked)
            {
                AppendTorichTextBox(new UTF8Encoding().GetString(data));
            }
            else
            {
                AppendTorichTextBox(new UnicodeEncoding().GetString(data));
            }
        }

        private void AppendTorichTextBox(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (checkBox1.Checked && txtReceive.Text.Length > 0)
                {
                    txtReceive.AppendText("\r");
                }
                txtReceive.AppendText(content);
            }));
        }
        /// <summary>
        /// 创建串口实例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "打开串口")
            {
                if (cobPort.Text == "")
                {
                    MessageBox.Show("端口为空！", "串口工具", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SP.PortName = cobPort.Text;
                SP.BaudRate = Convert.ToInt32(cobBaud.Text);
                SP.DataBits = Convert.ToInt32(cobData.Text);
                SP.Parity = Parity.None;
                SP.StopBits = (StopBits)Convert.ToInt32(cobStop.Text);

                try
                {
                    SP.Open();
                    Send.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "串口工具", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                button1.Text = "关闭串口";
                button2.BackColor = Color.Green;
            }
            else
            {
                SP.Close();
                Send.Enabled = false;

                button1.Text = "打开串口";
                button2.BackColor = Color.Red;
            }

            cobPort.Enabled = !SP.IsOpen;
            cobData.Enabled = !SP.IsOpen;
            cobCheck.Enabled = !SP.IsOpen;
            cobBaud.Enabled = !SP.IsOpen;
            cobStop.Enabled = !SP.IsOpen;
        }

        private void cobPort_MouseClick(object sender, MouseEventArgs e)
        {
            cobPort.Items.Clear();
            cobPort.Items.AddRange(SerialPort.GetPortNames());
        }
        /// <summary>
        /// 清除接收区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearR_Click(object sender, EventArgs e)
        {
            txtReceive.Clear();
        }
        /// <summary>
        /// 清除发送区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearS_Click(object sender, EventArgs e)
        {
            txtSend.Clear();
        }
        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Send_Click(object sender, EventArgs e)
        {
            byte[] Data = null;

            if (hex2.Checked)
            {
                Data = strToHex(txtSend.Text.Trim());
            }
            else if (ascii2.Checked)
            {
                Data = Encoding.ASCII.GetBytes(txtSend.Text.Trim());
            }
            else if (utf2.Checked)
            {
                Data = Encoding.UTF8.GetBytes(txtSend.Text.Trim());
            }
            else
            {
                Data = Encoding.Unicode.GetBytes(txtSend.Text.Trim());
            }

            if (SendData(Data))
            {
                txtNum2.Text = Data.Length.ToString();
            }
            txtSend.Text = "";
        }

        private bool SendData(byte[] data)
        {
            if (SP.IsOpen)
            {
                try
                {
                    SP.Write(data, 0, data.Length);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "串口工具", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private byte[] strToHex(string str)
        {
            str = str.Replace(" ", "");
            if ((str.Length % 2) != 0)
            {
                str += " ";
            }
            byte[] returndata = new byte[str.Length / 2];
            for (int i = 0; i < returndata.Length; i++)
            {
                returndata[i] = Convert.ToByte(str.Substring(i * 2, 2).Replace(" ", ""));
            }
            return returndata;
        }
        /// <summary>
        /// 检测串口有无连接，防止人为拔掉USB导致异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!SP.IsOpen)
            {
                Send.Enabled = false;

                button1.Text = "打开串口";
                button2.BackColor = Color.Red;

                cobPort.Enabled = !SP.IsOpen;
                cobData.Enabled = !SP.IsOpen;
                cobCheck.Enabled = !SP.IsOpen;
                cobBaud.Enabled = !SP.IsOpen;
                cobStop.Enabled = !SP.IsOpen;
            }
        }
    }
}
