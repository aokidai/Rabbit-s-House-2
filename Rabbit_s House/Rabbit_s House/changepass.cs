using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Rabbit_s_House.model;
namespace Rabbit_s_House
{
    public partial class frmChangepass : Form
    {
        string maNV = null;
        public frmChangepass()
        {
            InitializeComponent();
        }
      
        public frmChangepass(string pMaNV)
        {
            InitializeComponent();
            maNV = pMaNV;
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
            if (txtMKCu.Text.Length < 8 || !txtMKCu.Text.Any(char.IsUpper) || !txtMKCu.Text.Any(char.IsDigit) || !txtMKCu.Text.Any(char.IsLower))
            {
                errorProvider1.SetError(txtMKCu, "Mat khau toi thieu 8 ki tu" + "in hoa, in thuong.");
                return;
            }
            if (txtMKCu.Text != txtNhapLaiMK.Text)
            {
                errorProvider1.SetError(txtNhapLaiMK, "Mat khau khong trung!");
                return;
            }
            if (maNV != null)
            {
                int count = table.Thuc_hien_lenh("update NHANVIEN set Password ='" + txtMKCu.Text + "'where MaNV = '" + maNV + "'");
                if (count > 0)
                {
                    MessageBox.Show("Cap nhat thanh cong!.");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Mat khau khong hop le");
                    return;
                }
            }
            else
            {
                frmIndex fI = (frmIndex)this.MdiParent;
                int count = table.Thuc_hien_lenh("update NHANVIEN set Password ='" + txtMKCu.Text + "'where MaNV = '" + fI.maNV + "'");
                if (count > 0)
                {
                    MessageBox.Show("Cap nhat thanh cong!.");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Mat khau khong hop le");
                    return;
                }
            }
            
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
