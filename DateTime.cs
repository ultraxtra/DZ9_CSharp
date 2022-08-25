using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Math;

namespace DZ9_CSharp
{
    internal class TimeMethod
    {
        public string TimeNow()
        {
            return DateTime.Now.ToString("h:mm:ss tt");
        }

        public string DateNow()
        {
            return DateTime.Now.ToString("yy-MM-dd");
        }

        public string Day()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }
    }

    internal class Square
    {
        public double SquareOfTriangle(double side1, double side2, double angle)
        {
            return 0.5 * (side1 * side2) * (Sin(angle));
        }

        public double SquareOfRectangle(double Diagonal1, double Diagonal2, double Angle)
        {
            return 0.5 * (Diagonal1 * Diagonal2) * (Sin(Angle));
        }
    }
}

