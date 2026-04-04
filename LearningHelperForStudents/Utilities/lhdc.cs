using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Data.DCOMICS.Types;

namespace Jay.LearningHelperForStudents.Utilities
{
    /// <summary>
    /// Lightweight provider that exposes DC Comics sample data via the
    /// <see cref="IGetDCComicsData"/> interface.
    /// </summary>
    public class Lhdc : IGetDCComicsData
    {
        /// <summary>
        /// Returns the sample list of DC superheroes.
        /// </summary>
        public IList<Superhero> GetSuperheroes() => SuperheroSeed.List;

        /// <summary>
        /// Returns the sample list of DC villains.
        /// </summary>
        public IList<Villain> GetVillains() => VillainSeed.List;

        /// <summary>
        /// Returns the sample list of teams (e.g., Justice League).
        /// </summary>
        public IList<Team> GetTeams() => TeamSeed.List;

        /// <summary>
        /// Returns the sample list of villain teams (e.g., Legion of Doom).
        /// </summary>
        public IList<VillainTeam> GetVillainTeams() => VillainTeamSeed.List;

        /// <summary>
        /// Returns superhero-to-team membership records.
        /// </summary>
        public IList<SuperheroTeam> GetSuperheroTeams() => SuperheroTeamSeed.List;

        /// <summary>
        /// Returns villain-to-villain-team membership records.
        /// </summary>
        public IList<VillainTeamMembership> GetVillainTeamMemberships() => VillainTeamMembershipSeed.List;

        /// <summary>
        /// Returns the sample list of comics linking heroes and villains.
        /// </summary>
        public IList<Comic> GetComics() => ComicSeed.List;
    }
}