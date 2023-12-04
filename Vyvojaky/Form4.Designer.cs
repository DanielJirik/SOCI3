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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            panelPracovni = new Panel();
            panelPodminky = new Panel();
            tbPodminka = new TextBox();
            lbPromenna1 = new Label();
            panelInformaci = new Panel();
            tbNajitPromennou = new TextBox();
            lbVytvorene = new Label();
            lvPromenne = new ListView();
            lbPriklady = new Label();
            lbPromenna = new Label();
            tbPromenna = new TextBox();
            panelConsole = new Panel();
            tbConsole = new TextBox();
            panelVlastnosti = new Panel();
            btNajitP = new Button();
            lbTypP = new Label();
            lbHodnotaP = new Label();
            lbNazevP = new Label();
            menuMain = new MenuStrip();
            menuSoubor = new ToolStripMenuItem();
            itemSave = new ToolStripMenuItem();
            itemOpen = new ToolStripMenuItem();
            menuPanely = new ToolStripMenuItem();
            itemVars = new ToolStripMenuItem();
            itemIfs = new ToolStripMenuItem();
            panelPodminky.SuspendLayout();
            panelInformaci.SuspendLayout();
            panelConsole.SuspendLayout();
            panelVlastnosti.SuspendLayout();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            panelPodminky.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPodminky.BackColor = Color.Gray;
            panelPodminky.Controls.Add(tbPodminka);
            panelPodminky.Controls.Add(lbPromenna1);
            panelPodminky.Location = new Point(10, 38);
            panelPodminky.Name = "panelPodminky";
            panelPodminky.Size = new Size(252, 361);
            panelPodminky.TabIndex = 3;
            // 
            // tbPodminka
            // 
            tbPodminka.Location = new Point(34, 60);
            tbPodminka.Name = "tbPodminka";
            tbPodminka.Size = new Size(145, 23);
            tbPodminka.TabIndex = 1;
            tbPodminka.KeyDown += tbPodminka_KeyDown;
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
            // panelInformaci
            // 
            panelInformaci.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelInformaci.BackColor = Color.Gray;
            panelInformaci.Controls.Add(tbNajitPromennou);
            panelInformaci.Controls.Add(lbVytvorene);
            panelInformaci.Controls.Add(lvPromenne);
            panelInformaci.Controls.Add(lbPriklady);
            panelInformaci.Controls.Add(lbPromenna);
            panelInformaci.Controls.Add(tbPromenna);
            panelInformaci.Location = new Point(10, 38);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(252, 361);
            panelInformaci.TabIndex = 2;
            // 
            // tbNajitPromennou
            // 
            tbNajitPromennou.Location = new Point(3, 134);
            tbNajitPromennou.Name = "tbNajitPromennou";
            tbNajitPromennou.Size = new Size(246, 23);
            tbNajitPromennou.TabIndex = 13;
            tbNajitPromennou.TextChanged += tbNajitPromennou_TextChanged;
            // 
            // lbVytvorene
            // 
            lbVytvorene.AutoSize = true;
            lbVytvorene.Location = new Point(3, 116);
            lbVytvorene.Name = "lbVytvorene";
            lbVytvorene.Size = new Size(118, 15);
            lbVytvorene.TabIndex = 12;
            lbVytvorene.Text = "Vytvoøené promìnné";
            // 
            // lvPromenne
            // 
            lvPromenne.BorderStyle = BorderStyle.FixedSingle;
            lvPromenne.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "test";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "test1";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "test2";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "test3";
            lvPromenne.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3, listViewGroup4 });
            lvPromenne.Location = new Point(3, 159);
            lvPromenne.Name = "lvPromenne";
            lvPromenne.Size = new Size(246, 199);
            lvPromenne.TabIndex = 11;
            lvPromenne.UseCompatibleStateImageBehavior = false;
            lvPromenne.View = View.List;
            lvPromenne.Click += lvPromenne_Click;
            // 
            // lbPriklady
            // 
            lbPriklady.AutoSize = true;
            lbPriklady.Location = new Point(3, 60);
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
            lbPromenna.Size = new Size(93, 15);
            lbPromenna.TabIndex = 9;
            lbPromenna.Text = "Nová promìnná";
            // 
            // tbPromenna
            // 
            tbPromenna.Location = new Point(3, 34);
            tbPromenna.Name = "tbPromenna";
            tbPromenna.Size = new Size(246, 23);
            tbPromenna.TabIndex = 8;
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
            tbConsole.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // panelVlastnosti
            // 
            panelVlastnosti.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelVlastnosti.BackColor = Color.Gray;
            panelVlastnosti.Controls.Add(btNajitP);
            panelVlastnosti.Controls.Add(lbTypP);
            panelVlastnosti.Controls.Add(lbHodnotaP);
            panelVlastnosti.Controls.Add(lbNazevP);
            panelVlastnosti.Location = new Point(538, 411);
            panelVlastnosti.Name = "panelVlastnosti";
            panelVlastnosti.Size = new Size(560, 83);
            panelVlastnosti.TabIndex = 5;
            // 
            // btNajitP
            // 
            btNajitP.Location = new Point(461, 5);
            btNajitP.Name = "btNajitP";
            btNajitP.Size = new Size(96, 23);
            btNajitP.TabIndex = 3;
            btNajitP.Text = "Najít na ploše";
            btNajitP.UseVisualStyleBackColor = true;
            btNajitP.Click += btNajitP_Click;
            // 
            // lbTypP
            // 
            lbTypP.AutoSize = true;
            lbTypP.Location = new Point(3, 53);
            lbTypP.Name = "lbTypP";
            lbTypP.Size = new Size(70, 15);
            lbTypP.TabIndex = 2;
            lbTypP.Text = "Datový typ: ";
            // 
            // lbHodnotaP
            // 
            lbHodnotaP.AutoSize = true;
            lbHodnotaP.Location = new Point(3, 29);
            lbHodnotaP.Name = "lbHodnotaP";
            lbHodnotaP.Size = new Size(60, 15);
            lbHodnotaP.TabIndex = 1;
            lbHodnotaP.Text = "Hodnota: ";
            // 
            // lbNazevP
            // 
            lbNazevP.AutoSize = true;
            lbNazevP.Location = new Point(3, 5);
            lbNazevP.Name = "lbNazevP";
            lbNazevP.Size = new Size(45, 15);
            lbNazevP.TabIndex = 0;
            lbNazevP.Text = "Název: ";
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { menuSoubor, menuPanely });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(1110, 24);
            menuMain.TabIndex = 6;
            menuMain.Text = "menuStrip1";
            // 
            // menuSoubor
            // 
            menuSoubor.DropDownItems.AddRange(new ToolStripItem[] { itemSave, itemOpen });
            menuSoubor.Name = "menuSoubor";
            menuSoubor.Size = new Size(57, 20);
            menuSoubor.Text = "Soubor";
            // 
            // itemSave
            // 
            itemSave.Name = "itemSave";
            itemSave.Size = new Size(110, 22);
            itemSave.Text = "Uložit";
            // 
            // itemOpen
            // 
            itemOpen.Name = "itemOpen";
            itemOpen.Size = new Size(110, 22);
            itemOpen.Text = "Otevøít";
            // 
            // menuPanely
            // 
            menuPanely.DropDownItems.AddRange(new ToolStripItem[] { itemVars, itemIfs });
            menuPanely.Name = "menuPanely";
            menuPanely.Size = new Size(54, 20);
            menuPanely.Text = "Panely";
            // 
            // itemVars
            // 
            itemVars.Name = "itemVars";
            itemVars.Size = new Size(129, 22);
            itemVars.Text = "Promìnné";
            itemVars.Click += itemVars_Click;
            // 
            // itemIfs
            // 
            itemIfs.Name = "itemIfs";
            itemIfs.Size = new Size(129, 22);
            itemIfs.Text = "Podmínky";
            itemIfs.Click += itemIfs_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1110, 497);
            Controls.Add(panelVlastnosti);
            Controls.Add(panelConsole);
            Controls.Add(panelPracovni);
            Controls.Add(menuMain);
            Controls.Add(panelInformaci);
            Controls.Add(panelPodminky);
            MainMenuStrip = menuMain;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            FormClosing += formHlavniProTvorbu_FormClosing;
            panelPodminky.ResumeLayout(false);
            panelPodminky.PerformLayout();
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            panelConsole.ResumeLayout(false);
            panelConsole.PerformLayout();
            panelVlastnosti.ResumeLayout(false);
            panelVlastnosti.PerformLayout();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private Panel panelConsole;
        private TextBox tbConsole;
        private Panel panelPodminky;
        private Label lbPromenna1;
        private TextBox tbPromenna;
        private Label lbPriklady;
        private Label lbPromenna;
        private Label lbVytvorene;
        private ListView lvPromenne;
        private TextBox tbNajitPromennou;
        private Panel panelVlastnosti;
        private Label lbNazevP;
        private Label lbHodnotaP;
        private Label lbTypP;
        private Button btNajitP;
        private MenuStrip menuMain;
        private ToolStripMenuItem menuPanely;
        private ToolStripMenuItem itemVars;
        private ToolStripMenuItem itemIfs;
        private ToolStripMenuItem menuSoubor;
        private ToolStripMenuItem itemSave;
        private ToolStripMenuItem itemOpen;
        private TextBox tbPodminka;
    }
}