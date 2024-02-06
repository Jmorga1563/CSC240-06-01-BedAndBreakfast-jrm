namespace CSC240_06_01_BedAndBreakfast_jrm
{
    partial class LincolnForm
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
            lincolnDescriptionLabel = new Label();
            lincolnPriceLabel = new Label();
            lincolnPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lincolnPictureBox).BeginInit();
            SuspendLayout();
            // 
            // lincolnDescriptionLabel
            // 
            lincolnDescriptionLabel.AutoSize = true;
            lincolnDescriptionLabel.Location = new Point(75, 45);
            lincolnDescriptionLabel.Name = "lincolnDescriptionLabel";
            lincolnDescriptionLabel.Size = new Size(651, 96);
            lincolnDescriptionLabel.TabIndex = 0;
            lincolnDescriptionLabel.Text = "Return to the 1850's in this lovely room \r\nwith private bath.";
            // 
            // lincolnPriceLabel
            // 
            lincolnPriceLabel.AutoSize = true;
            lincolnPriceLabel.Location = new Point(475, 214);
            lincolnPriceLabel.Name = "lincolnPriceLabel";
            lincolnPriceLabel.Size = new Size(251, 48);
            lincolnPriceLabel.TabIndex = 1;
            lincolnPriceLabel.Text = "$110 per night";
            // 
            // lincolnPictureBox
            // 
            lincolnPictureBox.Image = Properties.Resources.AbeLincoln;
            lincolnPictureBox.Location = new Point(75, 214);
            lincolnPictureBox.Name = "lincolnPictureBox";
            lincolnPictureBox.Size = new Size(337, 342);
            lincolnPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            lincolnPictureBox.TabIndex = 2;
            lincolnPictureBox.TabStop = false;
            // 
            // LincolnForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 634);
            Controls.Add(lincolnPictureBox);
            Controls.Add(lincolnPriceLabel);
            Controls.Add(lincolnDescriptionLabel);
            Name = "LincolnForm";
            Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)lincolnPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lincolnDescriptionLabel;
        private Label lincolnPriceLabel;
        private PictureBox lincolnPictureBox;
    }
}