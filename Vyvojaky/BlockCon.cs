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
            popis.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.Text = podminka;
            popis.Location = new Point(this.Width / 2 - popis.Width / 2 + 5, this.Height / 2 - popis.Height / 2);
            popis.Parent = this;
            popis.BackColor = Color.Transparent;

            //PB
            this.Width = popis.Text.Length * 10;
            this.Height = 50;
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.BackColor = Block.pracPanel.BackColor;
            this.Image = Resources.podminka_svetly;
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
