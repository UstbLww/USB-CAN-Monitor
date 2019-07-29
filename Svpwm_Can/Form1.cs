using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;   //使用串口
using System.Threading.Tasks;  //线程
using System.Runtime.InteropServices;

namespace Svpwm_Can
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /*保存串口信息*/
        string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "data.ini";//ini文件名
        StringBuilder temp = new StringBuilder(255);   //存储读出ini内容变量  存储COM口
        StringBuilder temp1 = new StringBuilder(255); //存储波特率
        string CurrentPortName, CurrentBps;

        /*帧定义*/
        int maxDatalen = 200;          //最大字节数组
        byte[] head = { 0x00, 0x55 };  //帧头
        byte[] rear = { 0x00, 0x55 };  //帧尾
        byte[] frameData;              //帧数据
        int errorNum = 0;              //错误帧计数



        private delegate void UpdateBufferEventHandle(byte[] data, int bufferlen);   //定义多重委托
        private event UpdateBufferEventHandle bufferChanged;          //定义事件

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)   //界面初始化
        {
            GetPrivateProfileString("PortData", "PortName", "COM0", temp, 256, FileName);//读取ini值，默认是COM0
            GetPrivateProfileString("BpsData", "Bps", "9600", temp1, 256, FileName);     //读取ini值，默认是9600
            comboBox_Ports.Text = temp.ToString();      //初始化
            comboBox_Bps.Text = temp1.ToString();
            //comboBox_Ports.SelectedIndex = 0;         //端口默认COM0
            //comboBox_Bps.SelectedIndex = 3;           //波特率默认9600
            button_Close.Enabled = false;
            serialPort1.DataReceived += SerialPort1_DataReceived;   //添加串口接受数据事件
            //Control.CheckForIllegalCrossThreadCalls = false;        //禁止跨线程审查
            bufferChanged += new UpdateBufferEventHandle(HandleBuffer);   //将事件处理方法添加到事件中去
            tabControl1.SelectedTab = this.tabPage1;  //设置默认tabPage
            InitLight();  //初始化提示灯
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   //保存设置
        {
            CurrentPortName = comboBox_Ports.Text;
            CurrentBps = comboBox_Bps.Text;
            WritePrivateProfileString("PortData", "PortName", CurrentPortName, FileName);
            WritePrivateProfileString("BpsData", "Bps", CurrentBps, FileName);
        }


        private void button_Scan_Click(object sender, EventArgs e)   //寻找可用端口
        {
            SerchAndAddSerialToCombox(serialPort1, comboBox_Ports);
        }

        private void button_Open_Click(object sender, EventArgs e)   //打开端口
        {
            try    //防止打开没有对应的端口
            {
                serialPort1.PortName = comboBox_Ports.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_Bps.Text, 10);   //转成10进制
                serialPort1.Open();
                button_Open.Enabled = false;
                button_Close.Enabled = true;
                tabControl1.SelectedTab = this.tabPage1;  //设置默认tabPage
            }
            catch
            {
                MessageBox.Show("端口连接错误，请重新检查端口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)  //关闭端口
        {
            try    //防止没有打开端口就关闭产生的错误，这里因为打开之前不能关闭按钮，可加可不加
            {
                serialPort1.Close();
                button_Open.Enabled = true;
                button_Close.Enabled = false;
                tabControl1.SelectedTab = this.tabPage1;  //设置默认tabPage
                InitLight();
            }
            catch { }
        }


        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //串口接受数据事件
        {
            if (serialPort1.IsOpen)
            {
                int buffersize = serialPort1.BytesToRead;
                byte[] data = new byte[buffersize];
                serialPort1.Read(data, 0, buffersize);
                this.BeginInvoke(bufferChanged, data, buffersize);     //异步通过invoke调用事件
                System.Threading.Thread.Sleep(100);   //线程挂起100毫秒，线程挂起不消耗CPU资源             
            }
        }

        private void HandleBuffer(byte[] data, int bufferlen)   //接收到串口字节后事件处理方法
        {
            label_Buffersize.Text = bufferlen.ToString();
            if (bufferlen > maxDatalen)
            {
                data = Remove(data, 0, data.Length - maxDatalen);
            }

            int headindex, rearindex = SearchIndex(data, rear, data.Length);  //帧尾
            if (rearindex >= 0)
            {
                headindex = SearchIndex(data, head, rearindex);  //帧头
                if (headindex >= 0)
                {
                    frameData = GetSection(data, headindex + 2, rearindex - 1);
                    if (frameData != null)
                    {
                        if (frameData.Length == 8)
                        {
                            switch (frameData[0])
                            {
                                case 0x00:    //准备模式
                                    textBox_Test.AppendText("连接成功!" + "\n");
                                    if (50 == textBox_Test.Lines.Length)     //或者使用Lines.GetUpperBound(0) 
                                    {
                                        textBox_Test.Text.Remove(0, textBox_Test.Text.IndexOf("\n") + 1);  //删除第一行
                                    }
                                    InitLight();  //初始化提示灯
                                    break;

                                case 0x01:    //运行模式
                                    label_Ia.Text = ((Int32)frameData[1]).ToString();
                                    label_Ic.Text = ((Int32)frameData[2]).ToString();
                                    label_Udc.Text = ((Int32)frameData[3]).ToString();  //选int16对于转速不够
                                    label_Vel.Text = ((Int32)(frameData[4] + frameData[5] * 256 + frameData[6] * 65536)).ToString();
                                    button_Ia.Visible = true;  //设置为可见
                                    button_Ic.Visible = true;
                                    button_Udc.Visible = true;
                                    button_Vector.Visible = true;
                                    break;

                                case 0x02:   //出错模式
                                    label_Ia.Text = 0.ToString();
                                    label_Ic.Text = 0.ToString();
                                    label_Udc.Text = 0.ToString();
                                    label_Vel.Text = 0.ToString();
                                    
                                    if (frameData[4] == 0x01)  //母线欠压
                                    {
                                        button_Udc.Visible = true;
                                        button_Udc.BackgroundImage = Properties.Resources.Yellow_light;
                                    }
                                    else if (frameData[4] == 0x02)  //母线过压
                                    {
                                        button_Udc.Visible = true;
                                        button_Udc.BackgroundImage = Properties.Resources.Red_light;
                                    }

                                    if (frameData[5] == 0x01) //A相过流
                                    {
                                        button_Ia.Visible = true;  //设置为可见
                                        button_Ia.BackgroundImage = Properties.Resources.Red_light;
                                    }
                                    if (frameData[6] == 0x01)  //C相过流
                                    {
                                        button_Ic.Visible = true;
                                        button_Ic.BackgroundImage = Properties.Resources.Red_light;
                                    }
                                    if (frameData[7] == 0x01)  //电压矢量超范围
                                    {
                                        button_Vector.Visible = true;
                                        button_Vector.BackgroundImage = Properties.Resources.Red_light;
                                    }
                                    break;
                            }
                        }
                    }
                }
                else    //没有找到帧数据
                {
                    errorNum++;
                    label_ErrNum.Text = errorNum.ToString();
                }
            }

        }
        
        //发送控制消息
        private void button_ControlSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int velocity = Decimal.ToInt32(numericUpDown_Vel.Value);
                if (0 <= velocity && velocity <= 150000)
                {
                    byte[] id = { 0x00, 0x55 };
                    byte[] control = {0x02, 0x01, 0x00, 0x01 }; 
                    byte[] vel = ConvertHex(velocity);
                    if (velocity == 0)
                    {
                        control[1] = 0x00;
                    }
                    byte[] data = new byte[id.Length + control.Length + vel.Length];
                    data[0] = id[0];
                    data[1] = id[1];
                    data[2] = control[0];
                    data[3] = control[1];
                    data[4] = control[2];
                    data[5] = control[3];
                    data[6] = vel[0];
                    data[7] = vel[1];
                    data[8] = vel[2];
                    data[9] = vel[3];
                    serialPort1.Write(data, 0, 10);
                    textBox_Test.AppendText("已发送" + "\n");
                }
                else
                {
                    MessageBox.Show("请输入0~150000之间的速度", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("请连接CAN", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
        //清空测试框
        private void button_Clear_Click(object sender, EventArgs e)  
        {
            textBox_Test.Clear();
        }


        //让DSP记录数据
        private void button_Record_Click(object sender, EventArgs e)
        {
            byte[] data = {0x00, 0x55, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
            serialPort1.Write(data, 0, 10);
        }



        //寻找并存储可用端口
        private static void SerchAndAddSerialToCombox(SerialPort serialports, ComboBox mycombox)   //static
        {
            string[] portname = new string[10];   //用来存储可用端口
            string buffer;                        //用来暂存端口号
            mycombox.Items.Clear();               //从combox移除所有项
            int count = 0;
            for (int i = 1; i < 10; i++)
            {
                try
                {
                    buffer = "COM" + i.ToString();
                    serialports.PortName = buffer;
                    serialports.Open();        //打开串口，倘若能打开执行以下语,否则转到循环条件
                    portname[count] = buffer;  //利用try,catch
                    mycombox.Items.Add(buffer);
                    serialports.Close();
                    count++;
                }
                catch { }
            }

            mycombox.Text = portname[0];  //初始化combox
            if (mycombox.Text == "")
            {
                MessageBox.Show("没有发现端口，请重新插入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //提示灯初始化，不可见且背景图片为绿色
        private void InitLight()
        {
            button_Ia.Visible = false;  
            button_Ia.BackgroundImage = Properties.Resources.Green_light;
            button_Ic.Visible = false;
            button_Ic.BackgroundImage = Properties.Resources.Green_light;
            button_Udc.Visible = false;
            button_Udc.BackgroundImage = Properties.Resources.Green_light;
            button_Vector.Visible = false;
            button_Vector.BackgroundImage = Properties.Resources.Green_light;

        }

        //将转速转换为字节数组
        private byte[] ConvertHex(int vel)
        {
            int velocity = vel;
            byte[] hex = new byte[4];
            hex[0] = (byte)(velocity & 0xff);
            hex[1] = (byte)((velocity >> 8) & 0xff);
            hex[2] = (byte)((velocity >> 16) & 0xff);
            hex[3] = (byte)((velocity >> 24) & 0xff);
            return hex;
        }

        /// <summary>
        /// 删除字节数组的某段
        /// </summary>
        /// <param name="src">源字节数组</param>
        /// <param name="start">开始序号</param>
        /// <param name="end">末尾序号</param>
        /// <returns></returns>
        private byte[] Remove(byte[] src, int start, int end)  //缓冲区的字节数组从位置0开始
        {
            if (start >= end)
                return src;
            if (start < 0)
                start = 0;
            if (end > src.Length - 1)
                end = src.Length - 1;
            byte[] t = new byte[src.Length - (end - start + 1)];
            Buffer.BlockCopy(src, 0, t, 0, start);
            Buffer.BlockCopy(src, end + 1, t, start, src.Length - end - 1);
            return t;
        }

        //查找字节数组里的帧头帧尾
        private int SearchIndex(byte[] src, byte[] patten, int start)
        {
            start = start - 2; //开始的位置往前移2个字节
            while (start >= 0)
            {
                if (src[start] == patten[0] && src[start + 1] == patten[1])
                    break;
                start--;
            }
            return start;
        }

      
        //截取字节数组
        private byte[] GetSection(byte[] src, int start, int end)
        {
            if (start > end)
                return null;
            if (start < 0)
                start = 0;
            if (end > src.Length - 1)
                end = src.Length - 1;
            byte[] t = new byte[end - start + 1];
            Buffer.BlockCopy(src, start, t, 0, end - start + 1);
            return t;
        }


        //字节数组拼接，return: src1+src2
        private byte[] AddTo(byte[] src1, byte[] src2)
        {
            byte[] t = new byte[src1.Length + src2.Length];
            Buffer.BlockCopy(src1, 0, t, 0, src1.Length);
            Buffer.BlockCopy(src2, 0, t, src1.Length, src2.Length);
            return t;
        }
    }
}
