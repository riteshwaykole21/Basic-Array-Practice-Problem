using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class DuplicateElement
    {
        public void Elements()
        {
            int[] Array = {1,2,3,4,7,9,10,1,3,7};
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1 ; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total Number Of Dublicate Number in Array  :  " + count);
            
        }
    }
}
