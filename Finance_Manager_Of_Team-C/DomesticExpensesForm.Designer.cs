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
            label3.Location = new Point(302, 114);
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
            label4.Location = new Point(629, 114);
            label4.Name = "label4";
            label4.Size = new Size(114, 26);
            label4.TabIndex = 3;
            label4.Text = "Санітарія:";
            // 
            // DomesticExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
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
    }
}