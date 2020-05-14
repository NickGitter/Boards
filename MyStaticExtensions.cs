using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutBoards
{
    public static class MyStaticExtensions
    {
        public static bool MyExt_IsZero(this double a)
        {
            return (Math.Abs(a) <= 0.00000000000001);
        }
    }
}
