using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vyvojaky
{
    public partial class formHlavniProTvorbu : Form
    {

        public formHlavniProTvorbu()
        {
            InitializeComponent();
            panelSwitch.Hide();
            Block.pracPanel = panelPracovni;
            SequenceController.Start();

            prekladacTb.ReadOnly = false;
            prekladacTb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            prekladacTb.ForeColor = Color.White;

            switches.VyskaPaneluPuvodni = panelSwitch.Height;
            MainIsOpen = true;


            t.Interval = 20;
            t.Enabled = true;
            t.Tick += new EventHandler(TimerTick);

            this.KeyPreview = true;
        }

        SequenceController sController = new SequenceController();

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        private void TimerTick(object sender, EventArgs e)
        {
            panelPracovni.Refresh();
        }

        ////Přepínání mezi panely


        //Objekt pro manipulaci se vsemi promennymi
        Promenne promenne = new Promenne();

        //objekt podminky + obec.promenne
        Podminky podminky = new Podminky();

        //objekt switch
        Switches switches = new Switches();

        //object cycles
        Cycles cycles = new Cycles();

        //object process
        Process process = new Process();

        //objekt output
        Output output = new Output();

        //animation
        Animation animation = new Animation();

        //Nastane před zavřením formu
        public static bool MainIsOpen;
        private void formHlavniProTvorbu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Skutečně chcete odejít?", "Pozor", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MainIsOpen = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        //pohyb panelů na pracovní ploše
        private bool dragging;
        private int xPos, yPos;

        private void panelSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void panelSwitch_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelSwitch_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.panelSwitch.Top = e.Y + this.panelSwitch.Top - yPos;
                this.panelSwitch.Left = e.X + this.panelSwitch.Left - xPos;
            }
        }

        private void tbInputVariable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switches.FromTextBox();
                switches.MoznostiToVariables();
                switches.VytvoreniBloku(tbInputVariable.Text);
                //switches.Kontrola(tbConsole, tbInputVariable.Text, switches.variables, true);
            }
        }


        //right-click
        //private void panelPracovni_MouseClick(object sender, MouseEventArgs e)
        //{
        //    bool rozhodnuti = false;
        //    int positionX = e.Location.X;
        //    int positionY = e.Location.Y;
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        menuPanels.Location = new Point(positionX, positionY);
        //        if (!rozhodnuti && positionX == menuPanels.Location.X && positionY == menuPanels.Location.Y)
        //        {
        //            menuPanels.Show();
        //            rozhodnuti = true;
        //        }
        //        else
        //        {

        //            rozhodnuti = false;
        //        }
        //    }
        //    else
        //    {

        //        rozhodnuti = false;
        //    }
        //}

        //private void panelPracovni_MouseDown(object sender, MouseEventArgs e)
        //{
        //    bool rozhodnuti = false;
        //    int positionX = e.Location.X;
        //    int positionY = e.Location.Y;
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        menuPanels.Location = new Point(positionX, positionY);
        //        if (!rozhodnuti && positionX == menuPanels.Location.X && positionY == menuPanels.Location.Y)
        //        {
        //            menuPanels.Show();
        //            rozhodnuti = true;
        //        }
        //        else
        //        {

        //            rozhodnuti = false;
        //        }
        //    }
        //    else
        //    {

        //        rozhodnuti = false;
        //    }
        //}

        //prekladac 
        private void prekladacTb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelPracovni.Visible = true;
            }


        }


        //private void switchesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        switches.MazaniBoxu(panelSwitch);
        //        int pocet = 0;
        //        string hodnota = "";
        //        hodnota = Interaction.InputBox("Zadejte počet, kolik chcete mít možností ve switchi", "Switch");
        //        if (hodnota != "")
        //        {
        //            if (int.TryParse(hodnota, out pocet))
        //            {
        //                switches.pridavaniTextBoxu(pocet, panelSwitch, tbInputVariable);
        //                panelSwitch.Show();
        //    
        //            }
        //            else
        //            {
        //                MessageBox.Show("Zadal jste chybný tvar čísla!");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex);
        //        panelSwitch.Hide();
        //    }
        //}

        //Lines
        private void panelPracovni_Paint(object sender, PaintEventArgs e)
        {
            foreach (KeyValuePair<(PictureBox, int), PictureBox> pbs in Block.drawPoints)
            {
                Point from = new Point(pbs.Key.Item1.Left + pbs.Key.Item1.Width / 2, pbs.Key.Item1.Top + pbs.Key.Item1.Height / 2);
                Point to = new Point(pbs.Value.Left + pbs.Value.Width / 2, pbs.Value.Top + pbs.Value.Height / 2);

                Color lineColor;
                if (pbs.Key.Item2 == 1)
                    lineColor = Color.Red;
                else
                    lineColor = Color.Orange;

                Pen p = new Pen(lineColor, 3);
                e.Graphics.DrawLine(p, from, to);
            }
        }

        //Spustí simulaci
        private void btRun_Click(object sender, EventArgs e)
        {
            //Runs a sequence with default start index of 1 and endIndex of 0
            SequenceController.RunSequence(1, 0);
            prekladacTb.Text = CodeGenerator.Generate();
        }


        private void formHlavniProTvorbu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Block.markedBlock != null && e.KeyCode == Keys.Delete)
                Block.DeleteBlock(Block.markedBlock);
        }

        //menu - všechny bloky plus překladač
        private void variablesItem_Click(object sender, EventArgs e)
        {
            string prikaz = Interaction.InputBox("Zadejte proměnnou: \r\n\r\nPříklady: a = 5, b = 3.14, jmeno = Aneta ", "Variables");
            string[] values = Promenne.ArtificialVarValues(prikaz);

            Block.BlockVar(values[0], values[1], prikaz);

            panelSwitch.Hide();

        }

        private void conditionsItem_Click(object sender, EventArgs e)
        {
            string prikaz = Interaction.InputBox("Zadejte podmínku: \r\n\r\n Příklady: a > b", "Conditions");
            if (prikaz != "")
                Block.BlockCon(prikaz);

            panelSwitch.Hide();

        }

        private void endConditionsItem_Click(object sender, EventArgs e)
        {

            Block.BlockIfEnd();
        }

        private void processingItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Zadejte existující proměnnou a výraz k výpočtu\r\nPříklady: a = 5 + 6, jmeno = 'Ahoj' + 'jak se mate'", "Process");
            Block.BlockProcess(input);

        }

        private void outputItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Zadejte výraz, který chcete vytisknout\r\nPříklady: \"ahoj\"; existující proměnná: a", "Output");
            Block.BlockOutput(input);

        }

        private void forItem_Click(object sender, EventArgs e)
        {
            string nazev = Interaction.InputBox("Zadejte název proměnné", "Cycle-for");
            string pocatecniHodnota = Interaction.InputBox("Zadejte počáteční hodnotu", "Cycle-for");
            string konecnaHodnota = Interaction.InputBox("Zadejte konečnou hodnotu(cyklus bude počítat včetně této hodnoty)", "Cycle-for");
            string inkrement = Interaction.InputBox("Zadejte inkrement", "Cycle-for");
            if (nazev != "" && pocatecniHodnota != "" && konecnaHodnota != "" && inkrement != "")
            {
                cycles.Setup(panelPracovni);
                if (Cycles.CheckFor(nazev, pocatecniHodnota, konecnaHodnota, inkrement))
                {
                    Cycles.CreationOfCycleFor(nazev, pocatecniHodnota, konecnaHodnota, inkrement);

                }
                else
                {
                    MessageBox.Show("Něco je špatně!");
                }
            }
        }

        private void whileItem_Click(object sender, EventArgs e)
        {
            string condition = Interaction.InputBox("Zadejte podmínku", "Cycle-while");
            if (condition != "")
            {
                string par1, par2, oper;
                (par1, par2, oper) = Cycles.Separation(condition);
                if (par1 != "" && par2 != "" && oper != "")
                {
                    Cycles.CreationOfCycleWhile(condition);

                }
                else
                {
                    MessageBox.Show("Něco se nepovedlo");
                }
            }
        }

        private void doWhileItem_Click(object sender, EventArgs e)
        {
            string condition = Interaction.InputBox("Zadejte podmínku", "Cycle-while");
            if (condition != "")
            {
                string par1, par2, oper;
                (par1, par2, oper) = Cycles.Separation(condition);
                if (par1 != "" && par2 != "" && oper != "")
                {
                    Cycles.CreationOfCycleDoWhile(condition);

                }
                else
                {
                    MessageBox.Show("Něco se nepovedlo");
                }
            }
        }

        private void endForItem_Click(object sender, EventArgs e)
        {
            Block.BlockCycleEnd("For");

        }

        private void endWhileItem_Click(object sender, EventArgs e)
        {
            Block.BlockCycleEnd("While");

        }

        private void endDoWhileItem_Click(object sender, EventArgs e)
        {
            Block.BlockCycleEnd("Do-while");

        }

        bool switching = false;
        private void translatorItem_Click(object sender, EventArgs e)
        {
            if (!switching)
            {
                panelPracovni.Visible = false;
                prekladacTb.Visible = true;
                switching = true;
                translatorItem.Text = "Pracovni panel";
            }
            else
            {
                panelPracovni.Visible = true;
                prekladacTb.Visible = false;
                switching = false;
                translatorItem.Text = "C#";
            }
        }
    }
}
