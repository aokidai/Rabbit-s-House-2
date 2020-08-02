﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Rabbit_s_House
{
    public partial class safes : Form
    {
        public safes()
        {
            InitializeComponent();
        }
        DataTable tblHoaDon, tblKhachHang, tblMon, tblNhanVien, tblLoai;
        DataTable tblCTHD;
        SqlDataAdapter daHoaDon, daCTHD, daKhachHang, daMon, daNhanVien, daLoai;
        BindingManagerBase DSHD, DSHD2;
        bool capNhat = false;

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoai.SelectedIndex>=0)  // Check co chon
                tblMon.DefaultView.RowFilter = "maLoai=" + cboLoai.SelectedValue;
        }

        private void safes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tblHoaDon = new DataTable();
            daHoaDon = new SqlDataAdapter("Select * from hoadon", Model.cnnStr);
            tblCTHD = new DataTable();
            daCTHD = new SqlDataAdapter("Select * from chitiethoadon", Model.cnnStr);
            tblMon = new DataTable();
            daMon = new SqlDataAdapter("Select * from Mon", Model.cnnStr);
            tblNhanVien = new DataTable();
            daNhanVien = new SqlDataAdapter("Select * from NHANVIEN", Model.cnnStr);
            tblKhachHang = new DataTable();
            daKhachHang = new SqlDataAdapter("Select * from KhachHang", Model.cnnStr);
            tblLoai = new DataTable();
            daLoai = new SqlDataAdapter("Select * from Loaisp", Model.cnnStr);
            try
            {
                daLoai.Fill(tblLoai);
                //thaayf oi em sai cho nay
                //roi ok roi a thay
                daHoaDon.Fill(tblHoaDon);
                daCTHD.Fill(tblCTHD);
                daMon.Fill(tblMon);
                daKhachHang.Fill(tblKhachHang);
                daNhanVien.Fill(tblNhanVien);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daCTHD);
            loadDGVHoaDon();
            loadcboTenNV();
            loadcboMon();
            loadcboTenKH();
            cboTenNV.DataBindings.Add("text", tblHoaDon, "MaNV", true);
            cboTenKH.DataBindings.Add("text", tblHoaDon, "MaKh", true);
            datetime.DataBindings.Add("text", tblHoaDon, "Ngaylap", true);
            cboLoai.DataBindings.Add("text", tblCTHD, "MaLoai", true);
            cboTenMon.DataBindings.Add("text", tblCTHD, "MaMon", true);
            txtSoLuong.DataBindings.Add("text", tblCTHD, "Soluong", true);
            DSHD = this.BindingContext[tblCTHD];
            DSHD2 = this.BindingContext[tblHoaDon];
            enableButton();
            cboLoai_SelectedIndexChanged(sender,e);
        }
        private void loadcboTenNV()
        {
            cboTenNV.DataSource = tblNhanVien;
            cboTenNV.DisplayMember = "TenNV";
            cboTenNV.ValueMember = "MaNV";
        }
        private void loadcboMon()
        {
            cboLoai.DisplayMember = "Loai";
            cboLoai.ValueMember = "MaLoai";
            cboLoai.DataSource = tblLoai;
            // em loai cbLoai di nhe
            //tai sao vay thay???
            // Vi CSDL em thiet ke ma, em mo CSDL
         
            cboTenMon.DataSource = tblMon;
            cboTenMon.DisplayMember = "TenMon";
            cboTenMon.ValueMember = "MaMon";
        }
        private void loadcboTenKH()
        {
            cboTenKH.DataSource = tblKhachHang;
            cboTenKH.DisplayMember = "HoTen";
            cboTenKH.ValueMember = "MaKH";
        }
        private void enableButton()
        {
            tolSpInsert.Enabled = !capNhat;
            tolSpDelete.Enabled = !capNhat;
            tolSpEdit.Enabled = !capNhat;
            tolSpSave.Enabled = capNhat;
            tolSpCannel.Enabled = capNhat;
        }

        private void tolSpInsert_Click(object sender, EventArgs e)
        {
            DSHD.AddNew();
            DSHD2.AddNew();
            capNhat = true;
            enableButton();
        }

        private void tolSpSave_Click(object sender, EventArgs e)
        {
            try
            {
                DSHD.EndCurrentEdit();
                daCTHD.Update(tblCTHD);
                tblCTHD.AcceptChanges();
                capNhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                tblCTHD.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void tolSpCannel_Click(object sender, EventArgs e)
        {
            DSHD.CancelCurrentEdit();
            tblCTHD.RejectChanges();
            capNhat = false;
            enableButton();
        }

        private void tolSpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DSHD.RemoveAt(DSHD.Position);
                daCTHD.Update(tblCTHD);
                tblCTHD.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblCTHD.RejectChanges();
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void tolSpEdit_Click(object sender, EventArgs e)
        {
            capNhat = true;
            enableButton();
        }

        private void loadDGVHoaDon()
        {
            dgvHD.AutoGenerateColumns = false;
            dgvHD.DataSource = tblCTHD;
        }

    }
}
