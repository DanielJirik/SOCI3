using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockOutput : PictureBox, IBlock
    {
        public Label lb;
        public static int index;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }
        public string GenCode()
        {
            return $"Console.WriteLine({command});";
        }

        public BlockOutput(string input)
        {
            //Set interface property
            this.type = Block.Type.Output;
            this.command = input;

            index = Block.BlockIndex(type);
            this.Tag = index;

            //vytvoření nového labelu a jeho vlastnosti
            lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            lb.Text = input;
            lb.Location = new Point(this.Width / 2 - lb.Width / 2 + 5, this.Height / 2 - lb.Height / 2);
            lb.Parent = this;
            lb.BackColor = Color.Transparent;

            //nastavení picture-boxu
            this.Width = lb.Text.Length * 10;
            this.MinimumSize = new Size(50,50);
            this.Height = 50;
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.BackColor = Block.pracPanel.BackColor;
            this.Image = Resources.vstup_vystup_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            
            //přidání labelu do picture-boxu
            this.Controls.Add(lb);

            //základní vlastnosti picture-boxu
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            //přidání picture-boxu do pracovního panelu
            Block.pracPanel.Controls.Add(this);
        }
    }
}
