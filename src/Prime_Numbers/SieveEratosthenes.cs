using System;
using System.Collections.Generic;
using System.Text;

namespace Prime_Numbers
{
    public class SieveEratosthenes
    {
        public static List<int> AddSieveEratosthenes(int selection)
        {
            var numbers = new List<int>();

            for (var i = 2u; i < selection; i++)
            {
                numbers.Add((int)i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < selection; j++)
                {
                    numbers.Remove((int)(numbers[i] * j));
                }
            }

            return numbers;
        }
    }
}
