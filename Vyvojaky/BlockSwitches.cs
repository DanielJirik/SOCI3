using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class BlockSwitches : PictureBox
    {
        public Label lb;
        public Label lbVstup;
        public List<string> seznamLabelu;
        int startPositionX = 10;
        int startPositionY = 10;
        static List<string> hodnoty;
        static string vstup;

        public int index;
        public int? joint;
        public BlockSwitches(int pocetCasu, string vstupPromenna, List<TextBox> boxy)
        {
            
            lbVstup = new Label();
            hodnoty = new List<string>() { };
            vstup = "";
            seznamLabelu = new List<string>();
            for (int i = 0; i < boxy.Count; i++)
            {
                hodnoty.Add(boxy[i].Text.ToString());
            }
            vstup = vstupString;
            Debug.WriteLine("vstup: " + vstup);
            //Indexace
            index = Block.BlockIndex(Block.Type.Switch);
            this.Tag = index;

            //picture box
            this.Width = 120;
            this.Height = 50;
            this.BackColor = Color.White;

            //label + pridani lb do picture boxu
            lbVstup.Text = "Switch(" + vstupString + ")";
            for (int i = 0; i < pocetCasu; i++)
            {
                seznamLabelu.Add(boxy[i].Text);
            }
            int delka = 0;
            seznamLabelu.Add(lbVstup.ToString());
            for (int i = 0; i < seznamLabelu.Count; i++)
            {
                if (delka < seznamLabelu[i].Length)
                {
                    delka = seznamLabelu[i].Length;
                }
            }
            
            lbVstup.Location = new Point(startPositionX, startPositionY);
            lbVstup.Width = delka * 10;            
            this.Controls.Add(lbVstup);

            //vytvoreni novych labelu(casy) 
            for (int i = 0; i < pocetCasu; i++)
            {
                lb = new Label();
                lb.Text = (i + 1) + ".Case:" + boxy[i].Text;
                lb.Width = delka * 10;
                startPositionY += 20;
                this.Height += 20;
                lb.Location = new Point(startPositionX, startPositionY);
                this.Controls.Add(lb);
            }
            this.Width = (delka * 8) + (startPositionX * 5);
            this.Location = new Point(Random.Shared.Next(0, Block.pracPanel.Width - this.Width), Random.Shared.Next(0, Block.pracPanel.Height - this.Height));
            Block.pracPanel.Controls.Add(this);

            this.MouseClick += new MouseEventHandler(Block.OnMouseClick);
            this.MouseDown += new MouseEventHandler(Block.OnMouseDown);
            this.MouseUp += new MouseEventHandler(Block.OnMouseUp);
            this.MouseMove += new MouseEventHandler(Block.OnMouseMove);

            //Disable label on hover
            this.MouseEnter += new EventHandler(Block.DisableControl);
            this.MouseLeave += new EventHandler(Block.EnableControl);
        }

        public void Kontrola(TextBox console)
        {
            //vstupn� prom�nn�
            int vstupInt;
            double vstupDouble;
            float vstupFloat;
            bool vstupBool;
            string vstupString;
            char vstupChar;

            //prom�nn� pro boxy
            int moznostInt;
            double moznostDouble;
            float moznostFloat;
            bool moznostBool;
            string moznostString;
            char moznostChar;

            //bool prom�nn� pro p��pady, �e nenajde c�lenou prom�nnou nebo se stane i jin� chyba
            bool check = false;


            string typVstupu = Promenne.FindVar(vstup.Trim(), "type");
            if (typVstupu != null)
            {
                if (typVstupu == "Int16" || typVstupu == "Int32" || typVstupu == "Int64")
                {
                    vstupInt = int.Parse(Promenne.FindVar(vstup.Trim(), "value"));
                    for (int i = 0; i < hodnoty.Count; i++)
                    {
                        if (int.TryParse(hodnoty[i], out moznostInt) || "Int16" == Promenne.FindVar(hodnoty[i].Trim(), "type") || "Int32" == Promenne.FindVar(hodnoty[i].Trim(), "type") || "Int64" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("N�co se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if (Promenne.FindVar(hodnoty[i].Trim(), "value") != null)
                            {
                                moznostInt = int.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                int.TryParse(hodnoty[i].Trim(), out moznostInt);
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
                else
                {
                    switch (typVstupu)
                    {
                        case "Float":
                            vstupFloat = float.Parse(Promenne.FindVar(vstup.Trim(), "value"));
                            for (int i = 0; i < hodnoty.Count; i++)
                            {
                                if (float.TryParse(hodnoty[i], out moznostFloat) || "Float" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("N�co se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < hodnoty.Count; i++)
                                {
                                    if (Promenne.FindVar(hodnoty[i].Trim(), "type") != null)
                                    {
                                        moznostFloat = float.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                        if (vstupFloat == moznostFloat)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        float.TryParse(hodnoty[i].Trim(), out moznostFloat);
                                        if (vstupFloat == moznostFloat)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                
                            }
                            break;
                        case "Double":
                            vstupDouble = int.Parse(Promenne.FindVar(vstup.Trim(), "value"));
                            for (int i = 0; i < hodnoty.Count; i++)
                            {
                                if (double.TryParse(hodnoty[i], out moznostDouble) || "Double" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("N�co se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < hodnoty.Count; i++)
                                {
                                    if (Promenne.FindVar(hodnoty[i].Trim(), "type") != null)
                                    {
                                        moznostDouble = double.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                        if (vstupDouble == moznostDouble)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        double.TryParse(hodnoty[i].Trim(), out moznostDouble);
                                        if (vstupDouble == moznostDouble)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                
                            }
                            break;
                        case "Bool":
                            vstupBool = bool.Parse(Promenne.FindVar(vstup.Trim(), "value"));
                            for (int i = 0; i < hodnoty.Count; i++)
                            {
                                if (bool.TryParse(hodnoty[i], out moznostBool) || "Bool" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("N�co se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < hodnoty.Count; i++)
                                {
                                    if (Promenne.FindVar(hodnoty[i].Trim(), "type") != null)
                                    {
                                        moznostBool = bool.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                        if (vstupBool == moznostBool)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        bool.TryParse(hodnoty[i].Trim(), out moznostBool);
                                        if (vstupBool == moznostBool)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                
                            }
                            break;
                        case "Char":
                            vstupChar = char.Parse(Promenne.FindVar(vstup, "value"));
                            for (int i = 0; i < hodnoty.Count; i++)
                            {
                                if ((char.TryParse(hodnoty[i], out moznostChar) && hodnoty[i][0] == char.Parse("'") && hodnoty[i][hodnoty[i].Length - 1] == char.Parse("'")) || "Char" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("N�co se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < hodnoty.Count; i++)
                                {
                                    if (Promenne.FindVar(hodnoty[i], "type") != null)
                                    {
                                        moznostChar = char.Parse(Promenne.FindVar(hodnoty[i], "value"));
                                        if (vstupChar == moznostChar)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        moznostString = hodnoty[i].ToString();
                                        moznostString = Promenne.OverwriteChar(moznostString);
                                        char.TryParse(moznostString, out moznostChar);
                                        if (vstupChar == moznostChar)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                
                            }
                            break;
                        case "String":
                            vstupString = Promenne.FindVar(vstup, "value");
                            for (int i = 0; i < hodnoty.Count; i++)
                            {
                                if ((hodnoty[i][0] == '"' && hodnoty[i][hodnoty[i].Length - 1] == '"') || "String" == Promenne.FindVar(hodnoty[i], "type"))
                                    check = false;
                                else
                                    check = true;
                            }
                            if (check)
                                MessageBox.Show("N�co se nepovedlo!");
                            else
                            {
                                for (int i = 0; i < hodnoty.Count; i++)
                                {
                                    if (Promenne.FindVar(hodnoty[i], "type") != null)
                                    {
                                        moznostString = Promenne.FindVar(hodnoty[i], "value");
                                        if (vstupString == moznostString)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        moznostString = hodnoty[i];
                                        moznostString = Promenne.OverwriteString(moznostString);
                                        if (vstupString == moznostString)
                                        {
                                            console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                            break;
                                        }
                                    }
                                }
                                
                            }
                            break;
                        default:
                            MessageBox.Show("N�co se nepovedlo!");
                            break;
                    }
                }
            }
            else
            {
                if (int.TryParse(vstup.Trim(), out vstupInt))
                {
                    for (int i = 0; i < hodnoty.Count; i++)
                    {
                        if (int.TryParse(hodnoty[i], out moznostInt) || "Int16" == Promenne.FindVar(hodnoty[i].Trim(), "type") || "Int32" == Promenne.FindVar(hodnoty[i].Trim(), "type") || "Int64" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("N�co se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if (Promenne.FindVar(hodnoty[i].Trim(), "value") != null)
                            {
                                moznostInt = int.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                int.TryParse(hodnoty[i].Trim(), out moznostInt);
                                if (vstupInt == moznostInt)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
                else if (double.TryParse(vstup.Trim(), out vstupDouble))
                {
                    for (int i = 0; i < hodnoty.Count; i++)
                    {
                        if (double.TryParse(hodnoty[i], out moznostDouble) || "Double" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("N�co se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if (Promenne.FindVar(hodnoty[i].Trim(), "value") != null)
                            {
                                moznostDouble = double.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                if (vstupDouble == moznostDouble)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                double.TryParse(hodnoty[i].Trim(), out moznostDouble);
                                if (vstupDouble == moznostDouble)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
                else if (float.TryParse(vstup.Trim(), out vstupFloat))
                {
                    for (int i = 0; i < hodnoty.Count; i++)
                    {
                        if (float.TryParse(hodnoty[i], out moznostFloat) || "Float" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("N�co se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if (Promenne.FindVar(hodnoty[i].Trim(), "type") != null)
                            {
                                moznostFloat = float.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                if (vstupFloat == moznostFloat)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                float.TryParse(hodnoty[i].Trim(), out moznostFloat);
                                if (vstupFloat == moznostFloat)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
                else if (bool.TryParse(vstup.Trim(), out vstupBool))
                {
                    for (int i = 0; i < hodnoty.Count; i++)
                    {
                        if (bool.TryParse(hodnoty[i], out moznostBool) || "Bool" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
                            check = false;
                        else
                            check = true;
                    }
                    if (check)
                        MessageBox.Show("N�co se nepovedlo!");
                    else
                    {
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if (Promenne.FindVar(hodnoty[i].Trim(), "type") != null)
                            {
                                moznostBool = bool.Parse(Promenne.FindVar(hodnoty[i].Trim(), "value"));
                                if (vstupBool == moznostBool)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                bool.TryParse(hodnoty[i].Trim(), out moznostBool);
                                if (vstupBool == moznostBool)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
                else if (vstup[0] == char.Parse("'") && vstup[vstup.Length - 1] == char.Parse("'"))
                {
                    char.TryParse(Promenne.OverwriteChar(vstup), out vstupChar);
                    for (int i = 0; i < hodnoty.Count; i++)
                    {
                        if ((hodnoty[i][0] == char.Parse("'") && hodnoty[i][hodnoty[i].Length - 1] == char.Parse("'")) || "Char" == Promenne.FindVar(hodnoty[i].Trim(), "type"))
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
                        MessageBox.Show("N�co se nepovedlo!");
                    }
                    else
                    {
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if (Promenne.FindVar(hodnoty[i], "type") != null)
                            {
                                moznostChar = char.Parse(Promenne.FindVar(hodnoty[i], "value"));
                                if (vstupChar == moznostChar)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                            else
                            {
                                moznostString = hodnoty[i].ToString();
                                moznostChar = char.Parse(Promenne.OverwriteChar(moznostString));
                                if (vstupChar == moznostChar)
                                {
                                    console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
                else
                {
                    vstupString = vstup;
                    if (vstupString[0] == '"' && vstupString[vstupString.Length - 1] == '"')
                    {
                        vstupString = Promenne.OverwriteString(vstupString);
                        for (int i = 0; i < hodnoty.Count; i++)
                        {
                            if ((hodnoty[i][0] == '"' && hodnoty[i][hodnoty[i].Length - 1] == '"') || "String" == Promenne.FindVar(hodnoty[i], "type"))
                                check = false;
                            else
                                check = true;
                        }
                        if (check)
                            MessageBox.Show("N�co se nepovedlo!");
                        else
                        {
                            for (int i = 0; i < hodnoty.Count; i++)
                            {
                                if (Promenne.FindVar(hodnoty[i], "type") != null)
                                {
                                    moznostString = Promenne.FindVar(hodnoty[i], "value");
                                    if (vstupString == moznostString)
                                    {
                                        console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                        break;
                                    }
                                }
                                else
                                {
                                    moznostString = hodnoty[i];
                                    moznostString = Promenne.OverwriteString(moznostString);
                                    if (vstupString == moznostString)
                                    {
                                        console.Text += "\r\n" + ">" + "trueee v casu �." + (i + 1) + "\r\n";
                                        break;
                                    }
                                }
                            }
                            
                        }
                    }
                    else
                        MessageBox.Show("N�co se nepovedlo!");
                }
            }
        }
        }
}
