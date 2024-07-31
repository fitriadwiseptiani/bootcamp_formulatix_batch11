namespace MonopolyGame;

public interface IBoard
{
    public int NumberOfSquare {get;}
	public ISquare[,] SquareBoard { get; } 
}
