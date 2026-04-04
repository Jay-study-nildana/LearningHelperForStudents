using Jay.LearningHelperForStudents.Data.DCOMICS.Types;

namespace Jay.LearningHelperForStudents.Interfaces
{
    /// <summary>
    /// Defines a contract for retrieving DC Comics data.
    /// </summary>
    public interface IGetDCComicsData
    {
        /// <summary>
        /// Retrieves a list of DC superheroes.
        /// </summary>
        /// <returns>A list of superheroes.</returns>
        IList<Superhero> GetSuperheroes();

        /// <summary>
        /// Retrieves a list of DC villains.
        /// </summary>
        /// <returns>A list of villains.</returns>
        IList<Villain> GetVillains();

        /// <summary>
        /// Retrieves a list of DC teams.
        /// </summary>
        /// <returns>A list of teams.</returns>
        IList<Team> GetTeams();

        /// <summary>
        /// Retrieves a list of DC villain teams.
        /// </summary>
        /// <returns>A list of villain teams.</returns>
        IList<VillainTeam> GetVillainTeams();

        /// <summary>
        /// Retrieves a list of superhero-team memberships.
        /// </summary>
        /// <returns>A list of superhero-team memberships.</returns>
        IList<SuperheroTeam> GetSuperheroTeams();

        /// <summary>
        /// Retrieves a list of villain-team memberships.
        /// </summary>
        /// <returns>A list of villain-team memberships.</returns>
        IList<VillainTeamMembership> GetVillainTeamMemberships();

        /// <summary>
        /// Retrieves a list of DC comic issues.
        /// </summary>
        /// <returns>A list of comic issues.</returns>
        IList<Comic> GetComics();
    }
}