namespace Finance_Manager_Of_Team_C
{
    partial class DomesticExpensesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FruitCheck = new CheckBox();
            VegCheck = new CheckBox();
            DrinkCheck = new CheckBox();
            DessertCheck = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            FruitBox = new TextBox();
            VegBox = new TextBox();
            DrinkBox = new TextBox();
            DessertBox = new TextBox();
            FoodButton = new Button();
            FoodSum = new Label();
            MoneyLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 48);
            label1.TabIndex = 0;
            label1.Text = "Побутові витрати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(70, 110);
            label2.Name = "label2";
            label2.Size = new Size(95, 29);
            label2.TabIndex = 1;
            label2.Text = "На їжу:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(292, 110);
            label3.Name = "label3";
            label3.Size = new Size(218, 23);
            label3.TabIndex = 2;
            label3.Text = "Засоби особистої гігєни:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(617, 108);
            label4.Name = "label4";
            label4.Size = new Size(114, 26);
            label4.TabIndex = 3;
            label4.Text = "Санітарія:";
            // 
            // FruitCheck
            // 
            FruitCheck.AutoSize = true;
            FruitCheck.BackColor = Color.Transparent;
            FruitCheck.Font = new Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FruitCheck.ForeColor = SystemColors.ActiveBorder;
            FruitCheck.Location = new Point(17, 174);
            FruitCheck.Name = "FruitCheck";
            FruitCheck.Size = new Size(83, 25);
            FruitCheck.TabIndex = 4;
            FruitCheck.Text = "Фрукти";
            FruitCheck.UseVisualStyleBackColor = false;
            FruitCheck.CheckedChanged += FruitCheck_CheckedChanged;
            // 
            // VegCheck
            // 
            VegCheck.AutoSize = true;
            VegCheck.BackColor = Color.Transparent;
            VegCheck.Font = new Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VegCheck.ForeColor = SystemColors.ActiveBorder;
            VegCheck.Location = new Point(17, 205);
            VegCheck.Name = "VegCheck";
            VegCheck.Size = new Size(72, 25);
            VegCheck.TabIndex = 5;
            VegCheck.Text = "Овочі";
            VegCheck.UseVisualStyleBackColor = false;
            VegCheck.CheckedChanged += VegCheck_CheckedChanged;
            // 
            // DrinkCheck
            // 
            DrinkCheck.AutoSize = true;
            DrinkCheck.BackColor = Color.Transparent;
            DrinkCheck.Font = new Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DrinkCheck.ForeColor = SystemColors.ActiveBorder;
            DrinkCheck.Location = new Point(17, 236);
            DrinkCheck.Name = "DrinkCheck";
            DrinkCheck.Size = new Size(73, 25);
            DrinkCheck.TabIndex = 6;
            DrinkCheck.Text = "Напої";
            DrinkCheck.UseVisualStyleBackColor = false;
            DrinkCheck.CheckedChanged += DrinkCheck_CheckedChanged;
            // 
            // DessertCheck
            // 
            DessertCheck.AutoSize = true;
            DessertCheck.BackColor = Color.Transparent;
            DessertCheck.Font = new Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DessertCheck.ForeColor = SystemColors.ActiveBorder;
            DessertCheck.Location = new Point(17, 267);
            DessertCheck.Name = "DessertCheck";
            DessertCheck.Size = new Size(87, 25);
            DessertCheck.TabIndex = 7;
            DessertCheck.Text = "Десерти";
            DessertCheck.UseVisualStyleBackColor = false;
            DessertCheck.CheckedChanged += DessertCheck_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(106, 176);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "100 грн";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(106, 207);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 9;
            label6.Text = "120 грн";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(106, 238);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 10;
            label7.Text = "50 грн";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(106, 269);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 11;
            label8.Text = "150 грн";
            // 
            // FruitBox
            // 
            FruitBox.Enabled = false;
            FruitBox.Location = new Point(173, 172);
            FruitBox.Name = "FruitBox";
            FruitBox.Size = new Size(54, 27);
            FruitBox.TabIndex = 12;
            FruitBox.TextChanged += FruitBox_TextChanged;
            // 
            // VegBox
            // 
            VegBox.Enabled = false;
            VegBox.Location = new Point(173, 205);
            VegBox.Name = "VegBox";
            VegBox.Size = new Size(54, 27);
            VegBox.TabIndex = 13;
            VegBox.TextChanged += VegBox_TextChanged;
            // 
            // DrinkBox
            // 
            DrinkBox.Enabled = false;
            DrinkBox.Location = new Point(173, 238);
            DrinkBox.Name = "DrinkBox";
            DrinkBox.Size = new Size(54, 27);
            DrinkBox.TabIndex = 14;
            DrinkBox.TextChanged += DrinkBox_TextChanged;
            // 
            // DessertBox
            // 
            DessertBox.Enabled = false;
            DessertBox.Location = new Point(173, 271);
            DessertBox.Name = "DessertBox";
            DessertBox.Size = new Size(54, 27);
            DessertBox.TabIndex = 15;
            DessertBox.TextChanged += DessertBox_TextChanged;
            // 
            // FoodButton
            // 
            FoodButton.BackColor = Color.MediumSeaGreen;
            FoodButton.Font = new Font("Sitka Subheading", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FoodButton.ForeColor = SystemColors.ActiveCaptionText;
            FoodButton.Location = new Point(28, 315);
            FoodButton.Name = "FoodButton";
            FoodButton.Size = new Size(184, 47);
            FoodButton.TabIndex = 16;
            FoodButton.Text = "Обрахувати";
            FoodButton.UseVisualStyleBackColor = false;
            FoodButton.Click += FoodButton_Click;
            // 
            // FoodSum
            // 
            FoodSum.AutoSize = true;
            FoodSum.BackColor = Color.Transparent;
            FoodSum.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FoodSum.ForeColor = SystemColors.HotTrack;
            FoodSum.Location = new Point(70, 379);
            FoodSum.Name = "FoodSum";
            FoodSum.Size = new Size(44, 42);
            FoodSum.TabIndex = 17;
            FoodSum.Text = ":D";
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MoneyLabel.ForeColor = Color.FromArgb(0, 192, 0);
            MoneyLabel.Location = new Point(12, 9);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(180, 22);
            MoneyLabel.TabIndex = 18;
            MoneyLabel.Text = "Доступні кошти: -";
            // 
            // DomesticExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(MoneyLabel);
            Controls.Add(FoodSum);
            Controls.Add(FoodButton);
            Controls.Add(DessertBox);
            Controls.Add(DrinkBox);
            Controls.Add(VegBox);
            Controls.Add(FruitBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DessertCheck);
            Controls.Add(DrinkCheck);
            Controls.Add(VegCheck);
            Controls.Add(FruitCheck);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DomesticExpensesForm";
            Text = "Побутові витрати";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox FruitCheck;
        private CheckBox VegCheck;
        private CheckBox DrinkCheck;
        private CheckBox DessertCheck;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox FruitBox;
        private TextBox VegBox;
        private TextBox DrinkBox;
        private TextBox DessertBox;
        private Button FoodButton;
        private Label FoodSum;
        private Label MoneyLabel;
    }
}