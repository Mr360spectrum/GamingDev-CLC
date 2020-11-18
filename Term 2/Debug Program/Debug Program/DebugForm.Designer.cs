namespace Debug_Program
{
    partial class DebugForm
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
            this.ErrorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MondayRadio = new System.Windows.Forms.RadioButton();
            this.NoMondayRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(75, 154);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(119, 23);
            this.ErrorButton.TabIndex = 0;
            this.ErrorButton.Text = "Check Your Answer";
            this.ErrorButton.UseVisualStyleBackColor = true;
            this.ErrorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is today?";
            // 
            // MondayRadio
            // 
            this.MondayRadio.AutoSize = true;
            this.MondayRadio.Checked = true;
            this.MondayRadio.Location = new System.Drawing.Point(75, 74);
            this.MondayRadio.Name = "MondayRadio";
            this.MondayRadio.Size = new System.Drawing.Size(109, 17);
            this.MondayRadio.TabIndex = 2;
            this.MondayRadio.TabStop = true;
            this.MondayRadio.Text = "Today is Monday!";
            this.MondayRadio.UseVisualStyleBackColor = true;
            // 
            // NoMondayRadio
            // 
            this.NoMondayRadio.AutoSize = true;
            this.NoMondayRadio.Location = new System.Drawing.Point(75, 107);
            this.NoMondayRadio.Name = "NoMondayRadio";
            this.NoMondayRadio.Size = new System.Drawing.Size(127, 17);
            this.NoMondayRadio.TabIndex = 3;
            this.NoMondayRadio.TabStop = true;
            this.NoMondayRadio.Text = "Today is not Monday.";
            this.NoMondayRadio.UseVisualStyleBackColor = true;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 195);
            this.Controls.Add(this.NoMondayRadio);
            this.Controls.Add(this.MondayRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorButton);
            this.Name = "DebugForm";
            this.Text = "Debug Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MondayRadio;
        private System.Windows.Forms.RadioButton NoMondayRadio;
    }
}

