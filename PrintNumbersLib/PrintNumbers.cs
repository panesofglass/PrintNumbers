namespace PrintNumbersLib
{
    public class PrintNumbers
    {
        public static IEnumerable<string> All(int upperBound = 100)
        {
            return Enumerable.Range(1, upperBound).Select(num => Format(num));
        }

        public static string Format(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "RyanRiley";
            }
            else if (number % 3 == 0)
            {
                return "Ryan";
            }
            else if (number % 5 == 0)
            {
                return "Riley";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
