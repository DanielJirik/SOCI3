﻿using System;
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
        Panel pracPanel;
        public void Setup(Panel _pracPanel)
        {
            pracPanel = _pracPanel;
        }

        string opr = "";
        bool cond = false;

        public bool isTrue(string prikaz)
        {
            //př. příkazu: a > b, a == b, a <= b

            string a, b;

            try
            {
                for (int i = 0; i < prikaz.Length; i++)
                {
                    char c = prikaz[i];

                    if (c == '>' || c == '<' || c == '=' || c == '!')
                    {
                        if (prikaz[i + 1] == '=')
                            { opr = c.ToString() + "="; break; }
                        else
                            opr = c.ToString();
                    }
                }
                
                a = prikaz.Split(opr)[0].Trim();
                b = prikaz.Split(opr)[1].Trim();

                string varTypeA = "";
                string varTypeB = "";

                if ((varTypeA = Promenne.FindVar(a)) != "")
                {
                    switch (varTypeA)
                    {
                        case "Int16":
                            a = Promenne.Int16V[a].ToString();
                            break;
                        case "Int32":
                            a = Promenne.Int32V[a].ToString();
                            break;
                        case "Int64":
                            a = Promenne.Int64V[a].ToString();
                            break;
                        case "Float":
                            a = Promenne.FloatV[a].ToString();
                            break;
                        case "Double":
                            a = Promenne.DoubleV[a].ToString();
                            break;
                        case "Bool":
                            a = Promenne.BoolV[a].ToString();
                            break;
                        case "String":
                            a = '"' + Promenne.StringV[a].ToString() + '"';
                            break;
                        case "Char":
                            a = "'" + Promenne.CharV[a].ToString() + "'";
                            break;
                        default:
                            break;
                    }
                }
                if ((varTypeB = Promenne.FindVar(b)) != "")
                {
                    switch (varTypeB)
                    {
                        case "Int16":
                            b = Promenne.Int16V[b].ToString();
                            break;
                        case "Int32":
                            b = Promenne.Int32V[b].ToString();
                            break;
                        case "Int64":
                            b = Promenne.Int64V[b].ToString();
                            break;
                        case "Float":
                            b = Promenne.FloatV[b].ToString();
                            break;
                        case "Double":
                            b = Promenne.DoubleV[b].ToString();
                            break;
                        case "Bool":
                            b = Promenne.BoolV[b].ToString();
                            break;
                        case "String":
                            b = '"' + Promenne.StringV[b].ToString() + '"';
                            break;
                        case "Char":
                            b = "'" + Promenne.CharV[b].ToString() + "'";
                            break;
                        default:
                            break;
                    }
                }

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

            Block block = new Block(pracPanel);
            block.BlockCon(prikaz);
            //Jakýkoliv jiný případ
            return cond;
        }
    }
}
