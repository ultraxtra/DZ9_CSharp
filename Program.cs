using System;
using static System.Console;
using static System.Delegate;
using static DZ9_CSharp.Program;

namespace DZ9_CSharp
{
    internal class Program
    {

        public delegate void ArrayDelegate<T>(T[] array1);
        public delegate T AreaDelegat<T>(T parametr1, T parametr2, T parametr3);
        public delegate string F();

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write($" {arr[i]}");
            }
        }

        static void Main(string[] args)
        {
            //Program1();
            //Program2();
            Program3();
        }

        static void Program1()
        {
            try
            {

                int[] Result = new int[10];
                Array array = new Array(10);
                array.Fill();
                array.Print();
                WriteLine();

                ArrayDelegate<int> arrayDelgate = array.FibanacсiDigit;

                arrayDelgate += array.EvenValue;
                arrayDelgate += array.OddValue;
                arrayDelgate += array.PrimeDigit;

                arrayDelgate(Result);

                foreach (ArrayDelegate<int> item in arrayDelgate.GetInvocationList())
                {
                    item(Result);
                    PrintArr(Result);
                    WriteLine();
                }

            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }

        static void Program2()
        {
            try
            {
                TimeMethod timeMethod = new TimeMethod();
                Func<string> func = timeMethod.DateNow;
                func += timeMethod.TimeNow;
                func += timeMethod.Day;
                foreach (Func<string> item in func.GetInvocationList())
                {
                    WriteLine(item());
                }

                Square square = new Square();
                AreaDelegat<double> areaFigure = square.SquareOfTriangle;
                WriteLine($"Area of Triangle: {areaFigure(2.2, 3.3, 45)}");
                areaFigure = square.SquareOfRectangle;
                WriteLine($"Area of Rectangle: {areaFigure(2.2, 3.3, 45)}");

            }

            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }

      
    }
}