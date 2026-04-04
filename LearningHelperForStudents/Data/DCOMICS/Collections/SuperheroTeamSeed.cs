using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Sample superhero-team memberships.
    /// </summary>
    public static class SuperheroTeamSeed
    {
        /// <summary>
        /// Default superhero-team membership records used for examples and tests.
        /// </summary>
        public static readonly List<SuperheroTeam> List = new()
        {
            new SuperheroTeam { SuperheroID = 1, TeamID = 1 }, // Superman -> Justice League
            new SuperheroTeam { SuperheroID = 2, TeamID = 1 }, // Batman -> Justice League
            new SuperheroTeam { SuperheroID = 3, TeamID = 1 }, // Wonder Woman -> Justice League
            new SuperheroTeam { SuperheroID = 4, TeamID = 1 }, // Flash -> Justice League
            new SuperheroTeam { SuperheroID = 5, TeamID = 1 }  // Green Lantern -> Justice League

            //add some items to the Teen Titans team
             , new SuperheroTeam { SuperheroID = 4, TeamID = 2 } // Flash -> Teen Titans
             , new SuperheroTeam { SuperheroID = 5, TeamID = 2 } // Green Lantern -> Teen Titans
             , new SuperheroTeam { SuperheroID = 3, TeamID = 2 } // Wonder
        };
    }
}
