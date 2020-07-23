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
    public partial class frmThemSP : Form
    {
        public frmThemSP()
        {
            InitializeComponent();
        }
        DataTable tblMon;
        SqlDataAdapter daMon;
        BindingManagerBase DSMon;
        bool capNhat = false;

        private void frmThemSP_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tblMon = new DataTable();
            daMon = new SqlDataAdapter("Select * from Mon", Model.cnnStr);
            try
            {
                daMon.Fill(tblMon);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daMon);
            loaddgvMon();
            txtMaMon.DataBindings.Add("text", tblMon, "MaMon", true);
            txtTenMon.DataBindings.Add("text", tblMon, "TenMon", true);
            txtGia.DataBindings.Add("text", tblMon, "Gia", true);
            pHinh.DataBindings.Add("image", tblMon, "hinh", true);
            DSMon = this.BindingContext[tblMon];
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
        private void loaddgvMon()
        {
            dgvMon.AutoGenerateColumns = false;
            dgvMon.DataSource = tblMon;
           }

            private void btnThemAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pHinh.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void tolSpInsert_Click(object sender, EventArgs e)
        {
            DSMon.AddNew();
            capNhat = true;
            enableButton();
        }

        private void tolSpSave_Click(object sender, EventArgs e)
        {
            try
            {
                DSMon.EndCurrentEdit();
                daMon.Update(tblMon);
                tblMon.AcceptChanges();
                capNhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                tblMon.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void tolSpCannel_Click(object sender, EventArgs e)
        {
            DSMon.CancelCurrentEdit();
            tblMon.RejectChanges();
            capNhat = false;
            enableButton();
        }

        private void tolSpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DSMon.RemoveAt(DSMon.Position);
                daMon.Update(tblMon);
                tblMon.AcceptChanges();
            }
            catch (SqlException)
            {
                tblMon.RejectChanges();
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
                DataRow r = tblMon.Select("MaNV ='" + txtTimKiem.Text + "'")[0];
                DSMon.Position = tblMon.Rows.IndexOf(r);
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!!");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

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

        private void dgvMon_SelectionChanged(object sender, EventArgs e)
        {
            if (capNhat)
            {
                tolSpCannel_Click(sender, e);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
