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

            promenne.Setup(panelPracovni);
            podminky.Setup(panelPracovni);

            lvPromenne.HideSelection = false;

            MainIsOpen = true;
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

        //Podminky
        private void tbPodminka_KeyDown(object sender, KeyEventArgs e)
        {
            string prikaz = tbPodminka.Text;

            if (e.KeyCode == Keys.Enter)
            {
                tbConsole.Text += podminky.isTrue(prikaz) + Environment.NewLine + ">"; //vrati false/true
            }
        }


        /*Vytvorereni nove promenne*/
        string nazevPromenne = "";
        string hodnotaPromenne = "";
        bool legitPrikaz;

        private void tbPromenna_KeyDown(object sender, KeyEventArgs e)
        {
            string prikaz = tbPromenna.Text;

            if (e.KeyCode == Keys.Enter && KontrolaNazvu(prikaz.Split("=")[0].Trim()))
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
                    tbPromenna.Text = "";
                    nazevPromenne = "";
                    hodnotaPromenne = "";

                    legitPrikaz = false;
                }
            }
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
    }
}
