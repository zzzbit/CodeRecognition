using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 验证码识别
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.WebClient wb = new System.Net.WebClient();
            byte[] b = wb.DownloadData(textBox1.Text);
            //byte[] b = wb.DownloadData("http://p.blog.csdn.net/images/p_blog_csdn_net/jinjazz/355056/o_rrr.bmp");
            System.IO.MemoryStream ms = new System.IO.MemoryStream(b);
            System.Drawing.Bitmap bmp = new Bitmap(ms);
            string str = BmpNumber.Number.getNumber(bmp);
            label1.Text = str;
            Console.WriteLine(str);
        }
    }
}
