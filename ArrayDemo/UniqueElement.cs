using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class UniqueElement
    {
        public void Element()
        {
            int[] Array = { 1, 2, 3, 3, 2, 1, 5 };
            int[] Array2 = { 10, 20, 30, 40, 50 };
            int[] Array3 = new int[12];
            int Num = 0;
            for (int i =0; i < 7 ; i++)
            {
                Array3[i] = Array[i];
            }
            for (int i = 7; i < Array3.Length; i++)
            {
                Array3[i] = Array2[Num];
                Num++;
            }
            foreach (int i in Array3)
            {
                Console.Write(i + "  ");
            }

        }
    }
}
