namespace Jay.LearningHelperForStudents.Interfaces
{    /// <summary>
    /// Provides functionality to get string input from the user.
    /// </summary>
    public interface IGiveMeStringInput
    {
        /// <summary>
        /// Prompts the user for input and returns the entered string.
        /// </summary>
        /// <param name="prompt">The message to display to the user when asking for input.</param>
        /// <returns>The string input provided by the user.</returns>
        string GetStringInput(string? prompt = "Enter the expected string input: ");
    }
}