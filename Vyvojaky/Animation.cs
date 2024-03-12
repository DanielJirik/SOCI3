using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //funkce na změnu obrázku a textu daného bloku v sekvenci
        public static void ImagesForBlocks(bool change) 
        {            
            if (change)
            {
                foreach (Control block in Block.pracPanel.Controls)
                {
                    if (block.Tag != null)
                    {
                            if (block is BlockVar)
                            {
                                ((BlockVar)block).popis.ForeColor = Color.White;
                                ((BlockVar)block).Image = Resources.vstup_vystup_tmavy;
                            }
                            else if (block is BlockCon)
                            {
                                ((BlockCon)block).popis.ForeColor = Color.White;
                                ((BlockCon)block).Image = Resources.podminka_tmavy;
                            }
                            else if (block is BlockProcess)
                            {
                                ((BlockProcess)block).lb.ForeColor = Color.White;
                                ((BlockProcess)block).Image = Resources.zpracovani_tmavy;
                            }
                            else if (block is BlockSwitches)
                            {
                                ((BlockSwitches)block).lb.ForeColor = Color.White;
                                ((BlockSwitches)block).lbVstup.ForeColor = Color.White;
                                ((BlockSwitches)block).Image = Resources.zpracovani_tmavy;
                            }
                            else if (block is BlockCycles)
                            {
                                if (((BlockCycles)block).name == "For")
                                {
                                    ((BlockCycles)block).lb.ForeColor = Color.White;
                                    ((BlockCycles)block).Image = Resources.cyklus_for_tmavy;
                                }
                                else if (((BlockCycles)block).name == "While")
                                {
                                    ((BlockCycles)block).lb.ForeColor = Color.White;
                                    ((BlockCycles)block).lb.Image = Resources.cyklus_podminka_zacatek_tmavy;
                                }
                                else if (((BlockCycles)block).name == "Do-while")
                                {
                                    ((BlockCycles)block).lb.ForeColor = Color.White;
                                    ((BlockCycles)block).Image = Resources.cyklus_podminka_konec_tmavy;
                                }
                            }
                            else if (block is BlockOutput)
                            {
                                ((BlockOutput)block).lb.ForeColor = Color.White;
                                ((BlockOutput)block).Image = Resources.vstup_vystup_tmavy;
                            }
                            else if (block is BlockCycleEnd)
                            {
                                if (((BlockCycleEnd)block).name == "End-for")
                                {
                                    ((BlockCycleEnd)block).lb.ForeColor = Color.White;
                                    ((BlockCycleEnd)block).Image = Resources.cyklus_for_tmavy;
                                }
                                else if (((BlockCycleEnd)block).name == "End-while")
                                {
                                    ((BlockCycleEnd)block).lb.ForeColor = Color.White;
                                    ((BlockCycleEnd)block).lb.Image = Resources.cyklus_podminka_zacatek_tmavy;
                                }
                                else if (((BlockCycleEnd)block).name == "End-do-while")
                                {
                                    ((BlockCycleEnd)block).lb.ForeColor = Color.White;
                                    ((BlockCycleEnd)block).Image = Resources.cyklus_podminka_konec_tmavy;
                                }
                        }
                    }
                }
            }
            else
            {
                foreach (Control block in Block.pracPanel.Controls)
                {
                    if (block.Tag != null)
                    {
                            if (block is BlockVar)
                            {
                                ((BlockVar)block).popis.ForeColor = Color.Black;
                                ((BlockVar)block).Image = Resources.vstup_vystup_svetly;
                            }
                            else if (block is BlockCon)
                            {
                                ((BlockCon)block).popis.ForeColor = Color.Black;
                                ((BlockCon)block).Image = Resources.podminka_svetly;
                            }
                            else if (block is BlockProcess)
                            {
                                ((BlockProcess)block).lb.ForeColor = Color.Black;
                                ((BlockProcess)block).Image = Resources.zpracovani_svetly;
                            }
                            else if (block is BlockSwitches)
                            {
                                ((BlockSwitches)block).lb.ForeColor = Color.Black;
                                ((BlockSwitches)block).lbVstup.ForeColor = Color.Black;
                                ((BlockSwitches)block).Image = Resources.zpracovani_svetly;
                            }
                            else if (block is BlockCycles)
                            {
                                if (((BlockCycles)block).name == "For")
                                {
                                    ((BlockCycles)block).lb.ForeColor = Color.Black;
                                    ((BlockCycles)block).Image = Resources.cyklus_for_svetly;
                                }
                                else if (((BlockCycles)block).name == "While")
                                {
                                    ((BlockCycles)block).lb.ForeColor = Color.Black;
                                    ((BlockCycles)block).Image = Resources.cyklus_podminka_zacatek_svetly;
                                }
                                else if (((BlockCycles)block).name == "Do-while")
                                {
                                    ((BlockCycles)block).lb.ForeColor = Color.Black;
                                    ((BlockCycles)block).Image = Resources.cyklus_podminka_konec_svetly;
                                }
                            }
                            else if (block is BlockOutput)
                            {
                                ((BlockOutput)block).lb.ForeColor = Color.Black;
                                ((BlockOutput)block).Image = Resources.vstup_vystup_svetly;
                            }
                            else if (block is BlockCycleEnd)
                            {
                                if (((BlockCycleEnd)block).name == "End-for")
                                {
                                    ((BlockCycleEnd)block).lb.ForeColor = Color.Black;
                                    ((BlockCycleEnd)block).Image = Resources.cyklus_for_svetly;
                                }
                                else if (((BlockCycleEnd)block).name == "End-while")
                                {
                                    ((BlockCycleEnd)block).lb.ForeColor = Color.Black;
                                    ((BlockCycleEnd)block).Image = Resources.cyklus_podminka_zacatek_svetly;
                                }
                                else if (((BlockCycleEnd)block).name == "End-do-while")
                                {
                                    ((BlockCycleEnd)block).lb.ForeColor = Color.Black;
                                    ((BlockCycleEnd)block).Image = Resources.cyklus_podminka_konec_svetly;
                                }
                            }
                    }
                }
            }
        }

        //změna barvy textu během sekvence(krok po kroku mění text bloku)
        public static void Steps(Control block, bool next)
        {
            if (next)
            {
                if (block is BlockVar)
                {
                    ((BlockVar)block).popis.ForeColor = Color.Orange;
                }
                else if (block is BlockCon)
                {
                    ((BlockCon)block).popis.ForeColor = Color.Orange;
                }
                else if (block is BlockSwitches)
                {
                    ((BlockSwitches)block).lb.ForeColor = Color.Orange;
                    ((BlockSwitches)block).lbVstup.ForeColor = Color.Orange;
                }
                else if (block is BlockCycles)
                {
                    ((BlockCycles)block).lb.ForeColor = Color.Orange;
                }
                else if (block is BlockProcess)
                {
                    ((BlockProcess)block).lb.ForeColor = Color.Orange;
                }
                else if (block is BlockOutput)
                {
                    ((BlockOutput)block).lb.ForeColor = Color.Orange;
                }
                else if (block is BlockCycleEnd)
                {
                    ((BlockCycleEnd)block).lb.ForeColor = Color.Orange;
                }
            }
            else
            {
                if (block is BlockVar)
                {
                    ((BlockVar)block).popis.ForeColor = Color.White;
                }
                else if (block is BlockCon)
                {
                    ((BlockCon)block).popis.ForeColor = Color.White;
                }
                else if (block is BlockSwitches)
                {
                    ((BlockSwitches)block).lb.ForeColor = Color.White;
                    ((BlockSwitches)block).lbVstup.ForeColor = Color.White;
                }
                else if (block is BlockCycles)
                {
                    ((BlockCycles)block).lb.ForeColor = Color.White;
                }
                else if (block is BlockProcess)
                {
                    ((BlockProcess)block).lb.ForeColor = Color.White;
                }
                else if (block is BlockOutput)
                {
                    ((BlockOutput)block).lb.ForeColor = Color.White;
                }
                else if (block is BlockCycleEnd)
                {
                    ((BlockCycleEnd)block).lb.ForeColor = Color.White;
                }
            }
            
        }
    }
}
