using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockCycles : PictureBox
    {
        public BlockCycles(string nazev, string pocatek, string konecnaHodnota, string inkrement) 
        { 
            this.BackColor = Color.White;
            this.Width = 120;
            this.Height = 50;
            this.Tag = Block.BlockIndex();

            Label lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Location = new Point(10, 20);
            lb.Text = $"for(int {nazev} = {pocatek}; {nazev} <= {konecnaHodnota}; {nazev} += {inkrement})";
            lb.Width = lb.Text.Length * 8;
            if ((lb.Width + lb.Location.X) > this.Width)
            {
                int rozdil = (lb.Width + lb.Location.X) - this.Width;
                this.Width += rozdil - (lb.Location.X * 3);
            }
            this.Controls.Add(lb);
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            this.MouseDown += new MouseEventHandler(OnMouseDown);
            this.MouseUp += new MouseEventHandler(OnMouseUp);
            this.MouseMove += new MouseEventHandler(OnMouseMove);

            Block.pracPanel.Controls.Add(this);
        }




        //pohyb bloku
        private bool dragging;
        private int xPos, yPos;
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
