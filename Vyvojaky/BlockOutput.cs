using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockOutput : PictureBox, IBlock
    {
        Label lb;
        public static int index;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }

        public BlockOutput(string input)
        {
            //Set interface property
            this.type = Block.Type.Output;
            this.command = input;

            index = Block.BlockIndex(type);
            this.Tag = index;

            lb = new Label();
            lb.Text = input + " ";
            lb.Width = lb.Text.Length * 8;
            lb.Location = new Point(10, 20);

            this.BackColor = Color.White;
            this.Height = 50;
            this.Width = lb.Width + 20;
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
