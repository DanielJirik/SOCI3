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
        public string GenCode()
        {
            if (name == "For")
                return $"for (int {Nazev} = {Pocatek}; {Nazev} <= {KonecnaHodnota}; {Nazev} += {Inkrement})" + Environment.NewLine + "{" + Environment.NewLine;
            else if (name == "While")
                return $"while (int {Nazev} = {Pocatek}; {Nazev} <= {KonecnaHodnota}; {Nazev} += {Inkrement})" + Environment.NewLine + "{" + Environment.NewLine;
            else if (name == "Do-while")
            {
                CodeGenerator.lastCond = $"while (int {Nazev} = {Pocatek}; {Nazev} <= {KonecnaHodnota}; {Nazev} += {Inkrement});" + Environment.NewLine;
                return $"do" + Environment.NewLine + "{" + Environment.NewLine;
            }

            return "";
        }

        public string name;
        public Label lb;

        //proměnné cyklu for
        public string Nazev;
        public string Pocatek;
        public string KonecnaHodnota;
        public string Inkrement;

        //proměnné cyklu while a do-while
        public string condition;

        //konstruktor pro cyklus-for
        public BlockCycles(string nazev, string pocatek, string konecnaHodnota, string inkrement) 
        {
            //Set interface property
            this.type = Block.Type.Cycle;
            name = "For";
            //Indexace
            index = Block.BlockIndex(type);
            this.Tag = index;

            //nastavení bloku cyklu-for
            this.Width = 120;
            this.Height = 60;
            this.Image = Resources.cyklus_for_svetly;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Block.pracPanel.BackColor;
            
            //předání hodnot
            Nazev = nazev;
            Pocatek = pocatek;
            KonecnaHodnota = konecnaHodnota;
            Inkrement = inkrement;

            //nastavení textu v cyklu
            lb = new Label();
            lb.ForeColor = Color.Black;
            lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            lb.BackColor = Color.Transparent;
            lb.Location = new Point(30, 15);
            lb.Text = $"for(int {nazev} = {pocatek}; {nazev} <= {konecnaHodnota}; {nazev} += {inkrement})";
            lb.Width = lb.Text.Length * 9;

            //změna velikosti bloku na základě textu v lablu
            this.Width = lb.Width + 50;

            //přidání labelu do bloku
            this.Controls.Add(lb);

            //přidání běžných možností pro blok
            CommonElement();

            //přidání bloku do pracovního panelu
            Block.pracPanel.Controls.Add(this);
        }
        
        //konstruktor pro cyklus while a Do-while
        public BlockCycles(string condition, string type)
        {
            //Set interface property
            this.type = Block.Type.Cycle;
            //Indexace
            index = Block.BlockIndex(this.type);
            this.Tag = index;

            //podmínka přidána do proměnné pro blok pro další zpracování
            this.condition = condition;

            //rozhodnutí jestli se má vytvořit cyklus while nebo Do-while
            if (type == "While")
            {   
                //jméno pro daný cyklus
                name = "While";

                //nastavení picture-boxu
                this.BackColor = Color.White;
                this.Width = 120;
                this.Height = 70;
                this.Tag = index;
                this.Image = Resources.cyklus_podminka_zacatek_svetly;
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackColor = Block.pracPanel.BackColor;

                //vytvoření a nastavení textu cyklu while
                lb = new Label();
                lb.ForeColor = Color.Black;
                lb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                lb.BackColor = Color.Transparent;
                lb.Location = new Point(10, 30);
                lb.Text = $"While({condition})";
                lb.Width = lb.Text.Length * 10;

                //změna velikosti bloku na základě labelu
                this.Width = lb.Width + 10;

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
                name = "Do-while";

                //nastavení bloku
                this.BackColor = Color.White;
                this.Width = 150;
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
                lb.Text = $"Do-While({condition})";
                lb.Width = lb.Text.Length * 10;

                //změna velikosti bloku na základě velikosti labelu
                this.Width = lb.Width + 10;

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
