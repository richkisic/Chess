using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public abstract class ChessPiece
    {
        protected Dictionary<string, string[]> _moveDictionary = new Dictionary<string, string[]>();
        public static ChessPiece CreatePiece(PieceType pieceType, ChessColor pieceColor)
        {
            switch (pieceType)
            {
                case PieceType.Pawn:
                    return new Pawn(pieceColor);
                case PieceType.Rook:
                    return new Rook(pieceColor);
                case PieceType.Knight:
                    return new Knight(pieceColor);
                case PieceType.Bishop:
                    return new Bishop(pieceColor);
                case PieceType.Queen:
                    return new Queen(pieceColor);
                case PieceType.King:
                    return new King(pieceColor);
                default:
                    throw new NotImplementedException("The piece type requested does not exist.");
            }
        }

        public string[] GetAlgebraicNotationMoves(string currentLocationAsAlgebraicNotation)
        {
            if (!ChessBoard.IsAlgebraicNotationValid(currentLocationAsAlgebraicNotation)) throw new Exception("Invalid algebraic notation");
            
            return _moveDictionary[currentLocationAsAlgebraicNotation];
        }

        public bool HasMoved { get; protected set; }
        public abstract int IndividualValue { get; }
        public ChessColor Color { get; protected set; }
    }
}
