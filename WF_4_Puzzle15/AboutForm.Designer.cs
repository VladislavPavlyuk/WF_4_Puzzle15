namespace WF_4_Puzzle15
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            buttonOk = new Button();
            groupBox = new GroupBox();
            pictureBoxLogo = new PictureBox();
            labelProductName = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(42, 247);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 36);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(pictureBoxLogo);
            groupBox.Controls.Add(labelProductName);
            groupBox.Location = new Point(24, 21);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(151, 220);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(6, 74);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(139, 140);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductName.Location = new Point(7, 16);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(138, 37);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Puzzle 15";
            // 
            // AboutForm
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonOk;
            ClientSize = new Size(204, 311);
            Controls.Add(groupBox);
            Controls.Add(buttonOk);
            Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private GroupBox groupBox;
        private PictureBox pictureBoxLogo;
        private Label labelProductName;
    }
}