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
        public List<TextBox> Moznosti = new List<TextBox>();
        List<Label> Lably = new List<Label>() { };
        public List<string> variables = new List<string>();
        Panel Pracovni;
        public int VyskaPaneluPuvodni;

        public Switches() 
        { 
            
        }

        

        public void FromTextBox()
        {
            foreach (TextBox variable in Moznosti)
            { 
                variables.Add(variable.Text);
            }
        }

        public void Deleted()
        { 
            variables.Clear();
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

        public void Kontrola(TextBox console, string inputVar, List<string> variables, bool creation)
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


            string typVstupu = Promenne.FindVar(inputVar.Trim(), "type");
            if (typVstupu != null)
            {
                if (typVstupu == "Int16" || typVstupu == "Int32" || typVstupu == "Int64")
                {
                    vstupInt = int.Parse(Promenne.FindVar(inputVar.Trim(), "value"));
                    for (int i = 0; i < variables.Count; i++)
                    {
                        if (int.TryParse(variables[i], out moznostInt) || "Int16" == Promenne.FindVar(variables[i].Trim(), "type") || "Int32" == Promenne.FindVar(variables[i].Trim(), "type") || "Int64" == Promenne.FindVar(variables[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if (Promenne.FindVar(variables[i].Trim(), "value") != null)
                            {
                                moznostInt = int.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                int.TryParse(variables[i].Trim(), out moznostInt);
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        if (creation)
                            VytvoreniBloku(inputVar.Trim());
                    }
                }
                else
                {
                    switch (typVstupu)
                    {
                        case "Float":
                            vstupFloat = float.Parse(Promenne.FindVar(inputVar.Trim(), "value"));
                            for (int i = 0; i < variables.Count; i++)
                            {
                                if (float.TryParse(variables[i], out moznostFloat) || "Float" == Promenne.FindVar(variables[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < variables.Count; i++)
                                {
                                    if (Promenne.FindVar(variables[i].Trim(), "type") != null)
                                    {
                                        moznostFloat = float.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                        if (vstupFloat == moznostFloat)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        float.TryParse(variables[i].Trim(), out moznostFloat);
                                        if (vstupFloat == moznostFloat)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                if (creation)
                                    VytvoreniBloku(inputVar.Trim());
                            }
                            break;
                        case "Double":
                            vstupDouble = int.Parse(Promenne.FindVar(inputVar.Trim(), "value"));
                            for (int i = 0; i < variables.Count; i++)
                            {
                                if (double.TryParse(variables[i], out moznostDouble) || "Double" == Promenne.FindVar(variables[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < variables.Count; i++)
                                {
                                    if (Promenne.FindVar(variables[i].Trim(), "type") != null)
                                    {
                                        moznostDouble = double.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                        if (vstupDouble == moznostDouble)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        double.TryParse(variables[i].Trim(), out moznostDouble);
                                        if (vstupDouble == moznostDouble)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                if (creation)
                                    VytvoreniBloku(inputVar.Trim());
                            }
                            break;
                        case "Bool":
                            vstupBool = bool.Parse(Promenne.FindVar(inputVar.Trim(), "value"));
                            for (int i = 0; i < variables.Count; i++)
                            {
                                if (bool.TryParse(variables[i], out moznostBool) || "Bool" == Promenne.FindVar(variables[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < variables.Count; i++)
                                {
                                    if (Promenne.FindVar(variables[i].Trim(), "type") != null)
                                    {
                                        moznostBool = bool.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                        if (vstupBool == moznostBool)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else 
                                    {
                                        bool.TryParse(variables[i].Trim(), out moznostBool);
                                        if (vstupBool == moznostBool)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                if (creation)
                                    VytvoreniBloku(inputVar.Trim());
                            }
                            break;
                        case "Char":
                            vstupChar = char.Parse(Promenne.FindVar(inputVar, "value"));
                            for (int i = 0; i < variables.Count; i++)
                            {
                                if ((char.TryParse(variables[i], out moznostChar) && variables[i][0] == char.Parse("'") && variables[i][variables[i].Length - 1] == char.Parse("'")) || "Char" == Promenne.FindVar(variables[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < variables.Count; i++)
                                {
                                    if (Promenne.FindVar(variables[i], "type") != null)
                                    {
                                        moznostChar = char.Parse(Promenne.FindVar(variables[i], "value"));
                                        if (vstupChar == moznostChar)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        moznostString = variables[i].ToString();
                                        moznostString = Promenne.OverwriteChar(moznostString);
                                        char.TryParse(moznostString, out moznostChar);
                                        if (vstupChar == moznostChar)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                if (creation)
                                    VytvoreniBloku(inputVar.Trim());
                            }
                            break;
                        case "String":
                            vstupString = Promenne.FindVar(inputVar, "value");
                            for (int i = 0; i < variables.Count; i++)
                            {
                                if ((variables[i][0] == '"' && variables[i][variables[i].Length - 1] == '"' ) || "String" == Promenne.FindVar(variables[i], "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("Něco se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < variables.Count; i++)
                                {
                                    if (Promenne.FindVar(variables[i], "type") != null)
                                    {
                                        moznostString = Promenne.FindVar(variables[i], "value");
                                        if (vstupString == moznostString)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        moznostString = variables[i];
                                        moznostString = Promenne.OverwriteString(moznostString);
                                        if (vstupString == moznostString)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                if (creation)
                                    VytvoreniBloku(inputVar.Trim());
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
                if (int.TryParse(inputVar.Trim(), out vstupInt))
                {
                    for (int i = 0; i < variables.Count; i++)
                    {
                        if (int.TryParse(variables[i], out moznostInt) || "Int16" == Promenne.FindVar(variables[i].Trim(), "type") || "Int32" == Promenne.FindVar(variables[i].Trim(), "type") || "Int64" == Promenne.FindVar(variables[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if (Promenne.FindVar(variables[i].Trim(), "value") != null)
                            {
                                moznostInt = int.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                int.TryParse(variables[i].Trim(), out moznostInt);
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        if (creation)
                        {
                            VytvoreniBloku(inputVar.Trim());
                        }
                            
                    }
                }
                else if (double.TryParse(inputVar.Trim(), out vstupDouble))
                {
                    for (int i = 0; i < variables.Count; i++)
                    {
                        if (double.TryParse(variables[i], out moznostDouble) || "Double" == Promenne.FindVar(variables[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if (Promenne.FindVar(variables[i].Trim(), "value") != null)
                            {
                                moznostDouble = double.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                if (vstupDouble == moznostDouble)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                double.TryParse(variables[i].Trim(), out moznostDouble);
                                if (vstupDouble == moznostDouble)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        if (creation)
                            VytvoreniBloku(inputVar.Trim());
                    }
                }
                else if (float.TryParse(inputVar.Trim(), out vstupFloat))
                {
                    for (int i = 0; i < variables.Count; i++)
                    {
                        if (float.TryParse(variables[i], out moznostFloat) || "Float" == Promenne.FindVar(variables[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if (Promenne.FindVar(variables[i].Trim(), "type") != null)
                            {
                                moznostFloat = float.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                if (vstupFloat == moznostFloat)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                float.TryParse(variables[i].Trim(), out moznostFloat);
                                if (vstupFloat == moznostFloat)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        if (creation)
                            VytvoreniBloku(inputVar.Trim());
                    }
                }
                else if (bool.TryParse(inputVar.Trim(), out vstupBool))
                {
                    for (int i = 0; i < variables.Count; i++)
                    {
                        if (bool.TryParse(variables[i], out moznostBool) || "Bool" == Promenne.FindVar(variables[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("Něco se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if (Promenne.FindVar(variables[i].Trim(), "type") != null)
                            {
                                moznostBool = bool.Parse(Promenne.FindVar(variables[i].Trim(), "value"));
                                if (vstupBool == moznostBool)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                bool.TryParse(variables[i].Trim(), out moznostBool);
                                if (vstupBool == moznostBool)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        if (creation)
                            VytvoreniBloku(inputVar.Trim());
                    }
                }
                else if (inputVar[0] == char.Parse("'") && inputVar[inputVar.Length - 1] == char.Parse("'"))
                {
                    char.TryParse(Promenne.OverwriteChar(inputVar), out vstupChar);
                    for (int i = 0; i < variables.Count; i++)
                    {
                        if ((variables[i][0] == char.Parse("'") && variables[i][variables[i].Length - 1] == char.Parse("'")) || "Char" == Promenne.FindVar(variables[i].Trim(), "type"))
                        {
                            check = false;
                        }
                        else
                        {
                            check = true;
                        }
                            
                    }
                    if (check)
                    {
                        MessageBox.Show("Něco se nepovedlo!");
                    }
                    else
                    {
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if (Promenne.FindVar(variables[i], "type") != null)
                            {
                                moznostChar = char.Parse(Promenne.FindVar(variables[i], "value"));
                                if (vstupChar == moznostChar)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                moznostString = variables[i].ToString();
                                moznostChar = char.Parse(Promenne.OverwriteChar(moznostString));
                                if (vstupChar == moznostChar)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        if (creation)
                            VytvoreniBloku(inputVar.Trim());
                    }
                }
                else
                {
                    vstupString = inputVar;
                    if (vstupString[0] == '"' && vstupString[vstupString.Length - 1] == '"')
                    {
                        vstupString = Promenne.OverwriteString(vstupString);
                        for (int i = 0; i < variables.Count; i++)
                        {
                            if ((variables[i][0] == '"' && variables[i][variables[i].Length - 1] == '"') || "String" == Promenne.FindVar(variables[i], "type"))
                                check = false;
                            else
                                check = true;
                        }
                        if (check)
                            MessageBox.Show("Něco se nepovedlo!");
                        else
                        {
                            for (int i = 0; i < variables.Count; i++)
                            {
                                if (Promenne.FindVar(variables[i], "type") != null)
                                {
                                    moznostString = Promenne.FindVar(variables[i], "value");
                                    if (vstupString == moznostString)
                                    {
                                        console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                        break;
                                    }
                                }
                                else
                                {
                                    moznostString = variables[i];
                                    moznostString = Promenne.OverwriteString(moznostString);
                                    if (vstupString == moznostString)
                                    {
                                        console.Text += "\r\n" + ">" + "trueee v casu č." + (i + 1) + "\r\n";
                                        break;
                                    }
                                }
                            }
                            if (creation)
                                VytvoreniBloku(inputVar.Trim());
                        }
                    }
                    else
                        MessageBox.Show("Něco se nepovedlo!");
                }
            }
        }

        public void VytvoreniBloku(string hodnota) 
        {
            Block.BlockSwitch(variables.Count, hodnota, variables);
        }

        public void MazaniBoxu(Panel panelSwitch)
        {
            for (int i = 0; i < variables.Count; i++)
            {
                panelSwitch.Controls.Remove(Moznosti[i]);
                panelSwitch.Controls.Remove(Lably[i]);
            }
            Moznosti.Clear();
            variables.Clear();
            Lably.Clear();
            panelSwitch.Height = VyskaPaneluPuvodni;
        }
    }
}
