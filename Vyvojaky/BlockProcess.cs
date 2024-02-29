using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockProcess : PictureBox, IBlock
    {
        public int index;
        Label lb;

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
            this.BackColor = Color.White;
            this.Width = 120;
            this.Height = 50;
            lb = new Label();

            lb.Location = new Point(10, 20);
            lb.Text = input + "  ";
            lb.Width = (input.Length * 8) + 5;
            this.Width = lb.Width + 30;

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
