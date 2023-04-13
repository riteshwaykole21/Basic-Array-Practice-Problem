using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class CopyElements
    {
        public void Elements()
        {
           int[] FirstArray = {1,2,3,4,5};
            int[] LastArray = new int[5];
            Array.Copy(FirstArray, LastArray,5);
            foreach (int i in LastArray)
            {
                Console.Write(i + " ");
            }
        }
    }
}
