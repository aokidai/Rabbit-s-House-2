using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_s_House.model
{
    class NhanVien: table
    {
        public NhanVien() : base("NHANVIEN") { }
        public NhanVien(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
