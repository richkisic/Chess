using System;

namespace ChessEngine
{
    public class Queen : ChessPiece
    {
        public Queen(ChessColor pieceColor)
        {
            this.Color = pieceColor;
        }
       
        public override int IndividualValue { get { return 9; } }
    }
}

