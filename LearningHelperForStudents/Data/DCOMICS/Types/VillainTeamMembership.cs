namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a membership linking a villain to a villain team.
    /// </summary>
    public class VillainTeamMembership
    {
        /// <summary>
        /// Foreign key referencing the villain.
        /// </summary>
        public int VillainID { get; set; }

        /// <summary>
        /// Foreign key referencing the villain team.
        /// </summary>
        public int VillainTeamID { get; set; }

        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() => $"VillainID={VillainID}, VillainTeamID={VillainTeamID}";
    }
}
