namespace GuessMyNumber
{
    partial class Form1
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
            this.guessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.upDownLabel = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guessUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(324, 350);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(125, 34);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess my number!";
            // 
            // guessUpDown
            // 
            this.guessUpDown.Location = new System.Drawing.Point(349, 280);
            this.guessUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.guessUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guessUpDown.Name = "guessUpDown";
            this.guessUpDown.Size = new System.Drawing.Size(78, 20);
            this.guessUpDown.TabIndex = 2;
            this.guessUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "My number is between 1 and 10.";
            // 
            // upDownLabel
            // 
            this.upDownLabel.AutoSize = true;
            this.upDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownLabel.Location = new System.Drawing.Point(356, 237);
            this.upDownLabel.Name = "upDownLabel";
            this.upDownLabel.Size = new System.Drawing.Size(71, 25);
            this.upDownLabel.TabIndex = 4;
            this.upDownLabel.Text = "shhhh";
            this.upDownLabel.Visible = false;
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Location = new System.Drawing.Point(324, 409);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(125, 13);
            this.guessesLabel.TabIndex = 5;
            this.guessesLabel.Text = "You have three guesses.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.upDownLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guessUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessButton);
            this.Name = "Form1";
            this.Text = "Guess My Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guessUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown guessUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label upDownLabel;
        private System.Windows.Forms.Label guessesLabel;
    }
}

