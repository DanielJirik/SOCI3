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
        //public prom�nn�
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

            //vytvo�en� nov�ho listu hodnot, n�sledn� p�id�n� hodnot z listu boxy do listu hodnoty(pro dal�� pr�ci)
            hodnoty = new List<string>() { };
            for (int i = 0; i < boxy.Count; i++)
            {
                hodnoty.Add(boxy[i].ToString());
            }
            //p�id�n� vstupn� prom�nn� do public prom�nn� vstup pro dal�� zpracov�n�
            vstup = vstupPromenna;
            
            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //picture box - nastaven�
            this.Width = 120;
            this.Height = 50;
            this.BackColor = Color.White;

            //vytvo�en� labelu vstup, n�sledn� p�id�n� labelu do picture-boxu
            lbVstup = new Label();
            lbVstup.Text = "Switch(" + vstupPromenna + ")";
            lbVstup.ForeColor = Color.Black;
            lbVstup.Location = new Point(startPositionX, startPositionY);
            lbVstup.Width = (lbVstup.Text.Length * 7) + 20;
            this.Controls.Add(lbVstup);

            //vytvo�en� lok�ln� prom�nn� d�lka, p�id�n� velikosti labelu vstup do prom�nn� d�lka
            int delka = 0;
            delka = lbVstup.Width;

            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {   
                //vytvo�en� jednoho labelu a jeho vlastnosti
                lb = new Label();
                lb.Text = (i + 1) + ".Case: " + boxy[i] + "  ";
                lb.ForeColor = Color.Black;
                lb.Width = (lb.Text.Length * 7);

                //zm�na pozice Y, n�sledn� zm�na pozice labelu
                startPositionY += 20;
                lb.Location = new Point(startPositionX, startPositionY);
                //zm�na velikosti picture-boxu
                this.Height += 20;

                //p�id�n� labelu do picture-boxu
                this.Controls.Add(lb);

                //rozhodnut�, kter� hled� nejv�t�� velikost labelu
                if (delka < lb.Width)
                {
                    delka = lb.Width;
                }
            }

            //zm�na velikosti picture-boxu na z�klad� rozhodnut� z cyklu
            this.Width = delka + 20;

            //obecn� vlastnosti picture-boxu

            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            //dal�� nastaven� picture-boxu(pozice, obr�zek)
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.Image = Resources.zpracovani_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            //p�id�n� picture-boxu do pracovn�ho panelu
            Block.pracPanel.Controls.Add(this);
        }
    }
}
