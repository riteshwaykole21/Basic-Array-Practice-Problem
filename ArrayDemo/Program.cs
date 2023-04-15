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
            Console.WriteLine("2 : Array Reverse ");
            Console.WriteLine("3 : Array Sum");
            Console.WriteLine("4 : Sum Of All Array Element");
            Console.WriteLine("5 : Copy One Array TYo Second Array");
            Console.WriteLine("6 :Copy The Elements");
            Console.WriteLine("7 : Duplicate Element Of An Array");
            Console.WriteLine("8 : Unique Element Of An Array");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    ArrayPrint arrayPrint = new ArrayPrint();
                    arrayPrint.Array();
                    break;
                case 2:
                    ReverseArray reverseArray = new ReverseArray();
                    reverseArray.Array();
                    break;
                case 3:
                    ArraySum arraySum = new ArraySum();
                    arraySum.Sum();
                    break;
                case 4:
                    SumArray sumArray = new SumArray();
                    sumArray.Sum(); 
                    break;
                case 5:
                    CopyElements copyElements = new CopyElements();
                    copyElements.Elements();
                    break;
                case 6:
                    Elementscopy elementscopy = new Elementscopy();
                    elementscopy.Elements();
                    break;
                case 7:
                    DuplicateElement duplicateElement = new DuplicateElement();
                    duplicateElement.Elements();
                    break;
                case 8:
                    UniqueElement uniqueElement = new UniqueElement();
                    uniqueElement.Element();
                    break;
            }
            Console.ReadLine();
        }
    }
}
