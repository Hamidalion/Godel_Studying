using System.Numerics;

namespace Factorial
{
    class Recursion
    {
        public static BigInteger FactorialRecursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * FactorialRecursion(number - 1);
            }
        }
    }
}
