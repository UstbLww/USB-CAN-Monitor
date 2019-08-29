using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;          //使用串口
using System.Threading.Tasks;   //线程
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
        StringBuilder com = new StringBuilder(255);   //存储读出ini内容变量  存储COM口
        StringBuilder bps = new StringBuilder(255);   //存储波特率
        StringBuilder vel = new StringBuilder(225);   //存储速度
        string CurrentPortName, CurrentBps, CurrentVel;
        bool rec_flag = true;    //记录数据的标志位，默认记录数据

        /*帧定义*/
        int maxDatalen = 200;           //最大字节数组
        byte[] head1 = { 0x00, 0x55 };  //DSP的Messagebox1的帧头
        byte[] rear1 = { 0x00, 0x99 };  //DSP的Messagebox1的帧尾
        byte[] frameData1;              //DSP的Messagebox1的帧数据
        int errorNum = 0;               //错误帧计数
    
        byte[] head2 = { 0x00, 0x99 };  //DSP的Messagebox2的帧头
        byte[] rear2 = { 0x00, 0x55 };  //DSP的Messagebox2的帧尾
        byte[] frameData2;              //DSP的Messagebox2的帧数据

        /*线性列表用于图表显示*/
        private List<int> List_ia  = new List<int>();    //电流ia
        private List<int> List_ic  = new List<int>();    //电流ic
        private List<int> List_udc = new List<int>();    //母线电压dc
        private List<int> List_vel = new List<int>();    //速度

        private delegate void UpdateBufferEventHandle(byte[] data, int bufferlen);   //定义多重委托
        private event UpdateBufferEventHandle bufferChanged;          //定义事件

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)   //界面初始化
        {
            GetPrivateProfileString("PortData", "PortName", "COM0", com, 256, FileName); //读取ini值，如果没找到默认是COM0
            GetPrivateProfileString("BpsData", "Bps", "9600", bps, 256, FileName);       //读取ini值，如果没找到默认是9600
            GetPrivateProfileString("VelData", "Vel", "20000", vel, 256, FileName);      //读取ini值，如果没找到默认是20000
            comboBox_Ports.Text = com.ToString();      //初始化
            comboBox_Bps.Text = bps.ToString();
            numericUpDown_Vel.Value = decimal.Parse(vel.ToString());
            serialPort1.DataReceived += SerialPort1_DataReceived;         //添加串口接受数据事件
            bufferChanged += new UpdateBufferEventHandle(HandleBuffer);   //将事件处理方法添加到事件中去
            InitFeedback();  //初始化回显
            button_Close.Enabled = false;
            button_ControlSend.Enabled = false;
            button_ControlSend2.Enabled = false;
            button_Rec.Enabled = false;
            radioButton_Rec.Checked = true; //默认选中记录数据
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   //保存设置
        {
            CurrentPortName = comboBox_Ports.Text;
            CurrentBps = comboBox_Bps.Text;
            CurrentVel = Decimal.ToInt32(numericUpDown_Vel.Value).ToString();
            WritePrivateProfileString("PortData", "PortName", CurrentPortName, FileName);
            WritePrivateProfileString("BpsData", "Bps", CurrentBps, FileName);
            WritePrivateProfileString("VelData", "Vel", CurrentVel, FileName);
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
                button_ControlSend.Enabled = true;
                button_ControlSend2.Enabled = true;
                button_Rec.Enabled = true;
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
                button_ControlSend.Enabled = false;
                button_ControlSend2.Enabled = false;
                button_Rec.Enabled = false;
                errorNum = 0;
                label_ErrNum.Text = errorNum.ToString();
                InitFeedback();      //初始化回显
                ClearAllList();     //清除所有链表
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
            DataHandle1(data);   //messagebox1 发送的0x55
            DataHandle2(data);   //messagebox2 发送的0x99
        }
        
 
        private void DataHandle1(byte[] data)    //搜索0x55帧头   显示电压电流信息（包括画图）
        {
            int headindex, rearindex = SearchIndex(data, rear1, data.Length);  //帧尾
            if (rearindex >= 0)
            {
                headindex = SearchIndex(data, head1, rearindex);  //帧头
                if (headindex >= 0)
                {
                    frameData1 = GetSection(data, headindex + 2, rearindex - 1);
                    if (frameData1 != null)
                    {
                        if (frameData1.Length == 8)
                        {
                            switch (frameData1[0])
                            {
                                case 0x00:    //准备模式
                                    textBox_Test.ForeColor = Color.Black;
                                    textBox_Test.AppendText("连接就绪!" + "\r\n");
                                    if (50 == textBox_Test.Lines.Length)     //或者使用Lines.GetUpperBound(0) 
                                    {
                                        textBox_Test.Text.Remove(0, textBox_Test.Text.IndexOf("\n") + 1);  //删除第一行
                                    }
                                    InitFeedback();  
                                    break;

                                case 0x01:    //运行模式
                                    textBox_Test.ForeColor = Color.Black;
                                    Int32 ia, ic, udc, vel;
                                    ia =  (Int32)frameData1[1];   //int16 转速不够
                                    ic =  (Int32)frameData1[2];
                                    udc = (Int32)frameData1[3];
                                    vel = (Int32)(frameData1[4] + frameData1[5] * 256 + frameData1[6] * 65536);

                                    label_Ia.Text = ia.ToString();
                                    label_Ic.Text = ic.ToString();
                                    label_Udc.Text = udc.ToString();  
                                    label_Vel.Text = vel.ToString();

                                    button_Ia.Visible = true;   //设置为可见
                                    button_Ic.Visible = true;
                                    button_Udc.Visible = true;
                                    button_Vector.Visible = true;

                                    List_ia.Add(ia);    ListRemove(List_ia);    //将对象加到list的尾部,
                                    List_ic.Add(ic);    ListRemove(List_ic);
                                    List_udc.Add(udc);  ListRemove(List_udc);
                                    List_vel.Add(vel);  ListRemove(List_vel);
                                    DrawChart(List_ia, List_ic, List_udc, List_vel);
                                    break;

                                case 0x02:   //出错模式
                                    textBox_Test.ForeColor = Color.Red;
                                    label_Ia.Text  = 0.ToString();
                                    label_Ic.Text  = 0.ToString();
                                    label_Udc.Text = 0.ToString();
                                    label_Vel.Text = 0.ToString();

                                    if (frameData1[4] == 0x01)     //母线欠压
                                    {
                                        button_Udc.Visible = true;
                                        button_Udc.BackgroundImage = Properties.Resources.Yellow_light;
                                        textBox_Test.AppendText("母线欠压，请重启DSP!" + "\r\n");
                                    }
                                    else if (frameData1[4] == 0x02)  //母线过压
                                    {
                                        button_Udc.Visible = true;
                                        button_Udc.BackgroundImage = Properties.Resources.Red_light;
                                        textBox_Test.AppendText("母线过压，请重启DSP!" + "\r\n");
                                    }

                                    if (frameData1[5] == 0x01)     //A相过流
                                    {
                                        button_Ia.Visible = true;  //设置为可见
                                        button_Ia.BackgroundImage = Properties.Resources.Red_light;
                                        textBox_Test.AppendText("A相过流，请重启DSP!" + "\r\n");
                                    }
                                    if (frameData1[6] == 0x01)     //C相过流
                                    {
                                        button_Ic.Visible = true;
                                        button_Ic.BackgroundImage = Properties.Resources.Red_light;
                                        textBox_Test.AppendText("C相过流，请重启DSP!" + "\r\n");
                                    }
                                    if (frameData1[7] == 0x01)    //电压矢量超范围
                                    {
                                        button_Vector.Visible = true;
                                        button_Vector.BackgroundImage = Properties.Resources.Red_light;
                                        textBox_Test.AppendText("电压矢量超范围，请重启DSP!" + "\r\n");
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

        private void DataHandle2(byte[] data)    //搜索0x99帧头，备用数据
        {
            int headindex, rearindex = SearchIndex(data, rear2, data.Length);  //帧尾
            if (rearindex >= 0)
            {
                headindex = SearchIndex(data, head2, rearindex);  //帧头
                if (headindex >= 0)
                {
                    frameData2 = GetSection(data, headindex + 2, rearindex - 1);
                    if (frameData2 != null)
                    {
                        if (frameData2.Length == 8)
                        {
                            //备用数据显示
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

        //帧头尾0x55的帧信息画图
        private void DrawChart(List<int> List_ia, List<int> List_ic, List<int> List_udc, List<int> List_vel)
        {
            chart1.Series[0].Points.Clear();    //清除所有点
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();

            for (int i = 0; i < List_ia.Count; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, List_ia[i]);
            }
            for (int i = 0; i < List_ic.Count; i++)
            {
                chart1.Series[1].Points.AddXY(i + 1, List_ic[i]);
            }
            for (int i = 0; i < List_udc.Count; i++)
            {
                chart2.Series[0].Points.AddXY(i + 1, List_udc[i]);
            }
            for (int i = 0; i < List_vel.Count; i++)
            {
                chart3.Series[0].Points.AddXY(i + 1, List_vel[i]);
            }
        }

        //清除所有的链表
        private void ClearAllList()
        {
            List_ia.Clear();
            List_ic.Clear();
            List_udc.Clear();
            List_vel.Clear();
        }
  
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    scalesize ++;
        //    chart1.ChartAreas[0].AxisX.ScaleView.Size = scalesize;
        //}

        //发送控制消息
        private void button_ControlSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int velocity = Decimal.ToInt32(numericUpDown_Vel.Value);
                if (0 <= velocity && velocity <= 150000)
                {
                    byte[] id = { 0x00, 0x55 };
                    byte[] control = {0x02, 0x01, 0x00, 0x01 };   //记录数据
                    byte[] vel = ConvertHex(velocity);
                    if (velocity == 0)   control[1] = 0x00;
                    if (!rec_flag)       control[3] = 0x00;
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
                    string str = ConverToString(data);
                    textBox_Test.AppendText("已发送: " + str + "  Vel: " + velocity.ToString() +"\r\n");
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

        //第二个速度发送框
        private void button_ControlSend2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                int velocity = Decimal.ToInt32(numericUpDown_Vel2.Value);   //第二个发送框
                if (0 <= velocity && velocity <= 150000)
                {
                    byte[] id = { 0x00, 0x55 };
                    byte[] control = { 0x02, 0x01, 0x00, 0x01 };   //记录数据
                    byte[] vel = ConvertHex(velocity);
                    if (velocity == 0)  control[1] = 0x00;
                    if (!rec_flag)      control[3] = 0x00;
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
                    string str = ConverToString(data);
                    textBox_Test.AppendText("已发送: " + str + "  Vel: " + velocity.ToString() + "\r\n");
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

        //scalesize ++;
        //chart1.ChartAreas[0].AxisX.ScaleView.Size = scalesize;

        private void button_Rec_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                byte[] data = { 0x00, 0x55, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                serialPort1.Write(data, 0, 10);
                string str = ConverToString(data);
                textBox_Test.AppendText("重新记录: " + str + "\r\n");
            }
            else
            {
                MessageBox.Show("请连接CAN", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //当大于200时移除list头部
        private void ListRemove(List<int> list)
        {
            if(list.Count >= 200)
            {
                list.RemoveAt(0);
            }
        }

        //清空测试框
        private void button_Clear_Click(object sender, EventArgs e)  
        {
            textBox_Test.Clear();
        }

        //当改变下拉框的波特率时注意也要更改USB-CAN转换器的波特率
        private void comboBox_Bps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Bps.SelectedItem.ToString() != "9600")
            {
                MessageBox.Show("默认9600" + "\n" + "如果更改请也设置USB-CAN转换器的波特率", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        //当记录按钮被选中时
        private void radioButton_Rec_CheckedChanged(object sender, EventArgs e)
        {
            rec_flag = true;
        }

        //当不记录按钮被选中时
        private void radioButton_NoRec_CheckedChanged(object sender, EventArgs e)
        {
            rec_flag = false;
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


        //回显初始化，不可见且背景图片为绿色
        private void InitFeedback()
        {
            button_Ia.Visible = false;  
            button_Ia.BackgroundImage = Properties.Resources.Green_light;
            button_Ic.Visible = false;
            button_Ic.BackgroundImage = Properties.Resources.Green_light;
            button_Udc.Visible = false;
            button_Udc.BackgroundImage = Properties.Resources.Green_light;
            button_Vector.Visible = false;
            button_Vector.BackgroundImage = Properties.Resources.Green_light;
            label_Ia.Text  = 0.ToString();
            label_Ic.Text  = 0.ToString();
            label_Udc.Text = 0.ToString();
            label_Vel.Text = 0.ToString();
        }

        //将转速转换为字节数组
        private byte[] ConvertHex(int vel)
        {
            int velocity = vel;
            byte[] hex = new byte[4];
            hex[0] = (byte)(velocity & 0xff);
            hex[1] = (byte)((velocity >> 8)  & 0xff);
            hex[2] = (byte)((velocity >> 16) & 0xff);
            hex[3] = (byte)((velocity >> 24) & 0xff);
            return hex;
        }

        //将字节数组转为字符串
        private string ConverToString(byte[] data)
        {
            string str;
            StringBuilder stb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                if ((int)data[i] > 15)
                {
                    stb.Append(Convert.ToString(data[i], 16).ToUpper());
                }
                else  //如果是小于0F需要加个零
                {
                    stb.Append("0" + Convert.ToString(data[i], 16).ToUpper());
                }
            }
            str = stb.ToString();
            return str;
        }

        //删除字节数组中指定段
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    scalesize++;
        //    chart1.ChartAreas[0].AxisX.Interval = scalesize;
        //}


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
