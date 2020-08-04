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
using System.IO;
using Rabbit_s_House.model;

namespace Rabbit_s_House
{
    public partial class safes : Form
    {
        public safes()
        {
            InitializeComponent();
        }
        DataTable tblKhachHang, tblMon, tblNhanVien, tblLoai,tblhoadon;
        DataTable tblCTHD;
        SqlDataAdapter daCTHD, daKhachHang, daMon, daNhanVien, daLoai,dahd;
        BindingManagerBase DSCTHD,DSHD;
        bool capNhat = false;

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoai.SelectedIndex >= 0)  // Check co chon
                tblMon.DefaultView.RowFilter = "MaLoai='" + cboLoai.Text + "'";
        }

        private void safes_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            tblhoadon = new DataTable();
            dahd = new SqlDataAdapter("select * from hoadon", Model.cnnStr);
            try
            {
                daLoai.Fill(tblLoai);
                //thaayf oi em sai cho nay
                //roi ok roi a thay
                dahd.Fill(tblhoadon);
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
            var cmb2 = new SqlCommandBuilder(dahd);
            loadcboTenNV();
            loadcboTenKH();
            loadcboTenMon();
            loadcboLoai();
            loadDGVHoaDon();
            
            cboTenNV.DataBindings.Add("text", tblhoadon, "MaNV", true);
            cboTenKH.DataBindings.Add("text", tblhoadon, "MaKh", true);
            datetime.DataBindings.Add("text", tblhoadon, "Ngaylap", true);
            DSHD = this.BindingContext[tblhoadon];
            cboLoai.DataBindings.Add("text", tblCTHD, "MaLoai", true);
            cboTenMon.DataBindings.Add("text", tblCTHD, "MaMon", true);
            txtSoLuong.DataBindings.Add("text", tblCTHD, "Soluong", true);
            txtTien.DataBindings.Add("text", tblCTHD, "ThanhTien", true);
            txtgia.DataBindings.Add("text", tblCTHD, "Gia", true);
            DSCTHD = this.BindingContext[tblCTHD];
            enableButton();
            cboLoai_SelectedIndexChanged(sender,e);
            

        }



        private void loadcboTenMon()
        {
            //cboLoai.DataSource = tblLoai;
            //cboLoai.DisplayMember = "Loai";
            //cboLoai.ValueMember = "Loai";

            // em loai cbLoai di nhe
            //tai sao vay thay???
            // Vi CSDL em thiet ke ma, em mo CSDL

            cboTenMon.DataSource = tblMon;
            cboTenMon.DisplayMember = "MaMon";
            cboTenMon.ValueMember = "MaMon";
        }
        //private void loadcboMon()
        //{


        //    cboTenMon.DataSource = tblMon;
        //    cboTenMon.DisplayMember = "MaMon";
        //    cboTenMon.ValueMember = "MaMon";
        //}
        private void loadcboLoai()
        {
            cboLoai.DataSource = tblLoai;
            cboLoai.DisplayMember = "MaLoai";
            cboLoai.ValueMember = "Loai";

            // em loai cbLoai di nhe
            //tai sao vay thay???
            // Vi CSDL em thiet ke ma, em mo CSDL
        }
        private void loadcboTenKH()
        {
            cboTenKH.DataSource = tblKhachHang;
            cboTenKH.DisplayMember = "MaKH";
            cboTenKH.ValueMember = "MaKH";
        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboTenMon.SelectedIndex;
            if(index>-1)
            {
                txtgia.Text = tblMon.Rows[index][3].ToString();
                //txtTien.Text = tblCTHD.Rows[index][.ToString();
            }    
  
        }
        private void loadcboTenNV()
        {
            cboTenNV.DataSource = tblNhanVien;
            cboTenNV.DisplayMember = "MaNV";
            cboTenNV.ValueMember = "MaNV";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //int index = txtSoLuong.EnabledChanged;
            //if (index > -1)
            //{
              
            //}
        }

        private void enableButton()
        {
            tolSpInsert.Enabled = !capNhat;
            tolSpDelete.Enabled = !capNhat;
            tolSpEdit.Enabled = !capNhat;
            tolSpSave.Enabled = capNhat;
            tolSpCannel.Enabled = capNhat;
            groupBox1.Enabled = capNhat;
        }

        private void tolSpInsert_Click(object sender, EventArgs e)
        {
            
            DSHD.AddNew();
            DSCTHD.AddNew();
            capNhat = true;
            enableButton();
        }

        private void tolSpSave_Click(object sender, EventArgs e)
        {
            // chay thu di
     
            try
            {
                DSHD.EndCurrentEdit();
                dahd.Update(tblhoadon);
                tblhoadon.AcceptChanges();
                DSCTHD.EndCurrentEdit();
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
            //dgvHD.Columns[5] = ("select ThanhTien=Soluong*gia from chitiethoadon c, Mon m where c.MaMon=m.MaMon");
        }

    }
}
