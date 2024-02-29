using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Output
    {
        public Output() 
        { 
            
        }

        public static void Print(string input)
        {
            if (Promenne.FindVar(input, "value") != null)
                MessageBox.Show(Promenne.FindVar(input, "value"));
            else
                MessageBox.Show(input.Replace('"'.ToString(), ""));

        }
    }
}
