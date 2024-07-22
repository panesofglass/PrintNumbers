namespace PrintNumbersLib
{
    public static class PrintNumbers
    {
        /// <summary>
        /// Returns an enumerable sequence of formatted values from 1 to <paramref name="upperBound" />.
        /// </summary>
        /// <param name="upperBound">The number to which to enumerate values. (Defaults to 100)</param>
        /// <returns>The enumerable sequence of formatted values.</returns>
        public static IEnumerable<string> FormatSequence(int upperBound = 100) =>
            Enumerable.Range(1, upperBound).Select(Format);

        /// <summary>
        /// Formats an individual integer value into a string representation.
        /// </summary>
        /// <param name="number">The number to format.</param>
        /// <returns>The formatted number.</returns>
        internal static string Format(int number) =>
            (number % 3, number % 5) switch
            {
                (0, 0) => "RyanRiley",
                (0, _) => "Ryan",
                (_, 0) => "Riley",
                _ => number.ToString(),
            };
    }
}

