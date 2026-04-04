using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// DC Comics sample villain teams.
    /// </summary>
    public static class VillainTeamSeed
    {
        /// <summary>
        /// Default list of villain teams used for examples and tests.
        /// </summary>
        public static readonly List<VillainTeam> List = new()
        {
            new VillainTeam { VillainTeamID = 1, TeamName = "Legion of Doom", BaseOfOperations = "Pyramid Fortress" },
            new VillainTeam { VillainTeamID = 2, TeamName = "Secret Society of Super Villains", BaseOfOperations = "Unknown" }
        };
    }
}
