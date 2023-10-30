namespace Vyvojaky
{
    partial class formUvitaci
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
            btNovySoubor = new Button();
            btExistujici = new Button();
            SuspendLayout();
            // 
            // btNovySoubor
            // 
            btNovySoubor.Location = new Point(182, 183);
            btNovySoubor.Margin = new Padding(3, 2, 3, 2);
            btNovySoubor.Name = "btNovySoubor";
            btNovySoubor.Size = new Size(106, 30);
            btNovySoubor.TabIndex = 0;
            btNovySoubor.Text = "Nový soubor";
            btNovySoubor.UseVisualStyleBackColor = true;
            btNovySoubor.Click += btNovySoubor_Click;
            // 
            // btExistujici
            // 
            btExistujici.Location = new Point(340, 184);
            btExistujici.Margin = new Padding(3, 2, 3, 2);
            btExistujici.Name = "btExistujici";
            btExistujici.Size = new Size(125, 30);
            btExistujici.TabIndex = 1;
            btExistujici.Text = "Existující soubor";
            btExistujici.UseVisualStyleBackColor = true;
            // 
            // formUvitaci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(700, 338);
            Controls.Add(btExistujici);
            Controls.Add(btNovySoubor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formUvitaci";
            Text = "Vyvojaky - uvitaci";
            ResumeLayout(false);
        }

        #endregion

        private Button btNovySoubor;
        private Button btExistujici;
    }
}