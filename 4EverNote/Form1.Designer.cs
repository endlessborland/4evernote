namespace _4EverNote
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
            this.components = new System.ComponentModel.Container();
            this.exit = new System.Windows.Forms.Button();
            this.addNote = new System.Windows.Forms.Button();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.reminderbox = new System.Windows.Forms.TextBox();
            this.contentbox = new System.Windows.Forms.RichTextBox();
            this.eventTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reminderTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.isEventTime = new System.Windows.Forms.CheckBox();
            this.isReminderTime = new System.Windows.Forms.CheckBox();
            this.isAddress = new System.Windows.Forms.CheckBox();
            this.isReminder = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 510);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(750, 26);
            this.exit.TabIndex = 0;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(598, 457);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(75, 23);
            this.addNote.TabIndex = 2;
            this.addNote.Text = "Add Note";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(513, 12);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(249, 20);
            this.titlebox.TabIndex = 3;
            this.titlebox.Text = "Title";
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(513, 158);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(249, 20);
            this.addressbox.TabIndex = 5;
            this.addressbox.Text = "Address";
            // 
            // reminderbox
            // 
            this.reminderbox.Location = new System.Drawing.Point(513, 184);
            this.reminderbox.Name = "reminderbox";
            this.reminderbox.Size = new System.Drawing.Size(249, 20);
            this.reminderbox.TabIndex = 6;
            this.reminderbox.Text = "Reminder";
            // 
            // contentbox
            // 
            this.contentbox.Location = new System.Drawing.Point(513, 38);
            this.contentbox.Name = "contentbox";
            this.contentbox.Size = new System.Drawing.Size(249, 114);
            this.contentbox.TabIndex = 7;
            this.contentbox.Text = "Content";
            // 
            // eventTime
            // 
            this.eventTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.eventTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventTime.Location = new System.Drawing.Point(513, 210);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(145, 20);
            this.eventTime.TabIndex = 8;
            this.eventTime.Value = new System.DateTime(2017, 6, 7, 16, 12, 8, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "EventTime";
            // 
            // reminderTime
            // 
            this.reminderTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.reminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reminderTime.Location = new System.Drawing.Point(513, 236);
            this.reminderTime.Name = "reminderTime";
            this.reminderTime.Size = new System.Drawing.Size(145, 20);
            this.reminderTime.TabIndex = 10;
            this.reminderTime.Value = new System.DateTime(2017, 6, 7, 16, 12, 8, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ReminderTime";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.title,
            this.EventDate,
            this.Content});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(495, 492);
            this.dataGrid.TabIndex = 14;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // Number
            // 
            this.Number.FillWeight = 30F;
            this.Number.HeaderText = "No.";
            this.Number.Name = "Number";
            this.Number.Width = 30;
            // 
            // title
            // 
            this.title.FillWeight = 150F;
            this.title.HeaderText = "Name";
            this.title.Name = "title";
            this.title.Width = 150;
            // 
            // EventDate
            // 
            this.EventDate.HeaderText = "Date";
            this.EventDate.Name = "EventDate";
            // 
            // Content
            // 
            this.Content.FillWeight = 170F;
            this.Content.HeaderText = "Text";
            this.Content.Name = "Content";
            this.Content.Width = 170;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(598, 428);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 15;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(598, 399);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // isEventTime
            // 
            this.isEventTime.AutoSize = true;
            this.isEventTime.Checked = true;
            this.isEventTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isEventTime.Location = new System.Drawing.Point(768, 216);
            this.isEventTime.Name = "isEventTime";
            this.isEventTime.Size = new System.Drawing.Size(15, 14);
            this.isEventTime.TabIndex = 17;
            this.isEventTime.UseVisualStyleBackColor = true;
            this.isEventTime.CheckedChanged += new System.EventHandler(this.isEventTime_CheckedChanged);
            // 
            // isReminderTime
            // 
            this.isReminderTime.AutoSize = true;
            this.isReminderTime.Checked = true;
            this.isReminderTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isReminderTime.Location = new System.Drawing.Point(768, 242);
            this.isReminderTime.Name = "isReminderTime";
            this.isReminderTime.Size = new System.Drawing.Size(15, 14);
            this.isReminderTime.TabIndex = 18;
            this.isReminderTime.UseVisualStyleBackColor = true;
            this.isReminderTime.CheckedChanged += new System.EventHandler(this.isReminderTime_CheckedChanged);
            // 
            // isAddress
            // 
            this.isAddress.AutoSize = true;
            this.isAddress.Checked = true;
            this.isAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAddress.Location = new System.Drawing.Point(768, 161);
            this.isAddress.Name = "isAddress";
            this.isAddress.Size = new System.Drawing.Size(15, 14);
            this.isAddress.TabIndex = 20;
            this.isAddress.UseVisualStyleBackColor = true;
            this.isAddress.CheckedChanged += new System.EventHandler(this.isAddress_CheckedChanged);
            // 
            // isReminder
            // 
            this.isReminder.AutoSize = true;
            this.isReminder.Checked = true;
            this.isReminder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isReminder.Location = new System.Drawing.Point(768, 187);
            this.isReminder.Name = "isReminder";
            this.isReminder.Size = new System.Drawing.Size(15, 14);
            this.isReminder.TabIndex = 21;
            this.isReminder.UseVisualStyleBackColor = true;
            this.isReminder.CheckedChanged += new System.EventHandler(this.isReminder_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 548);
            this.Controls.Add(this.isReminder);
            this.Controls.Add(this.isAddress);
            this.Controls.Add(this.isReminderTime);
            this.Controls.Add(this.isEventTime);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reminderTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventTime);
            this.Controls.Add(this.contentbox);
            this.Controls.Add(this.reminderbox);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "4EverNote";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.TextBox reminderbox;
        private System.Windows.Forms.RichTextBox contentbox;
        private System.Windows.Forms.DateTimePicker eventTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker reminderTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox isEventTime;
        private System.Windows.Forms.CheckBox isReminderTime;
        private System.Windows.Forms.CheckBox isAddress;
        private System.Windows.Forms.CheckBox isReminder;
        private System.Windows.Forms.Timer timer1;
    }
}

