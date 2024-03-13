using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockIfEnd : PictureBox, IBlock
    {
        public int index;

        //Interface properties
        public string command { get; set; }
        public Vector2 joint { get; set; }
        public Block.Type type { get; set; }
        public string GenCode()
        {            
            return "";
        }

        public Label lb;

        public BlockIfEnd()
        {
            //Set interface property
            this.type = Block.Type.EndIf;

            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //nastavení bloku
            this.BackColor = Color.White;
            this.Width = 170;
            this.Height = 70;
            this.Tag = index;
            this.Image = Resources.cyklus_podminka_konec_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Block.pracPanel.BackColor;

            //vytvoření nového labelu a jeho nastavení
            lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Location = new Point(10, 20);
            lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            lb.BackColor = Color.Transparent;
            lb.Text = $"End-If";
            lb.Width = lb.Text.Length * 11;

            //přidání labelu do bloku
            this.Controls.Add(lb);

            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            //přidání bloku do pracovního panelu
            Block.pracPanel.Controls.Add(this);
        }
    }
}
