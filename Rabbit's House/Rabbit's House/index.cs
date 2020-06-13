using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabbit_s_House
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }
        private void frmIndex_Load(object sender, EventArgs e)
        {
            
      
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManager fM = new frmManager();
            fM.MdiParent = this;
            fM.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
