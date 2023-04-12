using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class ArrayPrint
    {
        public void Array()
        {
            Console.WriteLine("Enter The Size Of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            int[] arr = Array;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter The Element Of Array");
                int data = Convert.ToInt32(Console.ReadLine());
                arr[i] = data;  
            }
            Console.WriteLine("Your Array Elements Are Given Below");
            foreach(int item in arr)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
    }
}
