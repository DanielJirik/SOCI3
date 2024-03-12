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
        
        public static string Generate()
        {
            code = "using System;\r\n \r\npublic class Program\r\n{\r\n\tpublic static void Main(string[] args)\r\n{\r\n\t";


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

            code += "\r\n}\r\n}";

            return code;
        }
    }
}
