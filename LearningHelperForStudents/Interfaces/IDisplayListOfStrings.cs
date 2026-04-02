namespace Jay.LearningHelperForStudents.Interfaces
{
    /// <summary>
    /// Defines a contract for displaying a list of strings to the console.
    /// </summary>
    public interface IDisplayListOfStrings
    {
        /// <summary>
        /// Displays a list of strings to the console, with an optional prefix for each string.
        /// </summary>
        /// <param name="strings">The list of strings to display.</param>
        /// <param name="prefix">An optional prefix to add before each string. If null or empty, no prefix will be added.</param>
        void DisplayListOfStringsNow(IList<string> strings, string? prefix = null);
    }
}