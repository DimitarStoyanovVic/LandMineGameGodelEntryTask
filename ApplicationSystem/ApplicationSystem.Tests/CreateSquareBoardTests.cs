using ApplicationSystem.Models.BoardGames;
using Xunit;

namespace ApplicationSystem.Tests;

public class CreateSquareBoardTests
{
    [Fact]
    public void CreateSquareBoardField_Creates_Correct_BoardField()
    {
        // Arrange
        var board = new CreateSquareBoard();
        
        char[][] expectedBoard = new char[2][];
        for (int row = 0; row < 2; row++)
        {
            expectedBoard[row] = new char [expectedBoard.Length];
            for (int col = 0; col < expectedBoard[row].Length; col++)
            {
                expectedBoard[row][col] = '_';
            }
        }
        
        // Act
        char[][] actualBoard = board.CreateSquareBoardField(2);

        // Assert
        Assert.Equal(expectedBoard, actualBoard);
    }
}