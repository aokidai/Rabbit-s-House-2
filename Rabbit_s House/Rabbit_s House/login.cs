using Rabbit_s_House.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rabbit_s_House.model;
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
        NhanVien tblNhanVien;
        public void btnDangnhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new NhanVien();
            var r = tblNhanVien.Select("Username='"+txtTen.Text+"' and Password ='"+txtMatkhau.Text+"'");
            if(r.Count()>0)
            {
                frmIndex fI = new frmIndex();
                fI.Text = "Rabbit's House - Welcome " + r[0]["TenNV"].ToString();
                fI.maNV = r[0]["MaNV"].ToString();
                fI.enableControl((int)r[0]["MaLTK"]);
                fI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
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

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
