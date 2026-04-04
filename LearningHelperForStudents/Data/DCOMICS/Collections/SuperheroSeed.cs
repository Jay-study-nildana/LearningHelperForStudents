using System;
using System.Collections.Generic;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// DC Comics sample superheroes.
    /// </summary>
    public static class SuperheroSeed
    {
        /// <summary>
        /// Default list of DC superheroes used for examples and tests.
        /// </summary>
        public static readonly List<Superhero> List = new()
        {
            new Superhero { SuperheroID = 1, Name = "Superman", Alias = "Clark Kent", FirstAppearance = new DateTime(1938, 6, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 2, Name = "Batman", Alias = "Bruce Wayne", FirstAppearance = new DateTime(1939, 5, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 3, Name = "Wonder Woman", Alias = "Diana Prince", FirstAppearance = new DateTime(1941, 12, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 4, Name = "The Flash", Alias = "Barry Allen", FirstAppearance = new DateTime(1956, 10, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 5, Name = "Green Lantern", Alias = "Hal Jordan", FirstAppearance = new DateTime(1959, 10, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 6, Name = "Cyborg", Alias = "Victor Stone", FirstAppearance = new DateTime(1980, 10, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 7, Name = "Green Arrow", Alias = "Oliver Queen", FirstAppearance = new DateTime(1941, 11, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 8, Name = "Martian Manhunter", Alias = "J'onn J'onzz", FirstAppearance = new DateTime(1955, 11, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 9, Name = "Aquaman", Alias = "Arthur Curry", FirstAppearance = new DateTime(1941, 11, 1), Publisher = "DC Comics" },
            new Superhero { SuperheroID = 10, Name = "Shazam", Alias = "Billy Batson", FirstAppearance = new DateTime(1940, 2, 1), Publisher = "DC Comics" }
        };
    }
}
