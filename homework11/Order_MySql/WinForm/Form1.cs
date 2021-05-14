using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private orderWinForm.OrderService service = new orderWinForm.OrderService();
        private new string ProductName;
        private string message;
        public Form1()
        {
            InitializeComponent();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void alter_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.message);
            switch (ProductName)
            {
                case "按ID查询":
                    this.customerBindingSource.DataSource = service.GetById(Convert.ToInt32(message));
                    if (service.GetById(Convert.ToInt32(message)) != null) this.goodsBindingSource.DataSource = service.GetById(Convert.ToInt32(message)).Details;
                    else this.goodsBindingSource.DataSource = null; break;
                case "按客户查询": this.customerBindingSource.DataSource = service.QueryByCustomerName(message); break;
                case "按数量查询": this.customerBindingSource.DataSource = service.QueryByTotalAmount(Convert.ToDouble(message)); break;
                case "按商品查询": this.customerBindingSource.DataSource = service.QueryByGoodsName(message); break;

                default: break;
            }
            if (ProductName != "按ID查询")
            {
                List<orderWinForm.Order> o = (List<orderWinForm.Order>)customerBindingSource.DataSource;
                List<orderWinForm.OrderDetail> de = new List<orderWinForm.OrderDetail>();

                if (o != null)
                {
                    foreach (var i in o)
                    {
                        List<orderWinForm.OrderDetail> p = i.Details;
                        foreach (var j in p)
                            de.Add(j);
                    }
                    goodsBindingSource.DataSource = de;
                }
            }
        }

        private void export_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                DirectoryInfo theFolder = new DirectoryInfo(foldPath);
                try
                {
                    string path = @theFolder.FullName + "\\order.xml";
                    Console.WriteLine(path);
                    if (service.orderList != null)
                        service.Export(path);
                    else Console.WriteLine("empty");
                    MessageBox.Show("导出成功");
                }
                catch
                {
                    throw new Exception("导出失败");
                }
            }
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*xml*)|*.xml*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径            
                try
                {
                    service.Import(file);
                    MessageBox.Show("导入成功");
                }
                catch
                {
                    throw new Exception("导入失败");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => ProductName = comboBox1.Text;

    }
}
