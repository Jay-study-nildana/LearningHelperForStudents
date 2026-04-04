using System;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a villains' organization or team.
    /// </summary>
    public class VillainTeam
    {
        /// <summary>
        /// Primary key identifier for the villain team.
        /// </summary>
        public int VillainTeamID { get; set; }

        /// <summary>
        /// The villain team's display name.
        /// </summary>
        public string TeamName { get; set; } = null!;

        /// <summary>
        /// The base of operations for the villain team.
        /// </summary>
        public string BaseOfOperations { get; set; } = null!;

        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() =>
            $"VillainTeamID={VillainTeamID}, TeamName={TeamName}, BaseOfOperations={BaseOfOperations}";
    }
}
