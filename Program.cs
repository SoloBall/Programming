using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Services;
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

            //Console.Write("Enter string: ");
            //ReverseWords(Console.ReadLine());

            //Console.Write("Enter string: ");
            //Occurrences(Console.ReadLine());

            //Console.Write("Enter string");
            //CompressString(Console.ReadLine());

            // Basic:

            //Console.WriteLine("Enter 3 numbers separated by enter or new line: ");
            //AddMultiply(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

            //Console.Write("Enter temperature: ");
            //Console.ReadLine();

            //Console.WriteLine("Enter two numbers separated by enter or new line");
            //Calculator(Console.ReadLine(), Console.ReadLine());

            //Console.WriteLine("Enter two numbers separated by enter or new line");
            //SameSum(Console.ReadLine(), Console.ReadLine());

            //Console.WriteLine("Enter 3 numbers separated by enter or new line");
            //Modulo(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

            //Console.Write("Enter a number: ");
            //Cubed(Console.ReadLine());

            //Console.WriteLine("Enter two numbers separated by enter or new line");
            //Swap(Console.ReadLine(), Console.ReadLine());

            //Console.WriteLine("Enter year: ");
            //LeapYear(Console.ReadLine());

            //Console.Write("Enter number: ");
            //AbsoluteValue(Console.ReadLine());

            //Console.WriteLine("Enter two numbers separated by enter or new line");
            //Division(Console.ReadLine(), Console.ReadLine());

            //AMethodThatReturnsTheSubtractionOfTheFirstGivenNumberByTheSecondGivenNumberIfTheGivenStringCalledPneumonoultramicroscopicsilicovolcanoconiosisIsTheSameAsItsNameIfThatIsNotTheCaseItReturnsFalse(1, 5, "lmao nah");

            //Console.Write("Enter 3 letters: ");
            //Console.WriteLine(IsUpperCase(Console.ReadLine()).ToString());

            //Console.WriteLine("Enter 3 numbers separated by enter or new line");
            //BiggerThanThird(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

            //Console.Write("Enter a number: ");
            //IsEven(Console.ReadLine());

            //IsSorted();

            //Console.Write("Enter a number: ");
            //CheckNum(Console.ReadLine());

            //Console.WriteLine("Enter a string: ");
            //AscendingSort(Console.ReadLine());
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

        static void ReverseWords(string line)
        {
            string substring = " ";
            string text = "";
            string result = "";

            for (int i = 0; i < Length(line); i++)
            {
                if (!char.IsWhiteSpace(line[i]))
                {
                    substring += line[i];
                }
                else
                {
                    result = text.Insert(0, substring);
                    text = result;
                    substring = " ";
                }
            }
            result = text.Insert(0, substring);
            text = result;
            if (result[0] == ' ')
            {
                result = text.Remove(0, 1);
            }
            Console.WriteLine(result);
            Console.Read();
        }

        static void Occurrences(string line)
        {
            string substring = "go";
            bool exists = false;
            int result = 0;

            for (int i = 0; i < Length(line); i++)
            {
                if (line[i] == substring[0])
                {
                    exists = true;
                    for (int j = 1; j < Length(substring); j++)
                    {
                        if (line[i+j] != substring[j])
                        {
                            exists = false;
                        }
                    }
                    if (exists)
                    {
                        result++;
                    }
                }
            }
            Console.Write(result);
        }

        static void AscendingSort(string line)
        {
            char[] chars = line.ToCharArray();
            Array.Sort(chars);
            string result = ToString2(chars);
            Console.WriteLine(Reverse(result));
            Console.Read();
        }

        static void CompressString(string line)
        {
            int num = 1;
            string result = "";

            for (int i = 0; i < Length(line) - 1; i++)
            {
                while (line[i + num] == line[i])
                {
                    num++;
                    if (i + num >= Length(line))
                    {
                        break;
                    }
                }
                i += num - 1;
                result += line[i] + num.ToString();
                num = 1;
            }
            Console.WriteLine(result);
            Console.Read();
        }

        // Basic:

        static void AddMultiply(int num1, int num2, int num3)
        {
            Console.WriteLine((num1 + num2) * num3);
        }

        static void CtoF(int celcius)
        {
            if (((celcius * 9 / 5) + 32) < -271.15)
            {
                Console.WriteLine("That temperature does not exist!");
            }
            else
            {
                Console.WriteLine("T: " + ((celcius * 9 / 5) + 32).ToString() + "F");
            }
        }

        static void Calculator(int num1, int num2)
        {
            int a1 = num1 + num2;
            int a2 = num1 * num2;
            int a3 = num1 - num2;
            string a4 = "";
            if (num1 == 0 || num2 == 0)
            {
                a4 = "invalid";
            }
            else
            {
                a4 = (num1 / num2).ToString();
            }
            Console.WriteLine("Addition: " + a1.ToString()
                + " Multiplication: " + a2.ToString()
                + " Subtraction" + a3.ToString()
                + " Division: " + a4);
        }

        static void SameSum(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        static void Modulo(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 % num2 % num3);
        }

        static void Cubed(int num)
        {
            Console.WriteLine(num * num * num);
        }

        static void Swap(int num1, int num2)
        {
            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine($"num1: {num1} num2 = {num2}");
        }

        static void LeapYear(int year)
        {
            if (year % 4 != 0)
            {
                Console.WriteLine("is not leap year");
            }
            else
            {
                Console.WriteLine("is leap year");
            }
        }

        static void AbsoluteValue(int num)
        {
            if (num < 0)
            {
                num *= -1;
            }
            Console.WriteLine(num);
        }

        static void Division(int num1, int num2)
        {
            if (num1 % 2 == 0 || num1 % 3 == 0)
            {
                if (num2 % 2 == 0 || num2 % 3 == 0)
                {
                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine(num1 + num2);
                }
            }
            else
            {
                Console.WriteLine(num1 + num2);
            }
        }

        static int AMethodThatReturnsTheSubtractionOfTheFirstGivenNumberByTheSecondGivenNumberIfTheGivenStringCalledPneumonoultramicroscopicsilicovolcanoconiosisIsTheSameAsItsNameIfThatIsNotTheCaseItReturnsZero(int num1, int num2, string Pneumonoultramicroscopicsilicovolcanoconiosis)
        {
            if (Pneumonoultramicroscopicsilicovolcanoconiosis == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return num1 - num2;
            }
            else
            {
                return 0;
            }
        }

        static bool IsUpperCase(string line)
        {
            foreach (char c in line)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
                else
                {
                    if (char.IsLower(c))
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }

        static void BiggerThanThird(int num1, int num2, int num3)
        {
            if ((num1 + num2) > num3)
            {
                Console.WriteLine("True");
            }
            else if ((num1 * num2) > num3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void IsSorted()
        {
            /* I have an old version of c# apparently, so i can't give an array as an argument without the array being a variable
               example to show that i know how to do it: 
               static void IsSorted(int[] nums){} --> IsSorted([1, 2, 3]);
            */

            Console.WriteLine("Enter 3 numbers separated by enter or new line");
            int[] nums = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

            if (nums[0] < nums[1] && nums[1] < nums[2])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void CheckNum(double num)
        {
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        static string ToString2(char[] chars)
        {
            string result = "";
            foreach (char c in chars)
            {
                result += c;
            }
            return result;
        }
    }
}