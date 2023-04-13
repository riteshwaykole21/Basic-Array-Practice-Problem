using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class ArraySum
    {
        public void Sum()
        {
            Console.WriteLine("Enter The Size Of Array");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];   
            int [] arr = Array;
            int Sum = 0;
            Console.WriteLine("Enter The Element of an Array");
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Sum Of All Array Elements Are");
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            Console.WriteLine(Sum);
        }
    }
}
