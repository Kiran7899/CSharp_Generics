using System;
using System.Collections.Generic;

namespace CSharp_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            Numbers.Capacity = 20;
            Console.WriteLine(Numbers.Capacity); //0
            int capacity = -1;
            while (true)
            {
                /* To stop displaying the same capacity multiple times before it exceeds to next. 
                 Capacity will be doubled whenever it exceeds
                 */
                if (Numbers.Capacity!=capacity)  
                {
                    capacity = Numbers.Capacity;
                    Console.WriteLine(Numbers.Capacity);
                }
                Numbers.Add(1);
                
            }
        }

      
    }
}
