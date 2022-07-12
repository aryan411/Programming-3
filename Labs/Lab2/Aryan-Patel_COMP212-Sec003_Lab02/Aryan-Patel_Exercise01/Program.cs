using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aryan_Patel_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string, string> min = Min;
            Console.WriteLine($"Minium of Aryan, Jeet and Nen is : {min("Aryan", "Jeet", "Nen")}\n");

            Action<double, double, double> avrgGrade = AvrgGrade;
            avrgGrade(4.5, 3.9, 2.0);
        }

        //Find string of minmium length
        static string Min(string str1, string str2, string str3)
        {
            string minL = str1;

            if (str1.Length > str2.Length)
            {
                minL = str2;
            }

            if (minL.Length > str3.Length)
            {
                minL = str3;
            }
            return minL;

        }

        //Calculate avg of grades
        static void AvrgGrade(double grd1, double grd2, double grd3)
        {
            double avrgGrade = (grd1 + grd2 + grd3) / 3;
            Console.WriteLine($"Average of Grade {grd1}, {grd2}, {grd3} is : {String.Format("{0:0.##}", avrgGrade)}\n");
        }
    }
}
