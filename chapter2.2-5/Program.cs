using System;
using System.Collections.Generic;

namespace chapter2._2_5
{
    class Program
    {
        public static List<T> CopyAtMost<T>(
            List<T> input, int maxElements)
         {
                int actualCount = Math.Min(input.Count, maxElements);
                List<T> ret = new List<T>(actualCount);
                for (int i = 0; i < actualCount; i++)
                {
                    ret.Add(input[i]);
                }
                return ret;
         }
            static void Main()
            {
                List<int> numbers = new List<int>();
                numbers.Add(5);
                numbers.Add(10);
                numbers.Add(20);

                List<int> firstTwo = CopyAtMost<int>(numbers, 2);
                Console.WriteLine(firstTwo.Count);
                Console.ReadKey();
            }
        
    }
}
