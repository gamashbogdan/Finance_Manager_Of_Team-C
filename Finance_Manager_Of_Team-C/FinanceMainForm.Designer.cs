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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 26);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 0;
            label1.Text = "Financial Expenses";
            // 
            // buttonDomesticExpenses
            // 
            buttonDomesticExpenses.Location = new Point(209, 89);
            buttonDomesticExpenses.Name = "buttonDomesticExpenses";
            buttonDomesticExpenses.Size = new Size(161, 51);
            buttonDomesticExpenses.TabIndex = 1;
            buttonDomesticExpenses.Text = "Domestic Expenses";
            buttonDomesticExpenses.UseVisualStyleBackColor = true;
            buttonDomesticExpenses.Click += buttonDomesticExpenses_Click;
            // 
            // buttonSocialCosts
            // 
            buttonSocialCosts.Location = new Point(209, 146);
            buttonSocialCosts.Name = "buttonSocialCosts";
            buttonSocialCosts.Size = new Size(161, 51);
            buttonSocialCosts.TabIndex = 2;
            buttonSocialCosts.Text = "Social Costs";
            buttonSocialCosts.UseVisualStyleBackColor = true;
            buttonSocialCosts.Click += buttonSocialCosts_Click;
            // 
            // buttonUnplannedExpenses
            // 
            buttonUnplannedExpenses.Location = new Point(376, 89);
            buttonUnplannedExpenses.Name = "buttonUnplannedExpenses";
            buttonUnplannedExpenses.Size = new Size(161, 51);
            buttonUnplannedExpenses.TabIndex = 3;
            buttonUnplannedExpenses.Text = "Unplanned Expenses";
            buttonUnplannedExpenses.UseVisualStyleBackColor = true;
            buttonUnplannedExpenses.Click += buttonUnplannedExpenses_Click;
            // 
            // FormFinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUnplannedExpenses);
            Controls.Add(buttonSocialCosts);
            Controls.Add(buttonDomesticExpenses);
            Controls.Add(label1);
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
    }
}
