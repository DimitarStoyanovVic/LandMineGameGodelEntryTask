using ApplicationSystem.Interfaces;

namespace ApplicationSystem.Models.BoardGames.Landmine;

public class LandmineGame : IApplicationLauncher
{
    public void LaunchApplication()
    {
        Console.Write("Please insert a positive integer number for the square board: ");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Thank you!");

        BoardGameBuilder builder = new (new CreateSquareBoard());
        char[][] field = builder.Build(size);
        Console.WriteLine("Board created!");
        
        field = builder.PutSymbol(field, 0, 0, '*');
        field = PutMines(builder, field);

        Console.WriteLine("TODO play game!");
        // TODO move player and print result.
    }

    private char[][] PutMines(BoardGameBuilder builder, char[][] field)
    {
        // TODO
        return field;
    }
}