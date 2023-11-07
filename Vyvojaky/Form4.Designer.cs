namespace Vyvojaky
{
    partial class formHlavniProTvorbu
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
            panelPracovni = new Panel();
            panelPodminky = new Panel();
            btPodminka = new Button();
            tbPromenna2 = new TextBox();
            tbPromenna1 = new TextBox();
            lbPromenna2 = new Label();
            lbOperator = new Label();
            lbPromenna1 = new Label();
            menuStrip2 = new MenuStrip();
            operatory = new ToolStripMenuItem();
            itemVetsi = new ToolStripMenuItem();
            itemMensi = new ToolStripMenuItem();
            itemMensiRovno = new ToolStripMenuItem();
            itemVetsiRovno = new ToolStripMenuItem();
            itemRovnost = new ToolStripMenuItem();
            itemNerovnost = new ToolStripMenuItem();
            panelInformaci = new Panel();
            lbPriklady = new Label();
            lbPromenna = new Label();
            tbPromenna = new TextBox();
            panelConsole = new Panel();
            tbConsole = new TextBox();
            menuStrip1 = new MenuStrip();
            menuPanely = new ToolStripMenuItem();
            itemPromenne = new ToolStripMenuItem();
            itemPodminky = new ToolStripMenuItem();
            panelPodminky.SuspendLayout();
            menuStrip2.SuspendLayout();
            panelInformaci.SuspendLayout();
            panelConsole.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.BackColor = Color.Gray;
            panelPracovni.Location = new Point(268, 38);
            panelPracovni.Margin = new Padding(3, 2, 3, 2);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(832, 361);
            panelPracovni.TabIndex = 1;
            // 
            // panelPodminky
            // 
            panelPodminky.BackColor = Color.Gray;
            panelPodminky.Controls.Add(btPodminka);
            panelPodminky.Controls.Add(tbPromenna2);
            panelPodminky.Controls.Add(tbPromenna1);
            panelPodminky.Controls.Add(lbPromenna2);
            panelPodminky.Controls.Add(lbOperator);
            panelPodminky.Controls.Add(lbPromenna1);
            panelPodminky.Controls.Add(menuStrip2);
            panelPodminky.Location = new Point(268, 38);
            panelPodminky.Name = "panelPodminky";
            panelPodminky.Size = new Size(252, 361);
            panelPodminky.TabIndex = 3;
            // 
            // btPodminka
            // 
            btPodminka.Location = new Point(30, 191);
            btPodminka.Margin = new Padding(3, 2, 3, 2);
            btPodminka.Name = "btPodminka";
            btPodminka.Size = new Size(160, 22);
            btPodminka.TabIndex = 6;
            btPodminka.Text = "Spustit Podminku";
            btPodminka.UseVisualStyleBackColor = true;
            btPodminka.Click += btPodminka_Click;
            // 
            // tbPromenna2
            // 
            tbPromenna2.Location = new Point(34, 159);
            tbPromenna2.Margin = new Padding(3, 2, 3, 2);
            tbPromenna2.Name = "tbPromenna2";
            tbPromenna2.Size = new Size(154, 23);
            tbPromenna2.TabIndex = 4;
            // 
            // tbPromenna1
            // 
            tbPromenna1.Location = new Point(34, 52);
            tbPromenna1.Margin = new Padding(3, 2, 3, 2);
            tbPromenna1.Name = "tbPromenna1";
            tbPromenna1.Size = new Size(154, 23);
            tbPromenna1.TabIndex = 3;
            // 
            // lbPromenna2
            // 
            lbPromenna2.AutoSize = true;
            lbPromenna2.Location = new Point(30, 142);
            lbPromenna2.Name = "lbPromenna2";
            lbPromenna2.Size = new Size(147, 15);
            lbPromenna2.TabIndex = 2;
            lbPromenna2.Text = "Druhá promìnná/hodnota";
            // 
            // lbOperator
            // 
            lbOperator.AutoSize = true;
            lbOperator.Location = new Point(34, 88);
            lbOperator.Name = "lbOperator";
            lbOperator.Size = new Size(57, 15);
            lbOperator.TabIndex = 1;
            lbOperator.Text = "Operátor:";
            // 
            // lbPromenna1
            // 
            lbPromenna1.AutoSize = true;
            lbPromenna1.Location = new Point(34, 35);
            lbPromenna1.Name = "lbPromenna1";
            lbPromenna1.Size = new Size(145, 15);
            lbPromenna1.TabIndex = 0;
            lbPromenna1.Text = "První promìnná/hodnota:";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { operatory });
            menuStrip2.Location = new Point(34, 113);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(79, 24);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // operatory
            // 
            operatory.DropDownItems.AddRange(new ToolStripItem[] { itemVetsi, itemMensi, itemMensiRovno, itemVetsiRovno, itemRovnost, itemNerovnost });
            operatory.Name = "operatory";
            operatory.Size = new Size(72, 20);
            operatory.Text = "Operátory";
            // 
            // itemVetsi
            // 
            itemVetsi.Name = "itemVetsi";
            itemVetsi.Size = new Size(90, 22);
            itemVetsi.Text = ">";
            itemVetsi.Click += itemVetsi_Click;
            // 
            // itemMensi
            // 
            itemMensi.Name = "itemMensi";
            itemMensi.Size = new Size(90, 22);
            itemMensi.Text = "<";
            itemMensi.Click += itemMensi_Click;
            // 
            // itemMensiRovno
            // 
            itemMensiRovno.Name = "itemMensiRovno";
            itemMensiRovno.Size = new Size(90, 22);
            itemMensiRovno.Text = "<=";
            itemMensiRovno.Click += itemMensiRovno_Click;
            // 
            // itemVetsiRovno
            // 
            itemVetsiRovno.Name = "itemVetsiRovno";
            itemVetsiRovno.Size = new Size(90, 22);
            itemVetsiRovno.Text = ">=";
            itemVetsiRovno.Click += itemVetsiRovno_Click;
            // 
            // itemRovnost
            // 
            itemRovnost.Name = "itemRovnost";
            itemRovnost.Size = new Size(90, 22);
            itemRovnost.Text = "==";
            itemRovnost.Click += itemRovnost_Click;
            // 
            // itemNerovnost
            // 
            itemNerovnost.Name = "itemNerovnost";
            itemNerovnost.Size = new Size(90, 22);
            itemNerovnost.Text = "!=";
            itemNerovnost.Click += itemNerovnost_Click;
            // 
            // panelInformaci
            // 
            panelInformaci.BackColor = Color.Gray;
            panelInformaci.Controls.Add(lbPriklady);
            panelInformaci.Controls.Add(lbPromenna);
            panelInformaci.Controls.Add(tbPromenna);
            panelInformaci.Location = new Point(10, 38);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(252, 361);
            panelInformaci.TabIndex = 2;
            // 
            // lbPriklady
            // 
            lbPriklady.AutoSize = true;
            lbPriklady.Location = new Point(3, 75);
            lbPriklady.Name = "lbPriklady";
            lbPriklady.Size = new Size(217, 15);
            lbPriklady.TabIndex = 10;
            lbPriklady.Text = "Pøíklady: a = 5, b = 3.14, jmeno = Aneta ";
            // 
            // lbPromenna
            // 
            lbPromenna.AutoSize = true;
            lbPromenna.Location = new Point(3, 16);
            lbPromenna.Name = "lbPromenna";
            lbPromenna.Size = new Size(62, 15);
            lbPromenna.TabIndex = 9;
            lbPromenna.Text = "Promìnná";
            // 
            // tbPromenna
            // 
            tbPromenna.Location = new Point(3, 34);
            tbPromenna.Name = "tbPromenna";
            tbPromenna.Size = new Size(246, 23);
            tbPromenna.TabIndex = 8;
            tbPromenna.TextChanged += tbPromenna_TextChanged;
            tbPromenna.KeyDown += tbPromenna_KeyDown;
            // 
            // panelConsole
            // 
            panelConsole.BackColor = Color.White;
            panelConsole.Controls.Add(tbConsole);
            panelConsole.Location = new Point(10, 409);
            panelConsole.Margin = new Padding(3, 2, 3, 2);
            panelConsole.Name = "panelConsole";
            panelConsole.Size = new Size(522, 85);
            panelConsole.TabIndex = 3;
            // 
            // tbConsole
            // 
            tbConsole.BackColor = Color.Black;
            tbConsole.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(3, 2);
            tbConsole.Margin = new Padding(3, 2, 3, 2);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(518, 81);
            tbConsole.TabIndex = 0;
            tbConsole.TabStop = false;
            tbConsole.Text = ">";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuPanely });
            menuStrip1.Location = new Point(12, 7);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(61, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPanely
            // 
            menuPanely.DropDownItems.AddRange(new ToolStripItem[] { itemPromenne, itemPodminky });
            menuPanely.Name = "menuPanely";
            menuPanely.Size = new Size(54, 20);
            menuPanely.Text = "Panely";
            // 
            // itemPromenne
            // 
            itemPromenne.Name = "itemPromenne";
            itemPromenne.Size = new Size(129, 22);
            itemPromenne.Text = "Promìnné";
            itemPromenne.Click += itemPromenne_Click;
            // 
            // itemPodminky
            // 
            itemPodminky.Name = "itemPodminky";
            itemPodminky.Size = new Size(129, 22);
            itemPodminky.Text = "Podmínky";
            itemPodminky.Click += itemPodminky_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1110, 497);
            Controls.Add(panelPodminky);
            Controls.Add(panelConsole);
            Controls.Add(panelInformaci);
            Controls.Add(panelPracovni);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            panelPodminky.ResumeLayout(false);
            panelPodminky.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            panelConsole.ResumeLayout(false);
            panelConsole.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private Panel panelConsole;
        private TextBox tbConsole;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPanely;
        private ToolStripMenuItem itemPromenne;
        private ToolStripMenuItem itemPodminky;
        private Panel panelPodminky;
        private TextBox tbPromenna2;
        private TextBox tbPromenna1;
        private Label lbPromenna2;
        private Label lbOperator;
        private Label lbPromenna1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem operatory;
        private ToolStripMenuItem itemVetsi;
        private ToolStripMenuItem itemMensi;
        private ToolStripMenuItem itemMensiRovno;
        private ToolStripMenuItem itemVetsiRovno;
        private ToolStripMenuItem itemRovnost;
        private Button btPodminka;
        private ToolStripMenuItem itemNerovnost;
        private TextBox tbPromenna;
        private Label lbPriklady;
        private Label lbPromenna;
    }
}