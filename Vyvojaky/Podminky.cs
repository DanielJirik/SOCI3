using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CSharp;


namespace Vyvojaky
{
    internal class Podminky
    {   
        public Podminky() 
        {
        

        }

        public void porovnani(int prom1, int prom2, string operatory, TextBox console) 
        {
            
            switch (operatory)
            {
                case ">":
                    if (prom1 > prom2)
                    {
                        console.Text += "Podminka -->true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "Podminka -->false" + "\r\n" + ">";
                    }
                    break;
                case "<":
                    if (prom1 < prom2)
                    {
                        console.Text += "Podminka -->true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "Podminka -->false" + "\r\n" + ">";
                    }
                    break;
                case ">=":
                    if (prom1 >= prom2)
                    {
                        console.Text += "Podminka -->true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "Podminka -->false" + "\r\n" + ">";
                    }
                    break;
                case "<=":
                    if (prom1 <= prom2)
                    {
                        console.Text += "Podminka -->true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "Podminka -->false" + "\r\n" + ">";
                    }
                    break;
                case "==":
                    if (prom1 == prom2)
                    {
                        console.Text += "Podminka -->true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "Podminka -->false" + "\r\n" + ">";
                    }
                    break;
                case "!=":
                    if (prom1 != prom2)
                    {
                        console.Text += "Podminka -->true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "Podminka -->false" + "\r\n" + ">"; 
                    }
                    break;
                default:
                    console.Text += "*Zadán chybný operátor" + "\r\n" + ">";
                    break;

            }
        }

        public void porovnaniProString(string prom1, string prom2, string operatory, TextBox console)
        {
            switch (operatory)
            {
                case "==":
                    if (prom1 == prom2)
                    {
                        console.Text += "true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "false" + "\r\n" + ">";
                    }
                    break;
                case "!=":
                    if (prom1 != prom2)
                    {
                        console.Text += "true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "false" + "\r\n" + ">";
                    }
                    break;
                default:
                    console.Text += "Zadán chybný operátor" + "\r\n" + ">";
                    break;
            }
        }

        public (string, string) hledani(string text1, string text2, List<string> nazvy, Dictionary<string, Int16> inty16, TextBox console) 
        {
            Int16 value = 0;
            string valueS1 = "";
            string valueS2 = "";
            if (nazvy.Contains(text1))
            {
                
                if (inty16.ContainsKey(text1))
                {
                    inty16.TryGetValue(text1, out value);
                    valueS1 = value.ToString();
                }
                else
                {
                    valueS1 = text1;
                }
                
                
            }
            else
            {
                valueS1 = text1.ToString();
            }

            if (nazvy.Contains(text2))
            {
                if (inty16.ContainsKey(text2))
                {
                    inty16.TryGetValue(text2, out value);
                    valueS2 = value.ToString();
                }
                else
                {
                    valueS2 = text2;
                }
                
            }
            else
            {
                valueS2 = text2.ToString();
            }

            return (valueS1, valueS2);
        }


        
    }
}
