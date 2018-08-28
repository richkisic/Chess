using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{

    public class ChessBoard
    {
        private const int INT_MAX_COL_FILE = 8;
        private const int INT_MAX_ROW_RANK = 8;
        private readonly ChessSquare[,] _squares = new ChessSquare[INT_MAX_COL_FILE, INT_MAX_ROW_RANK];

        public ChessBoard()
        {
            for(int fileCol=0; fileCol < INT_MAX_COL_FILE; fileCol++)
            {
                for (int rankRow = 0; rankRow < INT_MAX_ROW_RANK; rankRow++)
                {
                    ChessSquare current = new ChessSquare(String.Format("{0}{1}", Convert.ToChar(((int)'a')+fileCol), 8-rankRow), fileCol % 2 == 0 ? ChessColor.White : ChessColor.Black);
                    _squares[fileCol, rankRow] = current;
                }
            }

            Reset();
        }

        public static bool IsAlgebraicNotationValid(string notation)
        {
            return !(string.IsNullOrEmpty(notation) || notation.Length != 2);
                
        }

        public void Reset()
        {
            for (int fileCol = 0; fileCol < INT_MAX_COL_FILE; fileCol++)
            {
                for (int rankRow = 0; rankRow < INT_MAX_ROW_RANK; rankRow++)
                {
                    ChessSquare current = _squares[fileCol, rankRow];
                    switch (current.AlgebraicNotation) // https://en.wikipedia.org/wiki/Chessboard#Board_notation
                    {
                        // Black Chess Pieces
                        case "a8":
                        case "h8":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Rook, ChessColor.Black);
                            break;
                        case "b8":
                        case "g8":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Knight, ChessColor.Black);
                            break;
                        case "c8":
                        case "f8":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Bishop, ChessColor.Black);
                            break;
                        case "d8":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Queen, ChessColor.Black);
                            break;
                        case "e8":
                            current.Piece = ChessPiece.CreatePiece(PieceType.King, ChessColor.Black);
                            break;
                        case "a7":
                        case "b7":
                        case "c7":
                        case "d7":
                        case "e7":
                        case "f7":
                        case "g7":
                        case "h7":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Pawn, ChessColor.Black);
                            break;
                        // White Chess Pieces
                        case "a1":
                        case "h1":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Rook, ChessColor.White);
                            break;
                        case "b1":
                        case "g1":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Knight, ChessColor.White);
                            break;
                        case "c1":
                        case "f1":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Bishop, ChessColor.White);
                            break;
                        case "d1":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Queen, ChessColor.White);
                            break;
                        case "e1":
                            current.Piece = ChessPiece.CreatePiece(PieceType.King, ChessColor.White);
                            break;
                        case "a2":
                        case "b2":
                        case "c2":
                        case "d2":
                        case "e2":
                        case "f2":
                        case "g2":
                        case "h2":
                            current.Piece = ChessPiece.CreatePiece(PieceType.Pawn, ChessColor.White);
                            break;
                        default:
                            current.Piece = null;
                            break;
                    }
                }
            }
        }

        public ChessSquare[,] Squares { get { return _squares; } }
    }
}
