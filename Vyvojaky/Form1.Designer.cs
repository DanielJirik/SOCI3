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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btNovySoubor
            // 
            btNovySoubor.Anchor = AnchorStyles.None;
            btNovySoubor.Location = new Point(208, 244);
            btNovySoubor.Name = "btNovySoubor";
            btNovySoubor.Size = new Size(121, 40);
            btNovySoubor.TabIndex = 0;
            btNovySoubor.Text = "Nový soubor";
            btNovySoubor.UseVisualStyleBackColor = true;
            btNovySoubor.Click += btNovySoubor_Click;
            // 
            // btExistujici
            // 
            btExistujici.Anchor = AnchorStyles.None;
            btExistujici.Location = new Point(389, 245);
            btExistujici.Name = "btExistujici";
            btExistujici.Size = new Size(143, 40);
            btExistujici.TabIndex = 1;
            btExistujici.Text = "Existující soubor";
            btExistujici.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Export1;
            pictureBox1.Location = new Point(215, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // formUvitaci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 451);
            Controls.Add(pictureBox1);
            Controls.Add(btExistujici);
            Controls.Add(btNovySoubor);
            MaximumSize = new Size(818, 498);
            MinimumSize = new Size(818, 498);
            Name = "formUvitaci";
            Text = "Vyvojaky - uvitaci";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btNovySoubor;
        private Button btExistujici;
        private PictureBox pictureBox1;
    }
}