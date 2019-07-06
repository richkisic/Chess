using System;

namespace ChessEngine
{
    public class Pawn : ChessPiece
    {
        public Pawn(ChessColor pieceColor)
        {
            this.Color = pieceColor;
            this._moveDictionary = ChessUtilities.GenerateAllNonCaptureNonSpecialAlgebraicNotationMoves(PieceType.Pawn, pieceColor);
        }

        public override int IndividualValue { get { return 1; } }
    }
}

