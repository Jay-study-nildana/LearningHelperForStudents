using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay.LearningHelperForStudents.Interfaces
{
    /// <summary>
    /// Provides functionality to generate a list of words where each selected
    /// word may be repeated a random number of times.
    /// </summary>
    public interface IRandomRepeatedWordsGenerator
    {
        /// <summary>
        /// Generate a list of words by selecting <paramref name="n"/> words from
        /// <paramref name="source"/> and repeating each selected word a random
        /// number of times between <paramref name="minRepeat"/> and
        /// <paramref name="maxRepeat"/> (inclusive).
        /// </summary>
        /// <param name="source">The collection of source words to select from.</param>
        /// <param name="n">The number of distinct words to select (unless <paramref name="allowSelectionDuplicates"/> is true).</param>
        /// <param name="minRepeat">Minimum inclusive repeat count for each selected word.</param>
        /// <param name="maxRepeat">Maximum inclusive repeat count for each selected word.</param>
        /// <param name="rng">Optional random number generator. If null, a new instance will be created.</param>
        /// <param name="allowSelectionDuplicates">If true, the same source word may be selected multiple times.</param>
        /// <param name="shuffleResult">If true, the resulting list will be shuffled before returning.</param>
        /// <returns>A list of words with repetitions as specified.</returns>
        /// <exception cref="ArgumentException">Thrown when arguments are invalid (see parameter constraints).</exception>
        List<string> GenerateRandomRepeatedWords(IList<string> source, int n, int minRepeat, int maxRepeat, Random? rng = null, bool allowSelectionDuplicates = false, bool shuffleResult = true);
    }
}
