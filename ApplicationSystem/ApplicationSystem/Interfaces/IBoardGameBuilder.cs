namespace ApplicationSystem.Interfaces;

public interface IBoardGameBuilder
{
    public char[][] Build(int size);

    public char[][] PutSymbol(char[][] board, int startingRow, int startingCol, char symbol);
}