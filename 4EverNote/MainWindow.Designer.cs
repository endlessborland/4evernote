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
            this.dataGrid = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Time,
            this.Content});
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid.Location = new System.Drawing.Point(13, 13);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(479, 567);
            this.dataGrid.TabIndex = 0;
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
            this.Content.Width = 240;
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
            this.eventTime.CustomFormat = "DD:MM:YYYY MM:HH";
            this.eventTime.Location = new System.Drawing.Point(498, 194);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(244, 20);
            this.eventTime.TabIndex = 4;
            this.eventTime.Value = new System.DateTime(2017, 6, 21, 21, 32, 12, 0);
            // 
            // reminderTime
            // 
            this.reminderTime.CustomFormat = "DD:MM:YYYY MM:HH";
            this.reminderTime.Location = new System.Drawing.Point(498, 220);
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
            this.addButton.Location = new System.Drawing.Point(498, 326);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add note";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 592);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.TextBox reminderBox;
        private System.Windows.Forms.DateTimePicker eventTime;
        private System.Windows.Forms.DateTimePicker reminderTime;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button addButton;
    }
}

