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
        private string typ, nazev, hodnota;
        private Panel pracPanel;

        public Block(string _typ, string _nazev, string _hodnota, Panel _pracPanel)
        {
            typ = _typ;
            nazev = _nazev;
            hodnota = _hodnota;
            pracPanel = _pracPanel;

            VytvoritBlock();
        }

        //
        public PictureBox pb = new PictureBox();
        public Label popis = new Label();

        private void VytvoritBlock()
        {
            //PB
            pb.Width = 120;
            pb.Height = 50;
            pb.Location = new Point(Random.Shared.Next(0, pracPanel.Width - pb.Width), Random.Shared.Next(0, pracPanel.Height - pb.Height));
            pb.BackColor = Color.White;

            //LB
            popis.ForeColor = Color.Black;
            popis.BackColor = pb.BackColor;
            popis.Font = new Font("Arial",10F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.AutoSize = true;
            popis.Location = new Point(0, 0);
            popis.Text = typ + " > " + nazev + " = " + hodnota;
            popis.Tag = "popis";

            //INIT                        
            pracPanel.Controls.Add(pb);
            pb.Controls.Add(popis);

            //Drag and Drop event handlers
            pb.MouseDown += new MouseEventHandler(MouseDown);
            pb.MouseUp += new MouseEventHandler(MouseUp);
            pb.MouseMove += new MouseEventHandler(MouseMove);

            //
        }

        //Drag and drop vars1
        private bool dragging;
        private int xPos, yPos;

        //Drag and Drop methods
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; yPos = e.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging){
                this.pb.Top = e.Y + this.pb.Top - yPos;
                this.pb.Left = e.X + this.pb.Left - xPos;
            }
        }

        //
    }
}
