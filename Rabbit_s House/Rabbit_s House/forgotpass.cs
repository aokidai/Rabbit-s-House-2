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
            errorProvider1.SetError(txtMatkhau, "");
            errorProvider1.SetError(txtNhapLaiMK, "");
            if (txtMatkhau.Text.Length < 8 || !txtMatkhau.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtMatkhau, "Mat khau toi thieu 8 ki tu" + "in hoa, in thuong.");
                return;
            }
            if (txtMatkhau.Text != txtNhapLaiMK.Text)
            {
                errorProvider1.SetError(txtNhapLaiMK, "Mật khẩu không trùng!");
                return;
            }
            tblNhanVien = new NhanVien();
            frmIndex fI = (frmIndex)this.MdiParent;

            var r = tblNhanVien.Select("Username='" + txtTenDN.Text + "' and MaNV ='" + txtKey.Text + "'");
            if (r.Count() > 0)
            {

                fI.maNV = r[0]["MaNV"].ToString();
                fI.enableControl((int)r[0]["MaLTK"]);
                fI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc Key!");
            }

            int count = table.Thuc_hien_lenh("Update NHANVIEN set Password ='" + txtMatkhau.Text + "where MaNV = '" + fI.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cap nhat thanh cong!.");
            }
            else
                MessageBox.Show("Mat khau khong hop le");
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
