namespace FavoriteFoodKE
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
            this.radioChinese = new System.Windows.Forms.RadioButton();
            this.radioMexican = new System.Windows.Forms.RadioButton();
            this.radioIndian = new System.Windows.Forms.RadioButton();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My favorite food is...";
            // 
            // radioChinese
            // 
            this.radioChinese.AutoSize = true;
            this.radioChinese.Location = new System.Drawing.Point(101, 101);
            this.radioChinese.Name = "radioChinese";
            this.radioChinese.Size = new System.Drawing.Size(63, 17);
            this.radioChinese.TabIndex = 1;
            this.radioChinese.TabStop = true;
            this.radioChinese.Text = "Chinese";
            this.radioChinese.UseVisualStyleBackColor = true;
            // 
            // radioMexican
            // 
            this.radioMexican.AutoSize = true;
            this.radioMexican.Location = new System.Drawing.Point(101, 135);
            this.radioMexican.Name = "radioMexican";
            this.radioMexican.Size = new System.Drawing.Size(65, 17);
            this.radioMexican.TabIndex = 2;
            this.radioMexican.TabStop = true;
            this.radioMexican.Text = "Mexican";
            this.radioMexican.UseVisualStyleBackColor = true;
            // 
            // radioIndian
            // 
            this.radioIndian.AutoSize = true;
            this.radioIndian.Location = new System.Drawing.Point(101, 169);
            this.radioIndian.Name = "radioIndian";
            this.radioIndian.Size = new System.Drawing.Size(54, 17);
            this.radioIndian.TabIndex = 3;
            this.radioIndian.TabStop = true;
            this.radioIndian.Text = "Indian";
            this.radioIndian.UseVisualStyleBackColor = true;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(133, 260);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 4;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 355);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.radioIndian);
            this.Controls.Add(this.radioMexican);
            this.Controls.Add(this.radioChinese);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioChinese;
        private System.Windows.Forms.RadioButton radioMexican;
        private System.Windows.Forms.RadioButton radioIndian;
        private System.Windows.Forms.Button buttonChoose;
    }
}

