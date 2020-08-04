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
    public partial class themkhach : Form
    {
        DataTable tblKHACHHANG;
        SqlDataAdapter daKH;
        BindingManagerBase bindkh;
        public themkhach()
        {
            InitializeComponent();
        }

        private void themkhach_Load(object sender, EventArgs e)
        {
            tblKHACHHANG = new DataTable();
            daKH = new SqlDataAdapter("Select * from KhachHang", Model.cnnStr);
            
            try
            {
                daKH.Fill(tblKHACHHANG);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daKH);
            textBox1.DataBindings.Add("text", tblKHACHHANG, "HoTen", true);
            textBox2.DataBindings.Add("text", tblKHACHHANG, "SoDT", true);
           
            bindkh = this.BindingContext[tblKHACHHANG];

            bindkh.AddNew();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                bindkh.EndCurrentEdit();
                daKH.Update(tblKHACHHANG);
                tblKHACHHANG.AcceptChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                tblKHACHHANG.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindkh.CancelCurrentEdit();
            tblKHACHHANG.RejectChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
