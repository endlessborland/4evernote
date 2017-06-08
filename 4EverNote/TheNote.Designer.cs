namespace _4EverNote
{
    partial class TheNote
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
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.RichTextBox();
            this.creation = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.reminder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventTime = new System.Windows.Forms.DateTimePicker();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reminderText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(116, 23);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(200, 20);
            this.title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content";
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(116, 51);
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(200, 96);
            this.content.TabIndex = 4;
            this.content.Text = "";
            // 
            // creation
            // 
            this.creation.CustomFormat = "dd/MM/yyyy HH:mm";
            this.creation.Enabled = false;
            this.creation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.creation.Location = new System.Drawing.Point(116, 154);
            this.creation.Name = "creation";
            this.creation.Size = new System.Drawing.Size(200, 20);
            this.creation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Creation Time";
            // 
            // reminder
            // 
            this.reminder.CustomFormat = "dd/MM/yyyy HH:mm";
            this.reminder.Enabled = false;
            this.reminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reminder.Location = new System.Drawing.Point(116, 180);
            this.reminder.Name = "reminder";
            this.reminder.Size = new System.Drawing.Size(200, 20);
            this.reminder.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reminder Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Event Time";
            // 
            // eventTime
            // 
            this.eventTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.eventTime.Enabled = false;
            this.eventTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventTime.Location = new System.Drawing.Point(116, 206);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(200, 20);
            this.eventTime.TabIndex = 10;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(116, 232);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(200, 20);
            this.address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // reminderText
            // 
            this.reminderText.Location = new System.Drawing.Point(116, 258);
            this.reminderText.Name = "reminderText";
            this.reminderText.ReadOnly = true;
            this.reminderText.Size = new System.Drawing.Size(200, 20);
            this.reminderText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Reminder";
            // 
            // TheNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 289);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reminderText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.eventTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reminder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creation);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TheNote";
            this.Text = "TheNote";
            this.Load += new System.EventHandler(this.TheNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.DateTimePicker creation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker reminder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker eventTime;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reminderText;
        private System.Windows.Forms.Label label7;
    }
}