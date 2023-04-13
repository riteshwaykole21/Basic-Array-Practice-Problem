using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class ReverseArray
    {
        public void Array()
        {
            Console.WriteLine("Enter The Size Of Array");
            int Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];    
            int[] arr = Array;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter The Element Of An Array");
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Array in Original Direction");
            foreach (int i in arr)
            {
               
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("Array In Reverse Direction");
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
        }
    }

       
   
}
