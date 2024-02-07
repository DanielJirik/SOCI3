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
            panelSwitch = new Panel();
            label2 = new Label();
            tbInputVariable = new TextBox();
            label1 = new Label();
            tbConsole = new TextBox();
            panelInformaci = new Panel();
            tbNajitPromennou = new TextBox();
            lbVytvorene = new Label();
            lvPromenne = new ListView();
            menuPanels = new MenuStrip();
            panelsToolStripMenuItem = new ToolStripMenuItem();
            variablesToolStripMenuItem = new ToolStripMenuItem();
            conditionsToolStripMenuItem = new ToolStripMenuItem();
            switchesToolStripMenuItem = new ToolStripMenuItem();
            cyclesToolStripMenuItem = new ToolStripMenuItem();
            forToolStripMenuItem = new ToolStripMenuItem();
            whileToolStripMenuItem = new ToolStripMenuItem();
            doWhileToolStripMenuItem = new ToolStripMenuItem();
            panelPracovni.SuspendLayout();
            panelSwitch.SuspendLayout();
            panelInformaci.SuspendLayout();
            menuPanels.SuspendLayout();
            SuspendLayout();
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.AutoScrollMargin = new Size(50, 50);
            panelPracovni.AutoScrollMinSize = new Size(2000, 1100);
            panelPracovni.BackColor = Color.Gray;
            panelPracovni.Controls.Add(panelSwitch);
            panelPracovni.Controls.Add(tbConsole);
            panelPracovni.Controls.Add(panelInformaci);
            panelPracovni.Controls.Add(menuPanels);
            panelPracovni.Dock = DockStyle.Fill;
            panelPracovni.Location = new Point(0, 0);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(1269, 681);
            panelPracovni.TabIndex = 1;
            panelPracovni.MouseClick += panelPracovni_MouseClick;
            panelPracovni.MouseDown += panelPracovni_MouseDown;
            // 
            // panelSwitch
            // 
            panelSwitch.BackColor = Color.FromArgb(192, 255, 192);
            panelSwitch.Controls.Add(label2);
            panelSwitch.Controls.Add(tbInputVariable);
            panelSwitch.Controls.Add(label1);
            panelSwitch.Location = new Point(612, 17);
            panelSwitch.Name = "panelSwitch";
            panelSwitch.Size = new Size(229, 107);
            panelSwitch.TabIndex = 6;
            panelSwitch.MouseDown += panelSwitch_MouseDown;
            panelSwitch.MouseMove += panelSwitch_MouseMove;
            panelSwitch.MouseUp += panelSwitch_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 36);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Vstupní proměnná";
            // 
            // tbInputVariable
            // 
            tbInputVariable.Location = new Point(3, 67);
            tbInputVariable.Name = "tbInputVariable";
            tbInputVariable.Size = new Size(159, 27);
            tbInputVariable.TabIndex = 1;
            tbInputVariable.KeyDown += tbInputVariable_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Switch:";
            // 
            // tbConsole
            // 
            tbConsole.BackColor = Color.Black;
            tbConsole.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbConsole.ForeColor = Color.White;
            tbConsole.Location = new Point(11, 17);
            tbConsole.Multiline = true;
            tbConsole.Name = "tbConsole";
            tbConsole.ReadOnly = true;
            tbConsole.ScrollBars = ScrollBars.Vertical;
            tbConsole.Size = new Size(258, 107);
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
            panelInformaci.Location = new Point(309, 17);
            panelInformaci.Margin = new Padding(3, 4, 3, 4);
            panelInformaci.Name = "panelInformaci";
            panelInformaci.Size = new Size(264, 157);
            panelInformaci.TabIndex = 2;
            panelInformaci.MouseDown += panelInformaci_MouseDown;
            panelInformaci.MouseMove += panelInformaci_MouseMove;
            panelInformaci.MouseUp += panelInformaci_MouseUp;
            // 
            // tbNajitPromennou
            // 
            tbNajitPromennou.Location = new Point(3, 36);
            tbNajitPromennou.Margin = new Padding(3, 4, 3, 4);
            tbNajitPromennou.Name = "tbNajitPromennou";
            tbNajitPromennou.Size = new Size(197, 27);
            tbNajitPromennou.TabIndex = 13;
            // 
            // lbVytvorene
            // 
            lbVytvorene.AutoSize = true;
            lbVytvorene.Location = new Point(3, 12);
            lbVytvorene.Name = "lbVytvorene";
            lbVytvorene.Size = new Size(147, 20);
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
            lvPromenne.Location = new Point(3, 71);
            lvPromenne.Margin = new Padding(3, 4, 3, 4);
            lvPromenne.Name = "lvPromenne";
            lvPromenne.Size = new Size(253, 74);
            lvPromenne.TabIndex = 11;
            lvPromenne.UseCompatibleStateImageBehavior = false;
            lvPromenne.View = View.List;
            // 
            // menuPanels
            // 
            menuPanels.Dock = DockStyle.None;
            menuPanels.ImageScalingSize = new Size(20, 20);
            menuPanels.Items.AddRange(new ToolStripItem[] { panelsToolStripMenuItem });
            menuPanels.Location = new Point(335, 384);
            menuPanels.Name = "menuPanels";
            menuPanels.Size = new Size(72, 28);
            menuPanels.TabIndex = 7;
            menuPanels.Text = "menuStrip1";
            menuPanels.Click += menuPanels_Click;
            // 
            // panelsToolStripMenuItem
            // 
            panelsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { variablesToolStripMenuItem, conditionsToolStripMenuItem, switchesToolStripMenuItem, cyclesToolStripMenuItem });
            panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            panelsToolStripMenuItem.Size = new Size(64, 24);
            panelsToolStripMenuItem.Text = "Panels";
            // 
            // variablesToolStripMenuItem
            // 
            variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            variablesToolStripMenuItem.Size = new Size(163, 26);
            variablesToolStripMenuItem.Text = "Variables";
            variablesToolStripMenuItem.Click += variablesToolStripMenuItem_Click_1;
            // 
            // conditionsToolStripMenuItem
            // 
            conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            conditionsToolStripMenuItem.Size = new Size(163, 26);
            conditionsToolStripMenuItem.Text = "Conditions";
            conditionsToolStripMenuItem.Click += conditionsToolStripMenuItem_Click_1;
            // 
            // switchesToolStripMenuItem
            // 
            switchesToolStripMenuItem.Name = "switchesToolStripMenuItem";
            switchesToolStripMenuItem.Size = new Size(163, 26);
            switchesToolStripMenuItem.Text = "Switches";
            switchesToolStripMenuItem.Click += switchesToolStripMenuItem_Click;
            // 
            // cyclesToolStripMenuItem
            // 
            cyclesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { forToolStripMenuItem, whileToolStripMenuItem, doWhileToolStripMenuItem });
            cyclesToolStripMenuItem.Name = "cyclesToolStripMenuItem";
            cyclesToolStripMenuItem.Size = new Size(163, 26);
            cyclesToolStripMenuItem.Text = "Cycles";
            // 
            // forToolStripMenuItem
            // 
            forToolStripMenuItem.Name = "forToolStripMenuItem";
            forToolStripMenuItem.Size = new Size(159, 26);
            forToolStripMenuItem.Text = "For";
            // 
            // whileToolStripMenuItem
            // 
            whileToolStripMenuItem.Name = "whileToolStripMenuItem";
            whileToolStripMenuItem.Size = new Size(159, 26);
            whileToolStripMenuItem.Text = "While";
            // 
            // doWhileToolStripMenuItem
            // 
            doWhileToolStripMenuItem.Name = "doWhileToolStripMenuItem";
            doWhileToolStripMenuItem.Size = new Size(159, 26);
            doWhileToolStripMenuItem.Text = "Do...While";
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1269, 681);
            Controls.Add(panelPracovni);
            MainMenuStrip = menuPanels;
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            FormClosing += formHlavniProTvorbu_FormClosing;
            panelPracovni.ResumeLayout(false);
            panelPracovni.PerformLayout();
            panelSwitch.ResumeLayout(false);
            panelSwitch.PerformLayout();
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            menuPanels.ResumeLayout(false);
            menuPanels.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPracovni;
        private Panel panelInformaci;
        private TextBox tbConsole;
        private Label lbVytvorene;
        private ListView lvPromenne;
        private TextBox tbNajitPromennou;
        private Panel panelSwitch;
        private Label label2;
        private TextBox tbInputVariable;
        private Label label1;
        private MenuStrip menuPanels;
        private ToolStripMenuItem panelsToolStripMenuItem;
        private ToolStripMenuItem variablesToolStripMenuItem;
        private ToolStripMenuItem conditionsToolStripMenuItem;
        private ToolStripMenuItem switchesToolStripMenuItem;
        private ToolStripMenuItem cyclesToolStripMenuItem;
        private ToolStripMenuItem forToolStripMenuItem;
        private ToolStripMenuItem whileToolStripMenuItem;
        private ToolStripMenuItem doWhileToolStripMenuItem;
    }
}