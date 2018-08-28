using System;

namespace ChessEngine
{
    public class Pawn : ChessPiece
    {
        public Pawn(ChessColor pieceColor)
        {
            this.Color = pieceColor;
        }

        public override int IndividualValue { get { return 1; } }
    }
}

