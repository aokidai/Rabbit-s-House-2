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
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }
        DataTable tblMon, tblNhanVien, tblKhachHang;
        SqlDataAdapter daMon, daNhanVien, daKhachHang;
        BindingManagerBase DSMon, DSNV, DSKH;
        bool capNhat = false;
        private void frmQuanLi_Load(object sender, EventArgs e)
        {
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
            DSMon = this.BindingContext[tblMon];
            tblNhanVien = new DataTable();
            daNhanVien = new SqlDataAdapter("Select * from NHANVIEN", Model.cnnStr);
            try
            {
                daNhanVien.Fill(tblNhanVien);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb1 = new SqlCommandBuilder(daNhanVien);
            DSNV = this.BindingContext[tblNhanVien];
            tblKhachHang = new DataTable();
            daKhachHang = new SqlDataAdapter("Select * from NHANVIEN", Model.cnnStr);
            try
            {
                daKhachHang.Fill(tblKhachHang);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb2 = new SqlCommandBuilder(daNhanVien);
            DSKH = this.BindingContext[tblNhanVien];
            enableButton();
        }
        private void enableButton()
        {
            tolSpInsert.Enabled = !capNhat;
            tolSpDelete.Enabled = !capNhat;
            tolSpEdit.Enabled = !capNhat;
            tolSpSave.Enabled = !capNhat;
            tolSpCannel.Enabled = !capNhat;
        }

    }
}
