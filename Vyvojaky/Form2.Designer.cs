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
            lbNazev.Location = new Point(99, 123);
            lbNazev.Name = "lbNazev";
            lbNazev.Size = new Size(233, 41);
            lbNazev.TabIndex = 0;
            lbNazev.Text = "Název souboru: ";
            // 
            // tbVstupNazevSouboru
            // 
            tbVstupNazevSouboru.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbVstupNazevSouboru.Location = new Point(338, 128);
            tbVstupNazevSouboru.Name = "tbVstupNazevSouboru";
            tbVstupNazevSouboru.Size = new Size(260, 38);
            tbVstupNazevSouboru.TabIndex = 1;
            // 
            // btVytvorit
            // 
            btVytvorit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btVytvorit.Location = new Point(338, 183);
            btVytvorit.Name = "btVytvorit";
            btVytvorit.Size = new Size(260, 45);
            btVytvorit.TabIndex = 2;
            btVytvorit.Text = "Vytvořit nový soubor";
            btVytvorit.UseVisualStyleBackColor = true;
            btVytvorit.Click += btVytvorit_Click;
            // 
            // formNovySoubor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btVytvorit);
            Controls.Add(tbVstupNazevSouboru);
            Controls.Add(lbNazev);
            Name = "formNovySoubor";
            Text = "Nový soubor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNazev;
        private TextBox tbVstupNazevSouboru;
        private Button btVytvorit;
    }
}