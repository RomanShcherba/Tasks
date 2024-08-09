using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
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
                Console.WriteLine("Enter number:");

                double a = Convert.ToDouble(Console.ReadLine());
                string action = Console.ReadLine();
                double b = Convert.ToDouble(Console.ReadLine());

                double result = Calculator.Calculate(a, b, action);
                Console.WriteLine(result);
            }
            catch(ArgumentOutOfRangeException ex) 
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
