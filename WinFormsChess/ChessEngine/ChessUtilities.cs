using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class ChessUtilities
    {
        private const int INT_MAX_COL_FILE = 8;
        private const int INT_MAX_ROW_RANK = 8;

        public static string GetAlgebraicNotationFromRowZBTLFileRank(int file, int rank) // ZBTL zero based top left
        {
            if (rank > 7 || rank < 0 || file > 7 || file < 0) return null;
            return String.Format("{0}{1}", Convert.ToChar(((int)'a') + file), 8 - rank);
        }

        public static Dictionary<string, string[]> GenerateAllAlgebraicNotationMoves(PieceType pieceType, ChessColor pieceColor)
        {
            Dictionary<string, string[]> moveDictionary = new Dictionary<string, string[]>();

            // loop through every square on the board
            for (int fileCol = 0; fileCol < INT_MAX_COL_FILE; fileCol++)
            {
                for (int rankRow = 0; rankRow < INT_MAX_ROW_RANK; rankRow++)
                {
                    string algebraicNotation = GetAlgebraicNotationFromRowZBTLFileRank(fileCol, rankRow);
                    List<string> possibleMoves = new List<string>();
                    string possibleMove = null;

                    switch (pieceType)
                    {
                        case PieceType.Pawn:
                            // A pawn can move forward one square, if that square is unoccupied. 
                            // If it has not yet moved, each pawn has the option of moving two squares 
                            // forward provided both squares in front of the pawn are unoccupied. A pawn cannot move backwards.
                            if (rankRow == 0) continue;
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol, rankRow - 1);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            break;
                        case PieceType.Rook:
                            break;
                        case PieceType.Knight:
                            break;
                        case PieceType.Bishop:
                            break;
                        case PieceType.Queen:
                            break;
                        case PieceType.King:
                            // King can move exactly one square horizontally, vertically, or diagonally. 
                            // At most once in every game, each king is allowed to make a special move, known as castling.
                            // Castling is not handled, here; it is a special move handled by ChessBoard and states of King and Rook
                            // More info, here https://en.wikipedia.org/wiki/Castling
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol - 1, rankRow - 1);
                            if(possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol, rankRow - 1);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol + 1, rankRow - 1);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol - 1, rankRow);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol + 1, rankRow);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol - 1, rankRow + 1);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol, rankRow + 1);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            possibleMove = GetAlgebraicNotationFromRowZBTLFileRank(fileCol + 1, rankRow + 1);
                            if (possibleMove != null) possibleMoves.Add(possibleMove);
                            break;
                        default:
                            break;
                    }

                    moveDictionary.Add(algebraicNotation, possibleMoves.ToArray());
                }
            }

            return moveDictionary;
        }
    }
}
