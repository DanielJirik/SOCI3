using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockSwitches : PictureBox
    {
        //public PictureBox this = new PictureBox();
        public Label lb = new Label();
        int startPositionX = 10;
        int startPositionY = 10;
        int promSirka = 0;
        public BlockSwitches(int pocetCasu, string vstupPromenna, List<TextBox> boxy) 
        {   
            //picture box
            this.Width = 120;
            this.Height = 50;
            this.BackColor = Color.White;
            promSirka = this.Width;
            this.Tag = Block.BlockIndex(); //Vygeneruje novy index pro dany block

            //label + pridani lb do picture boxu
            lb.Text = "Switch(" + vstupPromenna + "):";
            
            lb.Location = new Point(startPositionX, startPositionY);
            this.Controls.Add(lb);

            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {
                lb = new Label();
                lb.Text = (i + 1) + ".Case:" + boxy[i].Text;
                if (promSirka < (promSirka + lb.Text.Length))
                {
                    promSirka += lb.Text.Length*2;
                }
                startPositionY += 20;
                this.Height += 20;
                this.Width = promSirka;
                Debug.WriteLine("Vstup promnná: " + vstupPromenna);
                lb.Location = new Point(startPositionX, startPositionY);
                this.Controls.Add(lb);
            }
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            Block.pracPanel.Controls.Add(this);

            this.MouseDown += new MouseEventHandler(OnMouseDown);
            this.MouseUp += new MouseEventHandler(OnMouseUp);
            this.MouseMove += new MouseEventHandler(OnMouseMove);
        }

        private bool dragging;
        private int xPos, yPos;

        //pohyb bloku
        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; 
                yPos = e.Y;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Top = e.Y + this.Top - yPos;
                this.Left = e.X + this.Left - xPos;
            }
        }
    }
}
