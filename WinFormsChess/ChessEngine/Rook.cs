using System;

namespace ChessEngine
{
    public class Rook : ChessPiece
    {
        public Rook(ChessColor pieceColor)
        {
            this.Color = pieceColor;

            _moveDictionary.Add("a8", new string[] { "a7", "a6", "a5", "a4", "a3", "a2", "a1", "b8", "c8", "d8", "e8", "f8", "g8", "h8" });
            _moveDictionary.Add("a7", new string[] { "a8", "a6", "a5", "a4", "a3", "a2", "a1", "b7", "c7", "d7", "e7", "f7", "g7", "h7" });
            _moveDictionary.Add("a6", new string[] { "a7", "a8", "a5", "a4", "a3", "a2", "a1", "b6", "c6", "d6", "e6", "f6", "g6", "h6" });
            _moveDictionary.Add("a5", new string[] { "a6", "a7", "a8", "a4", "a3", "a2", "a1", "b5", "c5", "d5", "e5", "f5", "g5", "h5" });
            _moveDictionary.Add("a4", new string[] { "a5", "a6", "a7", "a8", "a3", "a2", "a1", "b4", "c4", "d4", "e4", "f4", "g4", "h4" });
            _moveDictionary.Add("a3", new string[] { "a4", "a5", "a6", "a7", "a8", "a2", "a1", "b3", "c3", "d3", "e3", "f3", "g3", "h3" });
            _moveDictionary.Add("a2", new string[] { "a3", "a4", "a5", "a6", "a7", "a8", "a1", "b2", "c2", "d2", "e2", "f2", "g2", "h2" });
            _moveDictionary.Add("a1", new string[] { "a2", "a3", "a4", "a5", "a6", "a7", "a8", "b1", "c1", "d1", "e1", "f1", "g1", "h1" });
            _moveDictionary.Add("b8", new string[] { "b7", "b6", "b5", "b4", "b3", "b2", "b1", "c8", "d8", "e8", "f8", "g8", "h8", "a8" });
            _moveDictionary.Add("b7", new string[] { "b8", "b6", "b5", "b4", "b3", "b2", "b1", "c7", "d7", "e7", "f7", "g7", "h7", "a7" });
            _moveDictionary.Add("b6", new string[] { "b7", "b8", "b5", "b4", "b3", "b2", "b1", "c6", "d6", "e6", "f6", "g6", "h6", "a6" });
            _moveDictionary.Add("b5", new string[] { "b6", "b7", "b8", "b4", "b3", "b2", "b1", "c5", "d5", "e5", "f5", "g5", "h5", "a5" });
            _moveDictionary.Add("b4", new string[] { "b5", "b6", "b7", "b8", "b3", "b2", "b1", "c4", "d4", "e4", "f4", "g4", "h4", "a4" });
            _moveDictionary.Add("b3", new string[] { "b4", "b5", "b6", "b7", "b8", "b2", "b1", "c3", "d3", "e3", "f3", "g3", "h3", "a3" });
            _moveDictionary.Add("b2", new string[] { "b3", "b4", "b5", "b6", "b7", "b8", "b1", "c2", "d2", "e2", "f2", "g2", "h2", "a2" });
            _moveDictionary.Add("b1", new string[] { "b2", "b3", "b4", "b5", "b6", "b7", "b8", "c1", "d1", "e1", "f1", "g1", "h1", "a1" });
            _moveDictionary.Add("c8", new string[] { "c7", "c6", "c5", "c4", "c3", "c2", "c1", "d8", "e8", "f8", "g8", "h8", "b8", "a8" });
            _moveDictionary.Add("c7", new string[] { "c8", "c6", "c5", "c4", "c3", "c2", "c1", "d7", "e7", "f7", "g7", "h7", "b7", "a7" });
            _moveDictionary.Add("c6", new string[] { "c7", "c8", "c5", "c4", "c3", "c2", "c1", "d6", "e6", "f6", "g6", "h6", "b6", "a6" });
            _moveDictionary.Add("c5", new string[] { "c6", "c7", "c8", "c4", "c3", "c2", "c1", "d5", "e5", "f5", "g5", "h5", "b5", "a5" });
            _moveDictionary.Add("c4", new string[] { "c5", "c6", "c7", "c8", "c3", "c2", "c1", "d4", "e4", "f4", "g4", "h4", "b4", "a4" });
            _moveDictionary.Add("c3", new string[] { "c4", "c5", "c6", "c7", "c8", "c2", "c1", "d3", "e3", "f3", "g3", "h3", "b3", "a3" });
            _moveDictionary.Add("c2", new string[] { "c3", "c4", "c5", "c6", "c7", "c8", "c1", "d2", "e2", "f2", "g2", "h2", "b2", "a2" });
            _moveDictionary.Add("c1", new string[] { "c2", "c3", "c4", "c5", "c6", "c7", "c8", "d1", "e1", "f1", "g1", "h1", "b1", "a1" });
            _moveDictionary.Add("d8", new string[] { "d7", "d6", "d5", "d4", "d3", "d2", "d1", "e8", "f8", "g8", "h8", "c8", "b8", "a8" });
            _moveDictionary.Add("d7", new string[] { "d8", "d6", "d5", "d4", "d3", "d2", "d1", "e7", "f7", "g7", "h7", "c7", "b7", "a7" });
            _moveDictionary.Add("d6", new string[] { "d7", "d8", "d5", "d4", "d3", "d2", "d1", "e6", "f6", "g6", "h6", "c6", "b6", "a6" });
            _moveDictionary.Add("d5", new string[] { "d6", "d7", "d8", "d4", "d3", "d2", "d1", "e5", "f5", "g5", "h5", "c5", "b5", "a5" });
            _moveDictionary.Add("d4", new string[] { "d5", "d6", "d7", "d8", "d3", "d2", "d1", "e4", "f4", "g4", "h4", "c4", "b4", "a4" });
            _moveDictionary.Add("d3", new string[] { "d4", "d5", "d6", "d7", "d8", "d2", "d1", "e3", "f3", "g3", "h3", "c3", "b3", "a3" });
            _moveDictionary.Add("d2", new string[] { "d3", "d4", "d5", "d6", "d7", "d8", "d1", "e2", "f2", "g2", "h2", "c2", "b2", "a2" });
            _moveDictionary.Add("d1", new string[] { "d2", "d3", "d4", "d5", "d6", "d7", "d8", "e1", "f1", "g1", "h1", "c1", "b1", "a1" });
            _moveDictionary.Add("e8", new string[] { "e7", "e6", "e5", "e4", "e3", "e2", "e1", "f8", "g8", "h8", "d8", "c8", "b8", "a8" });
            _moveDictionary.Add("e7", new string[] { "e8", "e6", "e5", "e4", "e3", "e2", "e1", "f7", "g7", "h7", "d7", "c7", "b7", "a7" });
            _moveDictionary.Add("e6", new string[] { "e7", "e8", "e5", "e4", "e3", "e2", "e1", "f6", "g6", "h6", "d6", "c6", "b6", "a6" });
            _moveDictionary.Add("e5", new string[] { "e6", "e7", "e8", "e4", "e3", "e2", "e1", "f5", "g5", "h5", "d5", "c5", "b5", "a5" });
            _moveDictionary.Add("e4", new string[] { "e5", "e6", "e7", "e8", "e3", "e2", "e1", "f4", "g4", "h4", "d4", "c4", "b4", "a4" });
            _moveDictionary.Add("e3", new string[] { "e4", "e5", "e6", "e7", "e8", "e2", "e1", "f3", "g3", "h3", "d3", "c3", "b3", "a3" });
            _moveDictionary.Add("e2", new string[] { "e3", "e4", "e5", "e6", "e7", "e8", "e1", "f2", "g2", "h2", "d2", "c2", "b2", "a2" });
            _moveDictionary.Add("e1", new string[] { "e2", "e3", "e4", "e5", "e6", "e7", "e8", "f1", "g1", "h1", "d1", "c1", "b1", "a1" });
            _moveDictionary.Add("f8", new string[] { "f7", "f6", "f5", "f4", "f3", "f2", "f1", "g8", "h8", "e8", "d8", "c8", "b8", "a8" });
            _moveDictionary.Add("f7", new string[] { "f8", "f6", "f5", "f4", "f3", "f2", "f1", "g7", "h7", "e7", "d7", "c7", "b7", "a7" });
            _moveDictionary.Add("f6", new string[] { "f7", "f8", "f5", "f4", "f3", "f2", "f1", "g6", "h6", "e6", "d6", "c6", "b6", "a6" });
            _moveDictionary.Add("f5", new string[] { "f6", "f7", "f8", "f4", "f3", "f2", "f1", "g5", "h5", "e5", "d5", "c5", "b5", "a5" });
            _moveDictionary.Add("f4", new string[] { "f5", "f6", "f7", "f8", "f3", "f2", "f1", "g4", "h4", "e4", "d4", "c4", "b4", "a4" });
            _moveDictionary.Add("f3", new string[] { "f4", "f5", "f6", "f7", "f8", "f2", "f1", "g3", "h3", "e3", "d3", "c3", "b3", "a3" });
            _moveDictionary.Add("f2", new string[] { "f3", "f4", "f5", "f6", "f7", "f8", "f1", "g2", "h2", "e2", "d2", "c2", "b2", "a2" });
            _moveDictionary.Add("f1", new string[] { "f2", "f3", "f4", "f5", "f6", "f7", "f8", "g1", "h1", "e1", "d1", "c1", "b1", "a1" });
            _moveDictionary.Add("g8", new string[] { "g7", "g6", "g5", "g4", "g3", "g2", "g1", "h8", "f8", "e8", "d8", "c8", "b8", "a8" });
            _moveDictionary.Add("g7", new string[] { "g8", "g6", "g5", "g4", "g3", "g2", "g1", "h7", "f7", "e7", "d7", "c7", "b7", "a7" });
            _moveDictionary.Add("g6", new string[] { "g7", "g8", "g5", "g4", "g3", "g2", "g1", "h6", "f6", "e6", "d6", "c6", "b6", "a6" });
            _moveDictionary.Add("g5", new string[] { "g6", "g7", "g8", "g4", "g3", "g2", "g1", "h5", "f5", "e5", "d5", "c5", "b5", "a5" });
            _moveDictionary.Add("g4", new string[] { "g5", "g6", "g7", "g8", "g3", "g2", "g1", "h4", "f4", "e4", "d4", "c4", "b4", "a4" });
            _moveDictionary.Add("g3", new string[] { "g4", "g5", "g6", "g7", "g8", "g2", "g1", "h3", "f3", "e3", "d3", "c3", "b3", "a3" });
            _moveDictionary.Add("g2", new string[] { "g3", "g4", "g5", "g6", "g7", "g8", "g1", "h2", "f2", "e2", "d2", "c2", "b2", "a2" });
            _moveDictionary.Add("g1", new string[] { "g2", "g3", "g4", "g5", "g6", "g7", "g8", "h1", "f1", "e1", "d1", "c1", "b1", "a1" });
            _moveDictionary.Add("h8", new string[] { "h7", "h6", "h5", "h4", "h3", "h2", "h1", "g8", "f8", "e8", "d8", "c8", "b8", "a8" });
            _moveDictionary.Add("h7", new string[] { "h8", "h6", "h5", "h4", "h3", "h2", "h1", "g7", "f7", "e7", "d7", "c7", "b7", "a7" });
            _moveDictionary.Add("h6", new string[] { "h7", "h8", "h5", "h4", "h3", "h2", "h1", "g6", "f6", "e6", "d6", "c6", "b6", "a6" });
            _moveDictionary.Add("h5", new string[] { "h6", "h7", "h8", "h4", "h3", "h2", "h1", "g5", "f5", "e5", "d5", "c5", "b5", "a5" });
            _moveDictionary.Add("h4", new string[] { "h5", "h6", "h7", "h8", "h3", "h2", "h1", "g4", "f4", "e4", "d4", "c4", "b4", "a4" });
            _moveDictionary.Add("h3", new string[] { "h4", "h5", "h6", "h7", "h8", "h2", "h1", "g3", "f3", "e3", "d3", "c3", "b3", "a3" });
            _moveDictionary.Add("h2", new string[] { "h3", "h4", "h5", "h6", "h7", "h8", "h1", "g2", "f2", "e2", "d2", "c2", "b2", "a2" });
            _moveDictionary.Add("h1", new string[] { "h2", "h3", "h4", "h5", "h6", "h7", "h8", "g1", "f1", "e1", "d1", "c1", "b1", "a1" });
        }

        public override int IndividualValue { get { return 5; } }
    }
}
