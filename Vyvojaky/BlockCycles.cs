﻿using System;
using System.Collections.Generic;
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

            this.BackColor = Color.White;
            this.Width = 120;
            this.Height = 50;
            this.BackgroundImage = Resources.cyklus_for_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Location = new Point(10, 20);
            lb.Text = $"for(int {nazev} = {pocatek}; {nazev} <= {konecnaHodnota}; {nazev} += {inkrement})";
            lb.ForeColor = Color.White;
            lb.Width = lb.Text.Length * 8;
            this.Width = lb.Width + 10;

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
                this.Height = 50;
                this.Tag = index;
                this.BackgroundImage = Resources.cyklus_podminka_zacatek_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Location = new Point(10, 20);
                lb.Text = $"While{condition}";
                lb.ForeColor = Color.White;
                lb.Width = lb.Text.Length * 8;
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
                this.Height = 50;
                this.Tag = index;
                this.BackgroundImage = Vyvojaky.Properties.Resources.cyklus_podminka_konec_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;

                Label lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Location = new Point(10, 20);
                lb.Text = $"Do-While{condition}";
                lb.ForeColor = Color.Black;
                lb.Width = lb.Text.Length * 8;
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
