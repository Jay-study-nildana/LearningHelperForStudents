using Jay.LearningHelperForStudents.Interfaces;

namespace Jay.LearningHelperForStudents
{
    /// <summary>
    /// Implementation of <see cref="Interfaces.IRandomRepeatedWordsGenerator"/> which
    /// selects words from a provided source and repeats them a random number of times.
    /// </summary>
    public class RandomRepeatedWordsGenerator : IRandomRepeatedWordsGenerator
    {
        /// <summary>
        /// Generate a list of words by selecting <paramref name="n"/> words from
        /// <paramref name="source"/> and repeating each selected word a random
        /// number of times between <paramref name="minRepeat"/> and
        /// <paramref name="maxRepeat"/> (inclusive).
        /// </summary>
        /// <param name="source">The collection of source words to select from. Optional. </param>
        /// <param name="n">The number of distinct words to select (unless <paramref name="allowSelectionDuplicates"/> is true).</param>
        /// <param name="minRepeat">Minimum inclusive repeat count for each selected word.</param>
        /// <param name="maxRepeat">Maximum inclusive repeat count for each selected word.</param>
        /// <param name="rng">Optional random number generator. If null, a new instance will be created.</param>
        /// <param name="allowSelectionDuplicates">If true, the same source word may be selected multiple times.</param>
        /// <param name="shuffleResult">If true, the resulting list will be shuffled before returning.</param>
        /// <returns>A list of words with repetitions as specified.</returns>
        /// <exception cref="ArgumentException">Thrown when arguments are invalid (see parameter constraints).</exception>
        public List<string> GenerateRandomRepeatedWords(
            IList<string>? source,
            int n,
            int minRepeat,
            int maxRepeat,
            Random? rng = null,
            bool allowSelectionDuplicates = false,
            bool shuffleResult = true)
        {
            rng ??= new Random();

            source ??= Data.SourceWords.List; // Use the default source if none provided

            if (source == null || source.Count == 0)
                throw new ArgumentException("Source must contain at least one word.", nameof(source));
            if (n <= 0)
                throw new ArgumentException("n must be > 0", nameof(n));
            if (minRepeat < 1)
                throw new ArgumentException("minRepeat must be >= 1", nameof(minRepeat));
            if (maxRepeat < minRepeat)
                throw new ArgumentException("maxRepeat must be >= minRepeat", nameof(maxRepeat));
            if (!allowSelectionDuplicates && n > source.Count)
                throw new ArgumentException("n cannot be greater than source.Count when allowSelectionDuplicates is false.", nameof(n));

            var selectedwords = new List<string>(n);

            if (allowSelectionDuplicates)
            {
                for (int i = 0; i < n; i++)
                {
                    selectedwords.Add(source[rng.Next(source.Count)]);
                }
            }
            else
            {
                var indices = Enumerable.Range(0, source.Count).ToArray();
                for (int i = indices.Length - 1; i > 0; i--)
                {
                    int j = rng.Next(i + 1);
                    (indices[i], indices[j]) = (indices[j], indices[i]);
                }

                for (int i = 0; i < n; i++)
                    selectedwords.Add(source[indices[i]]);
            }

            var outputlistofwords = new List<string>();
            foreach (var word in selectedwords)
            {
                int repeat = rng.Next(minRepeat, maxRepeat + 1);
                for (int r = 0; r < repeat; r++)
                    outputlistofwords.Add(word);
            }

            if (shuffleResult)
            {
                for (int i = outputlistofwords.Count - 1; i > 0; i--)
                {
                    int j = rng.Next(i + 1);
                    (outputlistofwords[i], outputlistofwords[j]) = (outputlistofwords[j], outputlistofwords[i]);
                }
            }

            return outputlistofwords;
        }
    }
}
