using System;

namespace ChessEngine
{
    public class Bishop : ChessPiece
    {
        public Bishop(ChessColor pieceColor)
        {
            this.Color = pieceColor;
        }
        
        public override int IndividualValue { get { return 3; } }
    }
}

