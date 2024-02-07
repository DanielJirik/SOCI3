namespace Vyvojaky
{
    internal class BlockCon : PictureBox
    {
        //public PictureBox this = new PictureBox();
        public Label popis = new Label();        
        public bool value;

        public BlockCon(string podminka, bool value)
        {
            //prirazeni hodnoty
            this.value = value;

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
            this.Tag = Block.BlockIndex(); //Vygeneruje novy index pro dany block

            //Drag and Drop event handlers
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //INIT                        
            Block.pracPanel.Controls.Add(this);
            this.Controls.Add(popis);
        }
    }
}
