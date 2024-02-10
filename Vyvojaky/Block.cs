using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Block
    {
        public static Panel? pracPanel;
        public static List<int> indexes = new List<int>();

        //Indexace Blocků
        public static int BlockIndex()
        {
            int index = indexes.Count() > 0 ? indexes.Max() + 1 : 1;
            indexes.Add(index);            

            return index;
        }

        //Block instances
        public static void BlockVar(string typ, string nazev, string hodnota)
        {
            BlockVar blockVar = new BlockVar(typ, nazev, hodnota);            
        }

        public static void BlockCon(string prikaz)
        {
            BlockCon blockCon = new BlockCon(prikaz, Podminky.isTrue(prikaz));
        }

        public static void BlockSwitch(int pocetMoznosti, string vstupPromenna, List<TextBox> boxy)
        {
            BlockSwitches blockSwitch = new BlockSwitches(pocetMoznosti, vstupPromenna, boxy);
        }

        public static void BlockCycleFor(string nazev, string pocatek, string konec, string inkrement)
        {
            BlockCycles blockFor = new BlockCycles(nazev, pocatek, konec, inkrement);
        }


        //Disable control method
        public static void DisableControl(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            foreach (Label l in p.Controls)
            {
                l.Enabled = false;
            }
        }

        //Enable control method
        public static void EnableControl(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            foreach (Label l in p.Controls)
            {
                l.Enabled = true;
            }
        }



        //Drag and drop vars
        public static bool dragging;
        public static int xPos, yPos;

        //Drag and Drop methods
        public static void OnMouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; yPos = e.Y;
            }
        }

        public static void OnMouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public static void OnMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pbRequest = (PictureBox)sender;
            if (dragging)
            {
                pbRequest.Top = e.Y + pbRequest.Top - yPos;
                pbRequest.Left = e.X + pbRequest.Left - xPos;
            }
        }


        //Right-click behaviour
        public static void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Opens menu
                MessageBox.Show("test");
            }
        }

    }
}