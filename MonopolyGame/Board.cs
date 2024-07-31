namespace MonopolyGame;

public class Board : IBoard
{
    public int NumberOfSquare {get; private set;}
	public ISquare[,] SquareBoard { get; private set;}

    public Board(int numberOfSquare, int maxFields = 40){
        NumberOfSquare = numberOfSquare;
        SquareBoard = new List<ISquare>(max);
    }
}
