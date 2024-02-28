using System.Reflection;

namespace Vyvojaky
{
    internal class BlockCon : PictureBox
    {
        public Label popis = new Label();        
        public bool value;

        public int index;
        public int? joint;
        public string podminka;

        public Block.Type type = Block.Type.Con;

        public BlockCon(string podminka)
        {
            //prirazeni hodnoty
            this.podminka = podminka; 

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
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            this.BackColor = Color.White;

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
