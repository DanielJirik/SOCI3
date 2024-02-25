using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockProcess : PictureBox
    {
        public int index;
        public int? joint;
        public Block.Type type = Block.Type.Process;
        Label lb;
        public string input = "";
        public BlockProcess(string input) 
        {   
            this.input = input;
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
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            Block.pracPanel.Controls.Add(this);
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            Block.pracPanel.Controls.Add(this);
        }
    }
}
