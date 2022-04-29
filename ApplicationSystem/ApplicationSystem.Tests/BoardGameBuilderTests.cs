using ApplicationSystem.Models.BoardGames;
using Xunit;

namespace ApplicationSystem.Tests;

public class BoardGameBuilderTests
{
    [Fact]
    public void BoardGameBuilder_Build_Returns_Correct_Result()
    {
        // Arrange
        BoardGameBuilder builder = new (new CreateSquareBoard());
        
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
        char[][] actualBoard = builder.Build(2);

        // Assert
        Assert.Equal(expectedBoard, actualBoard);
    }

    [Fact]
    public void BoardGameBuilder_PutSymbol_Retuns_Correct_Result()
    {
        // Arrange
        BoardGameBuilder builder = new (new CreateSquareBoard());
        char[][] expectedBoard = builder.Build(2);
        expectedBoard[0][0] = '*';
        
        // Act
        var actualBoard = builder.PutSymbol(expectedBoard, 0, 0, '*');

        // Assert 
        Assert.Equal(expectedBoard, actualBoard);
    }
}