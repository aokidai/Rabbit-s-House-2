using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_s_House.model
{
    class khachhang:table
    {
        public khachhang() : base("KhachHang") { }
        public khachhang(string pQuery) : base("KhachHang", pQuery) { }
    }
}
