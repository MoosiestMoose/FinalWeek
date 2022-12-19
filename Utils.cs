using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DR_R23_Add_in_Template1
{
    internal static class Utils
    {
        internal static double Metric(double meters)
        {
            double feet = meters * 3.28084;

            return feet;
        }
    }
}
