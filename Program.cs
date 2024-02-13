using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Xml.Schema;

namespace programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter max number: ");
            //PrimeNumbers(int.Parse(Console.ReadLine()));

            //Console.Write("Enter pyramid layers: ");
            //Pyramid(int.Parse(Console.ReadLine()));

            //MultiplicationTable();

            //BiggestNum();

            //SevenDuos();

            //Adjacents();

            //Console.WriteLine("Enter string: ");
            //ExtractString(Console.ReadLine());

            //Console.Write("Enter 2 letters");
            //extractAlphabet(Console.ReadLine());

            //SumAndAvg();

            //Console.WriteLine("Enter two numbers, separated by enter or new line");
            //ToThePowerOf(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            //Console.WriteLine("Enter a string and a symbol or letter separated by enter or new line");
            //Separate(Console.ReadLine(), Console.ReadLine());

            //Console.Write("Enter a string: ");
            //IsPalindrome(Console.ReadLine());

            //Console.WriteLine("Enter string: ");
            //Console.WriteLine(Length(Console.ReadLine()).ToString());

            //Console.WriteLine(Reverse("a string"));

            //Console.Write("Enter string: ");
            //WordCount(Console.ReadLine());
        }

        static void PrimeNumbers(int max)
        {
            int divident;
            int quotient = 2;
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

        static void Pyramid(int layers)
        {
            int stars = 1;

            while (layers > 0)
            {
                for (int i = 0; i < layers; i++)
                {
                    Console.Write(' ');
                }
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                layers--;
                stars += 2;
            }
        }

        static void MultiplicationTable()
        {
            int num;
            for (int i = 1; i <= 10; i++)
            {
                num = i;
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(num.ToString() + (' '));
                    num += i;
                }
                Console.WriteLine();
            }
        }

        static void BiggestNum()
        {
            int[] nums = { 99, 1, 2, 6, 3, 4, 5, 6, 7, };
            int maxNum = 0;

            foreach (int num in nums)
            {
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine(maxNum);
        }

        static void SevenDuos()
        {
            int[] nums = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };
            int sevens = 0;

            for (int i = 0; i < ArrayLength(nums) - 1; i++)
            {
                if (nums[i] == 7 && nums[i+1] == 7)
                {
                    sevens++;
                }
            }
            Console.WriteLine(sevens);
        }

        static void Adjacents()
        {
            int[] nums = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };

            int left = 0;
            int mid;
            int right;

            for (int i = 1; i < ArrayLength(nums) - 1; i++)
            {
                left = nums[i - 1];
                mid = nums[i];
                right = nums[i+1];

                if (left + 1 == mid && mid + 1 == right)
                {
                    Console.WriteLine("true");
                    left = -1;
                    break;
                }
            }
            if (left != -1)
            {
                Console.WriteLine("false");
            }
        }

        static void ExtractString(string line)
        {
            bool extract = false;
            string result = "";

            for (int i = 0; i < Length(line); i++)
            {
                if (line[i] == '#' && line[i + 1] == '#')
                {
                    if (extract)
                    {
                        extract = false;
                    }
                    else
                    {
                        extract = true;
                    }
                    i++;
                    continue;
                }
                if (extract)
                {
                    result += line[i];
                }
            }
            Console.WriteLine(result);
        }

        static void extractAlphabet(string letters)
        {

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            bool extract = false;
            string result = "";

            for (int i = 0; i < Length(alphabet); i++)
            {
                if (alphabet[i] == letters[0])
                {
                    extract = true;

                }
                if (extract)
                {
                    result += alphabet[i];
                }
                if (alphabet[i] == letters[1])
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }

        static void SumAndAvg()
        {
            int[] nums = { 11, 66 };
            int sum = 0;
            double avg = (nums[0] + nums[1]) / (double)2;

            for (int i = 0; i < (nums[1] + 1 - nums[0]); i++)
            {
                sum += nums[0] + i;
            }
            Console.WriteLine("sum is: " + sum.ToString() + "\naverage is: " + avg.ToString());
        }

        static void ToThePowerOf(int num, int power)
        {
            int result = num;

            for (int i = 2; i <= power; i++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }

        static void Separate(string line, string separator)
        {
            string result = "";

            for (int i = 0; i < Length(line); i++)
            {
                if (i == Length(line) - 1)
                {
                    separator = "";
                }
                result += line[i] + separator;
            }
            Console.WriteLine(result);
        }

        static void IsPalindrome(string line)
        {
            string result = Reverse(line);
            if (result == line)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static int Length(string line)
        {
            int result = 0;

            foreach (char c in line)
            {
                result++;
            }
            return result;
        }

        static string Reverse(string line)
        {
            string result = "";
            for (int i = 0; i < Length(line); i++)
            {
                result += line[Length(line) - 1 - i];
            }
            return result;
        }

        static void WordCount(string line)
        {
            int count = 0;

            if (char.IsLetter(line.Trim()[0]))
            {
                count++;
            }
            for (int i = 1; i < Length(line.Trim()); i++)
            {
                if (char.IsLetter(line.Trim()[i]) && line.Trim()[i - 1] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static int ArrayLength(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result++;
            }
            return result;
        }


    }
}
