using System;

namespace ChessEngine
{
    public class Rook : ChessPiece
    {
        public Rook(ChessColor pieceColor)
        {
            this.Color = pieceColor;
        }

        public override int IndividualValue { get { return 5; } }
    }
}
