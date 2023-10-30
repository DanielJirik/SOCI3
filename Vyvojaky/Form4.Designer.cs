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
            panelInformaci.SuspendLayout();
            mMoznosti.SuspendLayout();
            panelConsole.SuspendLayout();
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
            panelInformaci.Controls.Add(lbTypPopis);
            panelInformaci.Controls.Add(lbNazevPromenne);
            panelInformaci.Controls.Add(btPridat);
            panelInformaci.Controls.Add(tbNazevPromenne);
            panelInformaci.Controls.Add(mMoznosti);
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
            // lbTypPopis
            // 
            lbTypPopis.AutoSize = true;
            lbTypPopis.Location = new Point(8, 32);
            lbTypPopis.Name = "lbTypPopis";
            lbTypPopis.Size = new Size(25, 15);
            lbTypPopis.TabIndex = 5;
            lbTypPopis.Text = "Typ";
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
            // mMoznosti
            // 
            mMoznosti.BackColor = Color.White;
            mMoznosti.Dock = DockStyle.None;
            mMoznosti.ImageScalingSize = new Size(20, 20);
            mMoznosti.Items.AddRange(new ToolStripItem[] { menuTypy });
            mMoznosti.Location = new Point(69, 28);
            mMoznosti.Name = "mMoznosti";
            mMoznosti.Padding = new Padding(5, 2, 0, 2);
            mMoznosti.Size = new Size(50, 24);
            mMoznosti.TabIndex = 0;
            mMoznosti.Text = "menuStrip1";
            // 
            // menuTypy
            // 
            menuTypy.DropDownItems.AddRange(new ToolStripItem[] { int16ToolStripMenuItem, int32ToolStripMenuItem, int64ToolStripMenuItem, floatToolStripMenuItem, doubleToolStripMenuItem, boolToolStripMenuItem, stringToolStripMenuItem, charToolStripMenuItem });
            menuTypy.Name = "menuTypy";
            menuTypy.Size = new Size(43, 20);
            menuTypy.Text = "Typy";
            // 
            // int16ToolStripMenuItem
            // 
            int16ToolStripMenuItem.Name = "int16ToolStripMenuItem";
            int16ToolStripMenuItem.Size = new Size(112, 22);
            int16ToolStripMenuItem.Text = "Int16";
            int16ToolStripMenuItem.Click += int16ToolStripMenuItem_Click;
            // 
            // int32ToolStripMenuItem
            // 
            int32ToolStripMenuItem.Name = "int32ToolStripMenuItem";
            int32ToolStripMenuItem.Size = new Size(112, 22);
            int32ToolStripMenuItem.Text = "Int32";
            int32ToolStripMenuItem.Click += int32ToolStripMenuItem_Click;
            // 
            // int64ToolStripMenuItem
            // 
            int64ToolStripMenuItem.Name = "int64ToolStripMenuItem";
            int64ToolStripMenuItem.Size = new Size(112, 22);
            int64ToolStripMenuItem.Text = "Int64";
            int64ToolStripMenuItem.Click += int64ToolStripMenuItem_Click;
            // 
            // floatToolStripMenuItem
            // 
            floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            floatToolStripMenuItem.Size = new Size(112, 22);
            floatToolStripMenuItem.Text = "Float";
            floatToolStripMenuItem.Click += floatToolStripMenuItem_Click;
            // 
            // doubleToolStripMenuItem
            // 
            doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            doubleToolStripMenuItem.Size = new Size(112, 22);
            doubleToolStripMenuItem.Text = "Double";
            doubleToolStripMenuItem.Click += doubleToolStripMenuItem_Click;
            // 
            // boolToolStripMenuItem
            // 
            boolToolStripMenuItem.Name = "boolToolStripMenuItem";
            boolToolStripMenuItem.Size = new Size(112, 22);
            boolToolStripMenuItem.Text = "Bool";
            boolToolStripMenuItem.Click += boolToolStripMenuItem_Click;
            // 
            // stringToolStripMenuItem
            // 
            stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            stringToolStripMenuItem.Size = new Size(112, 22);
            stringToolStripMenuItem.Text = "String";
            stringToolStripMenuItem.Click += stringToolStripMenuItem_Click;
            // 
            // charToolStripMenuItem
            // 
            charToolStripMenuItem.Name = "charToolStripMenuItem";
            charToolStripMenuItem.Size = new Size(112, 22);
            charToolStripMenuItem.Text = "Char";
            charToolStripMenuItem.Click += charToolStripMenuItem_Click;
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
            tbConsole.Text = "> ";
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 1;
            mainTimer.Tick += mainTimer_Tick;
            // 
            // formHlavniProTvorbu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1110, 497);
            Controls.Add(panelConsole);
            Controls.Add(panelInformaci);
            Controls.Add(panelPracovni);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHlavniProTvorbu";
            Text = "Tvorba";
            panelInformaci.ResumeLayout(false);
            panelInformaci.PerformLayout();
            mMoznosti.ResumeLayout(false);
            mMoznosti.PerformLayout();
            panelConsole.ResumeLayout(false);
            panelConsole.PerformLayout();
            ResumeLayout(false);
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
    }
}