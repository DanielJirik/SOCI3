using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Vyvojaky.Promenne;

namespace Vyvojaky
{
    internal class Process
    {
        public Process() 
        { 
            
        }

        public void Processing(string input, bool creation)
        {
            CommandCheck(input, creation);
        }

        public static string Operater(string input) 
        {   
            string operater = "";
            string prom = "";
            for (int i = 0; i < input.Length; i++)
            {   
                if (input[i].ToString() == "+")
                {
                    if (input[i + 1].ToString() == "=")
                    {
                        operater = "+=";
                    }
                }
                else if (input[i].ToString() == "=")
                {
                    operater = "=";
                }
            }
            return operater;
        }



        public enum Type
        {
            Int,
            Float,
            Double,
            String
        }

        public static void CommandCheck(string prikaz, bool creation)
        {
            string nazevPromenne = "";
            string hodnotaPromenne = "";
            bool legitPrikaz = false;

            if (prikaz != "")
            {
                    try
                    {
                        Regex.Replace(prikaz, @"\s+", "");

                        nazevPromenne = prikaz.Split("=")[0].Trim();
                        hodnotaPromenne = prikaz.Split("=")[1].Trim();

                        legitPrikaz = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Něco je špatně.");
                    }

                    if (legitPrikaz)
                    {
                        
                        VytvoritPromennou(nazevPromenne, hodnotaPromenne, Operater(prikaz), creation);

                        if (Promenne.isValid)
                        {
                            //Prida nazev do pouzitych nazvu
                            Promenne.usedNames.Add(nazevPromenne);

                            //lvPromenne.Items.Add(nazevPromenne + " = " + Promenne.hodnota);
                        }

                        typ = "";
                    }
                
            }
        }


        //Metoda na třídění výrazu
        public static List<string> SplitCommand(string command)
        {
            List<string> seq = new List<string>();

            string arg = "";
            for (int i = 0; i < command.Length; i++)
            {
                char c = command[i];
                if ((c == '+' || c == '-' || c == '*' || c == '/') && arg != "")
                {
                    seq.Add(arg.Trim());
                    seq.Add(c.ToString());
                    arg = "";
                }
                else if (c == '(' || c == ')' || c == '[' || c == ']' || c == '{' || c == '}')
                {
                    seq.Add(arg.Trim());
                    arg = "";
                    seq.Add(c.ToString());
                }
                else
                    arg += c;

            }
            seq.Add(arg.Trim());
            seq.RemoveAll(s => string.IsNullOrEmpty(s));
            return seq;
        }

        //Validity of brackets
        static bool BalancedBrackets(List<string> seq)
        {
            Vector2 b1 = new Vector2(0, 0);
            Vector2 b2 = new Vector2(0, 0);
            Vector2 b3 = new Vector2(0, 0);

            foreach (string x in seq)
            {
                switch (x)
                {
                    case "(":
                        b1.X++;
                        break;
                    case "[":
                        b2.X++;
                        break;
                    case "{":
                        b3.X++;
                        break;
                    case ")":
                        b1.Y++;
                        break;
                    case "]":
                        b2.Y++;
                        break;
                    case "}":
                        b3.Y++;
                        break;
                    default:
                        break;
                }
            }

            return ((b1.X == b1.Y && b2.X == b2.Y && b3.X == b3.Y));
        }


        //Metoda na zjednodušení tříděného výrazu
        static List<string>? SimplifySequence(List<string> s)
        {

            List<string> _sequence = new List<string>();
            List<int> openedIndexes = new List<int>();
            List<int> closedIndexes = new List<int>();

            //Checking if valid
            if (!BalancedBrackets(s)) return null;

            void CountIndexes(List<string> s)
            {
                openedIndexes.Clear();
                closedIndexes.Clear();

                //Counting indexes of brackets
                for (int i = 0; i < s.Count; i++)
                {
                    if (s[i] == "(" || s[i] == "[" || s[i] == "{")
                        openedIndexes.Add(i);
                    else if (s[i] == ")" || s[i] == "]" || s[i] == "}")
                        closedIndexes.Add(i);
                }
            }

            CountIndexes(s);

            //Level of nesting
            int iterations = openedIndexes.Count();

            //Solving individual brackets
            for (int i = 0; i < iterations; i++)
            {
                _sequence.Clear();

                int endIndex = 0;
                int checkCount = 0;

                if (openedIndexes.Count > 0 && closedIndexes.Count > 0)
                {
                    for (int j = openedIndexes[openedIndexes.Count - 1]; j <= closedIndexes[0]; j++)
                    {
                        if (s[j] == "(" || s[j] == ")" || s[j] == "[" || s[j] == "]" || s[j] == "{" || s[j] == "}")
                            checkCount++;
                    }

                    if (checkCount % 2 != 0)
                        endIndex = closedIndexes[closedIndexes.Count - 1];
                    else
                        endIndex = closedIndexes[0];
                }

                if ((openedIndexes.Count > 1 && closedIndexes.Count > 1) && (closedIndexes[0] > openedIndexes[0] && closedIndexes[0] < openedIndexes[1]))
                    endIndex = closedIndexes[closedIndexes.Count - 1];

                for (int j = openedIndexes[openedIndexes.Count - 1] + 1; j < endIndex; j++)
                {
                    _sequence.Add(s[j]);
                }

                string temp = SolveSequence(_sequence);

                for (int j = endIndex; j > openedIndexes[openedIndexes.Count - 1] - 1; j--)
                {
                    s.RemoveAt(j);
                }

                s.Insert(openedIndexes[openedIndexes.Count - 1], temp);

                CountIndexes(s);
            }

            return s;
        }

