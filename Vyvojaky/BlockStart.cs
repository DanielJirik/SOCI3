using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockStart : PictureBox, IBlock
    {
        public static int index;

        //Interface properties
        public string command { get; set; }
        public Vector2 joint { get; set; }
        public Block.Type type { get; set; }
        public string GenCode() { return ""; }

        public BlockStart()
        {
            //Set interface property
            this.type = Block.Type.Start;

            index = Block.BlockIndex(type);
            this.Tag = index;            

            Image img = Resources.start;            
            
            this.Size = new Size(80, 40);
            this.Image = img;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);

            //Drag and Drop event handlers
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            Block.pracPanel.Controls.Add(this);
        }
    }
}
