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
            panelPodminky.Hide();
            panelSwitch.Hide();

            promenne.Setup(panelPracovni);
            podminky.Setup(panelPracovni);
            switches.Setup(panelPracovni);

            lvPromenne.HideSelection = false;
            switches.VyskaPaneluPuvodni = panelSwitch.Height;
            MainIsOpen = true;
            menuPanels.Hide();
        }



        ////Přepínání mezi panely
        private void itemVars_Click(object sender, EventArgs e)
        {
            panelInformaci.Show();
            panelPodminky.Hide();
        }

        private void itemIfs_Click(object sender, EventArgs e)
        {
            panelPodminky.Show();
            panelInformaci.Hide();
        }


        //

        //Objekt pro manipulaci se vsemi promennymi
        Promenne promenne = new Promenne();

        //objekt podminky + obec.promenne
        Podminky podminky = new Podminky();

        //objekt switch
        Switches switches = new Switches();

        /*Vytvorereni nove promenne*/
        string nazevPromenne = "";
        string hodnotaPromenne = "";
        bool legitPrikaz;

        private void tbPromenna_KeyDown(object sender, KeyEventArgs e)
        {

        }


        //Hledani promenne v listu
        private void tbNajitPromennou_TextChanged(object sender, EventArgs e)
        {
            ListViewItem item;

            if ((item = lvPromenne.FindItemWithText(tbNajitPromennou.Text)) != null)
            {
                lvPromenne.Items[item.Index].Selected = true;
                lvPromenne.Select();
            }
        }

        //Ovládání panelu vlastností
        private void lvPromenne_Click(object sender, EventArgs e)
        {
            if (lvPromenne.SelectedItems.Count > 0)
            {


                ListViewItem item = lvPromenne.SelectedItems[0];
                string[] itemSplit = item.Text.Split(" = ");

                lbNazevP.Text = "Název: " + itemSplit[0];
                lbHodnotaP.Text = "Hodnota: " + itemSplit[1];

                string typP = "";
                string key = itemSplit[0].Trim();

                typP = Promenne.FindVar(key, "value");

                lbTypP.Text = "Datový typ: " + typP;
            }
        }

        //Presune hledany block doleva nahoru
        private void btNajitP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Skutečně si přejete přesunout tento block do levého horního rohu plochy?", "Upozornění", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (PictureBox pb in panelPracovni.Controls)
                    {
                        foreach (Label lb in pb.Controls)
                        {
                            if (lb.Tag == "popis" && lb.Text.Split(">")[1].Trim().Split("=")[0].Trim() == lbNazevP.Text.Split(":")[1].Trim())
                            {
                                pb.Location = new Point(0, 0);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Něco se nepodařilo.");
                }
            }
        }


        //Metoda pro kontrolu duplikatu
        bool KontrolaNazvu(string nazevPromenne)
        {
            bool used = false;
            foreach (string nazev in Promenne.usedNames)
            {
                if (nazevPromenne == nazev)
                    used = true;
            }

            if (Keywords.Check(nazevPromenne) || used)
                return false;
            return true;
        }


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

        private void panelPodminky_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelPodminky_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.panelPodminky.Top = e.Y + this.panelPodminky.Top - yPos;
                this.panelPodminky.Left = e.X + this.panelPodminky.Left - xPos;
            }
        }

        private void panelPodminky_MouseDown(object sender, MouseEventArgs e)
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
            string indexes = "";
            foreach (int n in Block.indexes)
            {
                indexes += n + ", ";
            }
            MessageBox.Show(indexes);
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

        private void menuPanels_MouseLeave(object sender, EventArgs e)
        {
            menuPanels.Hide();
        }

        private void variablesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string prikaz = Interaction.InputBox("Zadejte proměnnou: \r\n\r\nPříklady: a = 5, b = 3.14, jmeno = Aneta ", "Variables");

            if (prikaz != "")
            {
                if (KontrolaNazvu(prikaz.Split("=")[0].Trim()))
                {
                    try
                    {
                        Regex.Replace(prikaz, @"\s+", "");

                        nazevPromenne = prikaz.Split("=")[0].Trim();
                        hodnotaPromenne = prikaz.Split("=")[1].Trim();

                        legitPrikaz = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Něco je špatně.");
                    }

                    if (legitPrikaz)
                    {
                        promenne.VytvoritPromennou(nazevPromenne, hodnotaPromenne, tbConsole);

                        if (Promenne.isValid)
                        {
                            //Prida nazev do pouzitych nazvu
                            Promenne.usedNames.Add(nazevPromenne);

                            lvPromenne.Items.Add(nazevPromenne + " = " + Promenne.hodnota);
                        }

                        Promenne.typ = "";
                        nazevPromenne = "";
                        hodnotaPromenne = "";

                        legitPrikaz = false;
                    }
                }
            }

            panelInformaci.Show();
            panelPodminky.Hide();
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

            panelPodminky.Show();
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
                        panelPodminky.Hide();
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
                panelPodminky.Hide();
            }
        }


    }
}
