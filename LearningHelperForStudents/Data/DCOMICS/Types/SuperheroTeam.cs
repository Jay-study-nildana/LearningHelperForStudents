namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a membership linking a superhero to a team.
    /// </summary>
    public class SuperheroTeam
    {
        /// <summary>
        /// Foreign key referencing the superhero.
        /// </summary>
        public int SuperheroID { get; set; }

        /// <summary>
        /// Foreign key referencing the team.
        /// </summary>
        public int TeamID { get; set; }

        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() => $"SuperheroID={SuperheroID}, TeamID={TeamID}";
    }
}
