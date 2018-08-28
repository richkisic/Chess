using System;
using System.Collections.Generic;

namespace ChessEngine
{
    public class King : ChessPiece
    {
        public King(ChessColor pieceColor)
        {
            this.Color = pieceColor;

            _moveDictionary.Add("a8", new string[] { "b8", "a7", "b7" });
            _moveDictionary.Add("a7", new string[] { "a8", "b8", "b7", "a6", "b6" });
            _moveDictionary.Add("a6", new string[] { "a7", "b7", "b6", "a5", "b5" });
            _moveDictionary.Add("a5", new string[] { "a6", "b6", "b5", "a4", "b4" });
            _moveDictionary.Add("a4", new string[] { "a5", "b5", "b4", "a3", "b3" });
            _moveDictionary.Add("a3", new string[] { "a4", "b4", "b3", "a2", "b2" });
            _moveDictionary.Add("a2", new string[] { "a3", "b3", "b2", "a1", "b1" });
            _moveDictionary.Add("a1", new string[] { "a2", "b2", "b1" });
            _moveDictionary.Add("b8", new string[] { "a8", "c8", "a7", "b7", "c7" });
            _moveDictionary.Add("b7", new string[] { "a8", "b8", "c8", "a7", "c7", "a6", "b6", "c6" });
            _moveDictionary.Add("b6", new string[] { "a7", "b7", "c7", "a6", "c6", "a5", "b5", "c5" });
            _moveDictionary.Add("b5", new string[] { "a6", "b6", "c6", "a5", "c5", "a4", "b4", "c4" });
            _moveDictionary.Add("b4", new string[] { "a5", "b5", "c5", "a4", "c4", "a3", "b3", "c3" });
            _moveDictionary.Add("b3", new string[] { "a4", "b4", "c4", "a3", "c3", "a2", "b2", "c2" });
            _moveDictionary.Add("b2", new string[] { "a3", "b3", "c3", "a2", "c2", "a1", "b1", "c1" });
            _moveDictionary.Add("b1", new string[] { "a2", "b2", "c2", "a1", "c1" });
            _moveDictionary.Add("c8", new string[] { "b8", "d8", "b7", "c7", "d7" });
            _moveDictionary.Add("c7", new string[] { "b8", "c8", "d8", "b7", "d7", "b6", "c6", "d6" });
            _moveDictionary.Add("c6", new string[] { "b7", "c7", "d7", "b6", "d6", "b5", "c5", "d5" });
            _moveDictionary.Add("c5", new string[] { "b6", "c6", "d6", "b5", "d5", "b4", "c4", "d4" });
            _moveDictionary.Add("c4", new string[] { "b5", "c5", "d5", "b4", "d4", "b3", "c3", "d3" });
            _moveDictionary.Add("c3", new string[] { "b4", "c4", "d4", "b3", "d3", "b2", "c2", "d2" });
            _moveDictionary.Add("c2", new string[] { "b3", "c3", "d3", "b2", "d2", "b1", "c1", "d1" });
            _moveDictionary.Add("c1", new string[] { "b2", "c2", "d2", "b1", "d1" });
            _moveDictionary.Add("d8", new string[] { "c8", "e8", "c7", "d7", "e7" });
            _moveDictionary.Add("d7", new string[] { "c8", "d8", "e8", "c7", "e7", "c6", "d6", "e6" });
            _moveDictionary.Add("d6", new string[] { "c7", "d7", "e7", "c6", "e6", "c5", "d5", "e5" });
            _moveDictionary.Add("d5", new string[] { "c6", "d6", "e6", "c5", "e5", "c4", "d4", "e4" });
            _moveDictionary.Add("d4", new string[] { "c5", "d5", "e5", "c4", "e4", "c3", "d3", "e3" });
            _moveDictionary.Add("d3", new string[] { "c4", "d4", "e4", "c3", "e3", "c2", "d2", "e2" });
            _moveDictionary.Add("d2", new string[] { "c3", "d3", "e3", "c2", "e2", "c1", "d1", "e1" });
            _moveDictionary.Add("d1", new string[] { "c2", "d2", "e2", "c1", "e1" });
            _moveDictionary.Add("e8", new string[] { "d8", "f8", "d7", "e7", "f7" });
            _moveDictionary.Add("e7", new string[] { "d8", "e8", "f8", "d7", "f7", "d6", "e6", "f6" });
            _moveDictionary.Add("e6", new string[] { "d7", "e7", "f7", "d6", "f6", "d5", "e5", "f5" });
            _moveDictionary.Add("e5", new string[] { "d6", "e6", "f6", "d5", "f5", "d4", "e4", "f4" });
            _moveDictionary.Add("e4", new string[] { "d5", "e5", "f5", "d4", "f4", "d3", "e3", "f3" });
            _moveDictionary.Add("e3", new string[] { "d4", "e4", "f4", "d3", "f3", "d2", "e2", "f2" });
            _moveDictionary.Add("e2", new string[] { "d3", "e3", "f3", "d2", "f2", "d1", "e1", "f1" });
            _moveDictionary.Add("e1", new string[] { "d2", "e2", "f2", "d1", "f1" });
            _moveDictionary.Add("f8", new string[] { "e8", "g8", "e7", "f7", "g7" });
            _moveDictionary.Add("f7", new string[] { "e8", "f8", "g8", "e7", "g7", "e6", "f6", "g6" });
            _moveDictionary.Add("f6", new string[] { "e7", "f7", "g7", "e6", "g6", "e5", "f5", "g5" });
            _moveDictionary.Add("f5", new string[] { "e6", "f6", "g6", "e5", "g5", "e4", "f4", "g4" });
            _moveDictionary.Add("f4", new string[] { "e5", "f5", "g5", "e4", "g4", "e3", "f3", "g3" });
            _moveDictionary.Add("f3", new string[] { "e4", "f4", "g4", "e3", "g3", "e2", "f2", "g2" });
            _moveDictionary.Add("f2", new string[] { "e3", "f3", "g3", "e2", "g2", "e1", "f1", "g1" });
            _moveDictionary.Add("f1", new string[] { "e2", "f2", "g2", "e1", "g1" });
            _moveDictionary.Add("g8", new string[] { "f8", "h8", "f7", "g7", "h7" });
            _moveDictionary.Add("g7", new string[] { "f8", "g8", "h8", "f7", "h7", "f6", "g6", "h6" });
            _moveDictionary.Add("g6", new string[] { "f7", "g7", "h7", "f6", "h6", "f5", "g5", "h5" });
            _moveDictionary.Add("g5", new string[] { "f6", "g6", "h6", "f5", "h5", "f4", "g4", "h4" });
            _moveDictionary.Add("g4", new string[] { "f5", "g5", "h5", "f4", "h4", "f3", "g3", "h3" });
            _moveDictionary.Add("g3", new string[] { "f4", "g4", "h4", "f3", "h3", "f2", "g2", "h2" });
            _moveDictionary.Add("g2", new string[] { "f3", "g3", "h3", "f2", "h2", "f1", "g1", "h1" });
            _moveDictionary.Add("g1", new string[] { "f2", "g2", "h2", "f1", "h1" });
            _moveDictionary.Add("h8", new string[] { "g8", "g7", "h7" });
            _moveDictionary.Add("h7", new string[] { "g8", "h8", "g7", "g6", "h6" });
            _moveDictionary.Add("h6", new string[] { "g7", "h7", "g6", "g5", "h5" });
            _moveDictionary.Add("h5", new string[] { "g6", "h6", "g5", "g4", "h4" });
            _moveDictionary.Add("h4", new string[] { "g5", "h5", "g4", "g3", "h3" });
            _moveDictionary.Add("h3", new string[] { "g4", "h4", "g3", "g2", "h2" });
            _moveDictionary.Add("h2", new string[] { "g3", "h3", "g2", "g1", "h1" });
            _moveDictionary.Add("h1", new string[] { "g2", "h2", "g1" });
        }
        
        public override int IndividualValue { get { return Int32.MaxValue; } }
    }
}

