using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Maths_Assignment_Mohamed_Wessam
{
    internal class Program
    {
        static void test(bool functionResult, bool result)                // Function to test my functions.
        {
            if (functionResult == result)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }

        static int InputNum()
        {
            return int.Parse(Console.ReadLine());   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter perfect number interval");
            int perfectN1 = InputNum();
            int perfectN2 = InputNum();
            Console.WriteLine("Enter prime number interval");
            int primeN1 = InputNum();
            int primeN2 = InputNum();
            Console.WriteLine("Perfect numbers from {0} to {1} are: ", perfectN1, perfectN2);
            PerfectNumbers(perfectN1, perfectN2);
            Console.WriteLine("Prime numbers from {0} to {1} are: ", primeN1, primeN2);
            PrimeNumbers(primeN1, primeN2);
        }

        // Start of Perfect Numbers Algorithm

        // Integer -> bool
        // Detect if this number is Perfect, return true if yes, else return false
        static bool PerfectNumber(int n)  // Perfect Number Detector
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;    // if i is a factor, then add to sum
                }
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }

        //Integer(n1, n2) -> Integer
        // Print all PerfectNumbers from n1, to n2 inclusive.
        static void PerfectNumbers(int n1, int n2)  // All Perfect Numbers from n1 to n2
        {
            for (int i = n1; i <= n2; i++)
            {
                if (PerfectNumber(i))               // If number is perfect, then print number    
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(i);
            }

        }
        // End of Perfect Numbers Algorithm

        // Start of Prime Numbers Algorithm

        static bool PrimeDetector(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)           // Check all numbers from 2 to the square root of the number, if there doesnt exist a factor, then its prime.
            {
                if (n % i != 0)
                {
                    continue;                                   // If number doesnt have a factor then ignore and move on to the next iteration
                }
                else
                {
                    return false;                               // If there is a factor, then return false
                }
            }
            return true;                                        // If it doesnt return anything from the previous statements, then this number doesn't have a factor which means that it will return true that it is a prime
        }

        static void PrimeNumbers(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)    // Loop through all numbers from n1 to n2
            {
                if (PrimeDetector(i))         // If number is prime then print the number
                {
                    Console.WriteLine(i);
                }
            }
        }

        //End of Prime Numbers Algorithm



    }




}
