using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockCycles : PictureBox
    {
        public int index;
        public int? joint;
        public Block.Type type = Block.Type.Cycle;

        public BlockCycles(string nazev, string pocatek, string konecnaHodnota, string inkrement) 
        {
            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            this.BackColor = Color.White;
            this.Width = 120;
            this.Height = 50;

            Label lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Location = new Point(10, 20);
            lb.Text = $"for(int {nazev} = {pocatek}; {nazev} <= {konecnaHodnota}; {nazev} += {inkrement})";
            lb.Width = lb.Text.Length * 8;
            this.Width = lb.Width + 10;

            this.Controls.Add(lb);
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            Block.pracPanel.Controls.Add(this);
        }
        
        public BlockCycles(string condition, string type)
        {
            if (type == "While")
            {
                this.BackColor = Color.White;
                this.Width = 120;
                this.Height = 50;
                this.Tag = index;

                Label lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Location = new Point(10, 20);
                lb.Text = $"While{condition}";
                lb.Width = lb.Text.Length * 8;
                this.Width = lb.Width + 10;

                this.Controls.Add(lb);
                this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
                this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
                this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
                this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

                Block.pracPanel.Controls.Add(this);
            }
            else
            {
                this.BackColor = Color.White;
                this.Width = 150;
                this.Height = 50;
                this.Tag = index;

                Label lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Location = new Point(10, 20);
                lb.Text = $"Do-While{condition}";
                lb.Width = lb.Text.Length * 8;
                this.Width = lb.Width + 10;

                this.Controls.Add(lb);
                this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
                this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
                this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
                this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

                Block.pracPanel.Controls.Add(this);
            }
        }

        
    }
}
