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

namespace Vyvojaky
{
    public partial class formHlavniProTvorbu : Form
    {

        public formHlavniProTvorbu()
        {
            InitializeComponent();
            panelInformaci.Show();
            panelSwitch.Hide();

            promenne.Setup(panelPracovni);
            podminky.Setup(panelPracovni);
            switches.Setup(panelPracovni);

            lvPromenne.HideSelection = false;
            switches.VyskaPaneluPuvodni = panelSwitch.Height;
            MainIsOpen = true;
            menuPanels.Hide();
        }

        SequenceController controller = new SequenceController();

        ////Přepínání mezi panely
        private void itemVars_Click(object sender, EventArgs e)
        {
            panelInformaci.Show();
        }

        private void itemIfs_Click(object sender, EventArgs e)
        {
            panelInformaci.Hide();
        }


        //

        //Objekt pro manipulaci se vsemi promennymi
        Promenne promenne = new Promenne();

        //objekt podminky + obec.promenne
        Podminky podminky = new Podminky();

        //objekt switch
        Switches switches = new Switches();

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
        private void panelInformaci_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.panelInformaci.Top = e.Y + this.panelInformaci.Top - yPos;
                this.panelInformaci.Left = e.X + this.panelInformaci.Left - xPos;
            }
        }

        private void panelInformaci_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelInformaci_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }


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
                switches.Kontrola(tbConsole);
            }
        }

        private void tbConsole_KeyDown(object sender, KeyEventArgs e)
        {
            //string indexes = "";
            //foreach (int n in Block.indexes)
            //{
            //    indexes += n + ", ";
            //}
            //MessageBox.Show(indexes);

            controller.InstructionOrder(panelPracovni);
        }


        //right-click
        bool rozhodnuti = false;

        private void panelPracovni_MouseClick(object sender, MouseEventArgs e)
        {
            int positionX = e.Location.X;
            int positionY = e.Location.Y;
            if (e.Button == MouseButtons.Right)
            {
                menuPanels.Location = new Point(positionX, positionY);
                if (!rozhodnuti && positionX == menuPanels.Location.X && positionY == menuPanels.Location.Y)
                {
                    menuPanels.Show();
                    rozhodnuti = true;
                }
                else
                {
                    menuPanels.Hide();
                    rozhodnuti = false;
                }
            }
            else
            {
                menuPanels.Hide();
                rozhodnuti = false;
            }
        }
        private void panelPracovni_MouseDown(object sender, MouseEventArgs e)
        {
            int positionX = e.Location.X;
            int positionY = e.Location.Y;
            if (e.Button == MouseButtons.Right)
            {
                menuPanels.Location = new Point(positionX, positionY);
                if (!rozhodnuti && positionX == menuPanels.Location.X && positionY == menuPanels.Location.Y)
                {
                    menuPanels.Show();
                    rozhodnuti = true;
                }
                else
                {
                    menuPanels.Hide();
                    rozhodnuti = false;
                }
            }
            else
            {
                menuPanels.Hide();
                rozhodnuti = false;
            }
        }

        private void menuPanels_Click(object sender, EventArgs e)
        {
            menuPanels.Hide();
        }


        private void variablesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Promenne.CommandCheck(Interaction.InputBox("Zadejte proměnnou: \r\n\r\nPříklady: a = 5, b = 3.14, jmeno = Aneta ", "Variables"));

            panelInformaci.Show();
            panelSwitch.Hide();
        }

        private void conditionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string prikaz = Interaction.InputBox("Zadejte podmínku: \r\n\r\n Příklady: a > b", "Conditions");
            if (prikaz != "")
            {
                Block block = new Block(panelPracovni);
                block.BlockCon(prikaz);
                tbConsole.Text += Podminky.isTrue(prikaz) + Environment.NewLine + ">"; //vrati false/true
            }

            panelInformaci.Hide();
            panelSwitch.Hide();
        }

        private void switchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                switches.MazaniBoxu(panelSwitch);
                int pocet = 0;
                string hodnota = "";
                hodnota = Interaction.InputBox("Zadejte počet, kolik chcete mít možností ve switchi", "Switch");
                if (hodnota != "")
                {
                    if (int.TryParse(hodnota, out pocet))
                    {
                        switches.pridavaniTextBoxu(pocet, panelSwitch, tbInputVariable);
                        panelSwitch.Show();
                        panelInformaci.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Zadal jste chybný tvar čísla!");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                panelSwitch.Hide();
                panelInformaci.Hide();
            }
        }


    }
}
