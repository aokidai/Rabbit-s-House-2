using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Rabbit_s_House
{
    class Model
    {
        public static string cnnStr = "Data Source=.;Initial Catalog=Rabbit_s_House;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);
    }
}
