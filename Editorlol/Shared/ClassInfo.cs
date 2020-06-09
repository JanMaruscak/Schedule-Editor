using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Editorlol.Shared
{
    public class ClassInfo
    {
        public int Week { get; set; }
        public int GoneLeft { get; set; }
        public int GoneRight { get; set; }
        public List<DateTime> Days { get; set; }

        public ClassInfo()
        {
        }

        public ClassInfo(int week, int goneLeft, int goneRight, List<DateTime> days)
        {
            Week = week;
            GoneLeft = goneLeft;
            GoneRight = goneRight;
            Days = days;
        }
    }
}