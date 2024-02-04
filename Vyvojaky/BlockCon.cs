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
            this.Tag = Block.BlockIndex() + $"/{value}"; //Vygeneruje novy index pro dany block

            //Drag and Drop event handlers
            this.MouseDown += new MouseEventHandler(OnMouseDown);
            this.MouseUp += new MouseEventHandler(OnMouseUp);
            this.MouseMove += new MouseEventHandler(OnMouseMove);

            //INIT                        
            Block.pracPanel.Controls.Add(this);
            this.Controls.Add(popis);
        }

        //Drag and drop vars
        private bool dragging;
        private int xPos, yPos;

        //Drag and Drop methods
        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; yPos = e.Y;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Top = e.Y + this.Top - yPos;
                this.Left = e.X + this.Left - xPos;
            }
        }

    }
}
