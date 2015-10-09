namespace BrahmLab2
{
    partial class StudentTrackerForm
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
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.inputStudentIDTextBox = new System.Windows.Forms.TextBox();
            this.inputStudentNameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentIDAndNameButton = new System.Windows.Forms.Button();
            this.deleteAllRecordsButton = new System.Windows.Forms.Button();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.searchWithStudentIDButton = new System.Windows.Forms.Button();
            this.clearDisplayScreenButton = new System.Windows.Forms.Button();
            this.displayAllButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel.Location = new System.Drawing.Point(49, 38);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(82, 16);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "STUDENT ID:";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(49, 79);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(108, 16);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "STUDENT NAME:";
            // 
            // inputStudentIDTextBox
            // 
            this.inputStudentIDTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStudentIDTextBox.Location = new System.Drawing.Point(181, 35);
            this.inputStudentIDTextBox.Name = "inputStudentIDTextBox";
            this.inputStudentIDTextBox.Size = new System.Drawing.Size(182, 23);
            this.inputStudentIDTextBox.TabIndex = 2;
            this.inputStudentIDTextBox.Text = "Enter Student ID";
            // 
            // inputStudentNameTextBox
            // 
            this.inputStudentNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStudentNameTextBox.Location = new System.Drawing.Point(181, 76);
            this.inputStudentNameTextBox.Name = "inputStudentNameTextBox";
            this.inputStudentNameTextBox.Size = new System.Drawing.Size(182, 23);
            this.inputStudentNameTextBox.TabIndex = 3;
            this.inputStudentNameTextBox.Text = "Enter Student _name";
            // 
            // addStudentIDAndNameButton
            // 
            this.addStudentIDAndNameButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentIDAndNameButton.Location = new System.Drawing.Point(52, 119);
            this.addStudentIDAndNameButton.Name = "addStudentIDAndNameButton";
            this.addStudentIDAndNameButton.Size = new System.Drawing.Size(124, 47);
            this.addStudentIDAndNameButton.TabIndex = 4;
            this.addStudentIDAndNameButton.Text = "ADD STUDENT ID and NAME";
            this.addStudentIDAndNameButton.UseVisualStyleBackColor = true;
            this.addStudentIDAndNameButton.Click += new System.EventHandler(this.addStudentIDAndNameButton_Click);
            // 
            // deleteAllRecordsButton
            // 
            this.deleteAllRecordsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllRecordsButton.Location = new System.Drawing.Point(52, 186);
            this.deleteAllRecordsButton.Name = "deleteAllRecordsButton";
            this.deleteAllRecordsButton.Size = new System.Drawing.Size(124, 46);
            this.deleteAllRecordsButton.TabIndex = 5;
            this.deleteAllRecordsButton.Text = "DELETE ALL RECORDS";
            this.deleteAllRecordsButton.UseVisualStyleBackColor = true;
            this.deleteAllRecordsButton.Click += new System.EventHandler(this.deleteAllRecordsButton_Click);
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordButton.Location = new System.Drawing.Point(249, 119);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(114, 47);
            this.deleteRecordButton.TabIndex = 6;
            this.deleteRecordButton.Text = "DELETE RECORD";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordButton_Click);
            // 
            // searchWithStudentIDButton
            // 
            this.searchWithStudentIDButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWithStudentIDButton.Location = new System.Drawing.Point(249, 185);
            this.searchWithStudentIDButton.Name = "searchWithStudentIDButton";
            this.searchWithStudentIDButton.Size = new System.Drawing.Size(114, 47);
            this.searchWithStudentIDButton.TabIndex = 7;
            this.searchWithStudentIDButton.Text = "SEARCH with STUDENT ID";
            this.searchWithStudentIDButton.UseVisualStyleBackColor = true;
            this.searchWithStudentIDButton.Click += new System.EventHandler(this.searchWithStudentIDButton_Click);
            // 
            // clearDisplayScreenButton
            // 
            this.clearDisplayScreenButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDisplayScreenButton.Location = new System.Drawing.Point(52, 249);
            this.clearDisplayScreenButton.Name = "clearDisplayScreenButton";
            this.clearDisplayScreenButton.Size = new System.Drawing.Size(311, 23);
            this.clearDisplayScreenButton.TabIndex = 8;
            this.clearDisplayScreenButton.Text = "CLEAR DISPLAY SCREEN";
            this.clearDisplayScreenButton.UseVisualStyleBackColor = true;
            this.clearDisplayScreenButton.Click += new System.EventHandler(this.clearDisplayScreenButton_Click);
            // 
            // displayAllButton
            // 
            this.displayAllButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllButton.Location = new System.Drawing.Point(52, 293);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(311, 23);
            this.displayAllButton.TabIndex = 9;
            this.displayAllButton.Text = "DISPLAY ALL";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(172, 353);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(66, 39);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // StudentTrackerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 428);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.displayAllButton);
            this.Controls.Add(this.clearDisplayScreenButton);
            this.Controls.Add(this.searchWithStudentIDButton);
            this.Controls.Add(this.deleteRecordButton);
            this.Controls.Add(this.deleteAllRecordsButton);
            this.Controls.Add(this.addStudentIDAndNameButton);
            this.Controls.Add(this.inputStudentNameTextBox);
            this.Controls.Add(this.inputStudentIDTextBox);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentTrackerUI";
            this.Text = "CENTENNIAL COLLEGE STUDENT TRACKER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.TextBox inputStudentIDTextBox;
        private System.Windows.Forms.TextBox inputStudentNameTextBox;
        private System.Windows.Forms.Button addStudentIDAndNameButton;
        private System.Windows.Forms.Button deleteAllRecordsButton;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button searchWithStudentIDButton;
        private System.Windows.Forms.Button clearDisplayScreenButton;
        private System.Windows.Forms.Button displayAllButton;
        private System.Windows.Forms.Button quitButton;
    }
}

