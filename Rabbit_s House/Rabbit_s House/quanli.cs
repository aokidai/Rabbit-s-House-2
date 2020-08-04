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
        DataTable tblMon;
        SqlDataAdapter daMon;
        BindingManagerBase DSMon;

        private void frmQuanLi_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            loaddgvmon();
            DSMon = this.BindingContext[tblMon];
      
        }
        private void loaddgvmon()
        {
            dgvmon.AutoGenerateColumns = false;
            dgvmon.DataSource = tblMon;
        }
    }

}
