namespace WF_4_Puzzle15
{
    partial class BestScoredPlayerNameForm
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
            buttonOk = new Button();
            buttonCancel = new Button();
            nameGroupBox = new GroupBox();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            infoLabel = new Label();
            nameGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Enabled = false;
            buttonOk.Location = new Point(159, 165);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(120, 36);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(285, 165);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 36);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // nameGroupBox
            // 
            nameGroupBox.Controls.Add(nameTextBox);
            nameGroupBox.Controls.Add(nameLabel);
            nameGroupBox.Controls.Add(infoLabel);
            nameGroupBox.Location = new Point(23, 12);
            nameGroupBox.Name = "nameGroupBox";
            nameGroupBox.Size = new Size(382, 134);
            nameGroupBox.TabIndex = 2;
            nameGroupBox.TabStop = false;
            nameGroupBox.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextBox.Location = new Point(128, 84);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(229, 20);
            nameTextBox.TabIndex = 0;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(22, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Your name, please:";
            // 
            // infoLabel
            // 
            infoLabel.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.Location = new Point(22, 33);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(335, 36);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "It seems, your result is in TOP-10. Lets save it!";
            // 
            // BestScoredPlayerNameForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(429, 224);
            Controls.Add(nameGroupBox);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BestScoredPlayerNameForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Name";
            nameGroupBox.ResumeLayout(false);
            nameGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private GroupBox nameGroupBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label infoLabel;
    }
}