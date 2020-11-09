namespace AlgorithmTest
{
    partial class AlgorithmTest
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
            this.MagicNumberButton = new System.Windows.Forms.Button();
            this.ConvertGradeButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MagicNumberButton
            // 
            this.MagicNumberButton.Location = new System.Drawing.Point(54, 30);
            this.MagicNumberButton.Name = "MagicNumberButton";
            this.MagicNumberButton.Size = new System.Drawing.Size(174, 45);
            this.MagicNumberButton.TabIndex = 0;
            this.MagicNumberButton.Text = "What\'s the Magic Number?";
            this.MagicNumberButton.UseVisualStyleBackColor = true;
            this.MagicNumberButton.Click += new System.EventHandler(this.MagicNumberButton_Click);
            // 
            // ConvertGradeButton
            // 
            this.ConvertGradeButton.Location = new System.Drawing.Point(54, 190);
            this.ConvertGradeButton.Name = "ConvertGradeButton";
            this.ConvertGradeButton.Size = new System.Drawing.Size(174, 42);
            this.ConvertGradeButton.TabIndex = 1;
            this.ConvertGradeButton.Text = "Convert to Letter Grade";
            this.ConvertGradeButton.UseVisualStyleBackColor = true;
            this.ConvertGradeButton.Click += new System.EventHandler(this.ConvertGradeButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(54, 164);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(174, 20);
            this.userTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your numeric grade:";
            // 
            // AlgorithmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.ConvertGradeButton);
            this.Controls.Add(this.MagicNumberButton);
            this.Name = "AlgorithmTest";
            this.Text = "Algorithm Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MagicNumberButton;
        private System.Windows.Forms.Button ConvertGradeButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
    }
}

