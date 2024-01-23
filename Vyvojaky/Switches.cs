using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Switches
    {
        public Panel PanelSwitch;
        public TextBox VstupPromenna;
        Label Text;
        TextBox Moznost;
        List<TextBox> Moznosti = new List<TextBox>(){ };
        List<Label> Lably = new List<Label>() { };
        Panel Pracovni;
        public int VyskaPaneluPuvodni;

        public Switches() 
        { 
            
        }

        public void Setup(Panel _pracpanel)
        {
            Pracovni = _pracpanel;
        }

        public void pridavaniTextBoxu(int pocetBoxu, Panel panelSwitch, TextBox vstupPromenna)
        {
            
            PanelSwitch = panelSwitch;
            VstupPromenna = vstupPromenna;
            int pozVstupPromX = VstupPromenna.Location.X;
            int pozVstupPromY = VstupPromenna.Location.Y;

            for (int i = 0; i < pocetBoxu; i++)
            {
                int cislo = i + 1;
                //text-label setup
                Text = new Label();
                Text.Text = cislo.ToString() + ".případ: ";
                pozVstupPromY += 30;
                Text.Location = new Point(pozVstupPromX, pozVstupPromY);
                //input-textbox setup
                pozVstupPromY += 30;
                Moznost = new TextBox();
                Moznost.Location = new Point(pozVstupPromX, pozVstupPromY);
                PanelSwitch.Height += 60;

                //pridani prvku do panelu switche
                PanelSwitch.Controls.Add(Moznost);
                PanelSwitch.Controls.Add(Text);

                //pridani labu a textboxu do prislusnych listu
                Lably.Add(Text);
                Moznosti.Add(Moznost);
            }
        }

        public void Kontrola(TextBox console)
        {
            int vstupniCislo = int.Parse(VstupPromenna.Text);
            for (int i = 0; i < Moznosti.Count; i++)
            {
                int box = int.Parse(Moznosti[i].Text);
                if (vstupniCislo == box)
                {
                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1);
                    break;
                }
            }
            Block block = new Block(Pracovni);
            block.BlockSwitch(Moznosti.Count, vstupniCislo, Moznosti);
        }

        public void MazaniBoxu(Panel panelSwitch)
        {
            
            for (int i = 0; i < Moznosti.Count; i++)
            {
                panelSwitch.Controls.Remove(Moznosti[i]);
                panelSwitch.Controls.Remove(Lably[i]);
            }

            Moznosti.Clear();
            Lably.Clear();
            panelSwitch.Height = VyskaPaneluPuvodni;
        }
    }
}
