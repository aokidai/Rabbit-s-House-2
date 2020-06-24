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
        public string maNV;
        public void enableControl(int maLTK)
        {
            switch(maLTK)
            {
                case 1:
                    newToolStripMenuItem.Enabled = true;
                    openToolStripMenuItem.Enabled = true;
                    break;
                case 2:
                    newToolStripMenuItem.Enabled = false;
                    openToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    newToolStripMenuItem.Enabled = false;
                    openToolStripMenuItem.Enabled = true;
                    break;
                default:
                    newToolStripMenuItem.Enabled = false;
                    openToolStripMenuItem.Enabled = false;
                    break;

            }
        }
        private void frmIndex_Load(object sender, EventArgs e)
        {
            
      
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            frmManager fM = new frmManager();
            fM.MdiParent = this;
            fM.WindowState = FormWindowState.Maximized;
            fM.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
           // frmIndex fi = new frmIndex();
            //Application.Run( new frmLogin());
          //  fi.Close();
            //frmLogin login = new frmLogin();
           // login.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLi fQ = new frmQuanLi();
            fQ.MdiParent = this;

            fQ.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About of code
            //frmAbout fA = frmAbout();
            //fA.Show();
        }
    }
}
