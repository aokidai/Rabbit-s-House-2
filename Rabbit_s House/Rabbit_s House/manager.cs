using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace Rabbit_s_House
{
    public partial class frmManager : Form
    {
        
        public frmManager()
        {
            InitializeComponent();
        }
        DataTable tblhoadon, tblKhachHang, tblMon;
        SqlDataAdapter daHD, daKH, daMo;


        BindingManagerBase bindDSHD, bindDSKH;



        bool capNhat = false;

        private void frmManager_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tblhoadon = new DataTable();
            daHD = new SqlDataAdapter("Select * from hoadon", Model.cnnStr);
            tblKhachHang = new DataTable();
            daKH = new SqlDataAdapter("Select * from KhachHang", Model.cnnStr);
            tblMon = new DataTable();
            daMo = new SqlDataAdapter("Select * from Mon", Model.cnnStr);
            try
            {
                daHD.Fill(tblhoadon);
                daKH.Fill(tblKhachHang);
                daMo.Fill(tblMon);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daKH);
            loadCBOGiamGia();
            loadDGVHoaDon();

            txtMaKH.DataBindings.Add("text", tblKhachHang, "MaKH", true);
            txtHoTen.DataBindings.Add("text", tblKhachHang, "HoTen", true);
            txtSDT.DataBindings.Add("text", tblKhachHang, "SoDT", true);
            //cmbGiamGia.DataBindings.Add("text", tblKhachHang, "GiamGia", true);
            bindDSKH = this.BindingContext[tblKhachHang];
            var rows = tblMon.Select("MaMon like 'Cafe*'");
            var rows2 = tblMon.Select("MaMon like 'nt*'");
            foreach (DataRow r in rows)
            {
                listView1.Items.Add(new ListViewItem(r["TenMon"].ToString()));
            }
            foreach (DataRow r in rows2)
            {
                listView2.Items.Add(new ListViewItem(r["TenMon"].ToString()));
            }
            enableButton();
        }

      

        private void enableButton()
        {
            tolSpInsert.Enabled = !capNhat;
            tolSpEdit.Enabled = !capNhat;
            tolSpDelete.Enabled = !capNhat;
            tolSpSave.Enabled = capNhat;
            tolSpCannel.Enabled = capNhat;
            tolSpPrint.Enabled = capNhat;
           // txtTimKiem.Enabled = capNhat;
            //btnSearch.Enabled = capNhat;
            gKhachHang.Enabled = capNhat;
        }

      

        private void loadCBOGiamGia()
        {
            cmbGiamGia.DataSource = tblKhachHang;
            cmbGiamGia.ValueMember = "MaKH";
            cmbGiamGia.DisplayMember = "HoTen";
        }

     

        private void loadDGVHoaDon()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = tblhoadon;
        }

       

        private void tolSpInsert_Click(object sender, EventArgs e)
        {
            bindDSKH.AddNew();
            capNhat = true;
            enableButton();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        listView1.ImageLocation = openFileDialog1.FileName;
        //    }
        //}

        private void tolSpEdit_Click(object sender, EventArgs e)
        {
            capNhat = true;
            enableButton();
        }
        private void tolSpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bindDSHD.RemoveAt(bindDSHD.Position);
                daHD.Update(tblhoadon);
                tblhoadon.AcceptChanges();
            }
            catch
            {
                tblhoadon.RejectChanges();
                MessageBox.Show("xoa that bai");
            }
        }
        private void tolSpSave_Click(object sender, EventArgs e)
        {
            try
            {
                bindDSKH.EndCurrentEdit();
                daKH.Update(tblKhachHang);
                tblKhachHang.AcceptChanges();
                capNhat = false;
                enableButton();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void tolSpCannel_Click(object sender, EventArgs e)
        {
            bindDSHD.CancelCurrentEdit();
            tblhoadon.RejectChanges();
            capNhat = false;
            enableButton();
        }
        
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                try
                {
                    DataRow r = tblKhachHang.Select("SoDT ='" + txtTimKiem.Text + "'")[0];
                    bindDSKH.Position = tblKhachHang.Rows.IndexOf(r);
                    capNhat = true;
                    gKhachHang.Show();
                    enableButton();
                }
                catch
                {
                    bindDSKH.AddNew();
                    capNhat = true;
                    txtSDT.Text = txtTimKiem.Text;
                    enableButton();
                }
            }
           
        }
}
}
