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
    public partial class frmChangepass : Form
    {
        public frmChangepass()
        {
            InitializeComponent();
        }

        private void frmChangepass_Load(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMKCu, "");
            errorProvider1.SetError(txtNhapLaiMK, "");
            if (txtMKCu.Text.Length < 8 || !txtMKCu.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtMKCu, "Mat khau toi thieu 8 ki tu" + "in hoa, in thuong.");
                return;
            }
            if (txtMKCu.Text != txtNhapLaiMK.Text)
            {
                errorProvider1.SetError(txtNhapLaiMK, "Mat khau khong trung!");
                return;
            }
            frmIndex fI = (frmIndex)this.MdiParent;
            int count = table.Thuc_hien_lenh("Update NHANVIEN set Password ='" + txtMKCu.Text + "where MaNV = '" + fI.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cap nhat thanh cong!.");
            }
            else
                MessageBox.Show("Mat khau khong hop le");
            frmLogin fL = new frmLogin();
            fL.Show();
            this.Close();
        }

      

        private void txtMKCu_KeyPress(object sender, KeyPressEventArgs e)
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
                btnUpdate.PerformClick();

            }
        }
    }
}
