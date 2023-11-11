namespace Vyvojaky
{
    partial class formNovySoubor
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
            lbNazev = new Label();
            tbVstupNazevSouboru = new TextBox();
            btVytvorit = new Button();
            SuspendLayout();
            // 
            // lbNazev
            // 
            lbNazev.AutoSize = true;
            lbNazev.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbNazev.ForeColor = Color.Black;
            lbNazev.Location = new Point(87, 92);
            lbNazev.Name = "lbNazev";
            lbNazev.Size = new Size(187, 32);
            lbNazev.TabIndex = 0;
            lbNazev.Text = "Název souboru: ";
            // 
            // tbVstupNazevSouboru
            // 
            tbVstupNazevSouboru.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbVstupNazevSouboru.Location = new Point(296, 96);
            tbVstupNazevSouboru.Margin = new Padding(3, 2, 3, 2);
            tbVstupNazevSouboru.Name = "tbVstupNazevSouboru";
            tbVstupNazevSouboru.Size = new Size(228, 32);
            tbVstupNazevSouboru.TabIndex = 1;
            // 
            // btVytvorit
            // 
            btVytvorit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btVytvorit.Location = new Point(296, 137);
            btVytvorit.Margin = new Padding(3, 2, 3, 2);
            btVytvorit.Name = "btVytvorit";
            btVytvorit.Size = new Size(228, 34);
            btVytvorit.TabIndex = 2;
            btVytvorit.Text = "Vytvořit nový soubor";
            btVytvorit.UseVisualStyleBackColor = true;
            btVytvorit.Click += btVytvorit_Click;
            // 
            // formNovySoubor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(btVytvorit);
            Controls.Add(tbVstupNazevSouboru);
            Controls.Add(lbNazev);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formNovySoubor";
            Text = "Nový soubor";
            FormClosing += formNovySoubor_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNazev;
        private TextBox tbVstupNazevSouboru;
        private Button btVytvorit;
    }
}