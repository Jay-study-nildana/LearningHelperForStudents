using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Sample villain-team memberships.
    /// </summary>
    public static class VillainTeamMembershipSeed
    {
        /// <summary>
        /// Default villain-team membership records used for examples and tests.
        /// </summary>
        public static readonly List<VillainTeamMembership> List = new()
        {
            new VillainTeamMembership { VillainID = 1, VillainTeamID = 1 }, // Lex -> Legion of Doom
            new VillainTeamMembership { VillainID = 3, VillainTeamID = 1 }, // Darkseid -> Legion of Doom
            new VillainTeamMembership { VillainID = 2, VillainTeamID = 2 }  // Joker -> Secret Society
                , new VillainTeamMembership { VillainID = 4, VillainTeamID = 2 } // Reverse-Flash -> Secret Society
                , new VillainTeamMembership { VillainID = 5, VillainTeamID = 2 } // Sinestro -> Secret Society
                , new VillainTeamMembership { VillainID = 6, VillainTeamID = 2 } // Deathstroke -> Secret Society
                , new VillainTeamMembership { VillainID = 7, VillainTeamID = 2 } // Black Manta -> Secret Society
                , new VillainTeamMembership { VillainID = 8, VillainTeamID = 2 } // Brainiac -> Secret Society
                , new VillainTeamMembership { VillainID = 9, VillainTeamID = 2 } // Cheetah -> Secret Society
                , new VillainTeamMembership { VillainID = 10, VillainTeamID = 2 } // Captain Cold -> Secret Society
        };
    }
}
