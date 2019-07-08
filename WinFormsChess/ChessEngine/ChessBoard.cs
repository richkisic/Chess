using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{

    public class ChessBoard : INotifyPropertyChanged
    {
        private const int INT_MAX_COL_FILE = 8;
        private const int INT_MAX_ROW_RANK = 8;
        private readonly ChessSquare[,] _squares = new ChessSquare[INT_MAX_COL_FILE, INT_MAX_ROW_RANK];
        private List<ChessPiece> _capturedByBlack = new List<ChessPiece>();
        private List<ChessPiece> _capturedByWhite = new List<ChessPiece>();

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
            CurrentTurn = ChessColor.White; // reset back to first move

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
        
        ChessColor _currentTurn;

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ChessColor CurrentTurn
        {
            get
            {
                return _currentTurn;
            }
            private set
            {
                _currentTurn = value;
                NotifyPropertyChanged();
            }
        } 

        public List<ChessPiece> CapturedByWhite
        {
            get
            {
                return _capturedByWhite;
            }
            private set
            {
                _capturedByWhite = value;
                NotifyPropertyChanged();
            }
        }

        public List<ChessPiece> CapturedByBlack
        {
            get
            {
                return _capturedByBlack;
            }
            private set
            {
                _capturedByBlack = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsValidMove(ChessSquare moveFrom, ChessSquare moveTo)
        {
            if (moveFrom == moveTo) return false;
            if (moveFrom == null) throw new ArgumentNullException("moveFrom");
            if (moveTo == null) throw new ArgumentNullException("moveTo");
            if (moveFrom.Piece == null) throw new ArgumentNullException("moveFrom.Piece");
            if (moveTo.Piece != null && moveFrom.Piece.Color == moveTo.Piece.Color) return false;
            if (moveFrom.Piece.Color != CurrentTurn) return false;



            return true;
        }

        public bool AttemptMove(ChessSquare moveFrom, ChessSquare moveTo)
        {
            if (!IsValidMove(moveFrom, moveTo)) return false;

            if(moveTo.Piece != null) // it's a valid move and the space is occupied; a piece is about to be captured
            {
                if(CurrentTurn == ChessColor.White)
                {
                    _capturedByWhite.Add(moveTo.Piece);
                }
                else if (CurrentTurn == ChessColor.Black)
                {
                    _capturedByBlack.Add(moveTo.Piece);
                }
            }

            moveTo.Piece = moveFrom.Piece;
            moveFrom.Piece = null;
            CurrentTurn = CurrentTurn == ChessColor.White ? ChessColor.Black : ChessColor.White; // the move of a piece indicates a new turn

            return true;
        }
    }
}
