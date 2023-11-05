using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public void VytvoritPromennou(string nazev, string hodnota, TextBox tbVystupConsole)
        {
            Int16 a;
            Int32 b;
            Int64 c;
            float d;
            double e;
            bool f;
            char g;
            

            if (Int16.TryParse(hodnota, out a))
            {
                Int16V.Add(nazev, a);
                tbVystupConsole.Text += nazev + " = " + Int16V[nazev] + Environment.NewLine + ">";
            }
            else if (Int32.TryParse(hodnota, out b))
            {
                Int32V.Add(nazev, b);
                tbVystupConsole.Text += nazev + " = " + Int32V[nazev] + Environment.NewLine + ">";
            }
            else if (Int64.TryParse(hodnota, out c))
            {
                Int64V.Add(nazev, c);
                tbVystupConsole.Text += nazev + " = " + Int64V[nazev] + Environment.NewLine + ">";
            }
            else if (float.TryParse(hodnota, out d))
            {
                FloatV.Add(nazev, d);
                tbVystupConsole.Text += nazev + " = " + FloatV[nazev] + Environment.NewLine + ">";
            }
            else if (double.TryParse(hodnota, out e))
            {
                DoubleV.Add(nazev, e);
                tbVystupConsole.Text += nazev + " = " + DoubleV[nazev] + Environment.NewLine + ">";
            }
            else if (bool.TryParse(hodnota, out f))
            {
                BoolV.Add(nazev, f);
                tbVystupConsole.Text += nazev + " = " + BoolV[nazev] + Environment.NewLine + ">";
            }
            else if (char.TryParse(hodnota, out g))
            {
                CharV.Add(nazev, g);
                tbVystupConsole.Text += nazev + " = " + CharV[nazev] + Environment.NewLine + ">";
            }
            else //Je string
            {
                StringV.Add(nazev, hodnota);
                tbVystupConsole.Text += nazev + " = " + StringV[nazev] + Environment.NewLine + ">";
            }
        }
    }
}
