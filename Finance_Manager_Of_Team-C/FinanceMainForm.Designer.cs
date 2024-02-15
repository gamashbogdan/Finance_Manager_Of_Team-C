namespace Finance_Manager_Of_Team_C
{
    partial class FormFinance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonDomesticExpenses = new Button();
            buttonSocialCosts = new Button();
            buttonUnplannedExpenses = new Button();
            IncomeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 19);
            label1.Name = "label1";
            label1.Size = new Size(253, 37);
            label1.TabIndex = 0;
            label1.Text = "Financial Expenses";
            // 
            // buttonDomesticExpenses
            // 
            buttonDomesticExpenses.BackColor = Color.FromArgb(36, 39, 54);
            buttonDomesticExpenses.FlatAppearance.BorderSize = 0;
            buttonDomesticExpenses.FlatStyle = FlatStyle.Flat;
            buttonDomesticExpenses.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            buttonDomesticExpenses.ForeColor = Color.White;
            buttonDomesticExpenses.Location = new Point(139, 222);
            buttonDomesticExpenses.Margin = new Padding(3, 2, 3, 2);
            buttonDomesticExpenses.Name = "buttonDomesticExpenses";
            buttonDomesticExpenses.Size = new Size(217, 38);
            buttonDomesticExpenses.TabIndex = 1;
            buttonDomesticExpenses.Text = "Domestic Expenses";
            buttonDomesticExpenses.UseVisualStyleBackColor = false;
            buttonDomesticExpenses.Click += buttonDomesticExpenses_Click;
            // 
            // buttonSocialCosts
            // 
            buttonSocialCosts.BackColor = Color.FromArgb(36, 39, 54);
            buttonSocialCosts.FlatAppearance.BorderSize = 0;
            buttonSocialCosts.FlatStyle = FlatStyle.Flat;
            buttonSocialCosts.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            buttonSocialCosts.ForeColor = Color.White;
            buttonSocialCosts.Location = new Point(139, 101);
            buttonSocialCosts.Margin = new Padding(3, 2, 3, 2);
            buttonSocialCosts.Name = "buttonSocialCosts";
            buttonSocialCosts.Size = new Size(217, 38);
            buttonSocialCosts.TabIndex = 2;
            buttonSocialCosts.Text = "Social Costs";
            buttonSocialCosts.UseVisualStyleBackColor = false;
            buttonSocialCosts.Click += buttonSocialCosts_Click;
            // 
            // buttonUnplannedExpenses
            // 
            buttonUnplannedExpenses.BackColor = Color.FromArgb(36, 39, 54);
            buttonUnplannedExpenses.FlatAppearance.BorderSize = 0;
            buttonUnplannedExpenses.FlatStyle = FlatStyle.Flat;
            buttonUnplannedExpenses.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            buttonUnplannedExpenses.ForeColor = Color.White;
            buttonUnplannedExpenses.Location = new Point(139, 161);
            buttonUnplannedExpenses.Margin = new Padding(3, 2, 3, 2);
            buttonUnplannedExpenses.Name = "buttonUnplannedExpenses";
            buttonUnplannedExpenses.Size = new Size(217, 38);
            buttonUnplannedExpenses.TabIndex = 3;
            buttonUnplannedExpenses.Text = "Unplanned Expenses";
            buttonUnplannedExpenses.UseVisualStyleBackColor = false;
            buttonUnplannedExpenses.Click += buttonUnplannedExpenses_Click;
            // 
            // IncomeButton
            // 
            IncomeButton.BackColor = Color.FromArgb(36, 39, 54);
            IncomeButton.FlatAppearance.BorderSize = 0;
            IncomeButton.FlatStyle = FlatStyle.Flat;
            IncomeButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IncomeButton.ForeColor = Color.White;
            IncomeButton.Location = new Point(378, 102);
            IncomeButton.Margin = new Padding(3, 2, 3, 2);
            IncomeButton.Name = "IncomeButton";
            IncomeButton.Size = new Size(119, 159);
            IncomeButton.TabIndex = 4;
            IncomeButton.Text = "Income";
            IncomeButton.UseVisualStyleBackColor = false;
            IncomeButton.Click += IncomeButton_Click;
            // 
            // FormFinance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            ClientSize = new Size(700, 338);
            Controls.Add(IncomeButton);
            Controls.Add(buttonDomesticExpenses);
            Controls.Add(buttonUnplannedExpenses);
            Controls.Add(label1);
            Controls.Add(buttonSocialCosts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormFinance";
            Text = "Finance Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonDomesticExpenses;
        private Button buttonSocialCosts;
        private Button buttonUnplannedExpenses;
        private Button IncomeButton;
    }
}
