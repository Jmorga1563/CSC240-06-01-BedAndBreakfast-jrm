namespace CSC240_06_01_BedAndBreakfast_jrm
{
    partial class BreakfastOptionForm
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
            breakfastOptionLabel = new Label();
            contRadioButton = new RadioButton();
            fullRadioButton = new RadioButton();
            deluxeRadioButton = new RadioButton();
            priceLabel = new Label();
            SuspendLayout();
            // 
            // breakfastOptionLabel
            // 
            breakfastOptionLabel.AutoSize = true;
            breakfastOptionLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            breakfastOptionLabel.Location = new Point(96, 82);
            breakfastOptionLabel.Name = "breakfastOptionLabel";
            breakfastOptionLabel.Size = new Size(551, 55);
            breakfastOptionLabel.TabIndex = 0;
            breakfastOptionLabel.Text = "Select your breakfast option";
            // 
            // contRadioButton
            // 
            contRadioButton.AutoSize = true;
            contRadioButton.Font = new Font("Times New Roman", 12F);
            contRadioButton.Location = new Point(138, 186);
            contRadioButton.Name = "contRadioButton";
            contRadioButton.Size = new Size(284, 59);
            contRadioButton.TabIndex = 1;
            contRadioButton.TabStop = true;
            contRadioButton.Text = "Continental";
            contRadioButton.UseVisualStyleBackColor = true;
            contRadioButton.CheckedChanged += contRadioButton_CheckedChanged;
            // 
            // fullRadioButton
            // 
            fullRadioButton.AutoSize = true;
            fullRadioButton.Font = new Font("Times New Roman", 12F);
            fullRadioButton.Location = new Point(138, 281);
            fullRadioButton.Name = "fullRadioButton";
            fullRadioButton.Size = new Size(143, 59);
            fullRadioButton.TabIndex = 2;
            fullRadioButton.TabStop = true;
            fullRadioButton.Text = "Full";
            fullRadioButton.UseVisualStyleBackColor = true;
            fullRadioButton.CheckedChanged += fullRadioButton_CheckedChanged;
            // 
            // deluxeRadioButton
            // 
            deluxeRadioButton.AutoSize = true;
            deluxeRadioButton.Font = new Font("Times New Roman", 12F);
            deluxeRadioButton.Location = new Point(138, 378);
            deluxeRadioButton.Name = "deluxeRadioButton";
            deluxeRadioButton.Size = new Size(205, 59);
            deluxeRadioButton.TabIndex = 3;
            deluxeRadioButton.TabStop = true;
            deluxeRadioButton.Text = "Deluxe";
            deluxeRadioButton.UseVisualStyleBackColor = true;
            deluxeRadioButton.CheckedChanged += deluxeRadioButton_CheckedChanged;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(339, 505);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(172, 63);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(794, 706);
            Controls.Add(priceLabel);
            Controls.Add(deluxeRadioButton);
            Controls.Add(fullRadioButton);
            Controls.Add(contRadioButton);
            Controls.Add(breakfastOptionLabel);
            Name = "BreakfastOptionForm";
            Text = "BreakfastOptionForm";
            Load += BreakfastOptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label breakfastOptionLabel;
        private RadioButton contRadioButton;
        private RadioButton fullRadioButton;
        private RadioButton deluxeRadioButton;
        private Label priceLabel;
    }
}