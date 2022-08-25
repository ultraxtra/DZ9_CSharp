using System;
using static System.Console;

namespace DZ9_CSharp
{
    internal class Array
    {
        int[] arr;
        int Length;

        public  Array(int Length)
        {
            this.arr = new int[Length];
            this.Length = Length;
        }

        public void Fill()
        {
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                this.arr[i] = rand.Next(50);
            }
        }

        public void Print()
        {
            foreach(int i in arr)
            {
                WriteLine($"{i}");
            }
        }

        public void EvenValue(int[] array1)
        {
            int j = 0;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] % 2 == 0)
                {
                    array1[i] = this.arr[i];
                    j++;
                }
            }
        }

        public void OddValue(int[] array1)
        {
            int j = 0;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (this.arr[i] % 2 != 0)
                {
                    array1[i] = this.arr[i];
                    j++;
                }
            }
        }

        public void PrimeDigit(int[] array2)
        {
            int j = 0;
            for (int i = 0; i < this.arr.Length; i++)
            {
                bool IsPrime = true;
                for (int j2 = 2; j2 < this.arr[i]; j2++)
                {
                    if (this.arr[i] % j2 == 0)
                    {
                        IsPrime = false;
                    }
                }
                if (IsPrime)
                {
                    array2[j] = this.arr[i];
                    j++;
                }
            }
        }
        public void FibanacсiDigit(int[] array2)
        {
            array2[0] = 0;
            array2[1] = 1;
            for (int i = 2; i < this.arr.Length; i++)
            {
                array2[i] = this.arr[i - 2] + array2[i - 1];
            }
        }
    }
}