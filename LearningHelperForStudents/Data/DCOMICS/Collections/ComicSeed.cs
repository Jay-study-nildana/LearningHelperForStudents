using System;
using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// DC Comics sample comic issues.
    /// </summary>
    public static class ComicSeed
    {
        /// <summary>
        /// Default list of DC comic issues used for examples and tests.
        /// </summary>
        public static readonly List<Comic> List = new()
        {
            // Superman vs Villains
            new Comic { ComicID = 1, Title = "Superman vs Lex Luthor", IssueNumber = 1, ReleaseDate = new DateTime(1940,4,1), SuperheroID = 1, VillainID = 1 },
            new Comic { ComicID = 2, Title = "Superman and The Joker", IssueNumber = 2, ReleaseDate = new DateTime(1941,5,1), SuperheroID = 1, VillainID = 2 },
            new Comic { ComicID = 3, Title = "Superman: Darkseid Rising", IssueNumber = 3, ReleaseDate = new DateTime(1971,6,1), SuperheroID = 1, VillainID = 3 },
            new Comic { ComicID = 4, Title = "Superman: Speed Nemesis", IssueNumber = 4, ReleaseDate = new DateTime(1964,7,1), SuperheroID = 1, VillainID = 4 },
            new Comic { ComicID = 5, Title = "Superman: Fear of Sinestro", IssueNumber = 5, ReleaseDate = new DateTime(1962,8,1), SuperheroID = 1, VillainID = 5 },

            // Batman vs Villains
            new Comic { ComicID = 6, Title = "Batman: Luthor's Plot", IssueNumber = 10, ReleaseDate = new DateTime(1945,3,1), SuperheroID = 2, VillainID = 1 },
            new Comic { ComicID = 7, Title = "Batman: The Joker's Game", IssueNumber = 11, ReleaseDate = new DateTime(1946,4,1), SuperheroID = 2, VillainID = 2 },
            new Comic { ComicID = 8, Title = "Batman: Darkseid's Shadow", IssueNumber = 12, ReleaseDate = new DateTime(1972,5,1), SuperheroID = 2, VillainID = 3 },
            new Comic { ComicID = 9, Title = "Batman & Reverse-Flash", IssueNumber = 13, ReleaseDate = new DateTime(1965,6,1), SuperheroID = 2, VillainID = 4 },
            new Comic { ComicID = 10, Title = "Batman: Sinestro's Fear", IssueNumber = 14, ReleaseDate = new DateTime(1962,9,1), SuperheroID = 2, VillainID = 5 },

            // Wonder Woman vs Villains
            new Comic { ComicID = 11, Title = "Wonder Woman vs Lex Luthor", IssueNumber = 20, ReleaseDate = new DateTime(1942,1,1), SuperheroID = 3, VillainID = 1 },
            new Comic { ComicID = 12, Title = "Wonder Woman: Joker's Trick", IssueNumber = 21, ReleaseDate = new DateTime(1943,2,1), SuperheroID = 3, VillainID = 2 },
            new Comic { ComicID = 13, Title = "Wonder Woman: Darkseid's Wrath", IssueNumber = 22, ReleaseDate = new DateTime(1973,3,1), SuperheroID = 3, VillainID = 3 },
            new Comic { ComicID = 14, Title = "Wonder Woman and Reverse-Flash", IssueNumber = 23, ReleaseDate = new DateTime(1966,4,1), SuperheroID = 3, VillainID = 4 },
            new Comic { ComicID = 15, Title = "Wonder Woman: Sinestro's Ring", IssueNumber = 24, ReleaseDate = new DateTime(1962,10,1), SuperheroID = 3, VillainID = 5 },

            // The Flash vs Villains
            new Comic { ComicID = 16, Title = "Flash vs Lex Luthor", IssueNumber = 30, ReleaseDate = new DateTime(1944,5,1), SuperheroID = 4, VillainID = 1 },
            new Comic { ComicID = 17, Title = "Flash: Joker Chase", IssueNumber = 31, ReleaseDate = new DateTime(1945,6,1), SuperheroID = 4, VillainID = 2 },
            new Comic { ComicID = 18, Title = "Flash: Darkseid Speed", IssueNumber = 32, ReleaseDate = new DateTime(1974,7,1), SuperheroID = 4, VillainID = 3 },
            new Comic { ComicID = 19, Title = "Flash: Reverse-Flash Returns", IssueNumber = 33, ReleaseDate = new DateTime(1967,8,1), SuperheroID = 4, VillainID = 4 },
            new Comic { ComicID = 20, Title = "Flash: Sinestro Encounter", IssueNumber = 34, ReleaseDate = new DateTime(1963,9,1), SuperheroID = 4, VillainID = 5 },

            // Green Lantern vs Villains
            new Comic { ComicID = 21, Title = "Green Lantern vs Lex Luthor", IssueNumber = 40, ReleaseDate = new DateTime(1946,9,1), SuperheroID = 5, VillainID = 1 },
            new Comic { ComicID = 22, Title = "Green Lantern: Joker Field", IssueNumber = 41, ReleaseDate = new DateTime(1947,10,1), SuperheroID = 5, VillainID = 2 },
            new Comic { ComicID = 23, Title = "Green Lantern: Darkseid War", IssueNumber = 42, ReleaseDate = new DateTime(1975,11,1), SuperheroID = 5, VillainID = 3 },
            new Comic { ComicID = 24, Title = "Green Lantern: Reverse Threat", IssueNumber = 43, ReleaseDate = new DateTime(1968,12,1), SuperheroID = 5, VillainID = 4 },
            new Comic { ComicID = 25, Title = "Green Lantern: Sinestro's Return", IssueNumber = 44, ReleaseDate = new DateTime(1964,1,1), SuperheroID = 5, VillainID = 5 }
        };
    }
}
