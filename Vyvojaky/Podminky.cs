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
        Podminky(int prom1, int prom2, string operatory) 
        {
            porovnani(prom1, prom2, operatory);

        }

        public void porovnani(int prom1, int prom2, string operatory) 
        {
            
            switch (operatory)
            {
                case ">":
                    if (prom1 > prom2)
                    {

                    }
                    break;
                case "<":
                    if (prom1 < prom2)
                    {

                    }
                    break;
                case ">=":
                    if (prom1 >= prom2)
                    {

                    }
                    break;
                case "<=":
                    if (prom1 <= prom2)
                    {

                    }
                    break;
                case "==":
                    if (prom1 == prom2)
                    {

                    }
                    break;
                case "!=":
                    if (prom1 != prom2)
                    {
                        
                    }
                    break;
                default:
                    break;

            }
        }


        public Podminky(string nazev) 
        { 
            
        }
    }
}
