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
            menu = new MenuStrip();
            blocksToolStripMenuItem = new ToolStripMenuItem();
            variablesItem = new ToolStripMenuItem();
            conditionsItem = new ToolStripMenuItem();
            endConditionsItem = new ToolStripMenuItem();
            cyclesToolStripMenuItem1 = new ToolStripMenuItem();
            forItem = new ToolStripMenuItem();
            whileItem = new ToolStripMenuItem();
            doWhileItem = new ToolStripMenuItem();
            endForItem = new ToolStripMenuItem();
            endWhileItem = new ToolStripMenuItem();
            endDoWhileItem = new ToolStripMenuItem();
            processingItem = new ToolStripMenuItem();
            outputItem = new ToolStripMenuItem();
            translatorItem = new ToolStripMenuItem();
            panelPracovni.SuspendLayout();
            panelSwitch.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // prekladacTb
            // 
            prekladacTb.BackColor = Color.FromArgb(68, 84, 103);
            prekladacTb.Dock = DockStyle.Fill;
            prekladacTb.Location = new Point(0, 28);
            prekladacTb.Multiline = true;
            prekladacTb.Name = "prekladacTb";
            prekladacTb.Size = new Size(1269, 653);
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
            panelPracovni.Dock = DockStyle.Fill;
            panelPracovni.Location = new Point(0, 28);
            panelPracovni.Name = "panelPracovni";
            panelPracovni.Size = new Size(1269, 653);
            panelPracovni.TabIndex = 11;
            panelPracovni.Paint += panelPracovni_Paint;
            // 
            // btRun
            // 
            btRun.Location = new Point(12, 9);
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
            panelSwitch.Location = new Point(166, 9);
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
            // menu
            // 
            menu.BackColor = Color.Silver;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { blocksToolStripMenuItem, translatorItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1269, 28);
            menu.TabIndex = 12;
            menu.Text = "menuStrip1";
            // 
            // blocksToolStripMenuItem
            // 
            blocksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { variablesItem, conditionsItem, endConditionsItem, cyclesToolStripMenuItem1, processingItem, outputItem });
            blocksToolStripMenuItem.Name = "blocksToolStripMenuItem";
            blocksToolStripMenuItem.Size = new Size(65, 24);
            blocksToolStripMenuItem.Text = "Blocks";
            // 
            // variablesItem
            // 
            variablesItem.Name = "variablesItem";
            variablesItem.Size = new Size(192, 26);
            variablesItem.Text = "Variables";
            variablesItem.Click += variablesItem_Click;
            // 
            // conditionsItem
            // 
            conditionsItem.Name = "conditionsItem";
            conditionsItem.Size = new Size(192, 26);
            conditionsItem.Text = "Conditions";
            conditionsItem.Click += conditionsItem_Click;
            // 
            // endConditionsItem
            // 
            endConditionsItem.Name = "endConditionsItem";
            endConditionsItem.Size = new Size(192, 26);
            endConditionsItem.Text = "End-conditions";
            endConditionsItem.Click += endConditionsItem_Click;
            // 
            // cyclesToolStripMenuItem1
            // 
            cyclesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { forItem, whileItem, doWhileItem, endForItem, endWhileItem, endDoWhileItem });
            cyclesToolStripMenuItem1.Name = "cyclesToolStripMenuItem1";
            cyclesToolStripMenuItem1.Size = new Size(192, 26);
            cyclesToolStripMenuItem1.Text = "Cycles";
            // 
            // forItem
            // 
            forItem.Name = "forItem";
            forItem.Size = new Size(176, 26);
            forItem.Text = "For";
            forItem.Click += forItem_Click;
            // 
            // whileItem
            // 
            whileItem.Name = "whileItem";
            whileItem.Size = new Size(176, 26);
            whileItem.Text = "While";
            whileItem.Click += whileItem_Click;
            // 
            // doWhileItem
            // 
            doWhileItem.Name = "doWhileItem";
            doWhileItem.Size = new Size(176, 26);
            doWhileItem.Text = "DoWhile";
            doWhileItem.Click += doWhileItem_Click;
            // 
            // endForItem
            // 
            endForItem.Name = "endForItem";
            endForItem.Size = new Size(176, 26);
            endForItem.Text = "End-for";
            endForItem.Click += endForItem_Click;
            // 
            // endWhileItem
            // 
            endWhileItem.Name = "endWhileItem";
            endWhileItem.Size = new Size(176, 26);
            endWhileItem.Text = "End-while";
            endWhileItem.Click += endWhileItem_Click;
            // 
            // endDoWhileItem
            // 
            endDoWhileItem.Name = "endDoWhileItem";
            endDoWhileItem.Size = new Size(176, 26);
            endDoWhileItem.Text = "End-dowhile";
            endDoWhileItem.Click += endDoWhileItem_Click;
            // 
            // processingItem
            // 
            processingItem.Name = "processingItem";
            processingItem.Size = new Size(192, 26);
            processingItem.Text = "Processing";
            processingItem.Click += processingItem_Click;
            // 
            // outputItem
            // 
            outputItem.Name = "outputItem";
            outputItem.Size = new Size(192, 26);
            outputItem.Text = "Output";
            outputItem.Click += outputItem_Click;
            // 
            // translatorItem
            // 
            translatorItem.Name = "translatorItem";
            translatorItem.Size = new Size(41, 24);
            translatorItem.Text = "C#";
            translatorItem.Click += translatorItem_Click;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(68, 84, 103);
            ClientSize = new Size(1269, 681);
            Controls.Add(panelPracovni);
            Controls.Add(prekladacTb);
            Controls.Add(menu);
            Name = "formHlavniProTvorbu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workspace";
            FormClosing += formHlavniProTvorbu_FormClosing;
            KeyDown += formHlavniProTvorbu_KeyDown;
            panelPracovni.ResumeLayout(false);
            panelSwitch.ResumeLayout(false);
            panelSwitch.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
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
        private MenuStrip menu;
        private ToolStripMenuItem blocksToolStripMenuItem;
        private ToolStripMenuItem variablesItem;
        private ToolStripMenuItem conditionsItem;
        private ToolStripMenuItem endConditionsItem;
        private ToolStripMenuItem cyclesToolStripMenuItem1;
        private ToolStripMenuItem forItem;
        private ToolStripMenuItem whileItem;
        private ToolStripMenuItem doWhileItem;
        private ToolStripMenuItem endForItem;
        private ToolStripMenuItem endWhileItem;
        private ToolStripMenuItem endDoWhileItem;
        private ToolStripMenuItem processingItem;
        private ToolStripMenuItem outputItem;
        private ToolStripMenuItem translatorItem;
    }
}