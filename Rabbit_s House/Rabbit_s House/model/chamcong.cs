using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_s_House.model
{
    class chamcong:table
    {
        public chamcong() : base("CHAMCONG") { }
        public chamcong(string pQuery) : base("CHAMCONG", pQuery) { }
    }
}
