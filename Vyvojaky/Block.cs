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
        
        private void VytvoritBlock()
        {
            PictureBox pb = new PictureBox();

            pb.Width = 120;
            pb.Height = 50;
            pb.Location = new Point(Random.Shared.Next(0, pracPanel.Width - pb.Width), Random.Shared.Next(0, pracPanel.Height - pb.Height));
            pb.BackColor = Color.White;

            Label popis = new Label();
            popis.ForeColor = Color.Black;
            popis.BackColor = pb.BackColor;
            popis.Font = new Font("Arial",10F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.AutoSize = true;
            popis.Location = new Point(0, 0);
            popis.Text = typ + " " + nazev + " = " + hodnota;
            
            pracPanel.Controls.Add(pb);
            pb.Controls.Add(popis);            
        }

        /*PRIDAT DRAG AND DROP*/
    }
}
