namespace Windows_GUI
{
    partial class StartPage
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
            this.creatorName = new System.Windows.Forms.Label();
            this.createdBy = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameMessage = new System.Windows.Forms.Label();
            this.ageSpn = new System.Windows.Forms.NumericUpDown();
            this.ageLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.genderM = new System.Windows.Forms.RadioButton();
            this.genderF = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.siblingListBox = new System.Windows.Forms.ListBox();
            this.exampleComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ageSpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // creatorName
            // 
            this.creatorName.AutoSize = true;
            this.creatorName.Location = new System.Drawing.Point(72, 428);
            this.creatorName.Name = "creatorName";
            this.creatorName.Size = new System.Drawing.Size(77, 13);
            this.creatorName.TabIndex = 0;
            this.creatorName.Text = "Karter D. Ence";
            this.creatorName.Click += new System.EventHandler(this.creatorName_Click);
            // 
            // createdBy
            // 
            this.createdBy.AutoSize = true;
            this.createdBy.Location = new System.Drawing.Point(12, 428);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(61, 13);
            this.createdBy.TabIndex = 1;
            this.createdBy.Text = "Created by:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(121, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "\r\nEnter name here";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameMessage
            // 
            this.nameMessage.AutoSize = true;
            this.nameMessage.Location = new System.Drawing.Point(12, 9);
            this.nameMessage.Name = "nameMessage";
            this.nameMessage.Size = new System.Drawing.Size(103, 13);
            this.nameMessage.TabIndex = 3;
            this.nameMessage.Text = "Enter your full name:";
            // 
            // ageSpn
            // 
            this.ageSpn.Location = new System.Drawing.Point(121, 43);
            this.ageSpn.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ageSpn.Name = "ageSpn";
            this.ageSpn.Size = new System.Drawing.Size(65, 20);
            this.ageSpn.TabIndex = 4;
            this.ageSpn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ageSpn.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ageLabel.Location = new System.Drawing.Point(12, 45);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(79, 13);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Enter your age:";
            // 
            // submitButton
            // 
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitButton.Location = new System.Drawing.Point(253, 408);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(275, 33);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(121, 81);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(204, 20);
            this.birthdayPicker.TabIndex = 8;
            this.birthdayPicker.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your birthday:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // genderM
            // 
            this.genderM.AutoSize = true;
            this.genderM.Location = new System.Drawing.Point(508, 5);
            this.genderM.Name = "genderM";
            this.genderM.Size = new System.Drawing.Size(48, 17);
            this.genderM.TabIndex = 10;
            this.genderM.TabStop = true;
            this.genderM.Text = "Male";
            this.genderM.UseVisualStyleBackColor = true;
            // 
            // genderF
            // 
            this.genderF.AutoSize = true;
            this.genderF.Location = new System.Drawing.Point(508, 29);
            this.genderF.Name = "genderF";
            this.genderF.Size = new System.Drawing.Size(59, 17);
            this.genderF.TabIndex = 11;
            this.genderF.TabStop = true;
            this.genderF.Text = "Female";
            this.genderF.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(453, 20);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 12;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // siblingListBox
            // 
            this.siblingListBox.FormattingEnabled = true;
            this.siblingListBox.Items.AddRange(new object[] {
            "Brother 1",
            "Brother 2",
            "Brother 3",
            "Brother 4",
            "Brother 5"});
            this.siblingListBox.Location = new System.Drawing.Point(121, 122);
            this.siblingListBox.Name = "siblingListBox";
            this.siblingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.siblingListBox.Size = new System.Drawing.Size(120, 95);
            this.siblingListBox.TabIndex = 13;
            // 
            // exampleComboBox
            // 
            this.exampleComboBox.FormattingEnabled = true;
            this.exampleComboBox.Items.AddRange(new object[] {
            "Test 1",
            "Test 2",
            "Test 3",
            "Test 4",
            "Test 5",
            "Test 6",
            "Test 7",
            "Test 8",
            "Test 9"});
            this.exampleComboBox.Location = new System.Drawing.Point(253, 122);
            this.exampleComboBox.Name = "exampleComboBox";
            this.exampleComboBox.Size = new System.Drawing.Size(245, 21);
            this.exampleComboBox.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(287, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(287, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(287, 246);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(287, 269);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(398, 223);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(158, 127);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(588, 418);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(157, 23);
            this.progressBar.TabIndex = 20;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 451);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.exampleComboBox);
            this.Controls.Add(this.siblingListBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.genderF);
            this.Controls.Add(this.genderM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageSpn);
            this.Controls.Add(this.nameMessage);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.creatorName);
            this.Name = "StartPage";
            this.Text = "Start Page";
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageSpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creatorName;
        private System.Windows.Forms.Label createdBy;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameMessage;
        private System.Windows.Forms.NumericUpDown ageSpn;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton genderM;
        private System.Windows.Forms.RadioButton genderF;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ListBox siblingListBox;
        private System.Windows.Forms.ComboBox exampleComboBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

