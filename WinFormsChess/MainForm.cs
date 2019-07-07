using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChessEngine;

namespace WinFormsChess
{
    public partial class MainChessForm : Form
    {
        private const int INT_MAX_COL_FILE = 8;
        private const int INT_MAX_ROW_RANK = 8;

        private readonly ChessBoard _board;

        private string[] _currentPieceANMoves = new string[0];

        private int? _squareBeginDragCol = null;
        private int? _squareBeginDragRow = null;

        private int? _lastSquareMousedOverCol = null;
        private int? _lastSquareMousedOverRow = null;

        public MainChessForm()
        {
            InitializeComponent();
            _board = new ChessBoard();
        }

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard(e);
            DrawPieces(e);
        }

        private void DrawBoard(PaintEventArgs e)
        {
            using (SolidBrush formBackgroundBrush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(formBackgroundBrush, e.ClipRectangle);
            }
            int squareWidth = e.ClipRectangle.Width / INT_MAX_COL_FILE;
            int squareHeight = e.ClipRectangle.Height / INT_MAX_ROW_RANK;
            for (int fileCol = 0; fileCol < INT_MAX_COL_FILE; fileCol++)
            {
                for (int rankRow = 0; rankRow < INT_MAX_ROW_RANK; rankRow++)
                {
                    string currentSquareAN = String.Format("{0}{1}", Convert.ToChar(((int)'a') + fileCol), 8 - rankRow);
                    if (_squareBeginDragCol != null && _squareBeginDragRow != null && _squareBeginDragRow == rankRow && _squareBeginDragCol == fileCol)
                    {
                        e.Graphics.FillRectangle(Brushes.Purple, fileCol * squareWidth, rankRow * squareHeight, squareWidth, squareHeight);
                    }
                    else if(_currentPieceANMoves.Contains(currentSquareAN))
                    {
                        e.Graphics.FillRectangle(Brushes.Green, fileCol * squareWidth, rankRow * squareHeight, squareWidth, squareHeight);
                    }
                    else
                    {
                        if (((fileCol % 2 == 0) && (rankRow % 2 == 0))
                            || ((fileCol % 2 == 1) && (rankRow % 2 == 1)))
                        {
                            e.Graphics.FillRectangle(Brushes.White, fileCol * squareWidth, rankRow * squareHeight, squareWidth, squareHeight);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(Brushes.Tan, fileCol * squareWidth, rankRow * squareHeight, squareWidth, squareHeight);
                        }
                    }
                }
            }

            if (_lastSquareMousedOverCol != null && _lastSquareMousedOverRow != null)
            {
                for (int fileCol = 0; fileCol < INT_MAX_COL_FILE; fileCol++)
                {
                    for (int rankRow = 0; rankRow < INT_MAX_ROW_RANK; rankRow++)
                    {
                        if (_lastSquareMousedOverCol == fileCol && _lastSquareMousedOverRow == rankRow)
                        {
                            using (Pen p = new Pen(Color.Purple, pnlBoard.Width / 100))
                            {
                                e.Graphics.DrawRectangle(p, fileCol * squareWidth, rankRow * squareHeight, squareWidth, squareHeight);
                            }
                        }
                    }
                }
            }
        }

        private void DrawPieces(PaintEventArgs e)
        {
            int squareWidth = e.ClipRectangle.Width / INT_MAX_COL_FILE;
            int squareHeight = e.ClipRectangle.Height / INT_MAX_ROW_RANK;
            for (int fileCol = 0; fileCol < INT_MAX_COL_FILE; fileCol++)
            {
                for (int rankRow = 0; rankRow < INT_MAX_ROW_RANK; rankRow++)
                {
                    ChessPiece currentPiece = _board.Squares[fileCol, rankRow].Piece;
                    if (currentPiece == null) continue;
                    Type pieceObjType = currentPiece.GetType();
                    string pieceString = GetPieceUnicodeRepresentation(currentPiece.Color, pieceObjType);
                    float emSize = Math.Min(pnlBoard.Width, pnlBoard.Height)/16;// GetMaxFontSizeForString(e.Graphics, DefaultFont, pieceString, squareWidth, squareHeight);
                    Font f = new Font("Courier", emSize);
                    e.Graphics.DrawString(pieceString, f, Brushes.Black, fileCol * squareWidth, rankRow * squareHeight);
                }
            }
        }

        private static float GetMaxFontSizeForString(Graphics graphics, Font srcFont, string val, int maxWidth, int maxHeight)
        {
            for (int tryFontSize = 300; tryFontSize > 0; tryFontSize--)
            {
                Font tryFont = new Font(srcFont.FontFamily, tryFontSize);
                SizeF size = graphics.MeasureString(val, tryFont);
                if (size.Width < maxWidth && size.Height < maxHeight) return tryFontSize;
            }
            throw new Exception("Could not find an appropriately small font size");
        }

