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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup3 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            ListViewGroup listViewGroup4 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
            panelPracovni = new Panel();
            panelSwitch = new Panel();
            label2 = new Label();
            tbInputVariable = new TextBox();
            label1 = new Label();
            panelVlastnosti = new Panel();
            btNajitP = new Button();
            lbTypP = new Label();
            lbHodnotaP = new Label();
            lbNazevP = new Label();
            tbConsole = new TextBox();
            panelInformaci = new Panel();
            tbNajitPromennou = new TextBox();
            lbVytvorene = new Label();
            lvPromenne = new ListView();
            panelPodminky = new Panel();
            tbPodminka = new TextBox();
            lbPromenna1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            panelsToolStripMenuItem = new ToolStripMenuItem();
            variablesToolStripMenuItem = new ToolStripMenuItem();
            conditionsToolStripMenuItem = new ToolStripMenuItem();
            switchToolStripMenuItem = new ToolStripMenuItem();
            panelPracovni.SuspendLayout();
            panelSwitch.SuspendLayout();
            panelVlastnosti.SuspendLayout();
            panelInformaci.SuspendLayout();
            panelPodminky.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.AutoScrollMargin = new Size(50, 50);
            panelPracovni.AutoScrollMinSize = new Size(2000, 1100);
            panelPracovni.BackColor = Color.Gray;
            panelPracovni.Controls.Add(panelSwitch);
            panelPracovni.Controls.Add(panelVlastnosti);
            panelPracovni.Controls.Add(tbConsole);
            panelPracovni.Controls.Add(panelInformaci);
            panelPracovni.Controls.Add(panelPodminky);
            panelPracovni.Dock = DockStyle.Fill;
            panelPracovni.Location = new Point(0, 0);
            panelPracovni.Margin = new Padding(3, 2, 3, 2);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(1110, 511);
            panelPracovni.TabIndex = 1;
            // 
            // panelSwitch
            // 
            panelSwitch.BackColor = Color.FromArgb(192, 255, 192);
            panelSwitch.Controls.Add(label2);
            panelSwitch.Controls.Add(tbInputVariable);
            panelSwitch.Controls.Add(label1);
            panelSwitch.Location = new Point(550, 80);
            panelSwitch.Margin = new Padding(3, 2, 3, 2);
            panelSwitch.Name = "panelSwitch";
            panelSwitch.Size = new Size(200, 80);
            panelSwitch.TabIndex = 6;
            panelSwitch.MouseDown += panelSwitch_MouseDown;
            panelSwitch.MouseMove += panelSwitch_MouseMove;
            panelSwitch.MouseUp += panelSwitch_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 27);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Vstupní proměnná";
            // 
            // tbInputVariable
            // 
            tbInputVariable.Location = new Point(3, 50);
            tbInputVariable.Margin = new Padding(3, 2, 3, 2);
            tbInputVariable.Name = "tbInputVariable";
            tbInputVariable.Size = new Size(140, 23);
            tbInputVariable.TabIndex = 1;
            tbInputVariable.KeyDown += tbInputVariable_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Switch:";
            // 
            // panelVlastnosti
            // 
            panelVlastnosti.BackColor = Color.FromArgb(192, 255, 192);
            panelVlastnosti.Controls.Add(btNajitP);
            panelVlastnosti.Controls.Add(lbTypP);
            panelVlastnosti.Controls.Add(lbHodnotaP);
            panelVlastnosti.Controls.Add(lbNazevP);
            panelVlastnosti.Location = new Point(10, 110);
            panelVlastnosti.Name = "panelVlastnosti";
            panelVlastnosti.Size = new Size(166, 109);
            panelVlastnosti.TabIndex = 5;
            // 
            // btNajitP
            // 
            btNajitP.Location = new Point(3, 78);
            btNajitP.Name = "btNajitP";
            btNajitP.Size = new Size(96, 23);
            btNajitP.TabIndex = 3;
            btNajitP.Text = "Naj�t na plo�e";
            btNajitP.UseVisualStyleBackColor = true;
            btNajitP.Click += btNajitP_Click;
            // 
            // lbTypP
            // 
            lbTypP.AutoSize = true;
            lbTypP.Location = new Point(3, 53);
            lbTypP.Name = "lbTypP";
            lbTypP.Size = new Size(75, 15);
            lbTypP.TabIndex = 2;
            lbTypP.Text = "Datov� typ: ";
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
            lbNazevP.Size = new Size(50, 15);
            lbNazevP.TabIndex = 0;
            lbNazevP.Text = "N�zev: ";
            // 
            // tbConsole
            // 
            tbConsole.BackColor = Color.Black;
            tbConsole.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(10, 13);
            tbConsole.Margin = new Padding(3, 2, 3, 2);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(226, 81);
            tbConsole.TabIndex = 0;
            tbConsole.TabStop = false;
            tbConsole.Text = ">";
            tbConsole.KeyDown += tbConsole_KeyDown;
            // 
            // panelInformaci
            // 
            panelInformaci.BackColor = Color.FromArgb(192, 255, 192);
            panelInformaci.Controls.Add(tbNajitPromennou);
            panelInformaci.Controls.Add(lbVytvorene);
            panelInformaci.Controls.Add(lvPromenne);
            panelInformaci.Location = new Point(270, 13);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(231, 118);
            panelInformaci.TabIndex = 2;
            panelInformaci.MouseDown += panelInformaci_MouseDown;
            panelInformaci.MouseMove += panelInformaci_MouseMove;
            panelInformaci.MouseUp += panelInformaci_MouseUp;
            // 
            // tbNajitPromennou
            // 
            tbNajitPromennou.Location = new Point(3, 27);
            tbNajitPromennou.Name = "tbNajitPromennou";
            tbNajitPromennou.Size = new Size(173, 23);
            tbNajitPromennou.TabIndex = 13;
            tbNajitPromennou.TextChanged += tbNajitPromennou_TextChanged;
            // 
            // lbVytvorene
            // 
            lbVytvorene.AutoSize = true;
            lbVytvorene.Location = new Point(3, 9);
            lbVytvorene.Name = "lbVytvorene";
            lbVytvorene.Size = new Size(118, 15);
            lbVytvorene.TabIndex = 12;
            lbVytvorene.Text = "Vytvořené proměnné";
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
            lvPromenne.Location = new Point(3, 53);
            lvPromenne.Name = "lvPromenne";
            lvPromenne.Size = new Size(222, 56);
            lvPromenne.TabIndex = 11;
            lvPromenne.UseCompatibleStateImageBehavior = false;
            lvPromenne.View = View.List;
            lvPromenne.Click += lvPromenne_Click;
            // 
            // panelPodminky
            // 
            panelPodminky.BackColor = Color.FromArgb(192, 255, 192);
            panelPodminky.Controls.Add(tbPodminka);
            panelPodminky.Controls.Add(lbPromenna1);
            panelPodminky.Location = new Point(547, 13);
            panelPodminky.Margin = new Padding(3, 2, 3, 2);
            panelPodminky.Name = "panelPodminky";
            panelPodminky.Size = new Size(201, 53);
            panelPodminky.TabIndex = 3;
            panelPodminky.MouseDown += panelPodminky_MouseDown;
            panelPodminky.MouseMove += panelPodminky_MouseMove;
            panelPodminky.MouseUp += panelPodminky_MouseUp;
            // 
            // tbPodminka
            // 
            tbPodminka.Location = new Point(3, 26);
            tbPodminka.Margin = new Padding(3, 2, 3, 2);
            tbPodminka.Name = "tbPodminka";
            tbPodminka.Size = new Size(176, 23);
            tbPodminka.TabIndex = 1;
            // 
            // lbPromenna1
            // 
            lbPromenna1.AutoSize = true;
            lbPromenna1.Location = new Point(3, 9);
            lbPromenna1.Name = "lbPromenna1";
            lbPromenna1.Size = new Size(61, 15);
            lbPromenna1.TabIndex = 0;
            lbPromenna1.Text = "Podmínky";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, panelsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(109, 48);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(108, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // panelsToolStripMenuItem
            // 
            panelsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { variablesToolStripMenuItem, conditionsToolStripMenuItem, switchToolStripMenuItem });
            panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            panelsToolStripMenuItem.Size = new Size(108, 22);
            panelsToolStripMenuItem.Text = "Panels";
            // 
            // variablesToolStripMenuItem
            // 
            variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            variablesToolStripMenuItem.Size = new Size(132, 22);
            variablesToolStripMenuItem.Text = "Variables";
            variablesToolStripMenuItem.Click += variablesToolStripMenuItem_Click;
            // 
            // conditionsToolStripMenuItem
            // 
            conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            conditionsToolStripMenuItem.Size = new Size(132, 22);
            conditionsToolStripMenuItem.Text = "Conditions";
            conditionsToolStripMenuItem.Click += conditionsToolStripMenuItem_Click;
            // 
            // switchToolStripMenuItem
            // 
            switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            switchToolStripMenuItem.Size = new Size(132, 22);
            switchToolStripMenuItem.Text = "Switch";
            switchToolStripMenuItem.Click += switchToolStripMenuItem_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1110, 511);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panelPracovni);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            FormClosing += formHlavniProTvorbu_FormClosing;
            panelPracovni.ResumeLayout(false);
            panelPracovni.PerformLayout();
            panelSwitch.ResumeLayout(false);
            panelSwitch.PerformLayout();
            panelVlastnosti.ResumeLayout(false);
            panelVlastnosti.PerformLayout();
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            panelPodminky.ResumeLayout(false);
            panelPodminky.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private TextBox tbConsole;
        private Panel panelPodminky;
        private Label lbPromenna1;
        private Label lbVytvorene;
        private ListView lvPromenne;
        private TextBox tbNajitPromennou;
        private Panel panelVlastnosti;
        private Label lbNazevP;
        private Label lbHodnotaP;
        private Label lbTypP;
        private Button btNajitP;
        private TextBox tbPodminka;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem panelsToolStripMenuItem;
        private ToolStripMenuItem variablesToolStripMenuItem;
        private ToolStripMenuItem conditionsToolStripMenuItem;
        private ToolStripMenuItem switchToolStripMenuItem;
        private Panel panelSwitch;
        private Label label2;
        private TextBox tbInputVariable;
        private Label label1;
    }
}