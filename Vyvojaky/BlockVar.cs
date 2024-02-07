using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockVar : PictureBox
    {
        //public PictureBox pb = new PictureBox();
        public Label popis = new Label();
        public string[] accessValue;

        public BlockVar(string typ, string nazev, string hodnota)
        {
            //Reference na value blocku
            accessValue = new string[] {typ, nazev, hodnota};

            //LB
            popis.ForeColor = Color.Black;            
            popis.BackColor = this.BackColor;
            popis.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.AutoSize = true;
            popis.Location = new Point(0, 0);
            popis.Text = typ + " > " + nazev + " = " + hodnota;
            popis.Tag = "popis";
            //popis.Enabled = false;

            //PB
            this.Width = popis.Text.Length * 7;
            this.Height = 50;
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            this.BackColor = Color.White;
            this.Tag = Block.BlockIndex(); //Vygeneruje novy index pro dany block a nastavi jej jako Tag PictureBoxu

            //Drag and Drop event handlers                        
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //INIT
            Block.pracPanel.Controls.Add(this);
            this.Controls.Add(popis);
        }
    }
}