        private static string GetPieceUnicodeRepresentation(ChessColor color, Type pieceObjType)
        {
            // https://en.wikipedia.org/wiki/Chess_symbols_in_Unicode
            if (pieceObjType.Equals(typeof(King)))
            {
                return color == ChessColor.White ? "\u2654" : "\u265A";
            }
            else if (pieceObjType.Equals(typeof(Queen)))
            {
                return color == ChessColor.White ? "\u2655" : "\u265B";
            }
            else if (pieceObjType.Equals(typeof(Rook)))
            {
                return color == ChessColor.White ? "\u2656" : "\u265C";
            }
            else if (pieceObjType.Equals(typeof(Bishop)))
            {
                return color == ChessColor.White ? "\u2657" : "\u265D";
            }
            else if (pieceObjType.Equals(typeof(Knight)))
            {
                return color == ChessColor.White ? "\u2658" : "\u265E";
            }
            else if (pieceObjType.Equals(typeof(Pawn)))
            {
                return color == ChessColor.White ? "\u2659" : "\u265F";
            }
            else throw new NotImplementedException("Unexpected chess piece type");
        }

        private void MainChessForm_Resize(object sender, EventArgs e)
        {
            pnlBoard.Invalidate();
        }

        private void pnlBoard_MouseMove(object sender, MouseEventArgs e)
        {
            int squareWidth = pnlBoard.Width / INT_MAX_COL_FILE;
            int squareHeight = pnlBoard.Height / INT_MAX_ROW_RANK;

            int currentSquareMousedOverCol = (e.X / squareWidth);
            int currentSquareMousedOverRow = (e.Y / squareHeight);

            if (_lastSquareMousedOverCol != currentSquareMousedOverCol
                || _lastSquareMousedOverRow != currentSquareMousedOverRow)
            {
                _lastSquareMousedOverCol = currentSquareMousedOverCol;
                _lastSquareMousedOverRow = currentSquareMousedOverRow;
                pnlBoard.Invalidate();// (new Rectangle(currentSquareMousedOverCol * squareWidth, currentSquareMousedOverRow * squareHeight, (currentSquareMousedOverCol + 1) * squareWidth, (currentSquareMousedOverRow + 1) * squareHeight));
            }
        }

        private void pnlBoard_MouseDown(object sender, MouseEventArgs e)
        {
            int squareWidth = pnlBoard.Width / INT_MAX_COL_FILE;
            int squareHeight = pnlBoard.Height / INT_MAX_ROW_RANK;

            if (e.Button == MouseButtons.Left)
            {
                _squareBeginDragCol = (e.X / squareWidth);
                _squareBeginDragRow = (e.Y / squareHeight);

                ChessSquare currentSquare = _board.Squares[_squareBeginDragCol.Value, _squareBeginDragRow.Value];
                if(currentSquare != null)
                {
                    if(currentSquare.Piece != null)
                    {
                        _currentPieceANMoves = currentSquare.Piece.GetAlgebraicNotationMoves(currentSquare.AlgebraicNotation);
                    }
                    else
                    {
                        _currentPieceANMoves = new string[0];
                    }
                }
                else
                {
                    throw new Exception("Square was unexpectedly null");
                }
            }
            else
            {
                _squareBeginDragCol = null;
                _squareBeginDragRow = null;
            }
            pnlBoard.Invalidate();
        }

        private void pnlBoard_MouseUp(object sender, MouseEventArgs e)
        { 
            // do we know where we dropped?
            if (_lastSquareMousedOverCol != null && _lastSquareMousedOverRow != null)
            {
                // do we know where we started?
                if (_squareBeginDragCol != null && _squareBeginDragRow != null)
                {
                    ChessSquare startingSquare = _board.Squares[_squareBeginDragCol.Value, _squareBeginDragRow.Value];
                    ChessSquare dropSquare = _board.Squares[_lastSquareMousedOverCol.Value, _lastSquareMousedOverRow.Value];
                    if(_board.AttemptMove(startingSquare, dropSquare))
                    {
                        
                    }
                }
            }

            _squareBeginDragCol = null;
            _squareBeginDragRow = null;
            _currentPieceANMoves = new string[0];
            pnlBoard.Invalidate();
        }

        private void kingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMovesToFile(PieceType.King);
        }

        private void pawnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMovesToFile(PieceType.Pawn);
        }

        private static void SaveMovesToFile(PieceType pieceType)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                saveFileDialog1.Title = "Save Moves to File";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    using (ChessColorForm chessColorDialog = new ChessColorForm())
                    {
                        if (chessColorDialog.ShowDialog() == DialogResult.OK)
                        {
                            StringBuilder sb = new StringBuilder();
                            Dictionary<string, string[]> moves = ChessUtilities.GenerateAllNonCaptureNonSpecialAlgebraicNotationMoves(pieceType, chessColorDialog.SelectedColor);

                            foreach (KeyValuePair<string, string[]> kvp in moves)
                            {
                                sb.Append(String.Format("_moveDictionary.Add(\"{0}\", new string[] {{ \"{1}\" }});{2}", kvp.Key, String.Join("\", \"", kvp.Value), Environment.NewLine));
                            }
                            File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
                        }
                    }
                }
            }
        }

        private void MainChessForm_Load(object sender, EventArgs e)
        {
#if !DEBUG
            utilitiesToolStripMenuItem.Visible = false;
#endif
            lblCurrentTurn.DataBindings.Add("Text", _board, "CurrentTurn");
        }
    }
}
