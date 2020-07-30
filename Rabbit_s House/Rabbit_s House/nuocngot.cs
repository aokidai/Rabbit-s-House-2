using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Rabbit_s_House
{
    public partial class nuocngot : UserControl
    {
        public nuocngot()
        {
            InitializeComponent();
        }
        DataTable tblMon;
        DataTable tblhoadon;
        SqlDataAdapter daMon;
        SqlDataAdapter dahoandon;
        BindingManagerBase DSMon;
        BindingManagerBase dshoadon;
        bool capNhat = false;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nuocngot_Load(object sender, EventArgs e)
        {
          
            tblMon = new DataTable();
            daMon = new SqlDataAdapter("Select * from Mon where MaMon like '%nt%'", Model.cnnStr);
            try
            {
                daMon.Fill(tblMon);

                foreach (DataRow r in tblMon.Rows)
                {
                    // load the bytes from the database that represent your image
                    var imageBytes = (byte[])r["hinh"];

                    // put those bytes into a memory stream and "rewind" the memory stream
                    System.IO.MemoryStream memStm = new System.IO.MemoryStream(imageBytes);
                    memStm.Seek(0, System.IO.SeekOrigin.Begin);

                    // create an "Image" from that memory stream
                    Image image = Image.FromStream(memStm);

                  

                    imageList1.Images.Add(r["MaMon"].ToString(),image );
                    listView1.LargeImageList = imageList1;
                    listView1.Items.Add(new ListViewItem(r["TenMon"].ToString(), r["MaMon"].ToString()));
                }
         

                // create image list and fill it 
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daMon);
            DSMon = this.BindingContext[tblMon];

   
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems.ToString());
        }
    }
}
