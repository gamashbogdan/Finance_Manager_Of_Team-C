namespace Finance_Manager_Of_Team_C
{
    partial class Income
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
            IncomeSourceGroupBox = new GroupBox();
            DescriptionLabel = new Label();
            EditIncomeSourceBtn = new Button();
            DeleteIncomeSourceBtn = new Button();
            AddIncomeSourceBtn = new Button();
            IncomeSourceCmb = new ComboBox();
            GraphGroupBox = new GroupBox();
            groupBox2 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            IncomeSourceGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // IncomeSourceGroupBox
            // 
            IncomeSourceGroupBox.BackColor = Color.LightSteelBlue;
            IncomeSourceGroupBox.Controls.Add(DescriptionLabel);
            IncomeSourceGroupBox.Controls.Add(EditIncomeSourceBtn);
            IncomeSourceGroupBox.Controls.Add(DeleteIncomeSourceBtn);
            IncomeSourceGroupBox.Controls.Add(AddIncomeSourceBtn);
            IncomeSourceGroupBox.Controls.Add(IncomeSourceCmb);
            IncomeSourceGroupBox.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IncomeSourceGroupBox.ForeColor = SystemColors.Control;
            IncomeSourceGroupBox.Location = new Point(12, 12);
            IncomeSourceGroupBox.Name = "IncomeSourceGroupBox";
            IncomeSourceGroupBox.Size = new Size(227, 160);
            IncomeSourceGroupBox.TabIndex = 0;
            IncomeSourceGroupBox.TabStop = false;
            IncomeSourceGroupBox.Text = "INCOME SOURCE";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 90);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(74, 21);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description";
            // 
            // EditIncomeSourceBtn
            // 
            EditIncomeSourceBtn.BackColor = Color.Orange;
            EditIncomeSourceBtn.Location = new Point(77, 29);
            EditIncomeSourceBtn.Name = "EditIncomeSourceBtn";
            EditIncomeSourceBtn.Size = new Size(74, 23);
            EditIncomeSourceBtn.TabIndex = 3;
            EditIncomeSourceBtn.Text = "EDIT";
            EditIncomeSourceBtn.UseVisualStyleBackColor = false;
            EditIncomeSourceBtn.Click += EditIncomeSourceBtn_Click;
            // 
            // DeleteIncomeSourceBtn
            // 
            DeleteIncomeSourceBtn.BackColor = Color.Salmon;
            DeleteIncomeSourceBtn.Location = new Point(152, 29);
            DeleteIncomeSourceBtn.Name = "DeleteIncomeSourceBtn";
            DeleteIncomeSourceBtn.Size = new Size(69, 23);
            DeleteIncomeSourceBtn.TabIndex = 2;
            DeleteIncomeSourceBtn.Text = "DELETE";
            DeleteIncomeSourceBtn.UseVisualStyleBackColor = false;
            DeleteIncomeSourceBtn.Click += DeleteIncomeSourceBtn_Click;
            // 
            // AddIncomeSourceBtn
            // 
            AddIncomeSourceBtn.BackColor = Color.PaleGreen;
            AddIncomeSourceBtn.Location = new Point(6, 29);
            AddIncomeSourceBtn.Name = "AddIncomeSourceBtn";
            AddIncomeSourceBtn.Size = new Size(69, 23);
            AddIncomeSourceBtn.TabIndex = 1;
            AddIncomeSourceBtn.Text = "ADD";
            AddIncomeSourceBtn.UseVisualStyleBackColor = false;
            AddIncomeSourceBtn.Click += AddIncomeSourceBtn_Click;
            // 
            // IncomeSourceCmb
            // 
            IncomeSourceCmb.BackColor = Color.LightCyan;
            IncomeSourceCmb.FormattingEnabled = true;
            IncomeSourceCmb.Location = new Point(6, 58);
            IncomeSourceCmb.Name = "IncomeSourceCmb";
            IncomeSourceCmb.Size = new Size(215, 29);
            IncomeSourceCmb.TabIndex = 0;
            IncomeSourceCmb.SelectedIndexChanged += IncomeSourceCmb_SelectedIndexChanged;
            // 
            // GraphGroupBox
            // 
            GraphGroupBox.BackColor = Color.LightSteelBlue;
            GraphGroupBox.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GraphGroupBox.ForeColor = SystemColors.Control;
            GraphGroupBox.Location = new Point(251, 12);
            GraphGroupBox.Name = "GraphGroupBox";
            GraphGroupBox.Size = new Size(537, 160);
            GraphGroupBox.TabIndex = 4;
            GraphGroupBox.TabStop = false;
            GraphGroupBox.Text = "GRAPH";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(251, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(537, 162);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "GRAPH";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 184);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 356);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBox2);
            Controls.Add(GraphGroupBox);
            Controls.Add(IncomeSourceGroupBox);
            Name = "Income";
            Text = "Income";
            IncomeSourceGroupBox.ResumeLayout(false);
            IncomeSourceGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox IncomeSourceGroupBox;
        private ComboBox IncomeSourceCmb;
        private Button AddIncomeSourceBtn;
        private Button DeleteIncomeSourceBtn;
        private Button EditIncomeSourceBtn;
        private Label DescriptionLabel;
        private GroupBox GraphGroupBox;
        private GroupBox groupBox2;
        private MonthCalendar monthCalendar1;
    }
}