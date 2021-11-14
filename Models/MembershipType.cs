using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp_Gr2.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFre { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}
