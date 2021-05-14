using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form3 : Form
    {
        public string id { set; get; }
        public string customer_name { set; get; }
        public string goods_name { set; get; }
        public string price { set; get; }
        public string amount { set; get; }
        public string customer_id { set; get; }
        public string goods_id { set; get; }
        public orderWinForm.OrderService service = new orderWinForm.OrderService();
        public int op { set; get; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_int = Convert.ToInt32(id);
            orderWinForm.Customer c = new orderWinForm.Customer(Convert.ToUInt32(customer_id), customer_name);
            orderWinForm.Goods goods = new orderWinForm.Goods(Convert.ToInt32(goods_id), goods_name, Convert.ToDouble(price));
            orderWinForm.OrderDetail de = new orderWinForm.OrderDetail(goods, Convert.ToUInt32(amount));
            orderWinForm.Order o = service.GetById(id_int);
            var d = o.Details;
            foreach (var i in d)
            {
                if (i.Goods.Id == Convert.ToInt32(goods_id))
                {
                    i.Amount = Convert.ToUInt32(amount);
                    i.Goods.Price = Convert.ToDouble(price);
                }
            }
            MessageBox.Show("修改成功");
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            id = textBox4.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            customer_name = textBox6.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            goods_name = textBox8.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            amount = textBox7.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            price = textBox5.Text;
        }
    }
}
