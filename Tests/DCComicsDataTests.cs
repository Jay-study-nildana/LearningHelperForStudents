

using Jay.LearningHelperForStudents.Interfaces;
using Jay.LearningHelperForStudents.Utilities;

namespace Jay.LearningHelperForStudents.Tests
{
    public class DCComicsDataTests
    {
        // Note: Testing data retrieval methods is often not necessary if they are simple getters.
        // However, we can implement a basic test to ensure that the data is returned as expected.

        [Fact]
        public void GetSuperheroes_ReturnsExpectedData()
        {
            // Arrange
            IGetDCComicsData dataProvider = new Lhdc();

            // Act
            var superheroes = dataProvider.GetSuperheroes();

            // Assert
            Assert.NotNull(superheroes);
            Assert.NotEmpty(superheroes);
            Assert.Contains(superheroes, s => s.SuperheroID == 1 && s.Name == "Superman");
        }

        [Fact]
        public void GetTeams_ReturnsExpectedData()
        {
            // Arrange
            IGetDCComicsData dataProvider = new Lhdc();

            // Act
            var teams = dataProvider.GetTeams();

            // Assert
            Assert.NotNull(teams);
            Assert.NotEmpty(teams);
            Assert.Contains(teams, t => t.TeamID == 1 && t.TeamName == "Justice League");
        }

        [Fact]
        public void GetVillains_ReturnsExpectedData()
        {
            // Arrange
            IGetDCComicsData dataProvider = new Lhdc();

            // Act
            var villains = dataProvider.GetVillains();

            // Assert
            Assert.NotNull(villains);
            Assert.NotEmpty(villains);
            Assert.Contains(villains, v => v.VillainID == 1 && v.Name == "Lex Luthor");
        }
    }
}