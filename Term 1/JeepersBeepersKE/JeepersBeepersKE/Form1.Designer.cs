namespace JeepersBeepersKE
{
    partial class jeepBeepForm
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
            this.DoButton = new System.Windows.Forms.Button();
            this.WhileButton = new System.Windows.Forms.Button();
            this.ForButton = new System.Windows.Forms.Button();
            this.NumBeepsLabel = new System.Windows.Forms.Label();
            this.NumBeepsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoButton
            // 
            this.DoButton.Location = new System.Drawing.Point(95, 235);
            this.DoButton.Name = "DoButton";
            this.DoButton.Size = new System.Drawing.Size(110, 23);
            this.DoButton.TabIndex = 0;
            this.DoButton.Text = "Do Loop Beep";
            this.DoButton.UseVisualStyleBackColor = true;
            this.DoButton.Click += new System.EventHandler(this.DoButton_Click);
            // 
            // WhileButton
            // 
            this.WhileButton.Location = new System.Drawing.Point(95, 188);
            this.WhileButton.Name = "WhileButton";
            this.WhileButton.Size = new System.Drawing.Size(110, 23);
            this.WhileButton.TabIndex = 1;
            this.WhileButton.Text = "While Loop Beep";
            this.WhileButton.UseVisualStyleBackColor = true;
            this.WhileButton.Click += new System.EventHandler(this.WhileButton_Click);
            // 
            // ForButton
            // 
            this.ForButton.Location = new System.Drawing.Point(95, 137);
            this.ForButton.Name = "ForButton";
            this.ForButton.Size = new System.Drawing.Size(110, 23);
            this.ForButton.TabIndex = 2;
            this.ForButton.Text = "For Loop Beep";
            this.ForButton.UseVisualStyleBackColor = true;
            this.ForButton.Click += new System.EventHandler(this.ForButton_Click);
            // 
            // NumBeepsLabel
            // 
            this.NumBeepsLabel.AutoSize = true;
            this.NumBeepsLabel.Location = new System.Drawing.Point(66, 68);
            this.NumBeepsLabel.Name = "NumBeepsLabel";
            this.NumBeepsLabel.Size = new System.Drawing.Size(92, 13);
            this.NumBeepsLabel.TabIndex = 3;
            this.NumBeepsLabel.Text = "Number of Beeps:";
            // 
            // NumBeepsText
            // 
            this.NumBeepsText.Location = new System.Drawing.Point(180, 65);
            this.NumBeepsText.Name = "NumBeepsText";
            this.NumBeepsText.Size = new System.Drawing.Size(47, 20);
            this.NumBeepsText.TabIndex = 4;
            // 
            // jeepBeepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 288);
            this.Controls.Add(this.NumBeepsText);
            this.Controls.Add(this.NumBeepsLabel);
            this.Controls.Add(this.ForButton);
            this.Controls.Add(this.WhileButton);
            this.Controls.Add(this.DoButton);
            this.Name = "jeepBeepForm";
            this.Text = "Jeepers, Beepers!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoButton;
        private System.Windows.Forms.Button WhileButton;
        private System.Windows.Forms.Button ForButton;
        private System.Windows.Forms.Label NumBeepsLabel;
        private System.Windows.Forms.TextBox NumBeepsText;
    }
}

