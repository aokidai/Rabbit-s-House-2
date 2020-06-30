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
using System.Data.SqlClient;
namespace Rabbit_s_House
{
    public partial class frmForgotpass : Form
    {
        public frmForgotpass()
        {
            InitializeComponent();
        }
        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtKey.Focus();
            }
        }
        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
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
                txtNhapLaiMK.Focus();
            }
        }
        private void txtNhapLaiMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnChapNhan.PerformClick();

            }
        }
        NhanVien tblNhanVien;
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenDN, "");
            errorProvider1.SetError(txtKey, "");
            tblNhanVien = new NhanVien();
            frmIndex fI = (frmIndex)this.MdiParent;
            var r = tblNhanVien.Select("Username='" + txtTenDN.Text + "' and MaNV ='" + txtKey.Text + "'");
            if (r.Count() > 0)
            {
                frmChangepass fC = new frmChangepass();
                fC.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc Key!");
                return;
            }
        }
    private void btnHuy_Click(object sender, EventArgs e)
        {
            frmLogin fL = new frmLogin();
            fL.Show();
            this.Close();
        }

        private void txtKey_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            helpProvider1.SetShowHelp(txtKey, true);
            helpProvider1.SetHelpString(txtKey, "Nhập Key nhân viên");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            helpProvider1.SetShowHelp(txtKey, true);
            helpProvider1.SetHelpString(txtKey, "Nhập Key nhân viên");
        }
    }
}
