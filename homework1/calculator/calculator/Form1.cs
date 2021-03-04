using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("×");
            comboBox1.Items.Add("÷");
            label_time.Text = DateTime.Now.ToString();  //设置label_time的文本为当前的系统时间
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double a, b;
            double c = 0;
            double number1 = 0;
            double number2 = 0;
            //异常处理
            try
            {
                number1 = Double.Parse(textBox_number1.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show("第一个加数异常", e1.Message);
                return;
            }
            try
            {
                number2 = Double.Parse(textBox_number2.Text);
            }
            catch (Exception e2)
            {
                MessageBox.Show("第二个加数异常", e2.Message);
                return;
            }
            a = Convert.ToDouble(textBox_number1.Text);
            b = Convert.ToDouble(textBox_number2.Text);

            switch (comboBox1.Text)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "×":
                    c = a * b;
                    break;
                case "÷":
                    //异常处理
                    if (b == 0)
                    {
                        MessageBox.Show("除数不能为0", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        c = a / b;
                    }
                    break;
                default:
                    break;
            }
            textBox_result.Text = c.ToString();
        }

    }
}
