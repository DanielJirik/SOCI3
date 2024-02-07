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
        public static Panel pracPanel;
        public static List<int> indexes = new List<int>();

        public Block(Panel _pracPanel)
        {
            pracPanel = _pracPanel;
        }

        //

        public static int BlockIndex()
        {
            int index = indexes.Count() > 0 ? indexes.Max() + 1 : 0;
            indexes.Add(index);            

            return index;
        }

        public void BlockVar(string typ, string nazev, string hodnota)
        {
            BlockVar blockVar = new BlockVar(typ, nazev, hodnota);            
        }

        public void BlockCon(string prikaz)
        {
            BlockCon blockCon = new BlockCon(prikaz, Podminky.isTrue(prikaz));
        }

        public void BlockSwitch(int pocetMoznosti, string vstupPromenna, List<TextBox> boxy)
        {
            BlockSwitches blockSwitch = new BlockSwitches(pocetMoznosti, vstupPromenna, boxy);
        }

        public void BlockCycleFor(string nazev, string pocatek, string konec, string inkrement)
        {
            BlockCycles blockFor = new BlockCycles(nazev, pocatek, konec, inkrement);
        }



        //Drag and drop vars
        public static bool dragging;
        public static int xPos, yPos;
        public static PictureBox pbRequest;

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
            if (dragging)
            {
                pbRequest = (PictureBox)sender;

                pbRequest.Top = e.Y + pbRequest.Top - yPos;
                pbRequest.Left = e.X + pbRequest.Left - xPos;
            }
        }        
    }
}