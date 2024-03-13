using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockVar : PictureBox, IBlock
    {
        public Label popis = new Label();
        public string[] accessValue;
        public int index;

        //Interface properties
        public string command { get; set; }
        public Vector2 joint { get; set; }
        public Block.Type type { get; set; }
        public string GenCode()
        {
            //Get data type
            Promenne.CommandCheck(command);
            string dataType = Promenne.FindVar(command.Split("=")[0].Trim(), "type");

            return $"{dataType} {command};";
        }

        public BlockVar(string nazev, string hodnota, string prikaz)
        {
            //Set interface property
            this.type = Block.Type.Var;

            //Reference na value blocku
            this.command = prikaz;
            accessValue = new string[] { nazev, hodnota, prikaz };

            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //LB
            popis.ForeColor = Color.Black;
            popis.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));            
            popis.Text = nazev + " = " + hodnota;            
            popis.Location = new Point(this.Width / 2 - popis.Width / 2 + 5, this.Height / 2 - popis.Height / 2);
            popis.Parent = this;
            popis.BackColor = Color.Transparent;


            //PB           
            this.Width = popis.Text.Length * 10;
            this.Height = 50;
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.BackColor = Block.pracPanel.BackColor;
            this.Image = Resources.vstup_vystup_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

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