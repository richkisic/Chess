namespace WinFormsChess
{
    partial class MainChessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMoveDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pawnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.lblStaticCurrentTurn = new System.Windows.Forms.Label();
            this.rookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(12, 27);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(478, 398);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            this.pnlBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseDown);
            this.pnlBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseMove);
            this.pnlBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateMoveDictionaryToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // generateMoveDictionaryToolStripMenuItem
            // 
            this.generateMoveDictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kingToolStripMenuItem,
            this.pawnToolStripMenuItem,
            this.rookToolStripMenuItem});
            this.generateMoveDictionaryToolStripMenuItem.Name = "generateMoveDictionaryToolStripMenuItem";
            this.generateMoveDictionaryToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.generateMoveDictionaryToolStripMenuItem.Text = "Generate Move Dictionary";
            // 
            // kingToolStripMenuItem
            // 
            this.kingToolStripMenuItem.Name = "kingToolStripMenuItem";
            this.kingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kingToolStripMenuItem.Text = "King";
            this.kingToolStripMenuItem.Click += new System.EventHandler(this.kingToolStripMenuItem_Click);
            // 
            // pawnToolStripMenuItem
            // 
            this.pawnToolStripMenuItem.Name = "pawnToolStripMenuItem";
            this.pawnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pawnToolStripMenuItem.Text = "Pawn";
            this.pawnToolStripMenuItem.Click += new System.EventHandler(this.pawnToolStripMenuItem_Click);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Location = new System.Drawing.Point(600, 230);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentTurn.TabIndex = 2;
            this.lblCurrentTurn.Text = "White";
            // 
            // lblStaticCurrentTurn
            // 
            this.lblStaticCurrentTurn.AutoSize = true;
            this.lblStaticCurrentTurn.Location = new System.Drawing.Point(522, 230);
            this.lblStaticCurrentTurn.Name = "lblStaticCurrentTurn";
            this.lblStaticCurrentTurn.Size = new System.Drawing.Size(72, 13);
            this.lblStaticCurrentTurn.TabIndex = 3;
            this.lblStaticCurrentTurn.Text = "Current Turn: ";
            // 
            // rookToolStripMenuItem
            // 
            this.rookToolStripMenuItem.Name = "rookToolStripMenuItem";
            this.rookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rookToolStripMenuItem.Text = "Rook";
            this.rookToolStripMenuItem.Click += new System.EventHandler(this.RookToolStripMenuItem_Click);
            // 
            // MainChessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 468);
            this.Controls.Add(this.lblStaticCurrentTurn);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlBoard);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainChessForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainChessForm_Load);
            this.Resize += new System.EventHandler(this.MainChessForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMoveDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pawnToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Label lblStaticCurrentTurn;
        private System.Windows.Forms.ToolStripMenuItem rookToolStripMenuItem;
    }
}

