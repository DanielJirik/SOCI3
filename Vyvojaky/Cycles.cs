using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Cycles
    {

        Panel Pracovni;
        List<string> partsOfConditions = new List<string>();
        public Cycles() 
        { 
            
        }

        public void Setup(Panel _pracpanel)
        {
            Pracovni = _pracpanel;
        }

        public bool CheckFor(string nazev, string pocatek, string konec, string inkrement) 
        {
            if (Promenne.KontrolaNazvu(nazev) && !nazev.Contains("'") && !nazev.Contains('"') && !int.TryParse(nazev, out int var) && !double.TryParse(nazev, out double var0) && !float.TryParse(nazev, out float var1) && int.TryParse(pocatek, out int var2) && int.TryParse(konec, out int var3) && int.TryParse(inkrement, out int var4)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CyclesFor(int pocatek, int konec, int inkrement) 
        {
            if (pocatek < konec && inkrement > 0)
            {
                for (int i = pocatek; i <= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                }
            }
            else if(pocatek < konec && inkrement < 0)
            {
                for (int i = pocatek; i <= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                    break;
                }
            }
            else if (pocatek > konec && inkrement < 0)
            {
                for (int i = pocatek; i >= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                }
            }
            else if (pocatek > konec && inkrement > 0)
            {
                for (int i = pocatek; i >= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                    break;
                }
            }
            else
            {
                MessageBox.Show("Něco se nepovedlo!");
            }
        }

        public void CreationOfCycleFor(string nazev, string pocatek, string konec, string inkrement) 
        {
            Block block = new Block(Pracovni);
            block.BlockCycleFor(nazev, pocatek, konec, inkrement);
        }

        public bool CheckWhileAndDoWhile(string condition)
        {
            string par1 = "";
            string par2 = "";
            string oper = "";
            bool request = false;
            for (int i = 0; i < condition.Length; i++)
            {
                if (condition[i].ToString() == "<" || condition[i].ToString() == ">" || condition[i].ToString() == "=" || condition[i].ToString() == "!")
                {
                    oper += condition[i].ToString();
                    if (condition[i + 1].ToString() != "=")
                    {
                        request = true;
                    }                    
                }
                else
                {
                    if (!request)
                    {
                        par1 += condition[i].ToString();
                    }
                    else
                    {
                        par2 += condition[i].ToString();
                    }
                }
            }
            Debug.WriteLine("par1: " + par1);
            Debug.WriteLine("par2: " + par2);
            Debug.WriteLine("operand: " + oper);


            if (oper == "")
            {
                return false;
            }
            else
            {
                if (Promenne.FindVar(par1, "type") != null)
                {
                    if (Promenne.FindVar(par2, "type") != null)
                    {
                        if ((Promenne.FindVar(par1, "type") == "Int16" || Promenne.FindVar(par1, "type") == "Int32" || Promenne.FindVar(par1, "type") == "Int64" || Promenne.FindVar(par1, "type") == "Float" || Promenne.FindVar(par1, "type") == "Double") && (Promenne.FindVar(par2, "type") == "Int16" || Promenne.FindVar(par2, "type") == "Int32" || Promenne.FindVar(par2, "type") == "Int64" || Promenne.FindVar(par2, "type") == "Float" || Promenne.FindVar(par2, "type") == "Double"))
                        {
                            if (oper != "==" || oper != "!=" || oper != ">" || oper != "<" || oper != ">=" || oper != "<=")
                            {
                                return false;
                            }
                        }
                        else if ((Promenne.FindVar(par1, "type") == "Bool" && Promenne.FindVar(par2, "type") == "Bool") || (Promenne.FindVar(par1, "type") == "Char" && Promenne.FindVar(par2, "type") == "Char") || (Promenne.FindVar(par1, "type") == "String" && Promenne.FindVar(par2, "type") == "String"))
                        {
                            if (oper != "==" || oper != "!=")
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return UnknownValues(par1, par2, oper);
                    }
                }
                else if (Promenne.FindVar(par2, "type") != null)
                {
                    return UnknownValues(par2, par1, oper);
                }
                else
                {
                    if ((int.TryParse(par1, out int var0) || double.TryParse(par1, out double var1) || float.TryParse(par1, out float var2)) && (int.TryParse(par2, out int var3) || double.TryParse(par2, out double var4) || float.TryParse(par2, out float var5)))
                    {
                        if (oper != ">" || oper != "<" || oper != ">=" || oper != "<=" || oper != "==" || oper != "!=")
                        {
                            return false;
                        }
                    }
                    else if (bool.TryParse(par1, out bool var6) && bool.TryParse(par2, out bool var7))
                    {
                        if (oper != "==" || oper != "!=")
                        {
                            return false;
                        }
                    }
                    else if ((par1[0].ToString() == "'" && par1[par1.Length - 1].ToString() == "'") && (par2[0].ToString() == "'" && par2[par2.Length - 1].ToString() == "'"))
                    {
                        if (oper != "==" || oper != "!=")
                        {
                            return false;
                        }
                    }
                    else if ((par1[0] == '"' && par1[par1.Length - 1] == '"') && (par2[0] == '"' && par2[par2.Length - 1] == '"'))
                    {
                        
                        if (oper != "==" && oper != "!=")
                        {   
                            Debug.WriteLine("Uvozovky OK");
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool UnknownValues(string a, string b, string op)
        {
            if (Promenne.FindVar(a, "type") == "Int16" || Promenne.FindVar(a, "type") == "Int32" || Promenne.FindVar(a, "type") == "Int64" || Promenne.FindVar(a, "type") == "Float" || Promenne.FindVar(a, "type") == "Double")
            {
                if (!int.TryParse(b, out int var0) || !float.TryParse(b, out float var1) || !double.TryParse(b, out double var2))
                {
                    return false;
                }
                else
                {
                    if (op != "==" || op != "!=" || op != ">" || op != "<" || op != ">=" || op != "<=")
                    {
                        return false;
                    }
                }
            }
            else if (Promenne.FindVar(a, "type") == "Bool")
            {
                if (!bool.TryParse(b, out bool var3))
                {
                    return false;
                }
                else
                {
                    if (op != "==" || op != "!=")
                    {
                        return false;
                    }
                }
            }
            else if (Promenne.FindVar(a, "type") == "Char")
            {
                if (!(b[0] == char.Parse("'") && b[b.Length - 1] == char.Parse("'")))
                {
                    return false;
                }
                else
                {
                    if (op != "==" || op != "!=")
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (!(b[0] == '"' && b[b.Length - 1] == '"'))
                {
                    return false;
                }
                else
                {
                    if (op != "==" || op != "!=")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
