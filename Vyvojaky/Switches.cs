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
            //vstupní proměnné
            int vstupInt;
            double vstupDouble;
            float vstupFloat;
            bool vstupBool;
            string vstupString;
            char vstupChar;

            //proměnné pro boxy
            int moznostInt;
            double moznostDouble;
            float moznostFloat;
            bool moznostBool;
            string moznostString;
            char moznostChar;

            //bool proměnná pro případy, že nenajde cílenou proměnnou nebo se stane i jiná chyba
            bool check = false; 

            string typVstupu = Promenne.FindVar(VstupPromenna.Text.Trim(), "type");
            if (typVstupu != null)
            {
                if (typVstupu == "Int16" || typVstupu == "Int32" || typVstupu == "Int64")
                {
                    vstupInt = int.Parse(Promenne.FindVar(VstupPromenna.Text.Trim(), "value"));
                    for (int i = 0; i < Moznosti.Count; i++)
                    {
                        if (int.TryParse(Moznosti[i].Text, out moznostInt) || "Int16" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type") || "Int32" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type") || "Int64" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if (Promenne.FindVar(Moznosti[i].Text.Trim(), "value") != null)
                            {
                                moznostInt = int.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                int.TryParse(Moznosti[i].Text.Trim(), out moznostInt);
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        VytvoreniBloku(VstupPromenna.Text.Trim());
                    }
                }
                else
                {
                    switch (typVstupu)
                    {
                        case "Float":
                            vstupFloat = float.Parse(Promenne.FindVar(VstupPromenna.Text.Trim(), "value"));
                            for (int i = 0; i < Moznosti.Count; i++)
                            {
                                if (float.TryParse(Moznosti[i].Text, out moznostFloat) || "Float" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < Moznosti.Count; i++)
                                {
                                    if (Promenne.FindVar(Moznosti[i].Text.Trim(), "type") != null)
                                    {
                                        moznostFloat = float.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                        if (vstupFloat == moznostFloat)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        float.TryParse(Moznosti[i].Text.Trim(), out moznostFloat);
                                        if (vstupFloat == moznostFloat)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                VytvoreniBloku(VstupPromenna.Text.Trim());
                            }
                            break;
                        case "Double":
                            vstupDouble = int.Parse(Promenne.FindVar(VstupPromenna.Text.Trim(), "value"));
                            for (int i = 0; i < Moznosti.Count; i++)
                            {
                                if (double.TryParse(Moznosti[i].Text, out moznostDouble) || "Double" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < Moznosti.Count; i++)
                                {
                                    if (Promenne.FindVar(Moznosti[i].Text.Trim(), "type") != null)
                                    {
                                        moznostDouble = double.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                        if (vstupDouble == moznostDouble)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        double.TryParse(Moznosti[i].Text.Trim(), out moznostDouble);
                                        if (vstupDouble == moznostDouble)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                VytvoreniBloku(VstupPromenna.Text.Trim());
                            }
                            break;
                        case "Bool":
                            vstupBool = bool.Parse(Promenne.FindVar(VstupPromenna.Text.Trim(), "value"));
                            for (int i = 0; i < Moznosti.Count; i++)
                            {
                                if (bool.TryParse(Moznosti[i].Text, out moznostBool) || "Bool" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < Moznosti.Count; i++)
                                {
                                    if (Promenne.FindVar(Moznosti[i].Text.Trim(), "type") != null)
                                    {
                                        moznostBool = bool.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                        if (vstupBool == moznostBool)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else 
                                    {
                                        bool.TryParse(Moznosti[i].Text.Trim(), out moznostBool);
                                        if (vstupBool == moznostBool)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                VytvoreniBloku(VstupPromenna.Text.Trim());
                            }
                            break;
                        case "Char":
                            vstupChar = char.Parse(Promenne.FindVar(VstupPromenna.Text, "value"));
                            for (int i = 0; i < Moznosti.Count; i++)
                            {
                                if ((char.TryParse(Moznosti[i].Text, out moznostChar) && Moznosti[i].Text[0] == char.Parse("'") && Moznosti[i].Text[Moznosti[i].Text.Length - 1] == char.Parse("'")) || "Char" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < Moznosti.Count; i++)
                                {
                                    if (Promenne.FindVar(Moznosti[i].Text, "type") != null)
                                    {
                                        moznostChar = char.Parse(Promenne.FindVar(Moznosti[i].Text, "value"));
                                        if (vstupChar == moznostChar)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        moznostString = Moznosti[i].ToString();
                                        moznostString = Promenne.OverwriteChar(moznostString);
                                        char.TryParse(moznostString, out moznostChar);
                                        if (vstupChar == moznostChar)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                VytvoreniBloku(VstupPromenna.Text.Trim());
                            }
                            break;
                        case "String":
                            vstupString = Promenne.FindVar(VstupPromenna.Text, "value");
                            for (int i = 0; i < Moznosti.Count; i++)
                            {
                                if ((Moznosti[i].Text[0] == '"' && Moznosti[i].Text[Moznosti[i].Text.Length - 1] == '"' ) || "String" == Promenne.FindVar(Moznosti[i].Text, "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < Moznosti.Count; i++)
                                {
                                    if (Promenne.FindVar(Moznosti[i].Text, "type") != null)
                                    {
                                        moznostString = Promenne.FindVar(Moznosti[i].Text, "value");
                                        if (vstupString == moznostString)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        moznostString = Moznosti[i].Text;
                                        moznostString = Promenne.OverwriteString(moznostString);
                                        if (vstupString == moznostString)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                VytvoreniBloku(VstupPromenna.Text.Trim());
                            }
                            break;
                        default:
                            MessageBox.Show("Něco se nepovedlo!");
                            break;
                    }
                }
            }
            else
            {
                if (int.TryParse(VstupPromenna.Text.Trim(), out vstupInt))
                {
                    for (int i = 0; i < Moznosti.Count; i++)
                    {
                        if (int.TryParse(Moznosti[i].Text, out moznostInt) || "Int16" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type") || "Int32" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type") || "Int64" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if (Promenne.FindVar(Moznosti[i].Text.Trim(), "value") != null)
                            {
                                moznostInt = int.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                int.TryParse(Moznosti[i].Text.Trim(), out moznostInt);
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        VytvoreniBloku(VstupPromenna.Text.Trim());
                    }
                }
                else if (double.TryParse(VstupPromenna.Text.Trim(), out vstupDouble))
                {
                    for (int i = 0; i < Moznosti.Count; i++)
                    {
                        if (double.TryParse(Moznosti[i].Text, out moznostDouble) || "Double" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if (Promenne.FindVar(Moznosti[i].Text.Trim(), "value") != null)
                            {
                                moznostDouble = double.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                if (vstupDouble == moznostDouble)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                double.TryParse(Moznosti[i].Text.Trim(), out moznostDouble);
                                if (vstupDouble == moznostDouble)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        VytvoreniBloku(VstupPromenna.Text.Trim());
                    }
                }
                else if (float.TryParse(VstupPromenna.Text.Trim(), out vstupFloat))
                {
                    for (int i = 0; i < Moznosti.Count; i++)
                    {
                        if (float.TryParse(Moznosti[i].Text, out moznostFloat) || "Float" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if (Promenne.FindVar(Moznosti[i].Text.Trim(), "type") != null)
                            {
                                moznostFloat = float.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                if (vstupFloat == moznostFloat)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                float.TryParse(Moznosti[i].Text.Trim(), out moznostFloat);
                                if (vstupFloat == moznostFloat)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        VytvoreniBloku(VstupPromenna.Text.Trim());
                    }
                }
                else if (bool.TryParse(VstupPromenna.Text.Trim(), out vstupBool))
                {
                    for (int i = 0; i < Moznosti.Count; i++)
                    {
                        if (bool.TryParse(Moznosti[i].Text, out moznostBool) || "Bool" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if (Promenne.FindVar(Moznosti[i].Text.Trim(), "type") != null)
                            {
                                moznostBool = bool.Parse(Promenne.FindVar(Moznosti[i].Text.Trim(), "value"));
                                if (vstupBool == moznostBool)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                bool.TryParse(Moznosti[i].Text.Trim(), out moznostBool);
                                if (vstupBool == moznostBool)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        VytvoreniBloku(VstupPromenna.Text.Trim());
                    }
                }
                else if (VstupPromenna.Text[0] == char.Parse("'") && VstupPromenna.Text[VstupPromenna.Text.Length - 1] == char.Parse("'"))
                {
                    char.TryParse(Promenne.OverwriteChar(VstupPromenna.Text), out vstupChar);
                    for (int i = 0; i < Moznosti.Count; i++)
                    {
                        if ((char.TryParse(Moznosti[i].Text, out moznostChar) && Moznosti[i].Text[0] == char.Parse("'") && Moznosti[i].Text[Moznosti[i].Text.Length - 1] == char.Parse("'")) || "Char" == Promenne.FindVar(Moznosti[i].Text.Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if (Promenne.FindVar(Moznosti[i].Text, "type") != null)
                            {
                                moznostChar = char.Parse(Promenne.FindVar(Moznosti[i].Text, "value"));
                                if (vstupChar == moznostChar)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                moznostString = Moznosti[i].ToString();
                                moznostString = Promenne.OverwriteChar(moznostString);
                                char.TryParse(moznostString, out moznostChar);
                                if (vstupChar == moznostChar)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        VytvoreniBloku(VstupPromenna.Text.Trim());
                    }
                }
                else
                {
                    vstupString = VstupPromenna.Text;
                    if (vstupString[0] == '"' && vstupString[vstupString.Length - 1] == '"')
                    {
                        vstupString = Promenne.OverwriteString(vstupString);
                        for (int i = 0; i < Moznosti.Count; i++)
                        {
                            if ((Moznosti[i].Text[0] == '"' && Moznosti[i].Text[Moznosti[i].Text.Length - 1] == '"') || "String" == Promenne.FindVar(Moznosti[i].Text, "type"))
                                check = false;
                            else
                                check = true;
                        }
                        if (check)
                            MessageBox.Show("Něco se nepovedlo!");
                        else
                        {
                            for (int i = 0; i < Moznosti.Count; i++)
                            {
                                if (Promenne.FindVar(Moznosti[i].Text, "type") != null)
                                {
                                    moznostString = Promenne.FindVar(Moznosti[i].Text, "value");
                                    if (vstupString == moznostString)
                                    {
                                        console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                        break;
                                    }
                                }
                                else
                                {
                                    moznostString = Moznosti[i].Text;
                                    moznostString = Promenne.OverwriteString(moznostString);
                                    if (vstupString == moznostString)
                                    {
                                        console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                        break;
                                    }
                                }
                            }
                            VytvoreniBloku(VstupPromenna.Text.Trim());
                        }
                    }
                    else
                        MessageBox.Show("Něco se nepovedlo!");
                }
            }
        }

        public string ZjisteniTypuVDictionary(string moznost) 
        {
            moznost = Promenne.FindVar(moznost, "type");
            return moznost;
        }
        public void VytvoreniBloku(string hodnota) 
        {
            Block block = new Block(Pracovni);
            block.BlockSwitch(Moznosti.Count, hodnota, Moznosti);
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
