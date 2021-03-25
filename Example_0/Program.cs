using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Example_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a = Convert.ToDouble(str, numberFormatInfo);
        }
    }
}