        //Metoda na řešení výrazu
        public static string? SolveSequence(List<string> s)
        {
            int value = 0;
            float valueF = 0.0f;
            double valueD = 0.0;

            string output = "";

            Type type = Type.Int;
            try
            {
                if (FindVar(s[0], "value") == null)
                {
                    if (float.TryParse(s[0], out valueF))
                        type = Type.Float;
                    else if (double.TryParse(s[0], out valueD))
                        type = Type.Double;
                    else if (int.TryParse(s[0], out value))
                        type = Type.Int;
                }
                else
                {
                    if (float.TryParse(FindVar(s[0], "value"), out valueF))
                        type = Type.Float;
                    else if (double.TryParse(FindVar(s[0], "value"), out valueD))
                        type = Type.Double;
                    else if (int.TryParse(FindVar(s[0], "value"), out value))
                        type = Type.Int;
                }

                string opr = "";
                int turn = 0; // 0 - turn operatora

                for (int i = 1; i < s.Count; i++)
                {
                    if (turn % 2 == 0)
                    {
                        opr = s[i];
                        turn++;
                    }
                    else
                    {
                        string arg = "";

                        if (FindVar(s[i], "value") == null)
                            arg = s[i];
                        else
                            arg = FindVar(s[i], "value");

                        switch (opr)
                        {
                            case "+":
                                if (type == Type.Int)
                                    value += int.Parse(arg);
                                else if (type == Type.Double)
                                    valueD += double.Parse(arg);
                                else if (type == Type.Float)
                                    valueF += float.Parse(arg);
                                break;
                            case "-":
                                if (type == Type.Int)
                                    value -= int.Parse(arg);
                                else if (type == Type.Double)
                                    valueD -= double.Parse(arg);
                                else if (type == Type.Float)
                                    valueF -= float.Parse(arg);
                                break;
                            case "*":
                                if (type == Type.Int)
                                    value *= int.Parse(arg);
                                else if (type == Type.Double)
                                    valueD *= double.Parse(arg);
                                else if (type == Type.Float)
                                    valueF *= float.Parse(arg);
                                break;
                            case "/":
                                if (type == Type.Int)
                                    value /= int.Parse(arg);
                                else if (type == Type.Double)
                                    valueD /= double.Parse(arg);
                                else if (type == Type.Float)
                                    valueF /= float.Parse(arg);
                                break;
                            default:
                                break;
                        }
                        turn++;
                    }
                }

                switch (type)
                {
                    case Type.Int:
                        output = value.ToString();
                        break;
                    case Type.Float:
                        output = valueF.ToString();
                        break;
                    case Type.Double:
                        output = valueD.ToString();
                        break;
                    default:
                        break;
                }
                return output;
            }
            catch
            {
                return null;
            }
        }


        public static bool isValid;
        public static string hodnota = "";

