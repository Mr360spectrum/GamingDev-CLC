
namespace FindBirthdayKE
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericMonth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter month:";
            // 
            // numericMonth
            // 
            this.numericMonth.Location = new System.Drawing.Point(122, 46);
            this.numericMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMonth.Name = "numericMonth";
            this.numericMonth.Size = new System.Drawing.Size(49, 20);
            this.numericMonth.TabIndex = 1;
            this.numericMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter day:";
            // 
            // numericDay
            // 
            this.numericDay.Location = new System.Drawing.Point(122, 84);
            this.numericDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDay.Name = "numericDay";
            this.numericDay.Size = new System.Drawing.Size(49, 20);
            this.numericDay.TabIndex = 3;
            this.numericDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter year:";
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(108, 127);
            this.numericYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(63, 20);
            this.numericYear.TabIndex = 5;
            this.numericYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(29, 171);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(134, 23);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "What day was I born?";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 215);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericMonth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Button FindButton;
    }
}

