using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class SumArray
    {
        public void Sum()
        {
            int[] Number = { 10, 20, 30, 40, 50, 60 };
            int Sum = 0;
            for (int i = 0; i < Number.Length; i++)
            {
                Sum += Number[i];
            }
            Console.WriteLine(Sum);
        }
    }
}
