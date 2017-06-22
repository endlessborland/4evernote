namespace _4EverNote
{
    partial class NoteWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteWindow));
            this.saveButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.reminderBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.eventSet = new System.Windows.Forms.CheckBox();
            this.reminderSet = new System.Windows.Forms.CheckBox();
            this.reminderTime = new System.Windows.Forms.DateTimePicker();
            this.eventTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createdTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 557);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(340, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 29);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(340, 20);
            this.titleBox.TabIndex = 2;
            this.titleBox.Text = "Title";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(12, 84);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(340, 96);
            this.contentBox.TabIndex = 3;
            this.contentBox.Text = "Content";
            // 
            // reminderBox
            // 
            this.reminderBox.Location = new System.Drawing.Point(12, 226);
            this.reminderBox.Name = "reminderBox";
            this.reminderBox.Size = new System.Drawing.Size(340, 20);
            this.reminderBox.TabIndex = 4;
            this.reminderBox.Text = "Reminder";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(12, 283);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(340, 20);
            this.addressBox.TabIndex = 7;
            this.addressBox.Text = "Address";
            // 
            // eventSet
            // 
            this.eventSet.AutoSize = true;
            this.eventSet.Checked = true;
            this.eventSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eventSet.Location = new System.Drawing.Point(241, 315);
            this.eventSet.Name = "eventSet";
            this.eventSet.Size = new System.Drawing.Size(15, 14);
            this.eventSet.TabIndex = 15;
            this.eventSet.UseVisualStyleBackColor = true;
            this.eventSet.CheckedChanged += new System.EventHandler(this.eventSet_CheckedChanged);
            // 
            // reminderSet
            // 
            this.reminderSet.AutoSize = true;
            this.reminderSet.Checked = true;
            this.reminderSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reminderSet.Location = new System.Drawing.Point(241, 361);
            this.reminderSet.Name = "reminderSet";
            this.reminderSet.Size = new System.Drawing.Size(15, 14);
            this.reminderSet.TabIndex = 14;
            this.reminderSet.UseVisualStyleBackColor = true;
            this.reminderSet.CheckedChanged += new System.EventHandler(this.reminderSet_CheckedChanged);
            // 
            // reminderTime
            // 
            this.reminderTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.reminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reminderTime.Location = new System.Drawing.Point(12, 377);
            this.reminderTime.Name = "reminderTime";
            this.reminderTime.Size = new System.Drawing.Size(340, 20);
            this.reminderTime.TabIndex = 13;
            this.reminderTime.Value = new System.DateTime(2017, 6, 21, 21, 32, 12, 0);
            // 
            // eventTime
            // 
            this.eventTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.eventTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventTime.Location = new System.Drawing.Point(12, 331);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(340, 20);
            this.eventTime.TabIndex = 12;
            this.eventTime.Value = new System.DateTime(2017, 6, 21, 21, 32, 12, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Reminder TIme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Event Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reminder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // createdTime
            // 
            this.createdTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.createdTime.Enabled = false;
            this.createdTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createdTime.Location = new System.Drawing.Point(12, 426);
            this.createdTime.Name = "createdTime";
            this.createdTime.Size = new System.Drawing.Size(340, 20);
            this.createdTime.TabIndex = 22;
            this.createdTime.Value = new System.DateTime(2017, 6, 21, 21, 32, 12, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Created:";
            // 
            // NoteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 592);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.createdTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventSet);
            this.Controls.Add(this.reminderSet);
            this.Controls.Add(this.reminderTime);
            this.Controls.Add(this.eventTime);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.reminderBox);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteWindow";
            this.Text = "NoteWindow";
            this.Load += new System.EventHandler(this.NoteWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.TextBox reminderBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox eventSet;
        private System.Windows.Forms.CheckBox reminderSet;
        private System.Windows.Forms.DateTimePicker reminderTime;
        private System.Windows.Forms.DateTimePicker eventTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker createdTime;
        private System.Windows.Forms.Label label7;
    }
}