using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form4 : Form
    {
        public string id { set; get; }
        public string customer_name { set; get; }
        public string goods_name { set; get; }
        public string price { set; get; }
        public string amount { set; get; }
        public string customer_id { set; get; }
        public string goods_id { set; get; }
        public orderWinForm.OrderService service = new orderWinForm.OrderService();
        public Form4()
        {
            InitializeComponent();
        }

        private void 删除订单_Click(object sender, EventArgs e)
        {
            int id_int = Convert.ToInt32(id);
            orderWinForm.Customer c = new orderWinForm.Customer(Convert.ToUInt32(customer_id), customer_name);
            orderWinForm.Goods goods = new orderWinForm.Goods(Convert.ToInt32(goods_id), goods_name, Convert.ToDouble(price));
            orderWinForm.OrderDetail de = new orderWinForm.OrderDetail(goods, Convert.ToUInt32(amount));
            if (service.GetById(id_int) == null)
            {
                orderWinForm.Order o = new orderWinForm.Order(id_int, c);
                service.AddOrder(o); o.AddDetails(de);
            }
            else
            {
                service.GetById(id_int).AddDetails(de);
            }
            MessageBox.Show("删除成功");
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            id = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            customer_name = textBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            goods_name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            amount = textBox2.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            price = textBox5.Text;
        }
    }
}
