using System;

namespace Jay.LearningHelperForStudents.Data.DCOMICS.Types
{
    /// <summary>
    /// Represents a comic-book villain.
    /// </summary>
    public class Villain
    {
        /// <summary>
        /// Primary key identifier for the villain.
        /// </summary>
        public int VillainID { get; set; }

        /// <summary>
        /// The public name of the villain.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// The alter ego or alias of the villain.
        /// </summary>
        public string Alias { get; set; } = null!;

        /// <summary>
        /// Date of the character's first appearance.
        /// </summary>
        public DateTime FirstAppearance { get; set; }

        /// <summary>
        /// Publishing company or imprint for the villain.
        /// </summary>
        public string Publisher { get; set; } = null!;

        /// <summary>
        /// Returns a string representation containing all properties.
        /// </summary>
        public override string ToString() =>
            $"VillainID={VillainID}, Name={Name}, Alias={Alias}, FirstAppearance={FirstAppearance:yyyy-MM-dd}, Publisher={Publisher}";
    }
}
