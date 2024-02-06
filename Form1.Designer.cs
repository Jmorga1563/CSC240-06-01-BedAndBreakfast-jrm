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
            belleAireCheckbox = new CheckBox();
            lincolnCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(86, 67);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(701, 82);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to Bailey's";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rateLabel.Location = new Point(156, 188);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(484, 73);
            rateLabel.TabIndex = 1;
            rateLabel.Text = "Check our rates";
            // 
            // belleAireCheckbox
            // 
            belleAireCheckbox.AutoSize = true;
            belleAireCheckbox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            belleAireCheckbox.Location = new Point(168, 352);
            belleAireCheckbox.Name = "belleAireCheckbox";
            belleAireCheckbox.Size = new Size(472, 68);
            belleAireCheckbox.TabIndex = 2;
            belleAireCheckbox.Text = "Belle Aire Suite";
            belleAireCheckbox.UseVisualStyleBackColor = true;
            belleAireCheckbox.CheckedChanged += BelleAireCheckbox_CheckedChanged;
            // 
            // lincolnCheckBox
            // 
            lincolnCheckBox.AutoSize = true;
            lincolnCheckBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lincolnCheckBox.Location = new Point(168, 448);
            lincolnCheckBox.Name = "lincolnCheckBox";
            lincolnCheckBox.Size = new Size(427, 68);
            lincolnCheckBox.TabIndex = 3;
            lincolnCheckBox.Text = "Lincoln Room";
            lincolnCheckBox.UseVisualStyleBackColor = true;
            lincolnCheckBox.CheckedChanged += LincolnCheckBox_CheckedChanged;
            // 
            // BaileysForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(871, 687);
            Controls.Add(lincolnCheckBox);
            Controls.Add(belleAireCheckbox);
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
        private CheckBox belleAireCheckbox;
        private CheckBox lincolnCheckBox;
    }
}
