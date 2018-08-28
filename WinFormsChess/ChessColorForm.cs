using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChessEngine;

namespace WinFormsChess
{
    public partial class ChessColorForm : Form
    {
        public ChessColorForm(string caption="Choose Color", string action="Please choose a color")
        {
            InitializeComponent();

            Text = caption;
            lblAction.Text = action;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedColor = cboColor.Text == "White" ? ChessColor.White : ChessColor.Black;
        }

        public ChessColor SelectedColor { get; private set; }

        private void ChessColorForm_Load(object sender, EventArgs e)
        {
            cboColor.SelectedIndex = 0;
        }
    }
}
