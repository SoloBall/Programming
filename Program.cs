using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grundlæggende_programmering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max number: ");
            PrimeNumbers(int.Parse(Console.ReadLine()));
        }

        static void PrimeNumbers(int max)
        {
            int divident;
            int quotient = 1;
            bool prime;
            List<int> primes = new List<int>();

            while (quotient <= max)
            {
                prime = true;
                divident = 2;
                while (quotient > divident)
                {
                    if (quotient % divident == 0)
                    {
                        prime = false;
                    }

                    divident++;
                }
                if (prime)
                {
                    primes.Add(quotient);
                }

                quotient++;
            }
            foreach (int n in primes)
            {
                Console.WriteLine(n);
            }
        }
    }
}
