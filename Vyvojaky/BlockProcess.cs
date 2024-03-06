using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockProcess : PictureBox, IBlock
    {
        public int index;
        public Label lb;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }

        public BlockProcess(string input) 
        {
            //Set interface properties
            this.type = Block.Type.Process;
            this.command = input;

            index = Block.BlockIndex(type);
            this.Tag = index;
            
            lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            lb.Left = this.Width / 2 - lb.Width / 2;            
            lb.Text = input;
            lb.Location = new Point(this.Width / 2 - lb.Width / 2 + 5, this.Height / 2 - lb.Height / 2);
            lb.Parent = this;
            lb.BackColor = Color.Transparent;

            this.Width = lb.Text.Length * 10;
            this.BackColor = Color.White;
            this.Height = 50;
            this.Image = Resources.zpracovani_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Block.pracPanel.BackColor;

            this.Controls.Add(lb);
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            Block.pracPanel.Controls.Add(this);
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            
        }
    }
}
