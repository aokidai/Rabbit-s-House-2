using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
         
            textBox1.DataBindings.Add("text", tblKHACHHANG, "HoTen", true);
            textBox2.DataBindings.Add("text", tblKHACHHANG, "SoDT", true);
            daKH = new SqlDataAdapter("Select * from KhachHang", Model.cnnStr);
            bindkh = this.BindingContext[tblKHACHHANG];
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bindkh.EndCurrentEdit();
                daKH.Update(tblKHACHHANG);
                tblKHACHHANG.AcceptChanges();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindkh.CancelCurrentEdit();
            tblKHACHHANG.RejectChanges();
        }
    }
}
