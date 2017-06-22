namespace _4EverNote
{
    partial class MainWindow
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.reminderBox = new System.Windows.Forms.TextBox();
            this.eventTime = new System.Windows.Forms.DateTimePicker();
            this.reminderTime = new System.Windows.Forms.DateTimePicker();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reminderSet = new System.Windows.Forms.CheckBox();
            this.eventSet = new System.Windows.Forms.CheckBox();
            this.exit = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Time,
            this.Content});
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(481, 567);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "EventTime";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 200;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(498, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(244, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.Text = "Title";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(498, 39);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(244, 96);
            this.contentBox.TabIndex = 2;
            this.contentBox.Text = "Content";
            // 
            // reminderBox
            // 
            this.reminderBox.Location = new System.Drawing.Point(498, 142);
            this.reminderBox.Name = "reminderBox";
            this.reminderBox.Size = new System.Drawing.Size(244, 20);
            this.reminderBox.TabIndex = 3;
            this.reminderBox.Text = "Reminder";
            // 
            // eventTime
            // 
            this.eventTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.eventTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventTime.Location = new System.Drawing.Point(498, 214);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(244, 20);
            this.eventTime.TabIndex = 4;
            this.eventTime.Value = new System.DateTime(2017, 6, 21, 21, 32, 12, 0);
            // 
            // reminderTime
            // 
            this.reminderTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.reminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reminderTime.Location = new System.Drawing.Point(498, 260);
            this.reminderTime.Name = "reminderTime";
            this.reminderTime.Size = new System.Drawing.Size(244, 20);
            this.reminderTime.TabIndex = 5;
            this.reminderTime.Value = new System.DateTime(2017, 6, 21, 21, 32, 12, 0);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(498, 168);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(244, 20);
            this.addressBox.TabIndex = 6;
            this.addressBox.Text = "Address";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(498, 297);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 46);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add note";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Event Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reminder TIme:";
            // 
            // reminderSet
            // 
            this.reminderSet.AutoSize = true;
            this.reminderSet.Checked = true;
            this.reminderSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reminderSet.Location = new System.Drawing.Point(727, 244);
            this.reminderSet.Name = "reminderSet";
            this.reminderSet.Size = new System.Drawing.Size(15, 14);
            this.reminderSet.TabIndex = 10;
            this.reminderSet.UseVisualStyleBackColor = true;
            this.reminderSet.CheckedChanged += new System.EventHandler(this.reminderSet_CheckedChanged);
            // 
            // eventSet
            // 
            this.eventSet.AutoSize = true;
            this.eventSet.Checked = true;
            this.eventSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eventSet.Location = new System.Drawing.Point(727, 198);
            this.eventSet.Name = "eventSet";
            this.eventSet.Size = new System.Drawing.Size(15, 14);
            this.eventSet.TabIndex = 11;
            this.eventSet.UseVisualStyleBackColor = true;
            this.eventSet.CheckedChanged += new System.EventHandler(this.eventSet_CheckedChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(502, 555);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(241, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(499, 350);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(242, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete note";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(498, 456);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(244, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Downloading...";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.eventSet);
            this.Controls.Add(this.reminderSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.reminderTime);
            this.Controls.Add(this.eventTime);
            this.Controls.Add(this.reminderBox);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "4EverNote";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.TextBox reminderBox;
        private System.Windows.Forms.DateTimePicker eventTime;
        private System.Windows.Forms.DateTimePicker reminderTime;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox reminderSet;
        private System.Windows.Forms.CheckBox eventSet;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
    }
}

