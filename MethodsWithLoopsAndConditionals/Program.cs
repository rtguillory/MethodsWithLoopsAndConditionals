using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            //PrintNumsInRange(1000, -1000);
            //PrintMultiplesOf3(3,999);
            //Ask user to enter 2 integers; test to see valid
                bool flag = false;
                int number1 = 0;
                int number2 = 0;
                while (!flag)
                {
                    Console.WriteLine("\nEnter the first of 2 integers.");
                    string num1Str = Console.ReadLine();
                    if (Int32.TryParse(num1Str, out int num1))
                    {
                        Console.WriteLine($"{num1} is first number.");
                        flag = true;
                        number1 = num1;
                    }
                    else
                    {
                        Console.WriteLine($"{ num1Str} is  not a valid integer.");
                    }
                }
                flag = false;
                while (!flag)
                {
                    Console.WriteLine("\nEnter the second of 2 integers.");
                    string num2Str = Console.ReadLine();

                    if (Int32.TryParse(num2Str, out int num2))
                    {
                        Console.WriteLine($"{num2} is second number.");
                        flag = true;
                        number2 = num2;
                    }
                    else
                    {
                        Console.WriteLine($"{ num2Str} is  not a valid integer.");
                    }
                }

            //Call method to test whether entered numbers are equal
                if(IsEqual(number1, number2))
                {
                    Console.WriteLine($"{number1} equals {number2}.");
                }
                else
                {
                    Console.WriteLine($"\n{number1} does not equal {number2}.");
                }

            //Call method to test whether first integer entered is even or odd
            EvenOrOdd(number1);

            //Call method to test whether second number entered is positive or negative
            PositveOrNegative(number2);

            //Call method to enter an age and test whether old enough to vote
            CanVote();

            //Call method to test whether first integer is between -10 and 10
            BetweenNegTenPosTen(number1);

            //Call method to print 1-12 multiplication table for second integer
            MultiplicationTable(number2);

        }

        //Method to print to the console
        //all numbers 1000 through -1000
        public static void PrintNumsInRange(int max, int min)
        {
            for(int i = max; i >= min; i--)
            {
                Console.Write(i + "  ");
                if(i % 20 == 0) { Console.WriteLine(""); }
            }
        }

        //Method to print multiples of 3
        public static void PrintMultiplesOf3(int start, int end)
        {
            for(int i = start; i <= end; i += 3)
            {
                Console.Write(i + " ");
                if(i % 60 == 0) { Console.WriteLine("");}
            }
        }

        //Method to check whether two integers
        //passed in as parameters are equal
        public static bool IsEqual(int a, int b)
        {
            if(a == b) { return true; }
            return false;

            //var check = (a == b) ? true : false;
            //return check;
        }

        //Method to accept a number as a parameter
        //and check whether it is even or odd
        public static void EvenOrOdd(int a)
        {
            if(a % 2 == 0) 
            { 
                Console.WriteLine($"\n{a} is even."); 
            }
            else
            {
                Console.WriteLine($"\n{a} is odd.");
            }
        }

        //Method to accept a number as a parameter
        //and check whether it is positive or negative
        public static void PositveOrNegative(double num)
        {
            if(num < 0)
            {
                Console.WriteLine($"\n{num} is negative.");
            }
            else if(num > 0)
            {
                Console.WriteLine($"\n{num} is positive.");
            }
            else
            {
                Console.WriteLine($"{num} is neither positive or negative.");
            }
        }

        //Method to read age of candidate and
        //determine if they can vote.
        public static void CanVote()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("\n\nEnter your age: ");
                string inputAge = Console.ReadLine();
                if (Int32.TryParse(inputAge, out int age))
                {
                    if (age >= 0)
                    {
                        flag = false;
                        if (age >= 21)
                        {
                            Console.WriteLine($"\n{age} is old enough to vote.");
                        }
                        else
                        {
                            Console.WriteLine($"\n{age} is not old enough to vote.");
                        }
                    }
                    else 
                    { Console.WriteLine($"\n{inputAge} is not a valid numerical age."); }
                }
                else
                {
                    Console.WriteLine($"\n{inputAge} is not a valid numerical age.");
                }
            } while (flag);
        }

        //method to determine if number taken in as parameter is 
        //in range -10 to 10, inclusive
        public static void BetweenNegTenPosTen(int num)
        {
            if(num >= -10 && num <= 10)
            {
                Console.WriteLine($"\n{num} is in the range from -10 to 10.");
            }
            else
            {
                Console.WriteLine($"\n{num} is not in the range from -10 to 10.");
            }
        }

        //method to take in integer parameter and
        //display multiplication table from 1 to 12
        //for that integer
        public static void MultiplicationTable(int n)
        {
            Console.WriteLine("");
            for(int i = 1; i <= 12; i++)
            {
                int product = i * n;
                Console.WriteLine($"{n} X {i} = {product}");
            }
            Console.WriteLine("");
        }
    }
}
