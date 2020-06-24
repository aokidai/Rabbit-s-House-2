using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabbit_s_House
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Application.Run(new frmIndex());
            //Application.Run(new frmLogin());
            //Application.Run(new frmIndex());
            //int i = 1000;
            //do
            //{
            //    Application.Run(new frmLogin());
            //    Application.Run(new frmIndex());
            //    i++;
            //} while (i >= 1000);
            //for(int i=0; i<1000; i++)
            //{
            //    Application.Run(new frmLogin());
            //    Application.Run(new frmIndex());
            //    if(f)
            //}

        }
    }
}
