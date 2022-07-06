using System;
using System.Collections.Generic;
using System.Linq;

namespace Lonely_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1,2,3,4,3,2,1};
            int result = 0;
            foreach (var item in array)
            {
                if (array.Count(i => i==item)==1)
                {
                    result = item;
                }             
            }
            Console.WriteLine(result);
        }
    }
}
