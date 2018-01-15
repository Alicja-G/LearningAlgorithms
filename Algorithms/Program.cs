using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //------ Calculations of factorial------ // 

            #region
            //Console.WriteLine("Please enter the integer for the factorial: ");
            //var n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Factorial calculated by the loop: {factorialWithLoopBackwards(n)}");
            //Console.WriteLine($"Factorial calculated by the loop (second option): {factorialWithLoopInwards(n)}");
            //Console.WriteLine($"Factorial calculated by the recursion: {factorialUsingRecursion(n)}");
            #endregion

            //----- FizzBuzz display -------//

            #region
            ///displayFizzBuzzUsingALoop();

            //displayFizzBuzzUsingARecursion(100);

            #endregion

            //---- Fibonacci calculations -----//
            #region
            Console.WriteLine("Which number of the Fibonacci Sequence you want to display?: ");
            var number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"{CalculateFibonacciUsingALoop(number)}");
            Console.WriteLine($"{CalculateFibonacciUsingRecursion(number)}");

            #endregion


            Console.ReadKey();


        }

        //-------- FACTORIAL USING A LOOP BACKWARDS --------------//
        public static int factorialWithLoopBackwards(int number)
        {
            var result = 1;

            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }

        //--------- FACTORIAL USING A LOOP INWARDS---------------//
        public static int factorialWithLoopInwards(int number)
        {
            var result = number;

            for (int i = 1; i< number; i++)
            {
                result *= i;
            }

            return result;
        }

        //--------- FACTORIAL USING RECURSION -----------------//
        public static int factorialUsingRecursion(int number)
        {
            var result = 1;
            
            if (number > 1)
            {
                result = number * factorialUsingRecursion(number - 1);
            }

            return result;

        }

        //------- DISPLAYING FIZZBUZZ USING A LOOP-----//
        public static void displayFizzBuzzUsingALoop()
        {
            for (int i = 1; i < 101; i++ )
            {
                var resultOfDvidingBy3 = i % 3;
                var resultOfDividingby5 = i % 5;

                if (resultOfDividingby5 == 0 && resultOfDvidingBy3  == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (resultOfDvidingBy3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (resultOfDividingby5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }

        }

        //------- DISPLAYING FIZZBUZZ USING A RECURSION ------//
        public static void displayFizzBuzzUsingARecursion(int n)
        {
            string text = "";
            if (n < 1)
                return;

            if (n % 15 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();

            Console.WriteLine(text);
            displayFizzBuzzUsingARecursion(n - 1);

        }

        //------- FIBONACCI USING A LOOP --------//

        public static int CalculateFibonacciUsingALoop(int n)
        {

            var number1 = 0;
            var number2 = 1;
            var next = 0;
            if (n == 1 || n == 2)
                next = 1;
            else


                for (int i = 0; i < (n-1); i++)
                {
                    next = number1 + number2;
                    number1 = number2;
                    number2 = next;
                }
            
                    return next;
        }

        //-------- FIBONACCI USING RECURSION-----//

        public static int CalculateFibonacciUsingRecursion(int n)
        {
            var result = 1;
            if (n == 1 || n == 2)
                return 1;
            else
                result = CalculateFibonacciUsingRecursion(n -1) + CalculateFibonacciUsingRecursion(n - 2);
            return result;

        }

        
    }

}
