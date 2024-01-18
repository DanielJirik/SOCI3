namespace Vyvojaky
{
    internal class BlockCon
    {
        public PictureBox pb = new PictureBox();
        public Label popis = new Label();

        public BlockCon(string podminka)
        {
            //LB
            popis.ForeColor = Color.Black;
            popis.BackColor = pb.BackColor;
            popis.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            popis.AutoSize = true;
            popis.Location = new Point(0, 0);
            popis.Text = podminka;
            popis.Tag = "popis";

            //PB
            pb.Width = popis.Text.Length * 7;
            pb.Height = 50;
            pb.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - pb.Width), Random.Shared.Next(0, Block.pracPanel.Height - pb.Height));
            pb.BackColor = Color.White;

            //Drag and Drop event handlers
            pb.MouseDown += new MouseEventHandler(MouseDown);
            pb.MouseUp += new MouseEventHandler(MouseUp);
            pb.MouseMove += new MouseEventHandler(MouseMove);

            //INIT                        
            Block.pracPanel.Controls.Add(pb);
            pb.Controls.Add(popis);
        }

        //Drag and drop vars
        private bool dragging;
        private int xPos, yPos;

        //Drag and Drop methods
        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; yPos = e.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.pb.Top = e.Y + this.pb.Top - yPos;
                this.pb.Left = e.X + this.pb.Left - xPos;
            }
        }

    }
}
