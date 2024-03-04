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
        public Label lb;
        public Label lbVstup;
        public List<string> seznamLabelu;
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

            lbVstup = new Label();
            hodnoty = new List<string>() { };
            seznamLabelu = new List<string>();
            for (int i = 0; i < boxy.Count; i++)
            {
                hodnoty.Add(boxy[i].ToString());
            }
            vstup = vstupPromenna;
            
            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //picture box
            this.Width = 120;
            this.Height = 50;
            this.BackColor = Color.White;

            

            //label + pridani lb do picture boxu
            lbVstup.Text = "Switch(" + vstupPromenna + ")";
            lbVstup.ForeColor = Color.Black;
            int delka = 0;
            
            lbVstup.Location = new Point(startPositionX, startPositionY);
            lbVstup.Width = (lbVstup.Text.Length * 7) + 20;            
            this.Controls.Add(lbVstup);
            delka = lbVstup.Width;

            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {
                lb = new Label();
                lb.Text = (i + 1) + ".Case: " + boxy[i] + "  ";
                lb.ForeColor = Color.Black;
                lb.Width = (lb.Text.Length * 7);
                startPositionY += 20;
                this.Height += 20;
                lb.Location = new Point(startPositionX, startPositionY);
                this.Controls.Add(lb);
                if (delka < lb.Width)
                {
                    delka = lb.Width;
                }
            }
            this.Width = delka + 20;
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.Image = Resources.zpracovani_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
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
