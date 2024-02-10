using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockStart : PictureBox
    {
        public static int index = 0;

        public BlockStart()
        {
            //only for test
            this.Size = new Size(50, 50);
            this.BackColor = Color.Black;
            this.Location = new Point(300, 300);
            //end

            Block.indexes.Add(index);
            Block.pracPanel.Controls.Add(this); //fix this
        }
    }
}
