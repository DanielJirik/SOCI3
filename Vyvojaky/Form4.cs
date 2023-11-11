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

            lvPromenne.HideSelection = false;
        }

        //Objekt pro manipulaci se vsemi promennymi
        Promenne promenne = new Promenne();

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
                    //Prida nazev do pouzitych nazvu
                    Promenne.pouziteNazvy.Add(nazevPromenne);

                    promenne.VytvoritPromennou(nazevPromenne, hodnotaPromenne, tbConsole);

                    lvPromenne.Items.Add(nazevPromenne + " > " + Promenne.typ);
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
                string[] itemSplit = item.Text.Split(">");
                string key = itemSplit[0].Trim();

                lbNazevP.Text = "Název: " + itemSplit[0];
                lbTypP.Text = "Datový typ: " + itemSplit[1];

                string hodnota = "";
                switch (itemSplit[1].Trim())
                {
                    case "Int16":
                        hodnota = Convert.ToString(Promenne.Int16V[key]);
                        break;
                    case "Int32":
                        hodnota = Convert.ToString(Promenne.Int32V[key]);
                        break;
                    case "Int64":
                        hodnota = Convert.ToString(Promenne.Int64V[key]);
                        break;
                    case "Float":
                        hodnota = Convert.ToString(Promenne.FloatV[key]);
                        break;
                    case "Double":
                        hodnota = Convert.ToString(Promenne.DoubleV[key]);
                        break;
                    case "Bool":
                        hodnota = Convert.ToString(Promenne.BoolV[key]);
                        break;
                    case "Char":
                        hodnota = Convert.ToString(Promenne.CharV[key]);
                        break;
                    case "String":
                        hodnota = Promenne.StringV[key];
                        break;
                    default:
                        break;
                }

                lbHodnotaP.Text = "Hodnota: " + hodnota;
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
            foreach (string nazev in Promenne.pouziteNazvy)
            {
                if (nazevPromenne == nazev)
                    return false;
            }

            return true;
        }




        //objekt podminky + obec.promenne
        Podminky podminky = new Podminky();


        //přepínání mezi panely
        private void itemPromenne_Click(object sender, EventArgs e)
        {
            menuPanely.Text = itemPromenne.Text;
            panelInformaci.Show();
            panelPodminky.Hide();


        }

        private void itemPodminky_Click(object sender, EventArgs e)
        {
            menuPanely.Text = itemPodminky.Text;
            panelPodminky.Show();

        }

        //

        //tlačítko pro spuštění podmínky
        private void btPodminka_Click(object sender, EventArgs e)
        {
            List<string> nazvy = Promenne.pouziteNazvy;
            Dictionary<string, Int16> inty16 = Promenne.Int16V;
            try
            {
                Int16 value1 = 0;
                Int16 value2 = 0;
                string prom1 = tbPromenna1.Text;
                string prom2 = tbPromenna2.Text;

                string oper = operatory.Text;
                (prom1, prom2) = podminky.hledani(prom1, prom2, nazvy, inty16, tbConsole);


                //tbConsole.Text += prom2;
                if (Int16.TryParse(prom1, out value1) && Int16.TryParse(prom2, out value2))
                {
                    value1 = Convert.ToInt16(prom1);
                    value2 = Convert.ToInt16(prom2);
                    podminky.porovnani(value1, value2, oper, tbConsole);
                }
                else
                {
                    podminky.porovnaniProString(prom1, prom2, oper, tbConsole);
                }

                tbPromenna1.Text = "";
                tbPromenna2.Text = "";
                operatory.Text = "operátory";
            }
            catch (Exception)
            {
                tbConsole.Text += "Error" + "\r\n" + ">";
                tbPromenna1.Text = "";
                tbPromenna2.Text = "";
                operatory.Text = "operátory";
            }


        }
        //

        //itemy z menuStripu pro operatory
        private void itemVetsi_Click(object sender, EventArgs e)
        {
            operatory.Text = itemVetsi.ToString();
        }

        private void itemMensi_Click(object sender, EventArgs e)
        {
            operatory.Text = itemMensi.Text;
        }

        private void itemMensiRovno_Click(object sender, EventArgs e)
        {
            operatory.Text = itemMensiRovno.Text;
        }

        private void itemVetsiRovno_Click(object sender, EventArgs e)
        {
            operatory.Text = itemVetsiRovno.Text;
        }

        private void itemRovnost_Click(object sender, EventArgs e)
        {
            operatory.Text = itemRovnost.Text;
        }

        private void itemNerovnost_Click(object sender, EventArgs e)
        {
            operatory.Text = itemNerovnost.Text;
        }








        //

        /*TO DO*/
        /*
         * sem mi prosim te pis vse, na cem ches pracovat nebo na cem uz pracujes
         * zatim funguje pridat jen int16 promenne, po pridani se ti vypise do console
         * 
         * PS: mel jsem problem s designerem, tak to musime jeste poresit
         * 
         * Dan:
         * -pridelat moznosti console a ">" po konci prikazu (po zadani enteru)
         * -pridelat moznost pridat jine datove typy
         * -pridelat bloky pro vizualizaci promennych
        */
        /*KONEC TO DO*/


    }
}
