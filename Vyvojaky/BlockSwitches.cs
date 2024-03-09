using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockSwitches : PictureBox, IBlock
    {   
        //public promìnné
        public Label lb;
        public Label lbVstup;
        int startPositionX = 10;
        int startPositionY = 10;
        public List<string> hodnoty;
        public string vstup;

        public int index;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }

        public BlockSwitches(int pocetCasu, string vstupPromenna, List<string> boxy)
        {
            //Set interface property
            this.type = Block.Type.Switch;

            //vytvoøení nového listu hodnot, následnì pøidání hodnot z listu boxy do listu hodnoty(pro další práci)
            hodnoty = new List<string>() { };
            for (int i = 0; i < boxy.Count; i++)
            {
                hodnoty.Add(boxy[i].ToString());
            }
            //pøidání vstupní promìnné do public promìnné vstup pro další zpracování
            vstup = vstupPromenna;
            
            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //picture box - nastavení
            this.Width = 120;
            this.Height = 50;
            this.BackColor = Color.White;

            //vytvoøení labelu vstup, následnì pøidání labelu do picture-boxu
            lbVstup = new Label();
            lbVstup.Text = "Switch(" + vstupPromenna + ")";
            lbVstup.ForeColor = Color.Black;
            lbVstup.Location = new Point(startPositionX, startPositionY);
            lbVstup.Width = (lbVstup.Text.Length * 7) + 20;
            this.Controls.Add(lbVstup);

            //vytvoøení lokální promìnná délka, pøidání velikosti labelu vstup do promìnné délka
            int delka = 0;
            delka = lbVstup.Width;

            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {   
                //vytvoøení jednoho labelu a jeho vlastnosti
                lb = new Label();
                lb.Text = (i + 1) + ".Case: " + boxy[i] + "  ";
                lb.ForeColor = Color.Black;
                lb.Width = (lb.Text.Length * 7);

                //zmìna pozice Y, následnì zmìna pozice labelu
                startPositionY += 20;
                lb.Location = new Point(startPositionX, startPositionY);
                //zmìna velikosti picture-boxu
                this.Height += 20;

                //pøidání labelu do picture-boxu
                this.Controls.Add(lb);

                //rozhodnutí, které hledá nejvìtší velikost labelu
                if (delka < lb.Width)
                {
                    delka = lb.Width;
                }
            }

            //zmìna velikosti picture-boxu na základì rozhodnutí z cyklu
            this.Width = delka + 20;

            //obecné vlastnosti picture-boxu

            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            //další nastavení picture-boxu(pozice, obrázek)
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.Image = Resources.zpracovani_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            //pøidání picture-boxu do pracovního panelu
            Block.pracPanel.Controls.Add(this);
        }
    }
}
