﻿using System;
using System.Windows.Forms;

namespace WF_4_Puzzle15
{
    public partial class BestScoredPlayerNameForm : Form
    {
        public BestScoredPlayerNameForm()
        {
            InitializeComponent();
        }

        public string PlayerName { get => nameTextBox.Text.Trim(); }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = PlayerName.Trim().Length > 0;
        }
    }
}
