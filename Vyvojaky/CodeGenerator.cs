using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class CodeGenerator
    {
        public static string code;

        public static string lastCond = "";        
        
        public static string Format(string _code)
        {
            int numTabs = 0;
            string formated = "";

            foreach (char c in _code)
            {
                formated += c;

                if (c == '{')
                    numTabs++;                    
                else if (c == '}')
                    numTabs--;

                if (c == '{' || c == '}' || c == ';')
                {
                    formated += "\r\n";
                    for (int i = 0; i < numTabs; i++)
                        formated += "\t";
                }
            }

            return formated;
        }

        public static string Generate()
        {
            code = "using System;public class Program{public static void Main(string[] args){";


            foreach (Control c in Block.pracPanel.Controls)
            {
                if (c is IBlock)
                    code += ((IBlock)c).GenCode();
            }

            //Memory clear
            Promenne.Int16V.Clear();
            Promenne.Int32V.Clear();
            Promenne.Int64V.Clear();
            Promenne.FloatV.Clear();
            Promenne.DoubleV.Clear();
            Promenne.BoolV.Clear();
            Promenne.StringV.Clear();
            Promenne.CharV.Clear();

            Promenne.usedNames.Clear();

            code += "}}";

            return Format(code);
        }
    }
}
