using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabbit_s_House
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = "admin", pass = "admin";
            if (txtTen.Text == user && txtMatkhau.Text == pass)
            {
                MessageBox.Show("Đã đăng nhạp thành công");
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu");
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMatkhau.Focus();
            }
        }

        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangnhap.PerformClick();

            }
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
           
        }


    }
}
