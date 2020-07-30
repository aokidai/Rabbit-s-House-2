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
using Rabbit_s_House.model;
using System.IO;
namespace Rabbit_s_House
{
    public partial class dav : UserControl
    {
        public dav()
        {
            InitializeComponent();
        }
        DataTable tblMon;
        SqlDataAdapter daMon;
        BindingManagerBase DSMon;
        bool capNhat = false;
        public int ColumnCount { get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dav_Load(object sender, EventArgs e)
        {

           

        }

       private void autopicture(int columnCount, int rowCount)
        {

          
        }
           
        
    }
    }

