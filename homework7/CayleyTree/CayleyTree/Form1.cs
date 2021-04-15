using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private double length = 100;
        private int n = 10;
        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private string color = "Blue";

        public Form1()
        {
            InitializeComponent();
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.splitContainer1.Panel2.CreateGraphics();
            else graphics.Clear(BackColor);
            var p = this.draw_button.Location; 
            drawCayleyTree(n, p.X + this.draw_button.Size.Width / 2, p.Y - 50, length, -1 * Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1*leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2*leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (color)
            {
                case "Red": graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "Blue": graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "Yellow": graphics.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1); break;
                case "Green": graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1); break;
                default: throw new Exception("Wrong color");
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.color = ComboBox.Text;
        }

        private void n_textBox_TextChanged(object sender, EventArgs e)
        {
            this.n = Convert.ToInt32(n_textBox.Text);
        }

        private void leng_textBox_TextChanged(object sender, EventArgs e)
        {
            this.length = Convert.ToDouble(leng_textBox.Text);
        }

        private void per1_textBox_TextChanged(object sender, EventArgs e)
        {
            this.per1 = Convert.ToDouble(per1_textBox.Text);
        }

        private void per2_textBox_TextChanged(object sender, EventArgs e)
        {
            this.per2 = Convert.ToDouble(per2_textBox.Text);
        }

        private void th1_textBox_TextChanged(object sender, EventArgs e)
        {
            this.th1 = Convert.ToDouble(th1_textBox.Text) * Math.PI / 180;
        }

        private void th2_textBox_TextChanged(object sender, EventArgs e)
        {
            this.th2 = Convert.ToDouble(th2_textBox.Text) * Math.PI / 180;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
