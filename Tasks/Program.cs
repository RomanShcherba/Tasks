Task4_Calculator
﻿namespace Tasks
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter expression");

                string input = Console.ReadLine()
    ;
                (double number1, string action, double number2) = Calculator.Parse(input);

                double result = Calculator.Calculate(number1, number2, action);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
        }

       
    }
}