        public static void VytvoritPromennou(string nazev, string _hodnota, string operater, bool creation)
        {
            isValid = true;
            hodnota = _hodnota;

            Int16 a;
            Int32 b;
            Int64 c;
            float d;
            double e;
            bool f;
            int result;

            List<string> sequence = new List<string>();

            string temp = "";
            bool hasBrackets = hodnota.Contains("(") || hodnota.Contains("[") || hodnota.Contains("{");
            if (Promenne.FindVar(nazev, "type") != null)
            {
                if (!hasBrackets && (temp = SumString(hodnota)) != null && int.TryParse(temp, out result) == false)
                {
                    hodnota = temp;
                    if (operater == "+=")
                    {
                        StringV[nazev] += hodnota;
                    }
                    else if (operater == "=")
                    {
                        StringV[nazev] = hodnota;
                    }
                    else
                    {
                        MessageBox.Show("Něco je špatně");
                    }

                    if (creation)
                    {
                        CreateBlock(nazev, hodnota);
                    }
                    
                    return;
                }
                else if (CheckIfChar(hodnota))
                {
                    hodnota = OverwriteChar(hodnota);
                    
                    if (operater == "+=")
                    {
                        CharV[nazev] += char.Parse(hodnota);
                    }
                    else if (operater == "=")
                    {
                        CharV[nazev] = char.Parse(hodnota);
                    }
                    else
                    {
                        MessageBox.Show("Něco je špatně");
                    }

                    if (creation)
                    {
                        CreateBlock(nazev, hodnota);
                    }
                    return;
                }
                else
                {
                    //Třídění výrazu "hodnota"
                    sequence = SplitCommand(hodnota);
                    sequence = (sequence.Contains("(") || sequence.Contains("[") || sequence.Contains("{")) ? SimplifySequence(sequence) : sequence;
                    //if (sequence.Contains("(") || sequence.Contains("[") || sequence.Contains("{")) { sequence = SimplifySequence(sequence); }

                    //Řešení
                    hodnota = SolveSequence(sequence);

                    if (Promenne.FindVar(nazev, "type") == "Int16" && Int16.TryParse(hodnota, out a))
                    {
                        if (operater == "+=")
                        {
                            Int16V[nazev] += a;
                        }
                        else if (operater == "=")
                        {
                            Int16V[nazev] = a;
                        }
                        else
                        {
                            MessageBox.Show("Něco je špatně");
                        }

                        if (creation)
                        {
                            CreateBlock(nazev, hodnota);
                        }
                    }
                    else if (Promenne.FindVar(nazev, "type") == "Int32" && Int32.TryParse(hodnota, out b))
                    {
                        if (operater == "+=")
                        {
                            Int32V[nazev] += b;
                        }
                        else if (operater == "=")
                        {
                            Int32V[nazev] = b;
                        }
                        else
                        {
                            MessageBox.Show("Něco je špatně");
                        }

                        if (creation)
                        {
                            CreateBlock(nazev, hodnota);
                        }
                        
                    }
                    else if (Promenne.FindVar(nazev, "type") == "Int64" && Int64.TryParse(hodnota, out c))
                    {
                        if (operater == "+=")
                        {
                            Int64V[nazev] += c;
                        }
                        else if (operater == "=")
                        {
                            Int64V[nazev] = c;
                        }
                        else
                        {
                            MessageBox.Show("Něco je špatně");
                        }

                        if (creation)
                        {
                            CreateBlock(nazev, hodnota);
                        }
                        
                    }
                    else if (float.TryParse(hodnota, out d))
                    {
                        if (operater == "+=")
                        {
                            FloatV[nazev] += d;
                        }
                        else if (operater == "=")
                        {
                            FloatV[nazev] = d;
                        }
                        else
                        {
                            MessageBox.Show("Něco je špatně");
                        }

                        if (creation)
                        {
                            CreateBlock(nazev, hodnota);
                        }
                    }
                    else if (double.TryParse(hodnota, out e))
                    {
                        if (operater == "+=")
                        {
                            DoubleV[nazev] += e;
                        }
                        else if (operater == "=")
                        {
                            DoubleV[nazev] = e;
                        }
                        else
                        {
                            MessageBox.Show("Něco je špatně");
                        }

                        if (creation)
                        {
                            CreateBlock(nazev, hodnota);
                        }

                    }
                    else if (bool.TryParse(hodnota, out f))
                    {
                        if (operater == "=")
                        {
                            BoolV[nazev] = f;
                        }
                        else
                        {
                            MessageBox.Show("Něco je špatně");
                        }

                        if (creation)
                        {
                            CreateBlock(nazev, hodnota);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Něco je špatně");
                    }
                }
            }
            else
            {
                MessageBox.Show("Něco je špatně");
            }
            
        }

        private static void CreateBlock(string nazev, string hodnota)
        {
            //BLOCK
            Block.BlockVar(typ, nazev, hodnota);
        }

        //

        //OverwriteString
        public static string OverwriteString(string _string)
        {
            return Regex.Replace(_string, '"'.ToString(), "");
        }

        //OverwriteChar
        public static string OverwriteChar(string _char)
        {
            return Regex.Replace(_char, "'", "");
        }


        //Summs strings
        public static string? SumString(string hodnota)
        {
            try
            {
                string value = "";
                bool isString = false;

                List<string> s = new List<string>();
                s = SplitCommand(hodnota);

                for (int i = 0; i <= s.Count - 1; i++)
                {
                    if (s[i][0] == '"' && s[i][s[i].Length - 1] == '"')
                    {
                        value += OverwriteString(s[i]);
                        isString = true;
                    }
                    else if (FindVar(s[i], "value") != null)
                    {
                        value += FindVar(s[i], "value");
                        isString = true;
                    }
                }

                if (isString)
                    return value;
            }
            catch { }

            return null;
        }

        //Checking chars
        public static bool CheckIfChar(string hodnota)
        {
            if (hodnota[0] == Convert.ToChar("'") && hodnota[hodnota.Length - 1] == Convert.ToChar("'") && hodnota.Length == 3)
                return true;
            return false;
        }
    }
}
