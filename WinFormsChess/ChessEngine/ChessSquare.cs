namespace ChessEngine
{
    public class ChessSquare
    {
        public ChessSquare(string algebraicNotation, ChessColor color)
        {
            AlgebraicNotation = algebraicNotation;
            Color = color;
        }

        public ChessPiece Piece { get; set; }

        public string AlgebraicNotation { get; }
        public ChessColor Color { get; }
    }
}
