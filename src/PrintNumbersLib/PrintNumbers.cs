namespace PrintNumbersLib
{
    public static class PrintNumbers
    {
        internal static readonly IReadOnlyDictionary<int, string> DefaultRules = new Dictionary<int, string>()
        {
            { 3, "Ryan" },
            { 5, "Riley" },
        };

        /// <summary>
        /// Returns an enumerable sequence of formatted values from 1 to <paramref name="upperBound" />.
        /// </summary>
        /// <param name="upperBound">The number to which to enumerate values. (Defaults to 100)</param>
        /// <param name="rules">The ordered formatting rules to apply.</param>
        /// <returns>The enumerable sequence of formatted values.</returns>
        public static IEnumerable<string> FormatSequence(int upperBound = 100, IReadOnlyDictionary<int, string>? rules = null) =>
            Enumerable
                .Range(1, upperBound)
                .Select(num => Format(num, rules ?? DefaultRules));

        /// <summary>
        /// Formats an individual integer value into a string representation.
        /// The formatted value corresponds to the first name for which the
        /// number is evenly divisible by paired divisor.
        /// </summary>
        /// <param name="number">The number to format.</param>
        /// <param name="rules">The ordered formatting rules to apply.</param>
        /// <returns>The formatted number.</returns>
        internal static string Format(int number, IReadOnlyDictionary<int, string> rules)
        {
            var result = "";
            foreach (var (divisor, name) in rules)
            {
                if (number % divisor == 0)
                {
                    result += name ?? "";
                }
            }

            return result.Length > 0 ? result : number.ToString();
        }
    }
}

