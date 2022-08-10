using Problems.Array;

namespace Problems.Test.Array;

public class CoinChangeTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 5 }, 11, 3)]
    [InlineData(new[] { 2 }, 3, -1)]
    [InlineData(new[] { 1 }, 0, 0)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] coins, int amount, int answer)
    {
        //Arrange
        var solution = new CoinChange();

        //Act
        var response = solution.Solution(coins, amount);

        //Assert
        Assert.Equal(answer, response);
    }
}
