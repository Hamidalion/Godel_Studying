using System.Numerics;

namespace Factorial
{
    class WhithoutRecursion
    {
        public static BigInteger FactorialFor(int number)
        {
            BigInteger whithoutRecursion = 1;
            for (int i = 1; i <= number; i++)
            {
                whithoutRecursion *= i;
            }
            return whithoutRecursion;
        }
    }
}
