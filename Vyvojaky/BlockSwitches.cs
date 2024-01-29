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
        int startPositionX = 10;
        int startPositionY = 10;
        int promSirka = 0;
        public BlockSwitches(int pocetCasu, string vstupPromenna, List<TextBox> boxy) 
        {   
            //picture box
            pb.Width = 120;
            pb.Height = 50;
            pb.BackColor = Color.White;
            promSirka = pb.Width;
            //label + pridani lb do picture boxu
            lb.Text = "Switch(" + vstupPromenna + "):";
            
            lb.Location = new Point(startPositionX, startPositionY);
            pb.Controls.Add(lb);

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
                pb.Height += 20;
                pb.Width = promSirka;
                Debug.WriteLine("Vstup promnná: " + vstupPromenna);
                lb.Location = new Point(startPositionX, startPositionY);
                pb.Controls.Add(lb);
            }
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
