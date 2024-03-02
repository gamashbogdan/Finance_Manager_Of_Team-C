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
            SocialExpensesPanelDiagram = new Panel();
            DomesticExpensesPanelDiagram = new Panel();
            labelDomesticExpenses = new Label();
            UnplannedExpensesPanelDiagram = new Panel();
            labelUnplannedExpenses = new Label();
            IncomePanelDiagram = new Panel();
            labelIncome = new Label();
            labelSocialExpences = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(1051, 522);
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
            labelDate.Location = new Point(12, 522);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(68, 35);
            labelDate.TabIndex = 4;
            labelDate.Text = "Date";
            labelDate.Click += labelDate_Click;
            labelDate.MouseEnter += ElementIllumination_MouseEnter;
            labelDate.MouseLeave += ElementIllumination_MouseLeave;
            // 
            // labelDateRange
            // 
            labelDateRange.AutoSize = true;
            labelDateRange.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            labelDateRange.ForeColor = SystemColors.ButtonHighlight;
            labelDateRange.Location = new Point(12, 9);
            labelDateRange.Name = "labelDateRange";
            labelDateRange.Size = new Size(168, 40);
            labelDateRange.TabIndex = 5;
            labelDateRange.Text = "Date Range";
            // 
            // SocialExpensesPanelDiagram
            // 
            SocialExpensesPanelDiagram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SocialExpensesPanelDiagram.Location = new Point(643, 110);
            SocialExpensesPanelDiagram.Name = "SocialExpensesPanelDiagram";
            SocialExpensesPanelDiagram.Size = new Size(479, 163);
            SocialExpensesPanelDiagram.TabIndex = 6;
            // 
            // DomesticExpensesPanelDiagram
            // 
            DomesticExpensesPanelDiagram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DomesticExpensesPanelDiagram.Location = new Point(643, 333);
            DomesticExpensesPanelDiagram.Name = "DomesticExpensesPanelDiagram";
            DomesticExpensesPanelDiagram.Size = new Size(479, 163);
            DomesticExpensesPanelDiagram.TabIndex = 8;
            // 
            // labelDomesticExpenses
            // 
            labelDomesticExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDomesticExpenses.AutoSize = true;
            labelDomesticExpenses.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelDomesticExpenses.ForeColor = SystemColors.ButtonHighlight;
            labelDomesticExpenses.Location = new Point(643, 295);
            labelDomesticExpenses.Name = "labelDomesticExpenses";
            labelDomesticExpenses.Size = new Size(253, 35);
            labelDomesticExpenses.TabIndex = 7;
            labelDomesticExpenses.Text = "Domestic Expenses : ";
            // 
            // UnplannedExpensesPanelDiagram
            // 
            UnplannedExpensesPanelDiagram.Location = new Point(12, 333);
            UnplannedExpensesPanelDiagram.Name = "UnplannedExpensesPanelDiagram";
            UnplannedExpensesPanelDiagram.Size = new Size(479, 163);
            UnplannedExpensesPanelDiagram.TabIndex = 12;
            // 
            // labelUnplannedExpenses
            // 
            labelUnplannedExpenses.AutoSize = true;
            labelUnplannedExpenses.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelUnplannedExpenses.ForeColor = SystemColors.ButtonHighlight;
            labelUnplannedExpenses.Location = new Point(12, 295);
            labelUnplannedExpenses.Name = "labelUnplannedExpenses";
            labelUnplannedExpenses.Size = new Size(272, 35);
            labelUnplannedExpenses.TabIndex = 11;
            labelUnplannedExpenses.Text = "Unplanned Expenses : ";
            // 
            // IncomePanelDiagram
            // 
            IncomePanelDiagram.Location = new Point(12, 110);
            IncomePanelDiagram.Name = "IncomePanelDiagram";
            IncomePanelDiagram.Size = new Size(479, 163);
            IncomePanelDiagram.TabIndex = 10;
            // 
            // labelIncome
            // 
            labelIncome.AutoSize = true;
            labelIncome.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelIncome.ForeColor = SystemColors.ButtonHighlight;
            labelIncome.Location = new Point(12, 72);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(119, 35);
            labelIncome.TabIndex = 9;
            labelIncome.Text = "Income : ";
            // 
            // labelSocialExpences
            // 
            labelSocialExpences.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSocialExpences.AutoSize = true;
            labelSocialExpences.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            labelSocialExpences.ForeColor = SystemColors.ButtonHighlight;
            labelSocialExpences.Location = new Point(643, 72);
            labelSocialExpences.Name = "labelSocialExpences";
            labelSocialExpences.Size = new Size(214, 35);
            labelSocialExpences.TabIndex = 13;
            labelSocialExpences.Text = "Social Expenses : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(643, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 40);
            label1.TabIndex = 14;
            label1.Text = "Total amount of expenses : ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            ClientSize = new Size(1134, 566);
            Controls.Add(label1);
            Controls.Add(UnplannedExpensesPanelDiagram);
            Controls.Add(labelSocialExpences);
            Controls.Add(DomesticExpensesPanelDiagram);
            Controls.Add(labelUnplannedExpenses);
            Controls.Add(labelDomesticExpenses);
            Controls.Add(IncomePanelDiagram);
            Controls.Add(labelIncome);
            Controls.Add(SocialExpensesPanelDiagram);
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
        private Panel SocialExpensesPanelDiagram;
        private Panel DomesticExpensesPanelDiagram;
        private Label labelDomesticExpenses;
        private Panel UnplannedExpensesPanelDiagram;
        private Label labelUnplannedExpenses;
        private Panel IncomePanelDiagram;
        private Label labelIncome;
        private Label labelSocialExpences;
        private Label label1;
    }
}