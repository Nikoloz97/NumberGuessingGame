using GuessNumberGame;
namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AssignDifficultyTest()
        {
            //Arrange
            Game game = new Game();

            //Act
            game.ChooseDifficulty(1);

            //Assert

            Assert.True(game.Difficulty == 1);
        }
    }
}