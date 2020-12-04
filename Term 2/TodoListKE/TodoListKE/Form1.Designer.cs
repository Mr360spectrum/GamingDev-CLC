
namespace TodoListKE
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
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.ToDoListBox = new System.Windows.Forms.ListBox();
            this.AddFrontButton = new System.Windows.Forms.Button();
            this.AddBackButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a to-do item:";
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(28, 51);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(229, 20);
            this.ItemTextBox.TabIndex = 1;
            // 
            // ToDoListBox
            // 
            this.ToDoListBox.FormattingEnabled = true;
            this.ToDoListBox.Location = new System.Drawing.Point(28, 98);
            this.ToDoListBox.Name = "ToDoListBox";
            this.ToDoListBox.Size = new System.Drawing.Size(148, 121);
            this.ToDoListBox.TabIndex = 2;
            this.ToDoListBox.SelectedIndexChanged += new System.EventHandler(this.ToDoListBox_SelectedIndexChanged);
            // 
            // AddFrontButton
            // 
            this.AddFrontButton.Location = new System.Drawing.Point(182, 98);
            this.AddFrontButton.Name = "AddFrontButton";
            this.AddFrontButton.Size = new System.Drawing.Size(75, 23);
            this.AddFrontButton.TabIndex = 3;
            this.AddFrontButton.Text = "Add Front";
            this.AddFrontButton.UseVisualStyleBackColor = true;
            this.AddFrontButton.Click += new System.EventHandler(this.AddFrontButton_Click);
            // 
            // AddBackButton
            // 
            this.AddBackButton.Location = new System.Drawing.Point(183, 128);
            this.AddBackButton.Name = "AddBackButton";
            this.AddBackButton.Size = new System.Drawing.Size(75, 23);
            this.AddBackButton.TabIndex = 4;
            this.AddBackButton.Text = "Add Back";
            this.AddBackButton.UseVisualStyleBackColor = true;
            this.AddBackButton.Click += new System.EventHandler(this.AddBackButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(183, 158);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(182, 188);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 252);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddBackButton);
            this.Controls.Add(this.AddFrontButton);
            this.Controls.Add(this.ToDoListBox);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.ListBox ToDoListBox;
        private System.Windows.Forms.Button AddFrontButton;
        private System.Windows.Forms.Button AddBackButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

