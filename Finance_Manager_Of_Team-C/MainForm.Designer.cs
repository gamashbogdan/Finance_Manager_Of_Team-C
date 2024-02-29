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
            labelTime = new Label();
            labelDate = new Label();
            labelDateRange = new Label();
            CostChartPanel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(913, 476);
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
            labelDate.Location = new Point(12, 476);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(68, 35);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date";
            // 
            // labelDateRange
            // 
            labelDateRange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDateRange.AutoSize = true;
            labelDateRange.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            labelDateRange.ForeColor = SystemColors.ButtonHighlight;
            labelDateRange.Location = new Point(786, 1);
            labelDateRange.Name = "labelDateRange";
            labelDateRange.Size = new Size(198, 46);
            labelDateRange.TabIndex = 5;
            labelDateRange.Text = "Date Range";
            labelDateRange.Click += labelDateRange_Click;
            labelDateRange.MouseEnter += ElementIllumination_MouseEnter;
            labelDateRange.MouseLeave += ElementIllumination_MouseLeave;
            // 
            // CostChartPanel
            // 
            CostChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CostChartPanel.Location = new Point(537, 50);
            CostChartPanel.Name = "CostChartPanel";
            CostChartPanel.Size = new Size(447, 184);
            CostChartPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Location = new Point(537, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 184);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(786, 240);
            label1.Name = "label1";
            label1.Size = new Size(198, 46);
            label1.TabIndex = 7;
            label1.Text = "Date Range";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Location = new Point(12, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 184);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 237);
            label2.Name = "label2";
            label2.Size = new Size(198, 46);
            label2.TabIndex = 11;
            label2.Text = "Date Range";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Location = new Point(12, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 184);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 1);
            label3.Name = "label3";
            label3.Size = new Size(198, 46);
            label3.TabIndex = 9;
            label3.Text = "Date Range";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            ClientSize = new Size(996, 520);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(CostChartPanel);
            Controls.Add(labelDateRange);
            Controls.Add(labelDate);
            Controls.Add(labelTime);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTime;
        private Label labelDate;
        private Label labelDateRange;
        private Panel CostChartPanel;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
    }
}