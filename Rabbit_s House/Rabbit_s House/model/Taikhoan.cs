using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_s_House.model
{
    class Taikhoan: table
    {
        public Taikhoan() : base("TAIKHOAN") { }
        public Taikhoan(string pQuery) : base("TAIKHOAN", pQuery) { }
    }
}
