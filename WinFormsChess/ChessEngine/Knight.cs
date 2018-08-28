﻿using System;

namespace ChessEngine
{
    public class Knight : ChessPiece
    {
        public Knight(ChessColor pieceColor)
        {
            this.Color = pieceColor;
        }

        public override int IndividualValue { get { return 3; } }
    }
}
