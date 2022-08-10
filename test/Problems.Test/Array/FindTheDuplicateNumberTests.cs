using Problems.Array;

namespace Problems.Test.Array;

public class FindTheDuplicateNumberTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 4, 2, 2 }, 2)]
    [InlineData(new[] { 3, 1, 3, 4, 2 }, 3)]
    public void Solution_ValidInput_MustReturnCorrectAnswer(int[] nums, int answer)
    {
        //Arrange
        var solution = new FindTheDuplicateNumber();

        //Act
        var response = solution.Solution(nums);

        //Assert
        Assert.Equal(answer, response);
    }
}
