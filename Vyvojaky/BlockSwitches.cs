using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockSwitches : PictureBox
    {
        public Label lb;
        public Label lbVstup;
        public List<string> seznamLabelu;
        int startPositionX = 10;
        int startPositionY = 10;
        public List<string> hodnoty = new List<string>();
        public string vstup;

        public int index;
        public int? joint;
        public BlockSwitches(int pocetCasu, string vstupPromenna, List<string> boxy)
        {
            
            lbVstup = new Label();
            hodnoty = new List<string>() { };
            vstup = "";
            seznamLabelu = new List<string>();
            for (int i = 0; i < boxy.Count; i++)
            {
                hodnoty.Add(boxy[i].ToString());
                Debug.WriteLine("boxy: " + boxy[i]);
            }
            vstup = vstupPromenna;
            
            //Indexace
            index = Block.BlockIndex();
            this.Tag = index;

            //picture box
            this.Width = 120;
            this.Height = 50;
            this.BackColor = Color.White;

            //label + pridani lb do picture boxu
            lbVstup.Text = "Switch(" + vstupPromenna + ")";
            for (int i = 0; i < pocetCasu; i++)
            {
                seznamLabelu.Add(boxy[i]);
            }
            int delka = 0;
            seznamLabelu.Add(lbVstup.ToString());
            for (int i = 0; i < seznamLabelu.Count; i++)
            {
                if (delka < seznamLabelu[i].Length)
                {
                    delka = seznamLabelu[i].Length;
                }
            }
            
            lbVstup.Location = new Point(startPositionX, startPositionY);
            lbVstup.Width = delka * 10;            
            this.Controls.Add(lbVstup);

            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {
                lb = new Label();
                lb.Text = (i + 1) + ".Case:" + boxy[i];
                lb.Width = delka * 10;
                startPositionY += 20;
                this.Height += 20;
                lb.Location = new Point(startPositionX, startPositionY);
                this.Controls.Add(lb);
            }
            this.Width = (delka * 8) + (startPositionX * 5);
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            Block.pracPanel.Controls.Add(this);

            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);
        }
    }
}
