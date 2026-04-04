using System;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a published comic issue.
    /// </summary>
    public class Comic
    {
        /// <summary>
        /// Primary key identifier for the comic issue.
        /// </summary>
        public int ComicID { get; set; }

        /// <summary>
        /// The title of the comic.
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// The issue number within the comic series.
        /// </summary>
        public int IssueNumber { get; set; }

        /// <summary>
        /// The release date of the comic issue.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Foreign key referencing the primary superhero featured.
        /// </summary>
        public int SuperheroID { get; set; }

        /// <summary>
        /// Foreign key referencing the primary villain featured.
        /// </summary>
        public int VillainID { get; set; }

        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() =>
            $"ComicID={ComicID}, Title={Title}, IssueNumber={IssueNumber}, ReleaseDate={ReleaseDate:yyyy-MM-dd}, SuperheroID={SuperheroID}, VillainID={VillainID}";

    }
}
