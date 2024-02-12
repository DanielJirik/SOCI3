using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockStart : PictureBox
    {
        public static int index = 0;

        public BlockStart()
        {
            this.Tag = index;

            Image img = Resources.start;            
            
            this.Size = new Size(80, 40);
            this.Image = img;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            
            this.Location = new Point(Block.pracPanel.Width / 2 - this.Width / 2, Block.pracPanel.Height / 2 - this.Height / 2);

            //Drag and Drop event handlers
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            Block.indexes.Add(index);
            Block.pracPanel.Controls.Add(this);
        }
    }
}
