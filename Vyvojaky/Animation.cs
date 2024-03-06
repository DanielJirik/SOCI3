using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vyvojaky.Properties;

namespace Vyvojaky
{
    internal class Animation
    {   

        public Animation() 
        { 
            
        }

        public enum Type 
        { 
            Var, 
            Con, 
            Switch,
            Cycle,
            Process, 
            Output,
            Start
        }

        public void ImagesForBlocks(Panel panel, List<int> orders, bool change) 
        {
            int index = 0;
            if (change)
            {
                foreach (Control block in panel.Controls)
                {
                    if (block.Tag.ToString() == orders[index].ToString())
                    {
                        if (block is BlockVar)
                        {
                            ((BlockVar)block).ForeColor = Color.Black;
                            ((BlockVar)block).Image = Resources.vstup_vystup_tmavy;
                        }
                        else if (block is BlockCon)
                        {
                            ((BlockCon)block).ForeColor = Color.Black;
                            ((BlockCon)block).Image = Resources.podminka_tmavy;
                        }
                        else if (block is BlockProcess)
                        {
                            ((BlockProcess)block).ForeColor = Color.Black;
                            ((BlockProcess)block).Image = Resources.zpracovani_tmavy;
                        }
                        else if (block is BlockSwitches)
                        {
                            ((BlockSwitches)block).ForeColor = Color.Black;
                            ((BlockSwitches)block).Image = Resources.zpracovani_tmavy;
                        }
                        else if (block is BlockCycles)
                        {
                            if (((BlockCycles)block).name == "For")
                            {
                                ((BlockCycles)block).ForeColor = Color.Black;
                                ((BlockCycles)block).Image = Resources.cyklus_for_tmavy;
                            }
                            else if (((BlockCycles)block).name == "While")
                            {
                                ((BlockCycles)block).ForeColor = Color.Black;
                                ((BlockCycles)block).Image = Resources.cyklus_podminka_zacatek_tmavy;
                            }
                            else if (((BlockCycles)block).name == "Do-while")
                            {
                                ((BlockCycles)block).ForeColor = Color.Black;
                                ((BlockCycles)block).Image = Resources.cyklus_podminka_konec_tmavy;
                            }
                        }
                        else if (block is BlockOutput)
                        {
                            ((BlockOutput)block).ForeColor = Color.Black;
                            ((BlockOutput)block).Image = Resources.vstup_vystup_tmavy;
                        }
                    }
                    index++;
                }
            }
            else
            {
                foreach (Control block in panel.Controls)
                {
                    if (block.Tag.ToString() == orders[index].ToString())
                    {
                        if (block is BlockVar)
                        {
                            ((BlockVar)block).ForeColor = Color.Black;
                            ((BlockVar)block).Image = Resources.vstup_vystup_svetly;
                        }
                        else if (block is BlockCon)
                        {
                            ((BlockCon)block).ForeColor = Color.Black;
                            ((BlockCon)block).Image = Resources.podminka_svetly;
                        }
                        else if (block is BlockProcess)
                        {
                            ((BlockProcess)block).ForeColor = Color.Black;
                            ((BlockProcess)block).Image = Resources.zpracovani_svetly;
                        }
                        else if (block is BlockSwitches)
                        {
                            ((BlockSwitches)block).ForeColor = Color.Black;
                            ((BlockSwitches)block).Image = Resources.zpracovani_svetly;
                        }
                        else if (block is BlockCycles)
                        {
                            if (((BlockCycles)block).name == "For")
                            {
                                ((BlockCycles)block).ForeColor = Color.Black;
                                ((BlockCycles)block).Image = Resources.cyklus_for_svetly;
                            }
                            else if (((BlockCycles)block).name == "While")
                            {
                                ((BlockCycles)block).ForeColor = Color.Black;
                                ((BlockCycles)block).Image = Resources.cyklus_podminka_zacatek_svetly;
                            }
                            else if (((BlockCycles)block).name == "Do-while")
                            {
                                ((BlockCycles)block).ForeColor = Color.Black;
                                ((BlockCycles)block).Image = Resources.cyklus_podminka_konec_svetly;
                            }
                        }
                        else if (block is BlockOutput)
                        {
                            ((BlockOutput)block).ForeColor = Color.Black;
                            ((BlockOutput)block).Image = Resources.vstup_vystup_svetly;
                        }
                    }
                    index++;
                }
            }
            
            //foreach ((int, Types) i in Panel) 
            //{ 
                
            //}
            //zjištění které bloky jsou propojeny a následně přiřadit příslušný tmavý obrázek
        }

        public async void Delays(int pause)
        {   
            //await Task.Delay(pause);
            //asynchronní metoda pro pauzu
            //potřebná asynchronní funkce pro run možná
            //po vyhodnocení bloků by se bloky vrátili do původní podoby
        }
    }
}
