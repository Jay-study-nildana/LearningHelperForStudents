namespace Jay.LearningHelperForStudents.Interfaces
{
    /// <summary>
    /// Provides functionality to display a list of words with an optional join string.
    /// </summary>
    public interface IDisplayWordsListWithJoin
    {
        /// <summary>
        /// Displays the list of words as a single string, with an optional join string between each word.
        /// </summary>
        /// <param name="words">The list of words to display.</param>
        /// <param name="joinString">The string to insert between each word. If null or empty, words will be concatenated without any separator.</param>
        /// <returns>A single string representing the joined list of words.</returns>
        string DisplayWordsList(IList<string> words, string? joinString = " ");
    }
}