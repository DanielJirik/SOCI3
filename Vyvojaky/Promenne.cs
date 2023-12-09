using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Promenne
    {
        //int16, int32, int64, float, double, bool, string, char

        enum Type
        {
            Int,
            Float,
            Double
        }

        public static Dictionary<string, Int16> Int16V = new Dictionary<string, Int16>();
        public static Dictionary<string, Int32> Int32V = new Dictionary<string, Int32>();
        public static Dictionary<string, Int64> Int64V = new Dictionary<string, Int64>();
        public static Dictionary<string, float> FloatV = new Dictionary<string, float>();
        public static Dictionary<string, double> DoubleV = new Dictionary<string, double>();
        public static Dictionary<string, bool> BoolV = new Dictionary<string, bool>();
        public static Dictionary<string, string> StringV = new Dictionary<string, string>();
        public static Dictionary<string, char> CharV = new Dictionary<string, char>();

        public static List<string> pouziteNazvy = new List<string>();

        public static string typ = "";

        private Panel pracPanel;

        public void Setup(Panel _pracPanel)
        {
            pracPanel = _pracPanel;
        }

        public static bool isValid;
        public static string hodnota = "";

        public void VytvoritPromennou(string nazev, string _hodnota, TextBox tbVystupConsole)
        {
            isValid = true;
            hodnota = _hodnota;

            Int16 a;
            Int32 b;
            Int64 c;
            float d;
            double e;
            bool f;
            char g;

            List<string> sequence = new List<string>();

            //Metoda na třídění výrazu
            List<string> SplitCommand(string command)
            {
                List<string> _sequence = new List<string>();
                string arg = "";
                foreach (char ch in command)
                {
                    if(ch != ' ')
                    {
                        if ((ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(' || ch == ')') && arg != "")
                        {
                            _sequence.Add(arg);
                            _sequence.Add(ch.ToString());
                            arg = "";
                        }
                        else
                            arg += ch;
                    }
                }
                _sequence.Add(arg); //Přidání posledního členu
                return _sequence;
            }

            //Metoda na zjednodušení tříděného výrazu
            List<string> SimplifySequence(List<string> s)
            {
                List<string> _sequence = new List<string>();

                //řešení závorek

                return _sequence;
            }            

            //Metoda na řešení výrazu
            string SolveSequence(List<string> s)
            {                
                int value = 0;
                float valueF = 0.0f;
                double valueD = 0.0;

                string output = "";

                Type type = Type.Int;

                if (FindVar(s[0]) == "")
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
                    if (float.TryParse(FindVar(s[0]), out valueF))
                        type = Type.Float;
                    else if (double.TryParse(FindVar(s[0]), out valueD))
                        type = Type.Double;
                    else if (int.TryParse(FindVar(s[0]), out value))
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

                        if (FindVar(s[i]) == "")
                            arg = s[i];
                        else
                            arg = FindVar(s[i]);

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



            if (CheckIfString(hodnota))
            {
                hodnota = OverwriteString(hodnota);
                StringV.Add(nazev, hodnota);
                tbVystupConsole.Text += nazev + " = " + StringV[nazev] + Environment.NewLine + ">";
                typ = "String";

                CreateBlock(nazev, hodnota);
            }
            else if (CheckIfChar(hodnota))
            {
                hodnota = OverwriteChar(hodnota);
                CharV.Add(nazev, Convert.ToChar(hodnota));
                tbVystupConsole.Text += nazev + " = " + CharV[nazev] + Environment.NewLine + ">";
                typ = "Char";

                CreateBlock(nazev, hodnota);
            }
            else
            {
                //Třídění výrazu "hodnota"
                sequence = SplitCommand(hodnota);
                if (sequence.Contains("(")) { sequence = SimplifySequence(sequence); }

                //Řešení
                if (sequence.Count > 2) { hodnota = SolveSequence(sequence); }

                
                if (Int16.TryParse(hodnota, out a))
                {
                    Int16V.Add(nazev, a);
                    tbVystupConsole.Text += nazev + " = " + Int16V[nazev] + Environment.NewLine + ">";
                    typ = "Int16";
                }
                else if (Int32.TryParse(hodnota, out b))
                {
                    Int32V.Add(nazev, b);
                    tbVystupConsole.Text += nazev + " = " + Int32V[nazev] + Environment.NewLine + ">";
                    typ = "Int32";
                }
                else if (Int64.TryParse(hodnota, out c))
                {
                    Int64V.Add(nazev, c);
                    tbVystupConsole.Text += nazev + " = " + Int64V[nazev] + Environment.NewLine + ">";
                    typ = "Int64";
                }
                else if (float.TryParse(hodnota, out d))
                {
                    FloatV.Add(nazev, d);
                    tbVystupConsole.Text += nazev + " = " + FloatV[nazev] + Environment.NewLine + ">";
                    typ = "Float";
                }
                else if (double.TryParse(hodnota, out e))
                {
                    DoubleV.Add(nazev, e);
                    tbVystupConsole.Text += nazev + " = " + DoubleV[nazev] + Environment.NewLine + ">";
                    typ = "Double";
                }
                else if (bool.TryParse(hodnota, out f))
                {
                    BoolV.Add(nazev, f);
                    tbVystupConsole.Text += nazev + " = " + BoolV[nazev] + Environment.NewLine + ">";
                    typ = "Bool";
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Něco je špatně");
                }

                if (isValid)
                    CreateBlock(nazev, hodnota);

            }
        }

        private void CreateBlock(string nazev, string hodnota)
        {
            //BLOCK
            Block block = new Block(pracPanel);
            block.BlockVar(typ, nazev, hodnota);
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


        //Check if string (true - je string, false - není string) !JE NUTNÉ RUČNĚ ODEBRAT UVOZOVKY! (metody nad)
        public static bool CheckIfString(string hodnota)
        {
            if (hodnota[0] == '"' && hodnota[hodnota.Length - 1] == '"' && hodnota.Length >= 2)
                return true;
            return false;
        }

        //Check if char (true - je char, false - není char) !JE NUTNÉ RUČNĚ ODEBRAT UVOZOVKY! (metody nad)
        public static bool CheckIfChar(string hodnota)
        {
            if (hodnota[0] == Convert.ToChar("'") && hodnota[hodnota.Length - 1] == Convert.ToChar("'") && hodnota.Length == 3)
                return true;
            return false;
        }

        //Metoda pro nalezení proměnné v Dictionaries
        public static string FindVar(string key) //Vrátí hodnotu podle key (jako string)
        {
            if (Promenne.Int16V.ContainsKey(key))
            {
                return Int16V[key].ToString();
            }
            else if (Promenne.Int32V.ContainsKey(key))
            {
                return Int32V[key].ToString();
            }
            else if (Promenne.Int64V.ContainsKey(key))
            {
                return Int64V[key].ToString();
            }
            else if (Promenne.FloatV.ContainsKey(key))
            {
                return FloatV[key].ToString();
            }
            else if (Promenne.DoubleV.ContainsKey(key))
            {
                return DoubleV[key].ToString();
            }
            else if (Promenne.BoolV.ContainsKey(key))
            {
                return BoolV[key].ToString();
            }
            else if (Promenne.StringV.ContainsKey(key))
            {
                return StringV[key].ToString();
            }
            else if (Promenne.CharV.ContainsKey(key))
            {
                return CharV[key].ToString();
            }

            return "";
        }

    }
}