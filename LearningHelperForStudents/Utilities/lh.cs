using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Data;

namespace Jay.LearningHelperForStudents.Utilities
{
    /// <summary>
    /// A utility class that provides helper methods for learning and educational purposes,
    /// including word generation, user input, and console display functionality.
    /// this is the entry point for each and every utility class in this project. It implements multiple interfaces to provide a wide range of functionalities.
    /// </summary>
    public class Lh : IAddSimpleConsoleDividerDash, IDisplayListOfStrings,IDisplayWordsListWithJoin,IGiveMeStringInput,IRandomRepeatedWordsGenerator
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

        /// <summary>
        /// Prompts the user for input and returns the entered string.
        /// </summary>
        /// <param name="prompt">The message to display to the user when asking for input.</param>
        /// <returns>The string input provided by the user.</returns>
        public string GetStringInput(string? prompt = "Enter the expected string input: ")
        {
            if (!string.IsNullOrEmpty(prompt))
            {
                Console.Write(prompt);
            }

            var input = Console.ReadLine() ?? string.Empty;

            return input;
        }

        /// <summary>
        /// Displays the list of words as a single string, with an optional join string between each word.
        /// </summary>
        /// <param name="words">The list of words to display.</param>
        /// <param name="joinString">The string to insert between each word. If null or empty, words will be concatenated without any separator.</param>
        /// <returns>A single string representing the joined list of words.</returns>
        public string DisplayWordsList(IList<string> words, string? joinString = " ")
        {
            if (words == null)
                throw new ArgumentNullException(nameof(words), "Words list cannot be null.");

            // If joinString is null or empty, concatenate without any separator
            if (string.IsNullOrEmpty(joinString))
                return string.Concat(words);

            var joinedstring = string.Join(joinString, words);

            Console.WriteLine(joinedstring);
            
            return joinedstring;
        }

        /// <summary>
        /// Displays a list of strings to the console.
        /// </summary>
        /// <param name="strings">The list of strings to display.</param>
        /// <param name="prefix">An optional prefix to display before the list.</param>
        /// <exception cref="ArgumentNullException">Thrown when strings is null.</exception>
        public void DisplayListOfStringsNow(IList<string> strings, string? prefix = null)
        {
            if (strings == null) throw new ArgumentNullException(nameof(strings));
            if (!string.IsNullOrEmpty(prefix))
            {
                Console.WriteLine(prefix);
            }   

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }           

        /// <summary>
        /// Adds a simple console divider consisting of dashes.
        /// </summary>
        /// <param name="length">The length of the divider in characters. Default is 50.</param>
        public void AddSimpleConsoleDivider(int? length = 10)
        {
            int dividerLength = length ?? 10;
            Console.WriteLine(new string('-', dividerLength));
        }     

    }
}