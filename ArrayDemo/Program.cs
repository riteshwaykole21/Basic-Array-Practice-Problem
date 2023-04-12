using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Print The Array Element");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    ArrayPrint arrayPrint = new ArrayPrint();
                    arrayPrint.Array();
                    break;
            }
            Console.ReadLine();
        }
    }
}
