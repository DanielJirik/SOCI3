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
            prekladacTb = new TextBox();
            panelPracovni = new Panel();
            btRun = new Button();
            panelSwitch = new Panel();
            label2 = new Label();
            tbInputVariable = new TextBox();
            label1 = new Label();
            tbConsole = new TextBox();
            menuPanels = new MenuStrip();
            panelsToolStripMenuItem = new ToolStripMenuItem();
            variablesToolStripMenuItem = new ToolStripMenuItem();
            conditionsToolStripMenuItem = new ToolStripMenuItem();
            switchesToolStripMenuItem = new ToolStripMenuItem();
            cyclesToolStripMenuItem = new ToolStripMenuItem();
            forToolStripMenuItem = new ToolStripMenuItem();
            whileToolStripMenuItem = new ToolStripMenuItem();
            doWhileToolStripMenuItem = new ToolStripMenuItem();
            processingToolStripMenuItem = new ToolStripMenuItem();
            outputToolStripMenuItem = new ToolStripMenuItem();
            cSharpMenu = new ToolStripMenuItem();
            endForMenu = new ToolStripMenuItem();
            endWhileMenu = new ToolStripMenuItem();
            endDoWhileMenu = new ToolStripMenuItem();
            panelPracovni.SuspendLayout();
            panelSwitch.SuspendLayout();
            menuPanels.SuspendLayout();
            SuspendLayout();
            // 
            // prekladacTb
            // 
            prekladacTb.BackColor = Color.FromArgb(68, 84, 103);
            prekladacTb.Dock = DockStyle.Fill;
            prekladacTb.Location = new Point(0, 0);
            prekladacTb.Multiline = true;
            prekladacTb.Name = "prekladacTb";
            prekladacTb.Size = new Size(1269, 681);
            prekladacTb.TabIndex = 10;
            prekladacTb.MouseDoubleClick += prekladacTb_MouseDoubleClick;
            // 
            // panelPracovni
            // 
            panelPracovni.AutoScroll = true;
            panelPracovni.AutoScrollMargin = new Size(50, 50);
            panelPracovni.AutoScrollMinSize = new Size(2000, 1100);
            panelPracovni.BackColor = Color.FromArgb(68, 84, 103);
            panelPracovni.Controls.Add(btRun);
            panelPracovni.Controls.Add(panelSwitch);
            panelPracovni.Controls.Add(tbConsole);
            panelPracovni.Controls.Add(menuPanels);
            panelPracovni.Dock = DockStyle.Fill;
            panelPracovni.Location = new Point(0, 0);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(1269, 681);
            panelPracovni.TabIndex = 11;
            panelPracovni.Paint += panelPracovni_Paint;
            panelPracovni.MouseClick += panelPracovni_MouseClick;
            panelPracovni.MouseDown += panelPracovni_MouseDown;
            // 
            // btRun
            // 
            btRun.Location = new Point(11, 130);
            btRun.Name = "btRun";
            btRun.Size = new Size(64, 64);
            btRun.TabIndex = 9;
            btRun.Text = "RUN";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // panelSwitch
            // 
            panelSwitch.BackColor = Color.FromArgb(43, 54, 82);
            panelSwitch.Controls.Add(label2);
            panelSwitch.Controls.Add(tbInputVariable);
            panelSwitch.Controls.Add(label1);
            panelSwitch.Location = new Point(325, 17);
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
            label2.ForeColor = Color.White;
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
            label1.ForeColor = Color.White;
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
            // 
            // menuPanels
            // 
            menuPanels.Dock = DockStyle.None;
            menuPanels.ImageScalingSize = new Size(20, 20);
            menuPanels.Items.AddRange(new ToolStripItem[] { panelsToolStripMenuItem, cSharpMenu });
            menuPanels.Location = new Point(335, 384);
            menuPanels.Name = "menuPanels";
            menuPanels.Padding = new Padding(6, 3, 0, 3);
            menuPanels.Size = new Size(263, 30);
            menuPanels.TabIndex = 7;
            menuPanels.Text = "menuStrip1";
            // 
            // panelsToolStripMenuItem
            // 
            panelsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { variablesToolStripMenuItem, conditionsToolStripMenuItem, switchesToolStripMenuItem, cyclesToolStripMenuItem, processingToolStripMenuItem, outputToolStripMenuItem });
            panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            panelsToolStripMenuItem.Size = new Size(64, 24);
            panelsToolStripMenuItem.Text = "Panels";
            // 
            // variablesToolStripMenuItem
            // 
            variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            variablesToolStripMenuItem.Size = new Size(224, 26);
            variablesToolStripMenuItem.Text = "Variables";
            variablesToolStripMenuItem.Click += variablesToolStripMenuItem_Click;
            // 
            // conditionsToolStripMenuItem
            // 
            conditionsToolStripMenuItem.Name = "conditionsToolStripMenuItem";
            conditionsToolStripMenuItem.Size = new Size(224, 26);
            conditionsToolStripMenuItem.Text = "Conditions";
            conditionsToolStripMenuItem.Click += conditionsToolStripMenuItem_Click;
            // 
            // switchesToolStripMenuItem
            // 
            switchesToolStripMenuItem.Name = "switchesToolStripMenuItem";
            switchesToolStripMenuItem.Size = new Size(224, 26);
            switchesToolStripMenuItem.Text = "Switches";
            switchesToolStripMenuItem.Click += switchesToolStripMenuItem_Click;
            // 
            // cyclesToolStripMenuItem
            // 
            cyclesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { forToolStripMenuItem, whileToolStripMenuItem, doWhileToolStripMenuItem, endForMenu, endWhileMenu, endDoWhileMenu });
            cyclesToolStripMenuItem.Name = "cyclesToolStripMenuItem";
            cyclesToolStripMenuItem.Size = new Size(224, 26);
            cyclesToolStripMenuItem.Text = "Cycles";
            // 
            // forToolStripMenuItem
            // 
            forToolStripMenuItem.Name = "forToolStripMenuItem";
            forToolStripMenuItem.Size = new Size(224, 26);
            forToolStripMenuItem.Text = "For";
            forToolStripMenuItem.Click += forToolStripMenuItem_Click;
            // 
            // whileToolStripMenuItem
            // 
            whileToolStripMenuItem.Name = "whileToolStripMenuItem";
            whileToolStripMenuItem.Size = new Size(224, 26);
            whileToolStripMenuItem.Text = "While";
            whileToolStripMenuItem.Click += whileToolStripMenuItem_Click;
            // 
            // doWhileToolStripMenuItem
            // 
            doWhileToolStripMenuItem.Name = "doWhileToolStripMenuItem";
            doWhileToolStripMenuItem.Size = new Size(224, 26);
            doWhileToolStripMenuItem.Text = "Do...While";
            doWhileToolStripMenuItem.Click += doWhileToolStripMenuItem_Click;
            // 
            // processingToolStripMenuItem
            // 
            processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            processingToolStripMenuItem.Size = new Size(224, 26);
            processingToolStripMenuItem.Text = "Processing";
            processingToolStripMenuItem.Click += processingToolStripMenuItem_Click;
            // 
            // outputToolStripMenuItem
            // 
            outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            outputToolStripMenuItem.Size = new Size(224, 26);
            outputToolStripMenuItem.Text = "Output";
            outputToolStripMenuItem.Click += outputToolStripMenuItem_Click;
            // 
            // cSharpMenu
            // 
            cSharpMenu.Name = "cSharpMenu";
            cSharpMenu.Size = new Size(41, 24);
            cSharpMenu.Text = "C#";
            cSharpMenu.Click += cSharpMenu_Click;
            // 
            // endForMenu
            // 
            endForMenu.Name = "endForMenu";
            endForMenu.Size = new Size(224, 26);
            endForMenu.Text = "End-for";
            endForMenu.Click += endForMenu_Click;
            // 
            // endWhileMenu
            // 
            endWhileMenu.Name = "endWhileMenu";
            endWhileMenu.Size = new Size(224, 26);
            endWhileMenu.Text = "End-while";
            endWhileMenu.Click += endWhileMenu_Click;
            // 
            // endDoWhileMenu
            // 
            endDoWhileMenu.Name = "endDoWhileMenu";
            endDoWhileMenu.Size = new Size(224, 26);
            endDoWhileMenu.Text = "End-Do...While";
            endDoWhileMenu.Click += endDoWhileMenu_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 84, 103);
            ClientSize = new Size(1269, 681);
            Controls.Add(panelPracovni);
            Controls.Add(prekladacTb);
            Name = "formHlavniProTvorbu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tvorba";
            FormClosing += formHlavniProTvorbu_FormClosing;
            KeyDown += formHlavniProTvorbu_KeyDown;
            panelPracovni.ResumeLayout(false);
            panelPracovni.PerformLayout();
            panelSwitch.ResumeLayout(false);
            panelSwitch.PerformLayout();
            menuPanels.ResumeLayout(false);
            menuPanels.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox prekladacTb;
        private Panel panelPracovni;
        private Button btRun;
        private Panel panelSwitch;
        private Label label2;
        private TextBox tbInputVariable;
        private Label label1;
        private TextBox tbConsole;
        private MenuStrip menuPanels;
        private ToolStripMenuItem panelsToolStripMenuItem;
        private ToolStripMenuItem variablesToolStripMenuItem;
        private ToolStripMenuItem conditionsToolStripMenuItem;
        private ToolStripMenuItem switchesToolStripMenuItem;
        private ToolStripMenuItem cyclesToolStripMenuItem;
        private ToolStripMenuItem forToolStripMenuItem;
        private ToolStripMenuItem whileToolStripMenuItem;
        private ToolStripMenuItem doWhileToolStripMenuItem;
        private ToolStripMenuItem processingToolStripMenuItem;
        private ToolStripMenuItem outputToolStripMenuItem;
        private ToolStripMenuItem cSharpMenu;
        private ToolStripMenuItem endForMenu;
        private ToolStripMenuItem endWhileMenu;
        private ToolStripMenuItem endDoWhileMenu;
    }
}