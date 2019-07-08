using System;

namespace ChessEngine
{
    public class Pawn : ChessPiece
    {
        public Pawn(ChessColor pieceColor)
        {
            this.Color = pieceColor;

            if(this.Color == ChessColor.White)
            {
                _moveDictionary.Add("a8", new string[] { "" });
                _moveDictionary.Add("a7", new string[] { "a8" });
                _moveDictionary.Add("a6", new string[] { "a7" });
                _moveDictionary.Add("a5", new string[] { "a6" });
                _moveDictionary.Add("a4", new string[] { "a5" });
                _moveDictionary.Add("a3", new string[] { "a4" });
                _moveDictionary.Add("a2", new string[] { "a3", "a4" });
                _moveDictionary.Add("b8", new string[] { "" });
                _moveDictionary.Add("b7", new string[] { "b8" });
                _moveDictionary.Add("b6", new string[] { "b7" });
                _moveDictionary.Add("b5", new string[] { "b6" });
                _moveDictionary.Add("b4", new string[] { "b5" });
                _moveDictionary.Add("b3", new string[] { "b4" });
                _moveDictionary.Add("b2", new string[] { "b3", "b4" });
                _moveDictionary.Add("c8", new string[] { "" });
                _moveDictionary.Add("c7", new string[] { "c8" });
                _moveDictionary.Add("c6", new string[] { "c7" });
                _moveDictionary.Add("c5", new string[] { "c6" });
                _moveDictionary.Add("c4", new string[] { "c5" });
                _moveDictionary.Add("c3", new string[] { "c4" });
                _moveDictionary.Add("c2", new string[] { "c3", "c4" });
                _moveDictionary.Add("d8", new string[] { "" });
                _moveDictionary.Add("d7", new string[] { "d8" });
                _moveDictionary.Add("d6", new string[] { "d7" });
                _moveDictionary.Add("d5", new string[] { "d6" });
                _moveDictionary.Add("d4", new string[] { "d5" });
                _moveDictionary.Add("d3", new string[] { "d4" });
                _moveDictionary.Add("d2", new string[] { "d3", "d4" });
                _moveDictionary.Add("e8", new string[] { "" });
                _moveDictionary.Add("e7", new string[] { "e8" });
                _moveDictionary.Add("e6", new string[] { "e7" });
                _moveDictionary.Add("e5", new string[] { "e6" });
                _moveDictionary.Add("e4", new string[] { "e5" });
                _moveDictionary.Add("e3", new string[] { "e4" });
                _moveDictionary.Add("e2", new string[] { "e3", "e4" });
                _moveDictionary.Add("f8", new string[] { "" });
                _moveDictionary.Add("f7", new string[] { "f8" });
                _moveDictionary.Add("f6", new string[] { "f7" });
                _moveDictionary.Add("f5", new string[] { "f6" });
                _moveDictionary.Add("f4", new string[] { "f5" });
                _moveDictionary.Add("f3", new string[] { "f4" });
                _moveDictionary.Add("f2", new string[] { "f3", "f4" });
                _moveDictionary.Add("g8", new string[] { "" });
                _moveDictionary.Add("g7", new string[] { "g8" });
                _moveDictionary.Add("g6", new string[] { "g7" });
                _moveDictionary.Add("g5", new string[] { "g6" });
                _moveDictionary.Add("g4", new string[] { "g5" });
                _moveDictionary.Add("g3", new string[] { "g4" });
                _moveDictionary.Add("g2", new string[] { "g3", "g4" });
                _moveDictionary.Add("h8", new string[] { "" });
                _moveDictionary.Add("h7", new string[] { "h8" });
                _moveDictionary.Add("h6", new string[] { "h7" });
                _moveDictionary.Add("h5", new string[] { "h6" });
                _moveDictionary.Add("h4", new string[] { "h5" });
                _moveDictionary.Add("h3", new string[] { "h4" });
                _moveDictionary.Add("h2", new string[] { "h3", "h4" });
            }
            else if(this.Color == ChessColor.Black)
            {
                _moveDictionary.Add("a7", new string[] { "a6", "a5" });
                _moveDictionary.Add("a6", new string[] { "a5" });
                _moveDictionary.Add("a5", new string[] { "a4" });
                _moveDictionary.Add("a4", new string[] { "a3" });
                _moveDictionary.Add("a3", new string[] { "a2" });
                _moveDictionary.Add("a2", new string[] { "a1" });
                _moveDictionary.Add("a1", new string[] { "" });
                _moveDictionary.Add("b7", new string[] { "b6", "b5" });
                _moveDictionary.Add("b6", new string[] { "b5" });
                _moveDictionary.Add("b5", new string[] { "b4" });
                _moveDictionary.Add("b4", new string[] { "b3" });
                _moveDictionary.Add("b3", new string[] { "b2" });
                _moveDictionary.Add("b2", new string[] { "b1" });
                _moveDictionary.Add("b1", new string[] { "" });
                _moveDictionary.Add("c7", new string[] { "c6", "c5" });
                _moveDictionary.Add("c6", new string[] { "c5" });
                _moveDictionary.Add("c5", new string[] { "c4" });
                _moveDictionary.Add("c4", new string[] { "c3" });
                _moveDictionary.Add("c3", new string[] { "c2" });
                _moveDictionary.Add("c2", new string[] { "c1" });
                _moveDictionary.Add("c1", new string[] { "" });
                _moveDictionary.Add("d7", new string[] { "d6", "d5" });
                _moveDictionary.Add("d6", new string[] { "d5" });
                _moveDictionary.Add("d5", new string[] { "d4" });
                _moveDictionary.Add("d4", new string[] { "d3" });
                _moveDictionary.Add("d3", new string[] { "d2" });
                _moveDictionary.Add("d2", new string[] { "d1" });
                _moveDictionary.Add("d1", new string[] { "" });
                _moveDictionary.Add("e7", new string[] { "e6", "e5" });
                _moveDictionary.Add("e6", new string[] { "e5" });
                _moveDictionary.Add("e5", new string[] { "e4" });
                _moveDictionary.Add("e4", new string[] { "e3" });
                _moveDictionary.Add("e3", new string[] { "e2" });
                _moveDictionary.Add("e2", new string[] { "e1" });
                _moveDictionary.Add("e1", new string[] { "" });
                _moveDictionary.Add("f7", new string[] { "f6", "f5" });
                _moveDictionary.Add("f6", new string[] { "f5" });
                _moveDictionary.Add("f5", new string[] { "f4" });
                _moveDictionary.Add("f4", new string[] { "f3" });
                _moveDictionary.Add("f3", new string[] { "f2" });
                _moveDictionary.Add("f2", new string[] { "f1" });
                _moveDictionary.Add("f1", new string[] { "" });
                _moveDictionary.Add("g7", new string[] { "g6", "g5" });
                _moveDictionary.Add("g6", new string[] { "g5" });
                _moveDictionary.Add("g5", new string[] { "g4" });
                _moveDictionary.Add("g4", new string[] { "g3" });
                _moveDictionary.Add("g3", new string[] { "g2" });
                _moveDictionary.Add("g2", new string[] { "g1" });
                _moveDictionary.Add("g1", new string[] { "" });
                _moveDictionary.Add("h7", new string[] { "h6", "h5" });
                _moveDictionary.Add("h6", new string[] { "h5" });
                _moveDictionary.Add("h5", new string[] { "h4" });
                _moveDictionary.Add("h4", new string[] { "h3" });
                _moveDictionary.Add("h3", new string[] { "h2" });
                _moveDictionary.Add("h2", new string[] { "h1" });
                _moveDictionary.Add("h1", new string[] { "" });
            }
        }

        public override int IndividualValue { get { return 1; } }
    }
}

