using System;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a superhero team or organization.
    /// </summary>
    public class Team
    {
        /// <summary>
        /// Primary key identifier for the team.
        /// </summary>
        public int TeamID { get; set; }

        /// <summary>
        /// The team's display name.
        /// </summary>
        public string TeamName { get; set; } = null!;

        /// <summary>
        /// The base of operations or headquarters for the team.
        /// </summary>
        public string BaseOfOperations { get; set; } = null!;

        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() =>
            $"TeamID={TeamID}, TeamName={TeamName}, BaseOfOperations={BaseOfOperations}";
    }
}
