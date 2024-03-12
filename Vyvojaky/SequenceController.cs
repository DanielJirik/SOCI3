using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class SequenceController
    {
        public static void Start()
        {
            BlockStart s = new BlockStart();
        }

        public static async void RunSequence(int index, int endIndex)
        {
            int? passIndex;

            string prikaz = "";
            Block.Type type = Block.Type.Start;

            Animation.ImagesForBlocks(true);
            
            foreach (Control var in Block.pracPanel.Controls)
            {
                if (var is IBlock && Convert.ToInt16(var.Tag) == index)
                {
                    //Sets next index to a joint of the present one
                    passIndex = Convert.ToInt16(((IBlock)var).joint);


                    //Změna barvy textu v momentě, kdy běží sekvence + čekání vteřinu
                    Animation.Steps(var, true);
                    await Task.Delay(1000);

                    //Block division
                    if (var is BlockVar)
                    {
                        prikaz = ((BlockVar)var).command;
                        type = Block.Type.Var;
                    }
                    else if (var is BlockCon)
                    {
                        prikaz = ((BlockCon)var).command;
                        type = Block.Type.Con;
                        if (Podminky.isTrue(prikaz))
                            var.BackColor = Color.Green;
                        else
                            var.BackColor = Color.Red;
                    }
                    else if (var is BlockProcess)
                    {
                        prikaz = ((BlockProcess)var).command;
                        type = Block.Type.Process;
                    }
                    else if (var is BlockOutput)
                    {
                        prikaz = ((BlockOutput)var).command;
                        type = Block.Type.Output;

                    }
                    else if (var is BlockCycles)
                    {
                        foreach (Control item in Block.pracPanel.Controls)
                        {
                            if (item is BlockCycleEnd)
                            {
                                //Sets next index to a joint of the present one
                                passIndex = Convert.ToInt32(item.Tag);

                                if (((BlockCycles)var).name == "For" && ((BlockCycleEnd)item).name == "End-for")
                                {
                                    Cycles.CyclesFor(((BlockCycles)var).Nazev, int.Parse(((BlockCycles)var).Pocatek), int.Parse(((BlockCycles)var).KonecnaHodnota), int.Parse(((BlockCycles)var).Inkrement), Convert.ToInt32(((IBlock)var).joint), Convert.ToInt32(item.Tag));
                                    break;
                                }
                                else if (((BlockCycles)var).name == "While" && ((BlockCycleEnd)item).name == "End-while")
                                {
                                    if (Cycles.CheckWhileAndDoWhile(((BlockCycles)var).condition))
                                    {
                                        Cycles.CycleWhileAndDoWhile("While", ((BlockCycles)var).condition, Convert.ToInt32(((IBlock)var).joint), Convert.ToInt32(item.Tag));
                                        break;
                                    }
                                }
                                else if (((BlockCycles)var).name == "Do-while" && ((BlockCycleEnd)item).name == "End-do-while")
                                {
                                    if (Cycles.CheckWhileAndDoWhile(((BlockCycles)var).condition))
                                    {
                                        Cycles.CycleWhileAndDoWhile("Do-while", ((BlockCycles)var).condition, Convert.ToInt32(((IBlock)var).joint), Convert.ToInt32(item.Tag));
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    //Perform an instruction
                    IstructionPerformance(prikaz, type);


                    //Změna barvy do původní podoby + pauza na půl vteřiny
                    Animation.Steps(var, false);
                    await Task.Delay(500);


                    if(passIndex == 0) //Erases memory only if RunSequence has reaches the joint
                    {
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

                        Animation.ImagesForBlocks(false);
                    }
                    else if (passIndex != endIndex) //Run a recursive function with a new given index and break the present one
                        RunSequence(Convert.ToInt16(passIndex), endIndex);

                    break;
                }
            }
        }

        public static void IstructionPerformance(string prikaz, Block.Type type)
        {
            switch (type)
            {
                case Block.Type.Switch:
                    break;
                case Block.Type.Cycle:
                    break;
                case Block.Type.Con:
                    Podminky.isTrue(prikaz);
                    break;
                case Block.Type.Start:
                    break;
                case Block.Type.Var:
                    Promenne.CommandCheck(prikaz);
                    break;
                case Block.Type.Process:
                    Process.CommandCheck(prikaz);
                    break;
                case Block.Type.Output:
                    Output.Print(prikaz);
                    break;
                default:
                    break;
            }
        }
    }
}
