namespace Finance_Manager_Of_Team_C
{
    partial class MainForm
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
            labelFinanceManager = new Label();
            labelTime = new Label();
            labelDate = new Label();
            SuspendLayout();
            // 
            // labelFinanceManager
            // 
            labelFinanceManager.Anchor = AnchorStyles.Top;
            labelFinanceManager.Font = new Font("Segoe UI Emoji", 22F, FontStyle.Bold);
            labelFinanceManager.ForeColor = SystemColors.ControlLightLight;
            labelFinanceManager.Location = new Point(331, 9);
            labelFinanceManager.Name = "labelFinanceManager";
            labelFinanceManager.Size = new Size(330, 53);
            labelFinanceManager.TabIndex = 2;
            labelFinanceManager.Text = "Finance Manager";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(914, 472);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(71, 35);
            labelTime.TabIndex = 3;
            labelTime.Text = "Time";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelDate.ForeColor = SystemColors.ButtonHighlight;
            labelDate.Location = new Point(12, 472);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(68, 35);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date";
            labelDate.Click += labelDate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            ClientSize = new Size(997, 516);
            Controls.Add(labelDate);
            Controls.Add(labelFinanceManager);
            Controls.Add(labelTime);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFinanceManager;
        private Label labelTime;
        private Label labelDate;
    }
}