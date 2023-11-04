using System;
using System.Collections.Generic;
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
                        console.Text += "true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "false" + "\r\n" + ">";
                    }
                    break;
                case "<":
                    if (prom1 < prom2)
                    {
                        console.Text += "true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "false" + "\r\n" + ">";
                    }
                    break;
                case ">=":
                    if (prom1 >= prom2)
                    {
                        console.Text += "true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "false" + "\r\n" + ">";
                    }
                    break;
                case "<=":
                    if (prom1 <= prom2)
                    {
                        console.Text += "true" + "\r\n" + ">";
                    }
                    else
                    {
                        console.Text += "false" + "\r\n" + ">";
                    }
                    break;
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


        
    }
}
