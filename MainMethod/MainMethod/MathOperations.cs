namespace MainMethod
{
    internal class MathOperations
    {
        public int Calculate(int number)
        {
            // Addition operation
            return number + 10;
        }
        public int Calculate(decimal number)
        {
            // Subtraction operation
            return (int)(number - 5);
        }
        public int Calculate(string numberString)
        {
            // Conversion and multiplication operation
            if (int.TryParse(numberString, out int number))
            {
                return number * 2;
            }
            else
            {
                throw new ArgumentException("Input string is not a valid integer.");
            }
        }
    }
}