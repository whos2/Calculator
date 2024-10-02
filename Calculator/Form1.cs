using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        Label label2 = new Label();
        private float x; //当前窗体的宽度
        private float y; //当前窗体的高度

        //控件状态记录
        private bool btnPercent_flag = false;
        private bool btnCE_flag = false;
        private bool btnC_flag = false;
        private bool btnPop_flag = false;
        private bool btnInverse_flag = false;
        private bool btnSqrt_flag = false;
        private bool btnSq_flag = false;
        private bool btnDiv_flag = false;
        private bool btn7_flag = false;
        private bool btn9_flag = false;
        private bool btn8_flag = false;
        private bool btnMul_flag = false;
        private bool btn4_flag = false;
        private bool btn1_flag = false;
        private bool btnReverse_flag = false;
        private bool btn6_flag = false;
        private bool btn3_flag = false;
        private bool btnPoint_flag = false;
        private bool btn5_flag = false;
        private bool btn2_flag = false;
        private bool btn0_flag = false;
        private bool btnSub_flag = false;
        private bool btnAdd_flag = false;
        private bool btnEqual_flag = false;
        private bool canOperate_flag = false;

        private List<double> value_list = new List<double>();//存用户输入的数字
        private List<int> operator_list = new List<int>();//存用户输入的运算符，定义+为0，-为1，×为2，÷为3
        
        public Form1()
        {
            InitializeComponent();
            //将 Form1_Load 方法订阅为窗体的 Load 事件的处理程序
            this.Load += new System.EventHandler(this.Form1_Load);
            //将 Form1_Resize 方法订阅为窗体的 Resize 事件的处理程序
            this.Resize += new System.EventHandler(this.Form1_Resize);
            //为tab添加文本内容
            label1.Text = "尚无历史记录。";
            label2.Text = "内存中未保存任何内容。";
            label1.Width = 200;
            label2.Width = 200;
            this.tabMemory.Controls.Add(label2);
            this.tabHistory.Controls.Add(label1);
            this.tabHistory.AutoScroll = true;
            this.tabMemory.AutoScroll = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float ratioX = this.Width / x;
            float ratioY = this.Height / y;
            setControls(ratioX, ratioY, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = this.Width;
            y = this.Height;
            setTag(this);//将窗体的初始状态记录下来
        }

        private void setTag(Control cons)//传入窗体
        {
            foreach (Control con in cons.Controls)//获取窗体的控件
            {
                //将每个控件的信息存到控件的Tag属性中 宽度 高度 左边距 顶边距 字体大小
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)//如果控件还有子控件，递归
                {
                    setTag(con);
                }
            }
        }

        private void setControls(float ratioX, float ratioY, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的属性
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = System.Convert.ToSingle(mytag[0]) * ratioX;//宽度
                con.Width = (int)a;
                a = System.Convert.ToSingle(mytag[1]) * ratioY;//高度
                con.Height = (int)a;
                a = System.Convert.ToSingle(mytag[2]) * ratioX;//左边距
                con.Left = (int)a;
                a = System.Convert.ToSingle(mytag[3]) * ratioY;//顶边距
                con.Top = (int)a;
                Single fontSize = System.Convert.ToSingle(mytag[4]) * ratioX;//字体大小
                con.Font = new Font(con.Font.Name, fontSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)//递归设置控件的子控件
                {
                    setControls(ratioX, ratioY, con);
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numDown("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numDown("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numDown("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numDown("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numDown("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numDown("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numDown("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numDown("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numDown("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numDown("9");
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            numDown(".");
        }
        private void numDown(string v)
        {
            if(btnAdd_flag||btnSub_flag||btnMul_flag||btnDiv_flag||btnEqual_flag)
            {
                txtDisplay.Clear();
                txtDisplay.Text+=v;
                btnAdd_flag = false;
                btnSub_flag = false;
                btnMul_flag = false;
                btnDiv_flag = false;
                btnEqual_flag = false;
            }
            else
            {
                // 如果当前显示的是"0"且输入不是小数点，则清除文本
                if (txtDisplay.Text == "0" && v != ".")
                {
                    txtDisplay.Clear();
                }

                // 如果已经包含小数点
                if (txtDisplay.Text.Contains("."))
                {
                    // 如果输入是小数点且已经包含小数点，则不进行操作
                    if (v == ".")
                    {
                        return;
                    }

                    // 分割整数和小数部分
                    string[] strArr = txtDisplay.Text.Split('.');
                    string ip = strArr[0];
                    string dp = strArr[1];

                    // 检查是否达到最大长度限制
                    if ((ip == "0" && (ip.Length + dp.Length) == 17) ||
                        (ip != "0" && (ip.Length + dp.Length) == 16))
                    {
                        return;
                    }
                    txtDisplay.Text += v;
                }
                else
                {
                    string num = txtDisplay.Text.Replace(",", "");
                    // 如果没有小数点，检查总长度是否达到16位
                    if (num.Length != 16)
                    {
                        txtDisplay.Text += v;
                        txtDisplay.Text = FormatWithCommas(txtDisplay.Text);
                    }
                    else
                    {
                        txtDisplay.Text = FormatWithCommas(txtDisplay.Text);
                        return;
                    }
                }
            }
            
        }

        private string FormatWithCommas(string numberStr)
        {
            numberStr = numberStr.Replace(",", "");
            if (long.TryParse(numberStr, out long number))
            {
                //MessageBox.Show($"if内：{ txtDisplay.Text}");
                return number.ToString("N0");
            }
            //MessageBox.Show($"if外：{ txtDisplay.Text}");
            return numberStr;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!btnAdd_flag)
            {
                value_list.Add(double.Parse(txtDisplay.Text));//将当前输入的数字存起来
                operator_list.Add(0);
                txtDisplay.Text += "+";
                btnAdd_flag = true;
                btnSub_flag = true;
                btnMul_flag = true;
                btnDiv_flag = true;
                //canOperate_flag = false;
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!btnSub_flag)
            {
                value_list.Add(double.Parse(txtDisplay.Text));//将当前输入的数字存起来
                operator_list.Add(1);
                txtDisplay.Text += "-";
                btnAdd_flag = true;
                btnSub_flag = true;
                btnMul_flag = true;
                btnDiv_flag = true;
                //canOperate_flag = false;
            }
        }
        private  void btnMul_Click(object sender, EventArgs e)
        {
            if (!btnMul_flag)
            {
                value_list.Add(double.Parse(txtDisplay.Text));//将当前输入的数字存起来
                operator_list.Add(2);
                txtDisplay.Text += "*";
                btnAdd_flag = true;
                btnSub_flag = true;
                btnMul_flag = true;
                btnDiv_flag = true;
                //canOperate_flag = false;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!btnDiv_flag)
            {
                value_list.Add(double.Parse(txtDisplay.Text));//将当前输入的数字存起来
                operator_list.Add(3);
                txtDisplay.Text += "/";
                btnAdd_flag = true;
                btnSub_flag = true;
                btnMul_flag = true;
                btnDiv_flag = true;
            }
        }

        void btnEqual_Click(object sender, EventArgs e)
        {
            if (!btnEqual_flag)
            {
                if(value_list.Count>0&&operator_list.Count>0)
                {
                    value_list.Add(double.Parse(txtDisplay.Text));
                    double result = value_list[0];
                    for(int i=0;i<operator_list.Count; i++)
                    {
                        int _operator = operator_list[i];
                        switch (_operator)
                        {
                            case 0:
                                result += value_list[i + 1];
                                break;
                            case 1:
                                result -= value_list[i + 1];
                                break;
                            case 2:
                                result *= value_list[i + 1];
                                break;
                            case 3:
                                result /= value_list[i + 1];
                                break;
                        }
                        
                    }
                    //清空列表
                    value_list.Clear();
                    operator_list.Clear();
                    txtDisplay.Text = FormatWithCommas(result.ToString());
                    btnEqual_flag = true;
                }
            }
        }
        
    }
}
