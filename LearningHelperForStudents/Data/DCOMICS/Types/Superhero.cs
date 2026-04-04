using System;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a comic-book superhero.
    /// </summary>
    public class Superhero
    {
        /// <summary>
        /// Primary key identifier for the superhero.
        /// </summary>
        public int SuperheroID { get; set; }

        /// <summary>
        /// The public name of the superhero.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// The alter ego or alias of the superhero.
        /// </summary>
        public string Alias { get; set; } = null!;

        /// <summary>
        /// Date of the character's first appearance.
        /// </summary>
        public DateTime FirstAppearance { get; set; }

        /// <summary>
        /// Publishing company or imprint for the superhero.
        /// </summary>
        public string Publisher { get; set; } = null!;
        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() =>
            $"SuperheroID={SuperheroID}, Name={Name}, Alias={Alias}, FirstAppearance={FirstAppearance:yyyy-MM-dd}, Publisher={Publisher}";
    }
}
