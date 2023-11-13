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
            ListViewGroup listViewGroup5 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup6 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup7 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup8 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            panelPracovni = new Panel();
            panelPodminky = new Panel();
            btPridatPodminku = new Button();
            tbPodminka = new TextBox();
            lbPodminka = new Label();
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
            panelPracovni.Location = new Point(306, 51);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(951, 481);
            panelPracovni.TabIndex = 1;
            // 
            // panelPodminky
            // 
            panelPodminky.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPodminky.BackColor = Color.Gray;
            panelPodminky.Controls.Add(btPridatPodminku);
            panelPodminky.Controls.Add(tbPodminka);
            panelPodminky.Controls.Add(lbPodminka);
            panelPodminky.Location = new Point(11, 51);
            panelPodminky.Margin = new Padding(3, 4, 3, 4);
            panelPodminky.Name = "panelPodminky";
            panelPodminky.Size = new Size(288, 481);
            panelPodminky.TabIndex = 3;
            // 
            // btPridatPodminku
            // 
            btPridatPodminku.Location = new Point(39, 113);
            btPridatPodminku.Name = "btPridatPodminku";
            btPridatPodminku.Size = new Size(183, 29);
            btPridatPodminku.TabIndex = 6;
            btPridatPodminku.Text = "Pøidat podmínku";
            btPridatPodminku.UseVisualStyleBackColor = true;
            btPridatPodminku.Click += btPridaniPodminky_Click;
            // 
            // tbPodminka
            // 
            tbPodminka.Location = new Point(39, 69);
            tbPodminka.Name = "tbPodminka";
            tbPodminka.Size = new Size(175, 27);
            tbPodminka.TabIndex = 3;
            // 
            // lbPodminka
            // 
            lbPodminka.AutoSize = true;
            lbPodminka.Location = new Point(39, 47);
            lbPodminka.Name = "lbPodminka";
            lbPodminka.Size = new Size(74, 20);
            lbPodminka.TabIndex = 0;
            lbPodminka.Text = "Podminka";
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
            panelInformaci.Location = new Point(10, 51);
            panelInformaci.Margin = new Padding(3, 4, 3, 4);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(288, 481);
            panelInformaci.TabIndex = 2;
            // 
            // tbNajitPromennou
            // 
            tbNajitPromennou.Location = new Point(3, 179);
            tbNajitPromennou.Margin = new Padding(3, 4, 3, 4);
            tbNajitPromennou.Name = "tbNajitPromennou";
            tbNajitPromennou.Size = new Size(281, 27);
            tbNajitPromennou.TabIndex = 13;
            tbNajitPromennou.TextChanged += tbNajitPromennou_TextChanged;
            // 
            // lbVytvorene
            // 
            lbVytvorene.AutoSize = true;
            lbVytvorene.Location = new Point(3, 155);
            lbVytvorene.Name = "lbVytvorene";
            lbVytvorene.Size = new Size(147, 20);
            lbVytvorene.TabIndex = 12;
            lbVytvorene.Text = "Vytvoøené promìnné";
            // 
            // lvPromenne
            // 
            lvPromenne.BorderStyle = BorderStyle.FixedSingle;
            lvPromenne.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "test";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "test1";
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "test2";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "test3";
            lvPromenne.Groups.AddRange(new ListViewGroup[] { listViewGroup5, listViewGroup6, listViewGroup7, listViewGroup8 });
            lvPromenne.Location = new Point(3, 212);
            lvPromenne.Margin = new Padding(3, 4, 3, 4);
            lvPromenne.Name = "lvPromenne";
            lvPromenne.Size = new Size(281, 265);
            lvPromenne.TabIndex = 11;
            lvPromenne.UseCompatibleStateImageBehavior = false;
            lvPromenne.View = View.List;
            lvPromenne.Click += lvPromenne_Click;
            // 
            // lbPriklady
            // 
            lbPriklady.AutoSize = true;
            lbPriklady.Location = new Point(3, 80);
            lbPriklady.Name = "lbPriklady";
            lbPriklady.Size = new Size(273, 20);
            lbPriklady.TabIndex = 10;
            lbPriklady.Text = "Pøíklady: a = 5, b = 3.14, jmeno = Aneta ";
            // 
            // lbPromenna
            // 
            lbPromenna.AutoSize = true;
            lbPromenna.Location = new Point(3, 21);
            lbPromenna.Name = "lbPromenna";
            lbPromenna.Size = new Size(116, 20);
            lbPromenna.TabIndex = 9;
            lbPromenna.Text = "Nová promìnná";
            // 
            // tbPromenna
            // 
            tbPromenna.Location = new Point(3, 45);
            tbPromenna.Margin = new Padding(3, 4, 3, 4);
            tbPromenna.Name = "tbPromenna";
            tbPromenna.Size = new Size(281, 27);
            tbPromenna.TabIndex = 8;
            tbPromenna.KeyDown += tbPromenna_KeyDown;
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
            tbConsole.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbConsole.BackColor = Color.Black;
            tbConsole.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(3, 3);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(591, 107);
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
            panelVlastnosti.Location = new Point(615, 548);
            panelVlastnosti.Margin = new Padding(3, 4, 3, 4);
            panelVlastnosti.Name = "panelVlastnosti";
            panelVlastnosti.Size = new Size(640, 111);
            panelVlastnosti.TabIndex = 5;
            // 
            // btNajitP
            // 
            btNajitP.Location = new Point(527, 7);
            btNajitP.Margin = new Padding(3, 4, 3, 4);
            btNajitP.Name = "btNajitP";
            btNajitP.Size = new Size(110, 31);
            btNajitP.TabIndex = 3;
            btNajitP.Text = "Najít na ploše";
            btNajitP.UseVisualStyleBackColor = true;
            btNajitP.Click += btNajitP_Click;
            // 
            // lbTypP
            // 
            lbTypP.AutoSize = true;
            lbTypP.Location = new Point(3, 71);
            lbTypP.Name = "lbTypP";
            lbTypP.Size = new Size(88, 20);
            lbTypP.TabIndex = 2;
            lbTypP.Text = "Datový typ: ";
            // 
            // lbHodnotaP
            // 
            lbHodnotaP.AutoSize = true;
            lbHodnotaP.Location = new Point(3, 39);
            lbHodnotaP.Name = "lbHodnotaP";
            lbHodnotaP.Size = new Size(75, 20);
            lbHodnotaP.TabIndex = 1;
            lbHodnotaP.Text = "Hodnota: ";
            // 
            // lbNazevP
            // 
            lbNazevP.AutoSize = true;
            lbNazevP.Location = new Point(3, 7);
            lbNazevP.Name = "lbNazevP";
            lbNazevP.Size = new Size(57, 20);
            lbNazevP.TabIndex = 0;
            lbNazevP.Text = "Název: ";
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { menuSoubor, menuPanely });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Padding = new Padding(7, 3, 0, 3);
            menuMain.Size = new Size(1269, 30);
            menuMain.TabIndex = 6;
            menuMain.Text = "menuStrip1";
            // 
            // menuSoubor
            // 
            menuSoubor.DropDownItems.AddRange(new ToolStripItem[] { itemSave, itemOpen });
            menuSoubor.Name = "menuSoubor";
            menuSoubor.Size = new Size(71, 24);
            menuSoubor.Text = "Soubor";
            // 
            // itemSave
            // 
            itemSave.Name = "itemSave";
            itemSave.Size = new Size(137, 26);
            itemSave.Text = "Uložit";
            // 
            // itemOpen
            // 
            itemOpen.Name = "itemOpen";
            itemOpen.Size = new Size(137, 26);
            itemOpen.Text = "Otevøít";
            // 
            // menuPanely
            // 
            menuPanely.DropDownItems.AddRange(new ToolStripItem[] { itemVars, itemIfs });
            menuPanely.Name = "menuPanely";
            menuPanely.Size = new Size(65, 24);
            menuPanely.Text = "Panely";
            // 
            // itemVars
            // 
            itemVars.Name = "itemVars";
            itemVars.Size = new Size(159, 26);
            itemVars.Text = "Promìnné";
            itemVars.Click += itemVars_Click;
            // 
            // itemIfs
            // 
            itemIfs.Name = "itemIfs";
            itemIfs.Size = new Size(159, 26);
            itemIfs.Text = "Podmínky";
            itemIfs.Click += itemIfs_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1269, 663);
            Controls.Add(panelVlastnosti);
            Controls.Add(panelConsole);
            Controls.Add(panelPracovni);
            Controls.Add(menuMain);
            Controls.Add(panelInformaci);
            Controls.Add(panelPodminky);
            MainMenuStrip = menuMain;
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
        private TextBox tbPromenna2;
        private TextBox tbPodminka;
        private Label lbPromenna2;
        private Label lbOperator;
        private Label lbPodminka;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem operatory;
        private ToolStripMenuItem itemVetsi;
        private ToolStripMenuItem itemMensi;
        private ToolStripMenuItem itemMensiRovno;
        private ToolStripMenuItem itemVetsiRovno;
        private ToolStripMenuItem itemRovnost;
        private Button btPridatPodminku;
        private ToolStripMenuItem itemNerovnost;
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
    }
}