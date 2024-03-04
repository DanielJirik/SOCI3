using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockCycles : PictureBox, IBlock
    {
        public int index;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }

        public BlockCycles(string nazev, string pocatek, string konecnaHodnota, string inkrement) 
        {
            //Set interface property
            this.type = Block.Type.Cycle;

            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            this.Width = 120;
            this.Height = 60;
            this.Image = Resources.cyklus_for_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Block.pracPanel.BackColor;
            
            Label lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            lb.BackColor = Color.Transparent;
            lb.Location = new Point(30, 15);
            lb.Text = $"for(int {nazev} = {pocatek}; {nazev} <= {konecnaHodnota}; {nazev} += {inkrement})";
            lb.Width = lb.Text.Length * 9;
            this.Width = lb.Width + 50;

            this.Controls.Add(lb);
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);

            Block.pracPanel.Controls.Add(this);
        }
        
        public BlockCycles(string condition, string type)
        {
            if (type == "While")
            {
                this.BackColor = Color.White;
                this.Width = 120;
                this.Height = 70;
                this.Tag = index;
                this.Image = Resources.cyklus_podminka_zacatek_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackColor = Block.pracPanel.BackColor;
                Label lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                lb.BackColor = Color.Transparent;
                lb.Location = new Point(10, 30);
                lb.Text = $"While{condition}";
                lb.Width = lb.Text.Length * 10;
                Debug.WriteLine(condition);   
                this.Width = lb.Width + 10;

                this.Controls.Add(lb);
                this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
                this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
                this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
                this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

                Block.pracPanel.Controls.Add(this);
            }
            else
            {
                this.BackColor = Color.White;
                this.Width = 150;
                this.Height = 70;
                this.Tag = index;
                this.Image = Resources.cyklus_podminka_konec_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackColor = Block.pracPanel.BackColor;
                Label lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Location = new Point(10, 20);
                lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                lb.BackColor = Color.Transparent;
                lb.Text = $"Do-While{condition}";
                lb.Width = lb.Text.Length * 10;
                this.Width = lb.Width + 10;

                this.Controls.Add(lb);
                this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
                this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
                this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
                this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

                Block.pracPanel.Controls.Add(this);
            }
        }

        
    }
}
