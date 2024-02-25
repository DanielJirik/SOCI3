using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockOutput : PictureBox
    {
        Label lb;
        public BlockOutput(string input)
        {   
            lb = new Label();
            lb.Text = input + " ";
            lb.Width = lb.Text.Length * 8;
            lb.Location = new Point(10, 20);

            this.BackColor = Color.White;
            this.Height = 50;
            this.Width = lb.Width + 20;
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
        }
    }
}
