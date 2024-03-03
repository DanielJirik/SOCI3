using System.Reflection;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockCon : PictureBox, IBlock
    {
        public Label popis = new Label();        
        public bool value;

        public int index;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }

        public BlockCon(string podminka)
        {
            //Set interface properties
            this.command = podminka;
            this.type = Block.Type.Con;

            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //LB
            popis.ForeColor = Color.Black;
            popis.BackColor = this.BackColor;
            popis.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.AutoSize = true;
            popis.Location = new Point(0, 0);
            popis.Text = podminka;
            popis.Tag = "popis";

            //this
            this.Width = popis.Text.Length * 7;
            this.Height = 50;
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.BackColor = Color.White;
            this.BackgroundImage = Resources.podminka_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            //Drag and Drop event handlers
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //INIT                        
            Block.pracPanel.Controls.Add(this);
            this.Controls.Add(popis);
        }
    }
}
