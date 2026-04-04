using System;
using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// DC Comics sample villains.
    /// </summary>
    public static class VillainSeed
    {
        /// <summary>
        /// Default list of DC villains used for examples and tests.
        /// </summary>
        public static readonly List<Villain> List = new()
        {
            new Villain { VillainID = 1, Name = "Lex Luthor", Alias = "Lex", FirstAppearance = new DateTime(1940, 4, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 2, Name = "The Joker", Alias = "Joker", FirstAppearance = new DateTime(1940, 4, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 3, Name = "Darkseid", Alias = "Darkseid", FirstAppearance = new DateTime(1970, 11, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 4, Name = "Reverse-Flash", Alias = "Eobard Thawne", FirstAppearance = new DateTime(1963, 6, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 5, Name = "Sinestro", Alias = "Sinestro", FirstAppearance = new DateTime(1961, 9, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 6, Name = "Deathstroke", Alias = "Slade Wilson", FirstAppearance = new DateTime(1980, 5, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 7, Name = "Black Manta", Alias = "Black Manta", FirstAppearance = new DateTime(1967, 9, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 8, Name = "Brainiac", Alias = "Brainiac", FirstAppearance = new DateTime(1958, 7, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 9, Name = "Cheetah", Alias = "Barbara Ann Minerva", FirstAppearance = new DateTime(1943, 10, 1), Publisher = "DC Comics" },
            new Villain { VillainID = 10, Name = "Captain Cold", Alias = "Leonard Snart", FirstAppearance = new DateTime(1959, 4, 1), Publisher = "DC Comics" }
        };
    }
}
