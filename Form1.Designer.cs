namespace CSC240_06_01_BedAndBreakfast_jrm
{
    partial class BaileysForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            rateLabel = new Label();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(63, 67);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(701, 82);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Bailey's";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateLabel.Location = new Point(156, 172);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(484, 73);
            rateLabel.TabIndex = 1;
            rateLabel.Text = "Check our rates";
            // 
            // BaileysForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(871, 687);
            Controls.Add(rateLabel);
            Controls.Add(welcomeLabel);
            Name = "BaileysForm";
            Text = "Bailey's Bed and Breakfast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label rateLabel;
    }
}
