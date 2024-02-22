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
            SuspendLayout();
            // 
            // labelFinanceManager
            // 
            labelFinanceManager.Anchor = AnchorStyles.Top;
            labelFinanceManager.Font = new Font("Segoe UI Emoji", 22F, FontStyle.Bold);
            labelFinanceManager.ForeColor = SystemColors.ControlLightLight;
            labelFinanceManager.Location = new Point(332, 9);
            labelFinanceManager.Name = "labelFinanceManager";
            labelFinanceManager.Size = new Size(330, 54);
            labelFinanceManager.TabIndex = 2;
            labelFinanceManager.Text = "Finance Manager";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(898, 466);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(86, 41);
            labelTime.TabIndex = 3;
            labelTime.Text = "Time";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(996, 516);
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
    }
}