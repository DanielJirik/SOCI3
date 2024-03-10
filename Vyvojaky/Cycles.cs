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
        public static string part1, part2, Oper;
        public Cycles() 
        { 
            
        }

        public void Setup(Panel _pracpanel)
        {
            Pracovni = _pracpanel;
        }

        public static bool CheckFor(string nazev, string pocatek, string konec, string inkrement) 
        {
            if (!nazev.Contains("'") && !nazev.Contains('"') && !int.TryParse(nazev, out int var) && !double.TryParse(nazev, out double var0) && !float.TryParse(nazev, out float var1) && int.TryParse(pocatek, out int var2) && int.TryParse(konec, out int var3) && int.TryParse(inkrement, out int var4)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void pocitani(Panel main, TextBox console, Switches switches)
        {
            
            List<Control> blocks = new List<Control>();
            foreach (BlockSwitches item in main.Controls)
            {
                if (item is BlockSwitches)
                {
                    switches.Kontrola(console, item.vstup, item.hodnoty, false);
                }
            }
        }

        public static void CyclesFor(string nazev, int pocatek, int konec, int inkrement, int startIndex, int endIndex) 
        {
            if (pocatek < konec && inkrement > 0 && Promenne.FindVar(nazev, "type") == null)
            {
                Promenne.Int64V.Add(nazev, pocatek);
                for (int i = pocatek; i <= konec; i += inkrement)
                {
                    Promenne.Int64V[nazev] = i;
                    SequenceController.PartSequence(startIndex, endIndex);
                }
                Promenne.Int64V.Remove(nazev);
            }
            else if(pocatek < konec && inkrement < 0 && Promenne.FindVar(nazev, "type") == null)
            {
                Promenne.Int64V.Add(nazev, pocatek);
                for (int i = pocatek; i <= konec; i += inkrement)
                {
                    Promenne.Int64V[nazev] = i;
                    SequenceController.PartSequence(startIndex, endIndex);
                    break;
                }
                Promenne.Int64V.Remove(nazev);
            }
            else if (pocatek > konec && inkrement < 0 && Promenne.FindVar(nazev, "type") == null)
            {
                Promenne.Int64V.Add(nazev, pocatek);
                for (int i = pocatek; i >= konec; i += inkrement)
                {
                    Promenne.Int64V[nazev] = i;
                    SequenceController.PartSequence(startIndex, endIndex);
                }
                Promenne.Int64V.Remove(nazev);
            }
            else if (pocatek > konec && inkrement > 0 && Promenne.FindVar(nazev, "type") == null)
            {
                Promenne.Int64V.Add(nazev, pocatek);
                for (int i = pocatek; i >= konec; i += inkrement)
                {
                    Promenne.Int64V[nazev] = i;
                    SequenceController.PartSequence(startIndex, endIndex);
                    break;
                }
                Promenne.Int64V.Remove(nazev);
            }
            else
            {
                MessageBox.Show("Něco se nepovedlo!");
            }
        }

        public static void CreationOfCycleFor(string nazev, string pocatek, string konec, string inkrement) 
        {
            Block.BlockCycleFor(nazev, pocatek, konec, inkrement);
        }

        public static void CreationOfCycleWhile(string condition)
        {
            string par1, par2, oper;
            (par1, par2, oper) = Separation(condition);
            if (par1 != "" && par2 != "" && oper != "")
            {
                string cond = $"({par1} {oper} {par2})";
                Block.BlockCycleWhileOrDoWhile(cond, "While");
            }
            else
            {
                MessageBox.Show("Něco se nepovedlo!");
            }
            
        }

        public static void CreationOfCycleDoWhile(string condition)
        {
            string par1, par2, oper;
            (par1, par2, oper) = Separation(condition);
            if (par1 != "" && par2 != "" && oper != "")
            {
                string cond = $"({par1} {oper} {par2})";
                Block.BlockCycleWhileOrDoWhile(cond, "DoWhile");
            }
            else
            {
                MessageBox.Show("Něco se nepovedlo!");
            }
        }

        public static void WhileDouble(double par1, double par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    while (par1 == par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex); 
                    }
                    break;
                case "!=":
                    while (par1 != par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case ">":
                    while (par1 > par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case "<":
                    while (par1 < par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case ">=":
                    while (par1 >= par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case "<=":
                    while (par1 <= par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void WhileBool(bool par1, bool par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    while (par1 == par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case "!=":
                    while (par1 != par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void WhileChar(char par1, char par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    while (par1 == par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case "!=":
                    while (par1 != par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void WhileString(string par1, string par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    while (par1 == par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                case "!=":
                    while (par1 != par2)
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void DoWhileDouble(double par1, double par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 == par2);
                    break;
                case "!=":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 != par2);
                    break;
                case ">":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 > par2);
                    break;
                case "<":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 < par2);
                    break;
                case ">=":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 >= par2);
                    break;
                case "<=":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 <= par2);
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void DoWhileBool(bool par1, bool par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 == par2);
                    break;
                case "!=":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 != par2);
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void DoWhileChar(char par1, char par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 == par2);
                    break;
                case "!=":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 != par2);
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void DoWhileString(string par1, string par2, string oper, int startIndex, int endIndex)
        {
            switch (oper)
            {
                case "==":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 == par2);
                    break;
                case "!=":
                    do
                    {
                        SequenceController.PartSequence(startIndex, endIndex);
                    }
                    while (par1 != par2);
                    break;
                default:
                    MessageBox.Show("Něco se nepovedlo!");
                    break;
            }
        }

        public static void CycleWhileAndDoWhile(string type, int startIndex, int endIndex)
        {
            if (Promenne.FindVar(part1, "type") != null)
            {
                if (Promenne.FindVar(part2, "type") != null)
                {
                    if ((Promenne.FindVar(part1, "type") == "Int16" || Promenne.FindVar(part1, "type") == "Int32" || Promenne.FindVar(part1, "type") == "Int64" || Promenne.FindVar(part1, "type") == "Double" || Promenne.FindVar(part1, "type") == "Float") && (Promenne.FindVar(part2, "type") == "Int16" || Promenne.FindVar(part2, "type") == "Int32" || Promenne.FindVar(part2, "type") == "Int64" || Promenne.FindVar(part2, "type") == "Double" || Promenne.FindVar(part2, "type") == "Float"))
                    {
                        if (type == "While")
                            WhileDouble(double.Parse(Promenne.FindVar(part1, "value")), double.Parse(Promenne.FindVar(part2, "value")), Oper, startIndex, endIndex);
                        else
                            DoWhileDouble(double.Parse(Promenne.FindVar(part1, "value")), double.Parse(Promenne.FindVar(part2, "value")), Oper, startIndex, endIndex);
                    }
                    else if (Promenne.FindVar(part1, "type") == "Bool" && Promenne.FindVar(part2, "type") == "Bool")
                    {
                        if (type == "While")
                            WhileBool(bool.Parse(Promenne.FindVar(part1, "value")), bool.Parse(Promenne.FindVar(part2, "value")), Oper, startIndex, endIndex);
                        else
                            DoWhileBool(bool.Parse(Promenne.FindVar(part1, "value")), bool.Parse(Promenne.FindVar(part2, "value")), Oper, startIndex, endIndex);
                    }
                    else if (Promenne.FindVar(part1, "type") == "Char" && Promenne.FindVar(part2, "type") == "Char")
                    {
                        if (type == "While")
                            WhileChar(char.Parse(Promenne.FindVar(part1, "value")), char.Parse(Promenne.FindVar(part2, "value")), Oper, startIndex, endIndex);
                        else
                            DoWhileChar(char.Parse(Promenne.FindVar(part1, "value")), char.Parse(Promenne.FindVar(part2, "value")), Oper, startIndex, endIndex);
                    }
                    else
                    {
                        if (type == "While")
                            WhileString(Promenne.FindVar(part1, "value"), Promenne.FindVar(part2, "value"), Oper, startIndex, endIndex);
                        else
                            DoWhileString(Promenne.FindVar(part1, "value"), Promenne.FindVar(part2, "value"), Oper, startIndex, endIndex);
                    }
                }
                else
                {
                    if ((Promenne.FindVar(part1, "type") == "Int16" || Promenne.FindVar(part1, "type") == "Int32" || Promenne.FindVar(part1, "type") == "Int64" || Promenne.FindVar(part1, "type") == "Double" || Promenne.FindVar(part1, "type") == "Float") && double.TryParse(part2, out double var))
                    {
                        if (type == "While")
                            WhileDouble(double.Parse(Promenne.FindVar(part1, "value")), var, Oper, startIndex, endIndex);
                        else
                            DoWhileDouble(double.Parse(Promenne.FindVar(part1, "value")), var, Oper, startIndex, endIndex);
                    }
                    else if (Promenne.FindVar(part1, "type") == "Bool" && bool.TryParse(part2, out bool var0))
                    {
                        if (type == "While")
                            WhileBool(bool.Parse(Promenne.FindVar(part1, "value")), var0, Oper, startIndex, endIndex);
                        else
                            DoWhileBool(bool.Parse(Promenne.FindVar(part1, "value")), var0, Oper, startIndex, endIndex);
                    }
                    else if (Promenne.FindVar(part1, "type") == "Char" && part2[0] == char.Parse("'") && part2[part2.Length - 1] == char.Parse("'"))
                    {
                        if (type == "While")
                            WhileChar(char.Parse(Promenne.FindVar(part1, "value")), char.Parse(Promenne.OverwriteChar(part2)), Oper, startIndex, endIndex);
                        else
                            DoWhileChar(char.Parse(Promenne.FindVar(part1, "value")), char.Parse(Promenne.OverwriteChar(part2)), Oper, startIndex, endIndex);
                    }
                    else if (Promenne.FindVar(part1, "type") == "String" && part2[0] == '"' && part2[part2.Length - 1] == '"')
                    {
                        if (type == "While")
                            WhileString(Promenne.FindVar(part1, "value"), Promenne.OverwriteString(part2), Oper, startIndex, endIndex);
                        else
                            DoWhileString(Promenne.FindVar(part1, "value"), Promenne.OverwriteChar(part2), Oper, startIndex, endIndex);
                    }
                }
            }
            else if (Promenne.FindVar(part2, "type") != null)
            {
                if ((Promenne.FindVar(part2, "type") == "Int16" || Promenne.FindVar(part2, "type") == "Int32" || Promenne.FindVar(part2, "type") == "Int64" || Promenne.FindVar(part2, "type") == "Double" || Promenne.FindVar(part2, "type") == "Float") && double.TryParse(part1, out double var))
                {
                    if (type == "While")
                        WhileDouble(double.Parse(Promenne.FindVar(part2, "value")), var, Oper, startIndex, endIndex);
                    else
                        DoWhileDouble(double.Parse(Promenne.FindVar(part2, "value")), var, Oper, startIndex, endIndex);
                }
                else if (Promenne.FindVar(part2, "type") == "Bool" && bool.TryParse(part1, out bool var0))
                {
                    if (type == "While")
                        WhileBool(bool.Parse(Promenne.FindVar(part2, "value")), var0, Oper, startIndex, endIndex);
                    else
                        DoWhileBool(bool.Parse(Promenne.FindVar(part2, "value")), var0, Oper, startIndex, endIndex);
                }
                else if (Promenne.FindVar(part2, "type") == "Char" && part1[0] == char.Parse("'") && part1[part1.Length - 1] == char.Parse("'"))
                {
                    if (type == "While")
                        WhileChar(char.Parse(Promenne.FindVar(part2, "value")), char.Parse(Promenne.OverwriteChar(part1)), Oper, startIndex, endIndex);
                    else
                        DoWhileChar(char.Parse(Promenne.FindVar(part2, "value")), char.Parse(Promenne.OverwriteChar(part1)), Oper, startIndex, endIndex);
                }
                else if (Promenne.FindVar(part2, "type") == "String" && part1[0] == '"' && part1[part1.Length - 1] == '"')
                {
                    if (type == "While")
                        WhileString(Promenne.FindVar(part2, "value"), Promenne.OverwriteString(part1), Oper, startIndex, endIndex);
                    else
                        DoWhileString(Promenne.FindVar(part2, "value"), Promenne.OverwriteString(part1), Oper, startIndex, endIndex);
                }
            }
            else
            {
                
                if (double.TryParse(part1, out double par1) && double.TryParse(part2, out double par2))
                {

                    if (type == "While")
                        WhileDouble(par1, par2, Oper, startIndex, endIndex);
                    else
                        DoWhileDouble(par1, par2, Oper, startIndex, endIndex);
                }
                else if (bool.TryParse(part1, out bool par1_b) && bool.TryParse(part2, out bool par2_b))
                {
                    if (type == "While")
                        WhileBool(par1_b, par2_b, Oper, startIndex, endIndex);
                    else
                        DoWhileBool(par1_b, par2_b, Oper, startIndex, endIndex);
                }
                else if (part1[0] == char.Parse("'") && part1[part1.Length - 1] == char.Parse("'") && part2[0] == char.Parse("'") && part2[part2.Length - 1] == char.Parse("'"))
                {
                    if (type == "While")
                        WhileChar(char.Parse(Promenne.OverwriteChar(part1)), char.Parse(Promenne.OverwriteChar(part2)), Oper, startIndex, endIndex);
                    else
                        DoWhileChar(char.Parse(Promenne.OverwriteChar(part1)), char.Parse(Promenne.OverwriteChar(part2)), Oper, startIndex, endIndex);
                }
                else if (part1[0] == '"' && part1[part1.Length - 1] == '"' && part2[0] == '"' && part2[part2.Length - 1] == '"')
                {
                    if (type == "While")
                        WhileString(Promenne.OverwriteChar(part1), Promenne.OverwriteChar(part2), Oper, startIndex, endIndex);
                    else
                        DoWhileString(Promenne.OverwriteChar(part1), Promenne.OverwriteChar(part2), Oper, startIndex, endIndex);
                }
            }
        }

        public static (string, string, string) Separation(string condition)
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
            par1 = par1.Trim();
            par2 = par2.Trim();
            oper = oper.Trim();
            return (par1, par2, oper);
        }
        public static bool CheckWhileAndDoWhile(string condition)
        {

            string par1, par2, oper;
            (par1, par2, oper) = Separation(condition);
            if (oper == "" || oper == "=")
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
                            if (oper != "==" && oper != "!=" && oper != ">" && oper != "<" && oper != ">=" && oper != "<=")
                            {
                                return false;
                            }
                        }
                        else if ((Promenne.FindVar(par1, "type") == "Bool" && Promenne.FindVar(par2, "type") == "Bool") || (Promenne.FindVar(par1, "type") == "Char" && Promenne.FindVar(par2, "type") == "Char") || (Promenne.FindVar(par1, "type") == "String" && Promenne.FindVar(par2, "type") == "String"))
                        {
                            if (oper != "==" && oper != "!=")
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
                        if (oper != ">" && oper != "<" && oper != ">=" && oper != "<=" && oper != "==" && oper != "!=")
                        {
                            return false;
                        }
                    }
                    else if (bool.TryParse(par1, out bool var6) && bool.TryParse(par2, out bool var7))
                    {
                        if (oper != "==" && oper != "!=")
                        {
                            return false;
                        }
                    }
                    else if ((par1[0].ToString() == "'" && par1[par1.Length - 1].ToString() == "'") && (par2[0].ToString() == "'" && par2[par2.Length - 1].ToString() == "'"))
                    {
                        if (oper != "==" && oper != "!=")
                        {
                            return false;
                        }
                    }
                    else if ((par1[0] == '"' && par1[par1.Length - 1] == '"') && (par2[0] == '"' && par2[par2.Length - 1] == '"'))
                    {
                        
                        if (oper != "==" && oper != "!=")
                        {   
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            part1 = par1;
            part2 = par2;
            Oper = oper;
            return true;
        }

        public static bool UnknownValues(string a, string b, string op)
        {
            if (Promenne.FindVar(a, "type") == "Int16" || Promenne.FindVar(a, "type") == "Int32" || Promenne.FindVar(a, "type") == "Int64" || Promenne.FindVar(a, "type") == "Float" || Promenne.FindVar(a, "type") == "Double")
            {
                if (!int.TryParse(b, out int var0) && !float.TryParse(b, out float var1) && !double.TryParse(b, out double var2))
                {
                    return false;
                }
                else
                {
                    if (op != "==" && op != "!=" && op != ">" && op != "<" && op != ">=" && op != "<=")
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
                    if (op != "==" && op != "!=")
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
                    if (op != "==" && op != "!=")
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
                    if (op != "==" && op != "!=")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
