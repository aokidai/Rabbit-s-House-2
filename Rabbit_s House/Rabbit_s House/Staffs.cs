using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Rabbit_s_House
{
    public partial class frmStaffs : Form
    {
        public frmStaffs()
        {
            InitializeComponent();
        }
        DataTable tblNhanVien;
        SqlDataAdapter daNhanVien;
        BindingManagerBase DSNV;
        bool capNhat = false;
        private void frmStaffs_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tblNhanVien = new DataTable();
            daNhanVien = new SqlDataAdapter("Select * from NHANVIEN", Model.cnnStr);
            try
            {
                daNhanVien.Fill(tblNhanVien);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNhanVien);
            loadDGVNhanVien();

            txtMaNV.DataBindings.Add("text", tblNhanVien, "MaNV", true);
            txtHoTen.DataBindings.Add("text", tblNhanVien, "TenNV", true);
            txtDiaChi.DataBindings.Add("text", tblNhanVien, "DiaChi", true);
            txtSoDT.DataBindings.Add("text", tblNhanVien, "SoDT", true);
            txtEmail.DataBindings.Add("text", tblNhanVien, "Email", true);
            txtUserName.DataBindings.Add("text", tblNhanVien, "UserName", true);
            txtPass.DataBindings.Add("text", tblNhanVien, "Password", true);
            txtMaLTK.DataBindings.Add("text", tblNhanVien, "MaLTK", true);
            
            radNam.DataBindings.Add("Checked", tblNhanVien, "GioiTinh", true);
            DSNV = this.BindingContext[tblNhanVien];
            enableButton();
        }
        private void enableButton()
        {
            tolSpInsert.Enabled = !capNhat;
            tolSpDelete.Enabled = !capNhat;
            tolSpEdit.Enabled = !capNhat;
            groupBox1.Enabled = capNhat;
            txtTimKiem.Enabled = !capNhat;
            btnTimKiem.Enabled = !capNhat;
            tolSpSave.Enabled = capNhat;
            tolSpCannel.Enabled = capNhat;
        }
        private void loadDGVNhanVien()
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = tblNhanVien;
        }
        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            radNu.Checked = !radNam.Checked;
        }
        private void tolSpInsert_Click(object sender, EventArgs e)
        {
            DSNV.AddNew();
            capNhat = true;
            enableButton();
        }

        private void tolSpSave_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                daNhanVien.Update(tblNhanVien);
                tblNhanVien.AcceptChanges();
                capNhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                tblNhanVien.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void tolSpCannel_Click(object sender, EventArgs e)
        {
            DSNV.CancelCurrentEdit();
            tblNhanVien.RejectChanges();
            capNhat = false;
            enableButton();
        }

        private void tolSpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.RemoveAt(DSNV.Position);
                daNhanVien.Update(tblNhanVien);
                tblNhanVien.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblNhanVien.RejectChanges();
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void tolSpEdit_Click(object sender, EventArgs e)
        {
            capNhat = true;
            enableButton();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblNhanVien.Select("MaNV ='" + txtTimKiem.Text + "'")[0];
                DSNV.Position = tblNhanVien.Rows.IndexOf(r);
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!!");
            }
        }

        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem_Click(sender, e);
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (capNhat)
            {
                tolSpCannel_Click(sender, e);
            }
        }

        
    }
}
