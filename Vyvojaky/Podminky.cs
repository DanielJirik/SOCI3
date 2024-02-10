using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CSharp;


namespace Vyvojaky
{
    internal class Podminky
    {
        //public static Panel mainPanel;
        //public void Setup(Panel _mainPanel)
        //{
        //    mainPanel = _mainPanel;
        //}


        public static bool isTrue(string command)
        {
            string opr = "";
            bool cond = false;

            //př. příkazu: a > b, a == b, a <= b

            string a, b;
            List<string> conSequence = new List<string>();

            try
            {
                for (int i = 0; i < command.Length; i++)
                {
                    char c = command[i];

                    if (c == '>' || c == '<' || c == '=' || c == '!')
                    {
                        if (command[i + 1] == '=')
                            { opr = c.ToString() + "="; break; }
                        else
                            opr = c.ToString();
                    }
                }

                //Převede část příkazu na sekvenci, tu následně vyřeší jako výraz
                int result;

                a = command.Split(opr)[0].Trim();
                conSequence = Promenne.SplitCommand(a);
                string temp = "";
                if ((temp = Promenne.SumString(a)) != null && int.TryParse(temp, out result) == false) { a = '"' + temp + '"'; }
                else if (conSequence.Count > 2) { a = Promenne.SolveSequence(conSequence); }

                b = command.Split(opr)[1].Trim();
                conSequence = Promenne.SplitCommand(b);
                if ((temp = Promenne.SumString(b)) != null && int.TryParse(temp, out result) == false) { b = '"' + temp + '"'; }
                else if (conSequence.Count > 2) { b = Promenne.SolveSequence(conSequence); }


                if (Promenne.FindVar(a, "value") != null)
                    a = Promenne.FindVar(a, "value");
                if (Promenne.FindVar(b, "value") != null)
                    b = Promenne.FindVar(b, "value");

                    if (((a[0] == '"' && a[a.Length - 1] == '"') && (b[0] == '"' && b[b.Length - 1] == '"')) //Je string nebo char (zároveň není instance)
                    || ((a[0] == Convert.ToChar("'") && a[a.Length - 1] == Convert.ToChar("'")) && (b[0] == Convert.ToChar("'") && b[b.Length - 1] == Convert.ToChar("'"))))
                {

                    switch (opr)
                    {
                        case "==":
                            if (a == b) cond = true;
                            break;
                        case "!=":
                            if (a != b) cond = true;
                            break;
                        default:
                            break;
                    }
                }
                else //Není string nebo char
                {
                    if (a == "True" || a == "true" || b == "True" || b == "true"
                        || a == "False" || a == "false" || b == "False" || b == "false")
                    {
                        bool _a = Convert.ToBoolean(a);
                        bool _b = Convert.ToBoolean(b);

                        switch (opr)
                        {
                            case "==":
                                if (_a == _b) cond = true;
                                break;
                            case "!=":
                                if (_a != _b) cond = true;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        double _a = Convert.ToDouble(a);
                        double _b = Convert.ToDouble(b);

                        switch (opr)
                        {
                            case ">":
                                if (_a > _b) cond = true;
                                break;
                            case "<":
                                if (_a < _b) cond = true;
                                break;
                            case "==":
                                if (_a == _b) cond = true;
                                break;
                            case "!=":
                                if (_a != _b) cond = true;
                                break;
                            case ">=":
                                if (_a >= _b) cond = true;
                                break;
                            case "<=":
                                if (_a <= _b) cond = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Něco je špatně.");
            }
            //Jakýkoliv jiný případ
            return cond;
        }
    }
}
