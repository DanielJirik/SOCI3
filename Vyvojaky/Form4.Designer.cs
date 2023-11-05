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
            components = new System.ComponentModel.Container();
            panelPracovni = new Panel();
            panelInformaci = new Panel();
            lbHodnota = new Label();
            tbHodnota = new TextBox();
            lbNazevPromenne = new Label();
            btPridat = new Button();
            tbNazevPromenne = new TextBox();
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
            panelConsole = new Panel();
            tbConsole = new TextBox();
            mainTimer = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuPanely = new ToolStripMenuItem();
            itemPromenne = new ToolStripMenuItem();
            itemPodminky = new ToolStripMenuItem();
            panelInformaci.SuspendLayout();
            panelPodminky.SuspendLayout();
            menuStrip2.SuspendLayout();
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
            // panelInformaci
            // 
            panelInformaci.BackColor = Color.Gray;
            panelInformaci.Controls.Add(lbHodnota);
            panelInformaci.Controls.Add(tbHodnota);
            panelInformaci.Controls.Add(lbNazevPromenne);
            panelInformaci.Controls.Add(btPridat);
            panelInformaci.Controls.Add(tbNazevPromenne);
            panelInformaci.Location = new Point(10, 38);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(252, 361);
            panelInformaci.TabIndex = 2;
            // 
            // lbHodnota
            // 
            lbHodnota.AutoSize = true;
            lbHodnota.Location = new Point(8, 86);
            lbHodnota.Name = "lbHodnota";
            lbHodnota.Size = new Size(54, 15);
            lbHodnota.TabIndex = 7;
            lbHodnota.Text = "Hodnota";
            // 
            // tbHodnota
            // 
            tbHodnota.Location = new Point(69, 83);
            tbHodnota.Margin = new Padding(3, 2, 3, 2);
            tbHodnota.Name = "tbHodnota";
            tbHodnota.Size = new Size(154, 23);
            tbHodnota.TabIndex = 6;
            // 
            // lbNazevPromenne
            // 
            lbNazevPromenne.AutoSize = true;
            lbNazevPromenne.Location = new Point(8, 59);
            lbNazevPromenne.Name = "lbNazevPromenne";
            lbNazevPromenne.Size = new Size(39, 15);
            lbNazevPromenne.TabIndex = 4;
            lbNazevPromenne.Text = "Název";
            // 
            // btPridat
            // 
            btPridat.Enabled = false;
            btPridat.Location = new Point(69, 113);
            btPridat.Margin = new Padding(3, 2, 3, 2);
            btPridat.Name = "btPridat";
            btPridat.Size = new Size(86, 26);
            btPridat.TabIndex = 2;
            btPridat.Text = "Pøidat";
            btPridat.UseVisualStyleBackColor = true;
            btPridat.Click += btPridat_Click;
            // 
            // tbNazevPromenne
            // 
            tbNazevPromenne.Location = new Point(69, 56);
            tbNazevPromenne.Margin = new Padding(3, 2, 3, 2);
            tbNazevPromenne.Name = "tbNazevPromenne";
            tbNazevPromenne.Size = new Size(154, 23);
            tbNazevPromenne.TabIndex = 1;
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
            panelPodminky.Location = new Point(10, 38);
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
            itemVetsi.Size = new Size(180, 22);
            itemVetsi.Text = ">";
            itemVetsi.Click += itemVetsi_Click;
            // 
            // itemMensi
            // 
            itemMensi.Name = "itemMensi";
            itemMensi.Size = new Size(180, 22);
            itemMensi.Text = "<";
            itemMensi.Click += itemMensi_Click;
            // 
            // itemMensiRovno
            // 
            itemMensiRovno.Name = "itemMensiRovno";
            itemMensiRovno.Size = new Size(180, 22);
            itemMensiRovno.Text = "<=";
            itemMensiRovno.Click += itemMensiRovno_Click;
            // 
            // itemVetsiRovno
            // 
            itemVetsiRovno.Name = "itemVetsiRovno";
            itemVetsiRovno.Size = new Size(180, 22);
            itemVetsiRovno.Text = ">=";
            itemVetsiRovno.Click += itemVetsiRovno_Click;
            // 
            // itemRovnost
            // 
            itemRovnost.Name = "itemRovnost";
            itemRovnost.Size = new Size(180, 22);
            itemRovnost.Text = "==";
            itemRovnost.Click += itemRovnost_Click;
            // 
            // itemNerovnost
            // 
            itemNerovnost.Name = "itemNerovnost";
            itemNerovnost.Size = new Size(180, 22);
            itemNerovnost.Text = "!=";
            itemNerovnost.Click += itemNerovnost_Click;
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
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(518, 81);
            tbConsole.TabIndex = 0;
            tbConsole.TabStop = false;
            tbConsole.Text = ">";
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 1;
            mainTimer.Tick += mainTimer_Tick;
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
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            panelPodminky.ResumeLayout(false);
            panelPodminky.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private TextBox tbNazevPromenne;
        private Button btPridat;
        private Panel panelConsole;
        private TextBox tbConsole;
        private Label lbNazevPromenne;
        private Label lbHodnota;
        private TextBox tbHodnota;
        private System.Windows.Forms.Timer mainTimer;
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
    }
}