using QuanLyBanHang.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class formStart : Form
    {
        public formStart()
        {
            InitializeComponent();
        }

        private void rBtn1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rBtn1.Checked)
            {
                formLoginAdmin f2 = new formLoginAdmin();
                f2.Show();
                this.Hide();
                f2.FormClosing += delegate { this.Close(); };
            }
            else if (rBtn2.Checked)
            {
                formLoginNV f2 = new formLoginNV();
                f2.Show();
                this.Hide();
                f2.FormClosing += delegate { this.Close(); };
            }
            else
            {
                formLoginKhachHang f2 = new formLoginKhachHang();
                f2.Show();
                this.Hide();
                f2.FormClosing += delegate { this.Close(); };
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
