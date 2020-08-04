using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
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
using Rabbit_s_House.model;

namespace Rabbit_s_House
{
    class Model
    {
        public static string cnnStr = "Data Source=.;Initial Catalog=Rabbit_s_House;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
      
       


    }
}
