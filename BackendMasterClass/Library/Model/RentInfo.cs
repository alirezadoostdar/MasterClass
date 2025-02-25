using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class RentInfo
    {
        public int BookCode { get; set; }
        public int MemberBook { get; set; }
        public DateTime RentDate{ get; set; }
        public DateTime DesiredRetutnDate{ get; set; }
        public DateTime ReturnDate{ get; set; }

    }
}
