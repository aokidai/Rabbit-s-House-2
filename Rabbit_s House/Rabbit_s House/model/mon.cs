using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Rabbit_s_House.model
{
    class mon:table
    {
        public mon() : base("Mon") { }
        public mon(string pQuery) : base("Mon", pQuery) { }
    }
}
