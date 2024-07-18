class Piece {
	public readonly PieceType pieceType;
	public readonly Colour colour;
}

// Contoh untuk catur
enum PieceType {
	Pawn,
	Rook,
	King,
	Queen,
	Bishop,
	Knight
}

// Contoh untuk Othello
enum Colour {
	White,
	Black
}

// dibuat enum karena warna atau piecenya paten tidak berubah

class Program
{
	Piece piece = new();
	Colour check = Colour.Black;
}