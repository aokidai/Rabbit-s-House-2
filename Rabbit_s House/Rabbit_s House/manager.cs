﻿using System;
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
            SidePanel.Height = cf.Height;
            SidePanel.Top = cf.Top;
            //cafe1.BringToFront();
            while (reader.Read())
            {
                string alio = reader["fornamn"].ToString();
                string efternamn = reader["efternamn"].ToString();
                ListViewItem lvi = new ListViewItem(alio);
                listView1.Items.Add(lvi);
                lvi.SubItems.Add(efternamn);
            }
        }
        DataTable tblhoadon, tblKhachHang, tblMon, tblCTHD;
        SqlDataAdapter daHD, daKH, daMo, daCTHD;


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
            tblCTHD = new DataTable();
            daCTHD = new SqlDataAdapter("Select * from chitiethoadon", Model.cnnStr);
            try
            {
                daHD.Fill(tblhoadon);
                daKH.Fill(tblKhachHang);
                daMo.Fill(tblMon);
                daCTHD.Fill(tblCTHD);
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
            enableButton();
            tblMon.DefaultView.RowFilter = "MaMon like '%cafe%'";
            load();
            loaddgv();

        }

        private void loaddgv()
        {
            dgvHoaDon.DataSource = tblCTHD;

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
            loadImagelist();
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

        private void cf_Click(object sender, EventArgs e)
        {
            SidePanel.Height = cf.Height;
            SidePanel.Top = cf.Top;
            tblMon.DefaultView.RowFilter = "MaMon like '%cafe%'";
            load();
            
        }

        private void nn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = nn.Height;
            SidePanel.Top = nn.Top;
            tblMon.DefaultView.RowFilter = "MaMon like '%nt%'";
            load();
        }

        private void dav_Click(object sender, EventArgs e)
        {
            SidePanel.Height = dav.Height;
            SidePanel.Top = dav.Top;
            tblMon.DefaultView.RowFilter = "MaMon like '%dav%'";
            load();
        }

        private void loadImagelist()
        {
            foreach (DataRow r in tblMon.Rows)
            {
                // load the bytes from the database that represent your image
                var imageBytes = (byte[])r["hinh"];

                // put those bytes into a memory stream and "rewind" the memory stream
                System.IO.MemoryStream memStm = new System.IO.MemoryStream(imageBytes);
                memStm.Seek(0, System.IO.SeekOrigin.Begin);

                // create an "Image" from that memory stream
                Image image = Image.FromStream(memStm);



                imageList1.Images.Add(r["MaMon"].ToString(), image);
                

                listView1.LargeImageList = imageList1;
            }
        }
        private void load()
        {
            listView1.Items.Clear();    

                foreach (DataRowView r in tblMon.DefaultView)
                {
                    listView1.Items.Add(new ListViewItem(r["TenMon"].ToString(), r["MaMon"].ToString()));
            }
        }
     
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.listView1.SelectedItems.Count == 0)
                return;

            string namn = this.listView1.SelectedItems[0].Text;

            // Create the sql statement to retrieve details for the user
            string sql = string.Format("select * from chitiethoadon where ");

           // // 
           //r["MaCTHD"] = "jhjh";

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
