namespace WF_4_Puzzle15
{
    partial class PuzzleForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleForm));
            buttonAbout = new Button();
            buttonExit = new Button();
            tableLayoutPanelCellButtons = new TableLayoutPanel();
            buttonCell16 = new Button();
            buttonCell15 = new Button();
            buttonCell14 = new Button();
            buttonCell13 = new Button();
            buttonCell12 = new Button();
            buttonCell11 = new Button();
            buttonCell10 = new Button();
            buttonCell9 = new Button();
            buttonCell8 = new Button();
            buttonCell7 = new Button();
            buttonCell5 = new Button();
            buttonCell4 = new Button();
            buttonCell3 = new Button();
            buttonCell2 = new Button();
            buttonCell1 = new Button();
            buttonCell6 = new Button();
            groupBoxTime = new GroupBox();
            labelTimer = new Label();
            groupBoxMoves = new GroupBox();
            labelMoves = new Label();
            buttonNewGame = new Button();
            timerGame = new System.Windows.Forms.Timer(components);
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileBestScoresToolStripMenuItem = new ToolStripMenuItem();
            fileSeparatorToolStripMenuItem = new ToolStripSeparator();
            fileExitToolStripMenuItem = new ToolStripMenuItem();
            gameToolStripMenuItem = new ToolStripMenuItem();
            gameNewGameToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            helpAboutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanelCellButtons.SuspendLayout();
            groupBoxTime.SuspendLayout();
            groupBoxMoves.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAbout.Location = new Point(408, 49);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(119, 38);
            buttonAbout.TabIndex = 17;
            buttonAbout.Text = "About...";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += AboutHandler;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExit.Location = new Point(408, 350);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(119, 38);
            buttonExit.TabIndex = 18;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ExitHandler;
            // 
            // tableLayoutPanelCellButtons
            // 
            tableLayoutPanelCellButtons.ColumnCount = 4;
            tableLayoutPanelCellButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.Controls.Add(buttonCell16, 3, 3);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell15, 2, 3);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell14, 1, 3);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell13, 0, 3);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell12, 3, 2);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell11, 2, 2);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell10, 1, 2);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell9, 0, 2);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell8, 3, 1);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell7, 2, 1);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell5, 0, 1);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell4, 3, 0);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell3, 2, 0);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell2, 1, 0);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell1, 0, 0);
            tableLayoutPanelCellButtons.Controls.Add(buttonCell6, 1, 1);
            tableLayoutPanelCellButtons.Location = new Point(25, 46);
            tableLayoutPanelCellButtons.Name = "tableLayoutPanelCellButtons";
            tableLayoutPanelCellButtons.RowCount = 4;
            tableLayoutPanelCellButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelCellButtons.Size = new Size(359, 342);
            tableLayoutPanelCellButtons.TabIndex = 1;
            // 
            // buttonCell16
            // 
            buttonCell16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell16.AutoSize = true;
            buttonCell16.Enabled = false;
            buttonCell16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell16.Location = new Point(270, 258);
            buttonCell16.Name = "buttonCell16";
            buttonCell16.Size = new Size(86, 81);
            buttonCell16.TabIndex = 15;
            buttonCell16.TabStop = false;
            buttonCell16.UseVisualStyleBackColor = true;
            buttonCell16.Visible = false;
            buttonCell16.Click += buttonCell_Click;
            // 
            // buttonCell15
            // 
            buttonCell15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell15.AutoSize = true;
            buttonCell15.Enabled = false;
            buttonCell15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell15.Location = new Point(181, 258);
            buttonCell15.Name = "buttonCell15";
            buttonCell15.Size = new Size(83, 81);
            buttonCell15.TabIndex = 14;
            buttonCell15.TabStop = false;
            buttonCell15.Text = "15";
            buttonCell15.UseVisualStyleBackColor = true;
            buttonCell15.Click += buttonCell_Click;
            // 
            // buttonCell14
            // 
            buttonCell14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell14.AutoSize = true;
            buttonCell14.Enabled = false;
            buttonCell14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell14.Location = new Point(92, 258);
            buttonCell14.Name = "buttonCell14";
            buttonCell14.Size = new Size(83, 81);
            buttonCell14.TabIndex = 13;
            buttonCell14.TabStop = false;
            buttonCell14.Text = "14";
            buttonCell14.UseVisualStyleBackColor = true;
            buttonCell14.Click += buttonCell_Click;
            // 
            // buttonCell13
            // 
            buttonCell13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell13.AutoSize = true;
            buttonCell13.Enabled = false;
            buttonCell13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell13.Location = new Point(3, 258);
            buttonCell13.Name = "buttonCell13";
            buttonCell13.Size = new Size(83, 81);
            buttonCell13.TabIndex = 12;
            buttonCell13.TabStop = false;
            buttonCell13.Text = "13";
            buttonCell13.UseVisualStyleBackColor = true;
            buttonCell13.Click += buttonCell_Click;
            // 
            // buttonCell12
            // 
            buttonCell12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell12.AutoSize = true;
            buttonCell12.Enabled = false;
            buttonCell12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell12.Location = new Point(270, 173);
            buttonCell12.Name = "buttonCell12";
            buttonCell12.Size = new Size(86, 79);
            buttonCell12.TabIndex = 11;
            buttonCell12.TabStop = false;
            buttonCell12.Text = "12";
            buttonCell12.UseVisualStyleBackColor = true;
            buttonCell12.Click += buttonCell_Click;
            // 
            // buttonCell11
            // 
            buttonCell11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell11.AutoSize = true;
            buttonCell11.Enabled = false;
            buttonCell11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell11.Location = new Point(181, 173);
            buttonCell11.Name = "buttonCell11";
            buttonCell11.Size = new Size(83, 79);
            buttonCell11.TabIndex = 10;
            buttonCell11.TabStop = false;
            buttonCell11.Text = "11";
            buttonCell11.UseVisualStyleBackColor = true;
            buttonCell11.Click += buttonCell_Click;
            // 
            // buttonCell10
            // 
            buttonCell10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell10.AutoSize = true;
            buttonCell10.Enabled = false;
            buttonCell10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell10.Location = new Point(92, 173);
            buttonCell10.Name = "buttonCell10";
            buttonCell10.Size = new Size(83, 79);
            buttonCell10.TabIndex = 9;
            buttonCell10.TabStop = false;
            buttonCell10.Text = "10";
            buttonCell10.UseVisualStyleBackColor = true;
            buttonCell10.Click += buttonCell_Click;
            // 
            // buttonCell9
            // 
            buttonCell9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell9.AutoSize = true;
            buttonCell9.Enabled = false;
            buttonCell9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell9.Location = new Point(3, 173);
            buttonCell9.Name = "buttonCell9";
            buttonCell9.Size = new Size(83, 79);
            buttonCell9.TabIndex = 8;
            buttonCell9.TabStop = false;
            buttonCell9.Text = "9";
            buttonCell9.UseVisualStyleBackColor = true;
            buttonCell9.Click += buttonCell_Click;
            // 
            // buttonCell8
            // 
            buttonCell8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell8.AutoSize = true;
            buttonCell8.Enabled = false;
            buttonCell8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell8.Location = new Point(270, 88);
            buttonCell8.Name = "buttonCell8";
            buttonCell8.Size = new Size(86, 79);
            buttonCell8.TabIndex = 7;
            buttonCell8.TabStop = false;
            buttonCell8.Text = "8";
            buttonCell8.UseVisualStyleBackColor = true;
            buttonCell8.Click += buttonCell_Click;
            // 
            // buttonCell7
            // 
            buttonCell7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell7.AutoSize = true;
            buttonCell7.Enabled = false;
            buttonCell7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell7.Location = new Point(181, 88);
            buttonCell7.Name = "buttonCell7";
            buttonCell7.Size = new Size(83, 79);
            buttonCell7.TabIndex = 6;
            buttonCell7.TabStop = false;
            buttonCell7.Text = "7";
            buttonCell7.UseVisualStyleBackColor = true;
            buttonCell7.Click += buttonCell_Click;
            // 
            // buttonCell5
            // 
            buttonCell5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell5.AutoSize = true;
            buttonCell5.Enabled = false;
            buttonCell5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell5.Location = new Point(3, 88);
            buttonCell5.Name = "buttonCell5";
            buttonCell5.Size = new Size(83, 79);
            buttonCell5.TabIndex = 4;
            buttonCell5.TabStop = false;
            buttonCell5.Text = "5";
            buttonCell5.UseVisualStyleBackColor = true;
            buttonCell5.Click += buttonCell_Click;
            // 
            // buttonCell4
            // 
            buttonCell4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell4.AutoSize = true;
            buttonCell4.Enabled = false;
            buttonCell4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell4.Location = new Point(270, 3);
            buttonCell4.Name = "buttonCell4";
            buttonCell4.Size = new Size(86, 79);
            buttonCell4.TabIndex = 3;
            buttonCell4.TabStop = false;
            buttonCell4.Text = "4";
            buttonCell4.UseVisualStyleBackColor = true;
            buttonCell4.Click += buttonCell_Click;
            // 
            // buttonCell3
            // 
            buttonCell3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell3.AutoSize = true;
            buttonCell3.Enabled = false;
            buttonCell3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell3.Location = new Point(181, 3);
            buttonCell3.Name = "buttonCell3";
            buttonCell3.Size = new Size(83, 79);
            buttonCell3.TabIndex = 2;
            buttonCell3.TabStop = false;
            buttonCell3.Text = "3";
            buttonCell3.UseVisualStyleBackColor = true;
            buttonCell3.Click += buttonCell_Click;
            // 
            // buttonCell2
            // 
            buttonCell2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell2.AutoSize = true;
            buttonCell2.Enabled = false;
            buttonCell2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell2.Location = new Point(92, 3);
            buttonCell2.Name = "buttonCell2";
            buttonCell2.Size = new Size(83, 79);
            buttonCell2.TabIndex = 1;
            buttonCell2.TabStop = false;
            buttonCell2.Text = "2";
            buttonCell2.UseVisualStyleBackColor = true;
            buttonCell2.Click += buttonCell_Click;
            // 
            // buttonCell1
            // 
            buttonCell1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell1.AutoSize = true;
            buttonCell1.Enabled = false;
            buttonCell1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell1.Location = new Point(3, 3);
            buttonCell1.Name = "buttonCell1";
            buttonCell1.Size = new Size(83, 79);
            buttonCell1.TabIndex = 0;
            buttonCell1.TabStop = false;
            buttonCell1.Text = "1";
            buttonCell1.UseVisualStyleBackColor = true;
            buttonCell1.Click += buttonCell_Click;
            // 
            // buttonCell6
            // 
            buttonCell6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCell6.AutoSize = true;
            buttonCell6.Enabled = false;
            buttonCell6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCell6.Location = new Point(92, 88);
            buttonCell6.Name = "buttonCell6";
            buttonCell6.Size = new Size(83, 79);
            buttonCell6.TabIndex = 5;
            buttonCell6.TabStop = false;
            buttonCell6.Text = "6";
            buttonCell6.UseVisualStyleBackColor = true;
            buttonCell6.Click += buttonCell_Click;
            // 
            // groupBoxTime
            // 
            groupBoxTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxTime.Controls.Add(labelTimer);
            groupBoxTime.Location = new Point(408, 134);
            groupBoxTime.Name = "groupBoxTime";
            groupBoxTime.Size = new Size(119, 79);
            groupBoxTime.TabIndex = 2;
            groupBoxTime.TabStop = false;
            groupBoxTime.Text = "Time:";
            // 
            // labelTimer
            // 
            labelTimer.Enabled = false;
            labelTimer.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.Location = new Point(17, 28);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(88, 23);
            labelTimer.TabIndex = 0;
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxMoves
            // 
            groupBoxMoves.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxMoves.Controls.Add(labelMoves);
            groupBoxMoves.Location = new Point(408, 219);
            groupBoxMoves.Name = "groupBoxMoves";
            groupBoxMoves.Size = new Size(119, 79);
            groupBoxMoves.TabIndex = 2;
            groupBoxMoves.TabStop = false;
            groupBoxMoves.Text = "Moves:";
            // 
            // labelMoves
            // 
            labelMoves.Enabled = false;
            labelMoves.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMoves.Location = new Point(17, 28);
            labelMoves.Name = "labelMoves";
            labelMoves.Size = new Size(88, 23);
            labelMoves.TabIndex = 0;
            labelMoves.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNewGame.Location = new Point(408, 93);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(119, 38);
            buttonNewGame.TabIndex = 16;
            buttonNewGame.Text = "New game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += NewGameHandler;
            // 
            // timerGame
            // 
            timerGame.Tick += timerGame_Tick;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, gameToolStripMenuItem, helpToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(5, 2, 0, 2);
            mainMenuStrip.Size = new Size(553, 24);
            mainMenuStrip.TabIndex = 19;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileBestScoresToolStripMenuItem, fileSeparatorToolStripMenuItem, fileExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // fileBestScoresToolStripMenuItem
            // 
            fileBestScoresToolStripMenuItem.Name = "fileBestScoresToolStripMenuItem";
            fileBestScoresToolStripMenuItem.Size = new Size(180, 22);
            fileBestScoresToolStripMenuItem.Text = "&Best scores";
            fileBestScoresToolStripMenuItem.Click += BestScoresHandler;
            // 
            // fileSeparatorToolStripMenuItem
            // 
            fileSeparatorToolStripMenuItem.Name = "fileSeparatorToolStripMenuItem";
            fileSeparatorToolStripMenuItem.Size = new Size(177, 6);
            // 
            // fileExitToolStripMenuItem
            // 
            fileExitToolStripMenuItem.Name = "fileExitToolStripMenuItem";
            fileExitToolStripMenuItem.Size = new Size(180, 22);
            fileExitToolStripMenuItem.Text = "&Exit";
            fileExitToolStripMenuItem.Click += ExitHandler;
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gameNewGameToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(50, 20);
            gameToolStripMenuItem.Text = "&Game";
            // 
            // gameNewGameToolStripMenuItem
            // 
            gameNewGameToolStripMenuItem.Name = "gameNewGameToolStripMenuItem";
            gameNewGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            gameNewGameToolStripMenuItem.Size = new Size(180, 22);
            gameNewGameToolStripMenuItem.Text = "&New game";
            gameNewGameToolStripMenuItem.Click += NewGameHandler;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpAboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(24, 20);
            helpToolStripMenuItem.Text = "&?";
            // 
            // helpAboutToolStripMenuItem
            // 
            helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            helpAboutToolStripMenuItem.Size = new Size(158, 22);
            helpAboutToolStripMenuItem.Text = "О &программе...";
            helpAboutToolStripMenuItem.Click += AboutHandler;
            // 
            // PuzzleForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 410);
            Controls.Add(groupBoxMoves);
            Controls.Add(groupBoxTime);
            Controls.Add(tableLayoutPanelCellButtons);
            Controls.Add(buttonNewGame);
            Controls.Add(buttonExit);
            Controls.Add(buttonAbout);
            Controls.Add(mainMenuStrip);
            Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PuzzleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puzzle 15";
            tableLayoutPanelCellButtons.ResumeLayout(false);
            tableLayoutPanelCellButtons.PerformLayout();
            groupBoxTime.ResumeLayout(false);
            groupBoxMoves.ResumeLayout(false);
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbout;
        private Button buttonExit;
        private TableLayoutPanel tableLayoutPanelCellButtons;
        private Button buttonCell16;
        private Button buttonCell15;
        private Button buttonCell14;
        private Button buttonCell13;
        private Button buttonCell12;
        private Button buttonCell11;
        private Button buttonCell10;
        private Button buttonCell9;
        private Button buttonCell8;
        private Button buttonCell7;
        private Button buttonCell6;
        private Button buttonCell5;
        private Button buttonCell4;
        private Button buttonCell3;
        private Button buttonCell2;
        private Button buttonCell1;
        private GroupBox groupBoxTime;
        private Label labelTimer;
        private GroupBox groupBoxMoves;
        private Label labelMoves;
        private Button buttonNewGame;
        private System.Windows.Forms.Timer timerGame;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileExitToolStripMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem gameNewGameToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpAboutToolStripMenuItem;
        private ToolStripMenuItem fileBestScoresToolStripMenuItem;
        private ToolStripSeparator fileSeparatorToolStripMenuItem;
    }
}

