namespace Jay.LearningHelperForStudents.Interfaces
{
    /// <summary>
    /// Provides functionality to add a simple console divider using dashes.
    /// </summary>
    public interface IAddSimpleConsoleDividerDash
    {
        /// <summary>
        /// Adds a simple console divider consisting of dashes.
        /// </summary>
        /// <param name="length">The length of the divider in characters. Default is 50.</param>
        void AddSimpleConsoleDivider(int? length = 10);
    }
}