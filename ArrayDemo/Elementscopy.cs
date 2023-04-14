using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class Elementscopy
    {
        public void Elements()
        {
            Console.WriteLine("Enter The Size Of Array");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];
            int Sum = 0;
            Console.WriteLine("Enter The Elements Of An Array");
            for (int i = 0; i < Size; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------");
            Console.Write("The Sum Of An Array is : ");
            for(int i = 0; i < Array.Length; i++)
            {
                Sum += Array[i];
            }
            Console.Write(Sum);
        }
    }
}
