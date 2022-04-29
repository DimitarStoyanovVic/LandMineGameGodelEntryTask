using ApplicationSystem.Interfaces;

namespace ApplicationSystem.Models.BoardGames;

public class BoardGameBuilder : IBoardGameBuilder
{
    private ICreateSquareBoard createSquareBoard;
    
    public BoardGameBuilder(ICreateSquareBoard createSquareBoard)
    {
        this.createSquareBoard = createSquareBoard;
    }
    
    public char[][] Build(int size)
    {
        return this.createSquareBoard.CreateSquareBoardField(size);
    }

    public char[][] PutSymbol(char[][] board, int startingRow, int startingCol, char symbol)
    {
        board[startingRow][startingCol] = symbol;
        return board;
    }
}