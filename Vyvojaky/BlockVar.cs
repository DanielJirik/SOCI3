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
        public Label popis = new Label();
        public string[] accessValue;
        public string prikaz;

        public int index;

        public int? joint;

        public Block.Type type = Block.Type.Var;

        public BlockVar(string nazev, string hodnota, string prikaz)
        {
            //Reference na value blocku
            this.prikaz = prikaz;
            accessValue = new string[] {nazev, hodnota, prikaz};

            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;            

            //LB
            popis.ForeColor = Color.Black;            
            popis.BackColor = this.BackColor;
            popis.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.AutoSize = true;
            popis.Location = new Point(0, 0);
            popis.Text = nazev + " = " + hodnota;
            popis.Tag = "popis";


            //PB
            this.Width = popis.Text.Length * 7;
            this.Height = 50;
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            this.BackColor = Color.White;

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            //Drag and Drop event handlers
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);            

            //INIT
            Block.pracPanel.Controls.Add(this);
            this.Controls.Add(popis);
        }
    }
}