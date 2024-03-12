using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class BlockCycleEnd : PictureBox, IBlock
    {
        public int index;

        //Interface properties
        public string command { get; set; }
        public int? joint { get; set; }
        public Block.Type type { get; set; }
        public string GenCode()
        {
            if (name == "End-for" || name == "End-while")
                return "}";
            else if (name == "End-do-while")
                return "}" + CodeGenerator.lastCond;

            return "";
        }

        public string name;
        public Label lb;

        public BlockCycleEnd(string types) 
        {
            //Set interface property
            this.type = Block.Type.EndCycle;

            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            if (types == "For")
            {
                //nastavení bloku end-for
                name = "End-for";
                this.Width = 150;
                this.Height = 60;
                this.Image = Resources.cyklus_for_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackColor = Block.pracPanel.BackColor;

                //nastavení textu v end-for
                lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                lb.BackColor = Color.Transparent;
                lb.Location = new Point(30, 15);
                lb.Text = $"End-for";
                //lb.Width = lb.Text.Length * 8;

                //přidání labelu do bloku
                this.Controls.Add(lb);

                //přidání běžných možností pro blok
                CommonElement();

                //přidání bloku do pracovního panelu
                Block.pracPanel.Controls.Add(this);
            }
            else if (types == "While")
            {
                //jméno pro daný end-while
                name = "End-while";

                //nastavení picture-boxu
                this.BackColor = Color.White;
                this.Width = 150;
                this.Height = 70;
                this.Tag = index;
                this.Image = Resources.cyklus_podminka_zacatek_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackColor = Block.pracPanel.BackColor;

                //vytvoření a nastavení textu end-while
                lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                lb.BackColor = Color.Transparent;
                lb.Location = new Point(10, 30);
                lb.Text = $"End-while";
                //lb.Width = lb.Text.Length * 8;

                //přidání labelu do bloku
                this.Controls.Add(lb);

                //přidání běžných možností pro blok
                CommonElement();

                //přidání bloku do pracovního panelu
                Block.pracPanel.Controls.Add(this);
            }
            else
            {
                //jméno pro daný cyklus
                name = "End-do-while";

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
                lb.Text = $"End-Dowhile";
                lb.Width = lb.Text.Length * 11;

                //přidání labelu do bloku
                this.Controls.Add(lb);

                //přidání běžných možností pro blok
                CommonElement();

                //přidání bloku do pracovního panelu
                Block.pracPanel.Controls.Add(this);
            }
        }

        //běžné možnosti bloků
        private void CommonElement()
        {
            this.Location = Block.pracPanel.PointToClient(Cursor.Position);
            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);
        }
    }
}
