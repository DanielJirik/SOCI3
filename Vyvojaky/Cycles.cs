using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Cycles
    {

        Panel Pracovni;
        List<string> partsOfConditions = new List<string>();
        public Cycles() 
        { 
            
        }

        public void Setup(Panel _pracpanel)
        {
            Pracovni = _pracpanel;
        }

        public bool CheckFor(string nazev, string pocatek, string konec, string inkrement) 
        {
            if (Promenne.KontrolaNazvu(nazev) && !nazev.Contains("'") && !nazev.Contains('"') && !int.TryParse(nazev, out int var) && !double.TryParse(nazev, out double var0) && !float.TryParse(nazev, out float var1) && int.TryParse(pocatek, out int var2) && int.TryParse(konec, out int var3) && int.TryParse(inkrement, out int var4)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CyclesFor(int pocatek, int konec, int inkrement) 
        {
            if (pocatek < konec && inkrement > 0)
            {
                for (int i = pocatek; i <= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                }
            }
            else if(pocatek < konec && inkrement < 0)
            {
                for (int i = pocatek; i <= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                    break;
                }
            }
            else if (pocatek > konec && inkrement < 0)
            {
                for (int i = pocatek; i >= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                }
            }
            else if (pocatek > konec && inkrement > 0)
            {
                for (int i = pocatek; i >= konec; i += inkrement)
                {
                    MessageBox.Show("Index: " + i);
                    break;
                }
            }
            else
            {
                MessageBox.Show("Něco se nepovedlo!");
            }
        }

        public void CreationOfCycleFor(string nazev, string pocatek, string konec, string inkrement) 
        {
            Block block = new Block(Pracovni);
            block.BlockCycleFor(nazev, pocatek, konec, inkrement);
        }

        public bool CheckWhileAndDoWhile(string condition)
        {
            string parameter = "";
            int count = 0;
            for (int i = 0; i < condition.Length; i++)
            {
                if (condition[i].ToString() == "<" || condition[i].ToString() == ">" || condition[i].ToString() == "<=" || condition[i].ToString() == ">=" || condition[i].ToString() == "==" || condition[i].ToString() == "!=")
                {
                    partsOfConditions.Add(parameter);
                    count++;
                    if (count > 1)
                    {
                        return false;
                    }
                }
                else
                {
                    parameter += condition[i].ToString();
                }
            }
            return true;
        }
    }
}
