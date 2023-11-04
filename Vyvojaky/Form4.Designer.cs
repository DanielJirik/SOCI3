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
            lbHodnota = new Label();
            tbHodnota = new TextBox();
            lbTypPopis = new Label();
            lbNazevPromenne = new Label();
            btPridat = new Button();
            tbNazevPromenne = new TextBox();
            mMoznosti = new MenuStrip();
            menuTypy = new ToolStripMenuItem();
            int16ToolStripMenuItem = new ToolStripMenuItem();
            int32ToolStripMenuItem = new ToolStripMenuItem();
            int64ToolStripMenuItem = new ToolStripMenuItem();
            floatToolStripMenuItem = new ToolStripMenuItem();
            doubleToolStripMenuItem = new ToolStripMenuItem();
            boolToolStripMenuItem = new ToolStripMenuItem();
            stringToolStripMenuItem = new ToolStripMenuItem();
            charToolStripMenuItem = new ToolStripMenuItem();
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
            mMoznosti.SuspendLayout();
            panelConsole.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.BackColor = Color.Gray;
            panelPracovni.Location = new Point(306, 51);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(951, 481);
            panelPracovni.TabIndex = 1;
            // 
            // panelInformaci
            // 
            panelInformaci.BackColor = Color.Gray;
            panelInformaci.Controls.Add(panelPodminky);
            panelInformaci.Controls.Add(lbHodnota);
            panelInformaci.Controls.Add(tbHodnota);
            panelInformaci.Controls.Add(lbTypPopis);
            panelInformaci.Controls.Add(lbNazevPromenne);
            panelInformaci.Controls.Add(btPridat);
            panelInformaci.Controls.Add(tbNazevPromenne);
            panelInformaci.Controls.Add(mMoznosti);
            panelInformaci.Location = new Point(11, 51);
            panelInformaci.Margin = new Padding(3, 4, 3, 4);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(288, 481);
            panelInformaci.TabIndex = 2;
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
            panelPodminky.Location = new Point(0, 0);
            panelPodminky.Margin = new Padding(3, 4, 3, 4);
            panelPodminky.Name = "panelPodminky";
            panelPodminky.Size = new Size(288, 481);
            panelPodminky.TabIndex = 3;
            // 
            // btPodminka
            // 
            btPodminka.Location = new Point(34, 255);
            btPodminka.Name = "btPodminka";
            btPodminka.Size = new Size(183, 29);
            btPodminka.TabIndex = 6;
            btPodminka.Text = "Spustit Podminku";
            btPodminka.UseVisualStyleBackColor = true;
            btPodminka.Click += btPodminka_Click;
            // 
            // tbPromenna2
            // 
            tbPromenna2.Location = new Point(39, 212);
            tbPromenna2.Name = "tbPromenna2";
            tbPromenna2.Size = new Size(175, 27);
            tbPromenna2.TabIndex = 4;
            // 
            // tbPromenna1
            // 
            tbPromenna1.Location = new Point(39, 70);
            tbPromenna1.Name = "tbPromenna1";
            tbPromenna1.Size = new Size(175, 27);
            tbPromenna1.TabIndex = 3;
            // 
            // lbPromenna2
            // 
            lbPromenna2.AutoSize = true;
            lbPromenna2.Location = new Point(34, 189);
            lbPromenna2.Name = "lbPromenna2";
            lbPromenna2.Size = new Size(183, 20);
            lbPromenna2.TabIndex = 2;
            lbPromenna2.Text = "Druhá promìnná/hodnota";
            // 
            // lbOperator
            // 
            lbOperator.AutoSize = true;
            lbOperator.Location = new Point(39, 118);
            lbOperator.Name = "lbOperator";
            lbOperator.Size = new Size(72, 20);
            lbOperator.TabIndex = 1;
            lbOperator.Text = "Operátor:";
            // 
            // lbPromenna1
            // 
            lbPromenna1.AutoSize = true;
            lbPromenna1.Location = new Point(39, 47);
            lbPromenna1.Name = "lbPromenna1";
            lbPromenna1.Size = new Size(178, 20);
            lbPromenna1.TabIndex = 0;
            lbPromenna1.Text = "První promìnná/hodnota:";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { operatory });
            menuStrip2.Location = new Point(39, 151);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(98, 28);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // operatory
            // 
            operatory.DropDownItems.AddRange(new ToolStripItem[] { itemVetsi, itemMensi, itemMensiRovno, itemVetsiRovno, itemRovnost, itemNerovnost });
            operatory.Name = "operatory";
            operatory.Size = new Size(90, 24);
            operatory.Text = "Operátory";
            // 
            // itemVetsi
            // 
            itemVetsi.Name = "itemVetsi";
            itemVetsi.Size = new Size(112, 26);
            itemVetsi.Text = ">";
            itemVetsi.Click += itemVetsi_Click;
            // 
            // itemMensi
            // 
            itemMensi.Name = "itemMensi";
            itemMensi.Size = new Size(112, 26);
            itemMensi.Text = "<";
            itemMensi.Click += itemMensi_Click;
            // 
            // itemMensiRovno
            // 
            itemMensiRovno.Name = "itemMensiRovno";
            itemMensiRovno.Size = new Size(112, 26);
            itemMensiRovno.Text = "<=";
            itemMensiRovno.Click += itemMensiRovno_Click;
            // 
            // itemVetsiRovno
            // 
            itemVetsiRovno.Name = "itemVetsiRovno";
            itemVetsiRovno.Size = new Size(112, 26);
            itemVetsiRovno.Text = ">=";
            itemVetsiRovno.Click += itemVetsiRovno_Click;
            // 
            // itemRovnost
            // 
            itemRovnost.Name = "itemRovnost";
            itemRovnost.Size = new Size(112, 26);
            itemRovnost.Text = "==";
            itemRovnost.Click += itemRovnost_Click;
            // 
            // itemNerovnost
            // 
            itemNerovnost.Name = "itemNerovnost";
            itemNerovnost.Size = new Size(112, 26);
            itemNerovnost.Text = "!=";
            itemNerovnost.Click += itemNerovnost_Click;
            // 
            // lbHodnota
            // 
            lbHodnota.AutoSize = true;
            lbHodnota.Location = new Point(9, 115);
            lbHodnota.Name = "lbHodnota";
            lbHodnota.Size = new Size(68, 20);
            lbHodnota.TabIndex = 7;
            lbHodnota.Text = "Hodnota";
            // 
            // tbHodnota
            // 
            tbHodnota.Location = new Point(79, 111);
            tbHodnota.Name = "tbHodnota";
            tbHodnota.Size = new Size(175, 27);
            tbHodnota.TabIndex = 6;
            // 
            // lbTypPopis
            // 
            lbTypPopis.AutoSize = true;
            lbTypPopis.Location = new Point(9, 43);
            lbTypPopis.Name = "lbTypPopis";
            lbTypPopis.Size = new Size(32, 20);
            lbTypPopis.TabIndex = 5;
            lbTypPopis.Text = "Typ";
            // 
            // lbNazevPromenne
            // 
            lbNazevPromenne.AutoSize = true;
            lbNazevPromenne.Location = new Point(9, 79);
            lbNazevPromenne.Name = "lbNazevPromenne";
            lbNazevPromenne.Size = new Size(50, 20);
            lbNazevPromenne.TabIndex = 4;
            lbNazevPromenne.Text = "Název";
            // 
            // btPridat
            // 
            btPridat.Enabled = false;
            btPridat.Location = new Point(79, 151);
            btPridat.Name = "btPridat";
            btPridat.Size = new Size(98, 35);
            btPridat.TabIndex = 2;
            btPridat.Text = "Pøidat";
            btPridat.UseVisualStyleBackColor = true;
            btPridat.Click += btPridat_Click;
            // 
            // tbNazevPromenne
            // 
            tbNazevPromenne.Location = new Point(79, 75);
            tbNazevPromenne.Name = "tbNazevPromenne";
            tbNazevPromenne.Size = new Size(175, 27);
            tbNazevPromenne.TabIndex = 1;
            // 
            // mMoznosti
            // 
            mMoznosti.BackColor = Color.White;
            mMoznosti.Dock = DockStyle.None;
            mMoznosti.ImageScalingSize = new Size(20, 20);
            mMoznosti.Items.AddRange(new ToolStripItem[] { menuTypy });
            mMoznosti.Location = new Point(79, 37);
            mMoznosti.Name = "mMoznosti";
            mMoznosti.Padding = new Padding(6, 3, 0, 3);
            mMoznosti.Size = new Size(61, 30);
            mMoznosti.TabIndex = 0;
            mMoznosti.Text = "menuStrip1";
            // 
            // menuTypy
            // 
            menuTypy.DropDownItems.AddRange(new ToolStripItem[] { int16ToolStripMenuItem, int32ToolStripMenuItem, int64ToolStripMenuItem, floatToolStripMenuItem, doubleToolStripMenuItem, boolToolStripMenuItem, stringToolStripMenuItem, charToolStripMenuItem });
            menuTypy.Name = "menuTypy";
            menuTypy.Size = new Size(53, 24);
            menuTypy.Text = "Typy";
            // 
            // int16ToolStripMenuItem
            // 
            int16ToolStripMenuItem.Name = "int16ToolStripMenuItem";
            int16ToolStripMenuItem.Size = new Size(141, 26);
            int16ToolStripMenuItem.Text = "Int16";
            int16ToolStripMenuItem.Click += int16ToolStripMenuItem_Click;
            // 
            // int32ToolStripMenuItem
            // 
            int32ToolStripMenuItem.Name = "int32ToolStripMenuItem";
            int32ToolStripMenuItem.Size = new Size(141, 26);
            int32ToolStripMenuItem.Text = "Int32";
            int32ToolStripMenuItem.Click += int32ToolStripMenuItem_Click;
            // 
            // int64ToolStripMenuItem
            // 
            int64ToolStripMenuItem.Name = "int64ToolStripMenuItem";
            int64ToolStripMenuItem.Size = new Size(141, 26);
            int64ToolStripMenuItem.Text = "Int64";
            int64ToolStripMenuItem.Click += int64ToolStripMenuItem_Click;
            // 
            // floatToolStripMenuItem
            // 
            floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            floatToolStripMenuItem.Size = new Size(141, 26);
            floatToolStripMenuItem.Text = "Float";
            floatToolStripMenuItem.Click += floatToolStripMenuItem_Click;
            // 
            // doubleToolStripMenuItem
            // 
            doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            doubleToolStripMenuItem.Size = new Size(141, 26);
            doubleToolStripMenuItem.Text = "Double";
            doubleToolStripMenuItem.Click += doubleToolStripMenuItem_Click;
            // 
            // boolToolStripMenuItem
            // 
            boolToolStripMenuItem.Name = "boolToolStripMenuItem";
            boolToolStripMenuItem.Size = new Size(141, 26);
            boolToolStripMenuItem.Text = "Bool";
            boolToolStripMenuItem.Click += boolToolStripMenuItem_Click;
            // 
            // stringToolStripMenuItem
            // 
            stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            stringToolStripMenuItem.Size = new Size(141, 26);
            stringToolStripMenuItem.Text = "String";
            stringToolStripMenuItem.Click += stringToolStripMenuItem_Click;
            // 
            // charToolStripMenuItem
            // 
            charToolStripMenuItem.Name = "charToolStripMenuItem";
            charToolStripMenuItem.Size = new Size(141, 26);
            charToolStripMenuItem.Text = "Char";
            charToolStripMenuItem.Click += charToolStripMenuItem_Click;
            // 
            // panelConsole
            // 
            panelConsole.BackColor = Color.White;
            panelConsole.Controls.Add(tbConsole);
            panelConsole.Location = new Point(11, 545);
            panelConsole.Name = "panelConsole";
            panelConsole.Size = new Size(597, 113);
            panelConsole.TabIndex = 3;
            // 
            // tbConsole
            // 
            tbConsole.BackColor = Color.Black;
            tbConsole.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(3, 3);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(591, 107);
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
            menuStrip1.Location = new Point(14, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(73, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPanely
            // 
            menuPanely.DropDownItems.AddRange(new ToolStripItem[] { itemPromenne, itemPodminky });
            menuPanely.Name = "menuPanely";
            menuPanely.Size = new Size(65, 24);
            menuPanely.Text = "Panely";
            // 
            // itemPromenne
            // 
            itemPromenne.Name = "itemPromenne";
            itemPromenne.Size = new Size(159, 26);
            itemPromenne.Text = "Promìnné";
            itemPromenne.Click += itemPromenne_Click;
            // 
            // itemPodminky
            // 
            itemPodminky.Name = "itemPodminky";
            itemPodminky.Size = new Size(159, 26);
            itemPodminky.Text = "Podmínky";
            itemPodminky.Click += itemPodminky_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1269, 663);
            Controls.Add(panelConsole);
            Controls.Add(panelInformaci);
            Controls.Add(panelPracovni);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            panelPodminky.ResumeLayout(false);
            panelPodminky.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            mMoznosti.ResumeLayout(false);
            mMoznosti.PerformLayout();
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
        private MenuStrip mMoznosti;
        private Button btPridat;
        private ToolStripMenuItem menuTypy;
        private ToolStripMenuItem int16ToolStripMenuItem;
        private ToolStripMenuItem int32ToolStripMenuItem;
        private ToolStripMenuItem int64ToolStripMenuItem;
        private ToolStripMenuItem floatToolStripMenuItem;
        private ToolStripMenuItem doubleToolStripMenuItem;
        private ToolStripMenuItem boolToolStripMenuItem;
        private ToolStripMenuItem stringToolStripMenuItem;
        private ToolStripMenuItem charToolStripMenuItem;
        private Panel panelConsole;
        private TextBox tbConsole;
        private Label lbNazevPromenne;
        private Label lbTypPopis;
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