using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyvojaky
{
    public partial class formHlavniProTvorbu : Form
    {
        public formHlavniProTvorbu()
        {
            InitializeComponent();
        }

        /*Zacatek strip menu item metod*/
        private void int16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = int16ToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void int32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = int32ToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void int64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = int64ToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = floatToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = doubleToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = boolToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = stringToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }

        private void charToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuTypy.Text = charToolStripMenuItem.ToString();
            typPromenne = menuTypy.Text;
            typChecked = true;
        }
        /*Konecstrip menu item metod*/



        //Pro ulozeni typu a nazvu promenne
        string typPromenne, nazevPromenne;

        //Objekt pro manipulaci se vsemi promennymi
        Promenne promenne = new Promenne();

        //Bool pro kontrolu zaskrtnuti typu nove promenne
        bool typChecked = false;




        private void btPridat_Click(object sender, EventArgs e)
        {
            //Prida nazev do pouzitych nazvu
            promenne.pouziteNazvy.Add(nazevPromenne);


            //Prida promennou do dictionary
            promenne.VytvoritPromennou(typPromenne, nazevPromenne, tbHodnota.Text, tbConsole);

            //Resetuje zadane udaje
            typPromenne = "";
            menuTypy.Text = "Typy";
            tbNazevPromenne.Text = "";
            tbHodnota.Text = "";
            typChecked = false;
        }

        //Metoda pro kontrolu duplikatu
        bool KontrolaNazvu()
        {
            nazevPromenne = tbNazevPromenne.Text;

            foreach (string nazev in promenne.pouziteNazvy)
            {
                if (nazevPromenne == nazev)
                {
                    return false;
                }
            }

            return true;
        }

        //Main timer tick method
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            //Zkontroluje, jestli ma nazev promenne alespon jeden znak a je vybrany typ promenne
            //a zaroven nazev promenne jeste neexistuje

            if (tbNazevPromenne.Text.Length > 0 && tbHodnota.Text.Length > 0 && typChecked && KontrolaNazvu())
            {
                btPridat.Enabled = true;
            }
            else
            {
                btPridat.Enabled = false;
            }
        }


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
