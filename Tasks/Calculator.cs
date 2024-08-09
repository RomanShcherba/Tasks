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
        /// <param name="a">
        /// First number
        /// </param>
        /// <param name="b">
        /// Second number
        /// </param>
        /// <param name="actions">
        /// Math operators
        /// </param>
        /// <exception cref="DivideByZeroException">
        /// Divide by zero exception
        /// </exception>
        /// <exception cref="Exception">
        /// Exception of zero numbers of roots
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Argument out of range exception
        /// </exception>
        public static double Calculate(double a, double b, string actions)
        {
            switch (actions)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        throw new DivideByZeroException("You can't divide by zero");
                    }
                    return a / b;
                case "^":
                    return Math.Pow(a, b);
                case "V":
                    if (a > 0 || b > 0)
                    {
                        return Math.Pow(a, 1.0 / b);
                    }
                    throw new Exception("invalid operation");
                default:
                throw new ArgumentOutOfRangeException(nameof(actions), "Out of range");

            }
        }
    }
}
