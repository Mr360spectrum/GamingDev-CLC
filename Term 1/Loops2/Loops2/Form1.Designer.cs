namespace Loops2
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
            this.runBttn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runBttn
            // 
            this.runBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBttn.Location = new System.Drawing.Point(339, 342);
            this.runBttn.Name = "runBttn";
            this.runBttn.Size = new System.Drawing.Size(104, 42);
            this.runBttn.TabIndex = 0;
            this.runBttn.Text = "Run";
            this.runBttn.UseVisualStyleBackColor = true;
            this.runBttn.Click += new System.EventHandler(this.runBttn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(317, 79);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(152, 55);
            this.outputLbl.TabIndex = 1;
            this.outputLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.runBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBttn;
        private System.Windows.Forms.Label outputLbl;
    }
}

