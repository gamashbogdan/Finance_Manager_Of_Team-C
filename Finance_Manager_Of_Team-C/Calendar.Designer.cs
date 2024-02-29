namespace Finance_Manager_Of_Team_C
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            monthCalendar = new MonthCalendar();
            buttonCancelDate = new Button();
            buttonOkDate = new Button();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(2, 1);
            monthCalendar.Location = new Point(9, 6);
            monthCalendar.MaxDate = new DateTime(2120, 1, 1, 0, 0, 0, 0);
            monthCalendar.MaxSelectionCount = 365;
            monthCalendar.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 0;
            // 
            // buttonCancelDate
            // 
            buttonCancelDate.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelDate.FlatStyle = FlatStyle.Flat;
            buttonCancelDate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancelDate.Location = new Point(9, 213);
            buttonCancelDate.Name = "buttonCancelDate";
            buttonCancelDate.Size = new Size(192, 39);
            buttonCancelDate.TabIndex = 1;
            buttonCancelDate.Text = "Cancel";
            buttonCancelDate.UseVisualStyleBackColor = false;
            buttonCancelDate.Click += buttonCancelDate_Click;
            // 
            // buttonOkDate
            // 
            buttonOkDate.BackColor = Color.FromArgb(192, 255, 192);
            buttonOkDate.FlatStyle = FlatStyle.Flat;
            buttonOkDate.Font = new Font("Verdana", 12F);
            buttonOkDate.Location = new Point(205, 213);
            buttonOkDate.Name = "buttonOkDate";
            buttonOkDate.Size = new Size(192, 39);
            buttonOkDate.TabIndex = 2;
            buttonOkDate.Text = "OK";
            buttonOkDate.UseVisualStyleBackColor = false;
            buttonOkDate.Click += buttonOkDate_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 259);
            Controls.Add(buttonOkDate);
            Controls.Add(buttonCancelDate);
            Controls.Add(monthCalendar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calendar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calendar";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button buttonCancelDate;
        private Button buttonOkDate;
    }
}