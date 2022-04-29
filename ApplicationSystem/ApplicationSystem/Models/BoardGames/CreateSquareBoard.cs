using ApplicationSystem.Interfaces;

namespace ApplicationSystem.Models.BoardGames;

public class CreateSquareBoard : ICreateSquareBoard
{
    public char[][] CreateSquareBoardField(int size)
    {
        char[][] board = new char[size][];
        for (int row = 0; row < board.Length; row++)
        {
            board[row] = new char [board.Length];
            for (int col = 0; col < board[row].Length; col++)
            {
                board[row][col] = '_';
            }
        }

        return board;
    }
}