using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Promenne
    {
        //int16, int32, int64, float, double, bool, string, char

        public Dictionary<string, Int16> Int16V = new Dictionary<string, Int16>();
        public Dictionary<string, Int32> Int32V = new Dictionary<string, Int32>();
        public Dictionary<string, Int64> Int64V = new Dictionary<string, Int64>();
        public Dictionary<string, float> FloatV = new Dictionary<string, float>();
        public Dictionary<string, double> DoubleV = new Dictionary<string, double>();
        public Dictionary<string, bool> BoolV = new Dictionary<string, bool>();
        public Dictionary<string, string> StringV = new Dictionary<string, string>();
        public Dictionary<string, char> CharV = new Dictionary<string, char>();

        public List<string> pouziteNazvy = new List<string>();



        public Promenne()
        {
            
        }

        public void VytvoritPromennou(string typ, string nazev, string hodnota, TextBox tbVystupConsole)
        {
            switch (typ)
            {
                case "Int16":
                    Int16V.Add(nazev, Convert.ToInt16(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(Int16V[nazev]) + Environment.NewLine + ">";
                    break;
                case "Int32":
                    Int32V.Add(nazev, Convert.ToInt32(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(Int32V[nazev]) + Environment.NewLine + ">";
                    break;
                case "Int64":
                    Int64V.Add(nazev, Convert.ToInt64(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(Int64V[nazev]) + Environment.NewLine + ">";
                    break;
                case "Float":
                    FloatV.Add(nazev, float.Parse(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(FloatV[nazev]) + Environment.NewLine + ">";
                    break;
                case "Double":
                    DoubleV.Add(nazev, Convert.ToDouble(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(DoubleV[nazev]) + Environment.NewLine + ">";
                    break;
                case "Bool":
                    BoolV.Add(nazev, Convert.ToBoolean(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(BoolV[nazev]) + Environment.NewLine + ">";
                    break;
                case "String":
                    StringV.Add(nazev, Convert.ToString(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToString(StringV[nazev]) + Environment.NewLine + ">";
                    break;
                case "Char":
                    CharV.Add(nazev, Convert.ToChar(hodnota));
                    tbVystupConsole.Text += nazev + " = " + Convert.ToChar(CharV[nazev]) + Environment.NewLine + ">";
                    break;

                default:
                    break;
            }
        }
    }
}
