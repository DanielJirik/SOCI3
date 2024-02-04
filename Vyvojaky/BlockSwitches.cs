using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockSwitches
    {
        public PictureBox pb = new PictureBox();
        public Label lb = new Label();
        public Label lbVstup = new Label();
        public List<string> seznamLabelu = new List<string>();
        int startPositionX = 10;
        int startPositionY = 10;
        public BlockSwitches(int pocetCasu, string vstupPromenna, List<TextBox> boxy) 
        {   
            //picture box
            pb.Width = 120;
            pb.Height = 50;
            pb.BackColor = Color.White;
            pb.Tag = Block.BlockIndex(); //Vygeneruje novy index pro dany block

            //label + pridani lb do picture boxu
            lbVstup.Text = vstupPromenna;
            for (int i = 0; i < pocetCasu; i++)
            {
                seznamLabelu.Add(boxy[i].Text);
            }
            int delka = 0;
            seznamLabelu.Add(lbVstup.Text.ToString());
            for (int i = 0; i < seznamLabelu.Count; i++)
            {
                if (delka < seznamLabelu[i].Length)
                {
                    delka = seznamLabelu[i].Length;
                }
            }
            
            lbVstup.Text = "Switch(" + vstupPromenna + "):";
            lbVstup.Width += delka * 10;
            lbVstup.Location = new Point(startPositionX, startPositionY);
            pb.Controls.Add(lbVstup);
            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {
                lb = new Label();
                lb.Text = (i + 1) + ".Case:" + boxy[i].Text;
                startPositionY += 20;
                pb.Height += 20;
                lb.Location = new Point(startPositionX, startPositionY);
                lb.Width += delka * 10;
                pb.Controls.Add(lb);
            }
            pb.Width += (delka * 7) + startPositionX;
            pb.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - pb.Width), Random.Shared.Next(0, Block.pracPanel.Height - pb.Height));
            Block.pracPanel.Controls.Add(pb);

            pb.MouseDown += new MouseEventHandler(MouseDown);
            pb.MouseUp += new MouseEventHandler(MouseUp);
            pb.MouseMove += new MouseEventHandler(MouseMove);
        }

        private bool dragging;
        private int xPos, yPos;

        //pohyb bloku
        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; 
                yPos = e.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.pb.Top = e.Y + this.pb.Top - yPos;
                this.pb.Left = e.X + this.pb.Left - xPos;
            }
        }
    }
}
