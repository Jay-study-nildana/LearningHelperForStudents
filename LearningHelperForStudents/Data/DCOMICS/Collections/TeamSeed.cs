using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// DC Comics sample teams.
    /// </summary>
    public static class TeamSeed
    {
        /// <summary>
        /// Default list of DC teams used for examples and tests.
        /// </summary>
        public static readonly List<Team> List = new()
        {
            new Team { TeamID = 1, TeamName = "Justice League", BaseOfOperations = "Hall of Justice" },
            new Team { TeamID = 2, TeamName = "Teen Titans", BaseOfOperations = "Titans Tower" }
        };
    }
}
