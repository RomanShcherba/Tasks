namespace Tasks
{
    /// <summary>
    /// Calculator
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Calculate operations
        /// </summary>
        /// <param name="number1">
        /// First number
        /// </param>
        /// <param name="number2">
        /// Second number
        /// </param>
        /// <param name="actions">
        /// Math operators
        /// </param>
        
        public static double Calculate(double number1, double number2, string actions)
        {
            switch (actions)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    if (number2 == 0)
                    {
                        throw new DivideByZeroException("You can't divide by zero");
                    }
                    return number1 / number2;
                case "^":
                    return Math.Pow(number1, number2);
                case "V":
                    if (number1 > 0 || number2 > 0)
                    {
                        return Math.Pow(number1, 1.0 / number2);
                    }
                    throw new Exception("invalid operation");
                default:
                throw new ArgumentOutOfRangeException(nameof(actions), "Out of range");

            }
        }
        /// <summary>
        /// Parser for one line 
        /// </summary>
        /// <param name="input">
        /// parsed input
        /// </param>
        public static (double, string, double) Parse(string input)
        {
            string[] part = input.Split(' ');

            double number1 = Convert.ToDouble(part[0]);

            string action = part[1];

            double number2 = Convert.ToDouble(part[2]);

            return (number1, action, number2);
        }
    }
}
