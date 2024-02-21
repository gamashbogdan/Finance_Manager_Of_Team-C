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
            panelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            iconButtonIncome = new FontAwesome.Sharp.IconButton();
            iconButtonDomesticExpenses = new FontAwesome.Sharp.IconButton();
            iconButtonSocialCosts = new FontAwesome.Sharp.IconButton();
            iconButtonUnplannedExpenses = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(iconButtonIncome);
            panelMenu.Controls.Add(iconButtonDomesticExpenses);
            panelMenu.Controls.Add(iconButtonSocialCosts);
            panelMenu.Controls.Add(iconButtonUnplannedExpenses);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 597);
            panelMenu.TabIndex = 4;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // iconButtonIncome
            // 
            iconButtonIncome.Dock = DockStyle.Top;
            iconButtonIncome.FlatAppearance.BorderSize = 0;
            iconButtonIncome.FlatStyle = FlatStyle.Flat;
            iconButtonIncome.ForeColor = SystemColors.ButtonHighlight;
            iconButtonIncome.IconChar = FontAwesome.Sharp.IconChar.I;
            iconButtonIncome.IconColor = Color.White;
            iconButtonIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonIncome.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonIncome.Location = new Point(3, 149);
            iconButtonIncome.Name = "iconButtonIncome";
            iconButtonIncome.Padding = new Padding(10, 0, 20, 0);
            iconButtonIncome.Size = new Size(240, 60);
            iconButtonIncome.TabIndex = 1;
            iconButtonIncome.Text = "Income";
            iconButtonIncome.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonIncome.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonIncome.UseVisualStyleBackColor = true;
            iconButtonIncome.Click += iconButtonIncome_Click;
            // 
            // iconButtonDomesticExpenses
            // 
            iconButtonDomesticExpenses.Dock = DockStyle.Top;
            iconButtonDomesticExpenses.FlatAppearance.BorderSize = 0;
            iconButtonDomesticExpenses.FlatStyle = FlatStyle.Flat;
            iconButtonDomesticExpenses.ForeColor = SystemColors.ButtonHighlight;
            iconButtonDomesticExpenses.IconChar = FontAwesome.Sharp.IconChar.D;
            iconButtonDomesticExpenses.IconColor = Color.White;
            iconButtonDomesticExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDomesticExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDomesticExpenses.Location = new Point(3, 215);
            iconButtonDomesticExpenses.Name = "iconButtonDomesticExpenses";
            iconButtonDomesticExpenses.Padding = new Padding(10, 0, 20, 0);
            iconButtonDomesticExpenses.Size = new Size(240, 60);
            iconButtonDomesticExpenses.TabIndex = 2;
            iconButtonDomesticExpenses.Text = "Domestic Expenses";
            iconButtonDomesticExpenses.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDomesticExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDomesticExpenses.UseVisualStyleBackColor = true;
            iconButtonDomesticExpenses.Click += iconButtonDomesticExpenses_Click;
            // 
            // iconButtonSocialCosts
            // 
            iconButtonSocialCosts.Dock = DockStyle.Top;
            iconButtonSocialCosts.FlatAppearance.BorderSize = 0;
            iconButtonSocialCosts.FlatStyle = FlatStyle.Flat;
            iconButtonSocialCosts.ForeColor = SystemColors.ButtonHighlight;
            iconButtonSocialCosts.IconChar = FontAwesome.Sharp.IconChar.S;
            iconButtonSocialCosts.IconColor = Color.White;
            iconButtonSocialCosts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSocialCosts.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSocialCosts.Location = new Point(3, 281);
            iconButtonSocialCosts.Name = "iconButtonSocialCosts";
            iconButtonSocialCosts.Padding = new Padding(10, 0, 20, 0);
            iconButtonSocialCosts.Size = new Size(240, 60);
            iconButtonSocialCosts.TabIndex = 3;
            iconButtonSocialCosts.Text = "Social Costs";
            iconButtonSocialCosts.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonSocialCosts.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSocialCosts.UseVisualStyleBackColor = true;
            iconButtonSocialCosts.Click += iconButtonSocialCosts_Click;
            // 
            // iconButtonUnplannedExpenses
            // 
            iconButtonUnplannedExpenses.Dock = DockStyle.Top;
            iconButtonUnplannedExpenses.FlatAppearance.BorderSize = 0;
            iconButtonUnplannedExpenses.FlatStyle = FlatStyle.Flat;
            iconButtonUnplannedExpenses.ForeColor = SystemColors.ButtonHighlight;
            iconButtonUnplannedExpenses.IconChar = FontAwesome.Sharp.IconChar.U;
            iconButtonUnplannedExpenses.IconColor = Color.White;
            iconButtonUnplannedExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUnplannedExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUnplannedExpenses.Location = new Point(3, 347);
            iconButtonUnplannedExpenses.Name = "iconButtonUnplannedExpenses";
            iconButtonUnplannedExpenses.Padding = new Padding(10, 0, 20, 0);
            iconButtonUnplannedExpenses.Size = new Size(240, 60);
            iconButtonUnplannedExpenses.TabIndex = 4;
            iconButtonUnplannedExpenses.Text = "Unplanned Expenses";
            iconButtonUnplannedExpenses.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonUnplannedExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonUnplannedExpenses.UseVisualStyleBackColor = true;
            iconButtonUnplannedExpenses.Click += iconButtonUnplannedExpenses_Click;
            // 
            // FormFinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 597);
            Controls.Add(panelMenu);
            Name = "FormFinance";
            Text = "Finance Manager";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonIncome;
        private FontAwesome.Sharp.IconButton iconButtonDomesticExpenses;
        private FontAwesome.Sharp.IconButton iconButtonSocialCosts;
        private FontAwesome.Sharp.IconButton iconButtonUnplannedExpenses;
    }
}
