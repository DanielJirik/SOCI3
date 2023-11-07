using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        //Objekt pro manipulaci se vsemi promennymi
        Promenne promenne = new Promenne();

        /*Vytvorereni nove promenne*/
        string nazevPromenne = "";
        string hodnotaPromenne = "";

        private void tbPromenna_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string prikaz = tbPromenna.Text.Trim();

                nazevPromenne = prikaz.Split("=")[0];
                hodnotaPromenne = prikaz.Split("=")[1];
            }
            catch (Exception)
            {

            }
        }

        private void tbPromenna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && KontrolaNazvu())
            {
                //Prida nazev do pouzitych nazvu
                promenne.pouziteNazvy.Add(nazevPromenne);

                promenne.VytvoritPromennou(nazevPromenne, hodnotaPromenne, tbConsole);
                tbPromenna.Text = "";
                nazevPromenne = "";
                hodnotaPromenne = "";
            }
        }

        //Metoda pro kontrolu duplikatu
        bool KontrolaNazvu()
        {
            foreach (string nazev in promenne.pouziteNazvy)
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
            List<string> nazvy = promenne.pouziteNazvy;
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
