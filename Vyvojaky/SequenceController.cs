using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        //Sorted blocks list
        public static List<int> blocksSorted = new List<int>();

        //Seřazení blocků
        public void InstructionOrder(Panel mainPanel)
        {
            //Reset pořadí
            blocksSorted.Clear();

            //
            int numOfIterations = Block.indexes.Count - 1;
            int nextIndex = 1;            

            //Přidání indexu BlockStart
            blocksSorted.Add(nextIndex);

            //Identifikace indexů ostatních blocků
            for (int i = 0; i < numOfIterations; i++)
            {
                foreach (Control block in mainPanel.Controls)
                {
                    if (block is IBlock && nextIndex == Convert.ToInt16(block.Tag))
                    {
                        nextIndex = Convert.ToInt16(((IBlock)block).joint);
                        break;
                    }
                }
                    blocksSorted.Add(nextIndex);                    
            }            
        }

        //Run a part of the sequence (parameters as block indexes)
        public void PartSequence(int startIndex, int endIndex)
        {
            //Sort block indexes
            InstructionOrder(Block.pracPanel);

            //Border indexes
            startIndex = blocksSorted.IndexOf(startIndex);
            endIndex = blocksSorted.IndexOf(endIndex);
            
            string prikaz = "";
            Block.Type type = Block.Type.Start;
            int iter = startIndex;

            foreach (Control var in Block.pracPanel.Controls)
            {
                //In case of non-matching tag or if the tag is null, skips an iteration
                if (var.Tag != null)
                {
                    if (var.Tag.ToString() != blocksSorted[iter].ToString())
                        continue;
                }
                else
                    continue;

                //Division
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

                //Perform an instruction
                IstructionPerformance(prikaz, type);
                
                //Check if end
                if (iter == endIndex)
                    break;

                //Incrementing num if iterations
                iter++;                
            }
        }

        //Run the whole sequence
        public async void RunSequence()
        {
            //Sort block indexes
            InstructionOrder(Block.pracPanel);

            string prikaz = "";
            Block.Type type = Block.Type.Start;
            int iter = 0;

            //Animace - přepnutí na tmavý režim
            Animation.ImagesForBlocks(Block.pracPanel, blocksSorted, true);
            foreach (Control var in Block.pracPanel.Controls)
            {
                //In case of non-matching tag or if the tag is null, skips an iteration
                if (var.Tag != null)
                {
                    if (var.Tag.ToString() != blocksSorted[iter].ToString())
                        continue;
                }
                else
                    continue;

                //Změna barvy textu v momentě, kdy běží sekvence + čekání vteřinu
                Animation.Steps(var, true);
                await Task.Delay(1000);
                //Division
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

                //Perform an instruction
                IstructionPerformance(prikaz, type);
                //Změna barvy do původní podoby + pauza na půl vteřiny
                Animation.Steps(var, false);
                await Task.Delay(500);

                //Incrementing num if iterations
                iter++;
            }
            //vrátí obrázky do světlé podoby
            Animation.ImagesForBlocks(Block.pracPanel, blocksSorted, false);
            //Memory clear at the end
            Promenne.Int16V.Clear();
            Promenne.Int32V.Clear();
            Promenne.Int64V.Clear();
            Promenne.FloatV.Clear();
            Promenne.DoubleV.Clear();
            Promenne.BoolV.Clear();
            Promenne.StringV.Clear();
            Promenne.CharV.Clear();

            Promenne.usedNames.Clear();
        }

        public void IstructionPerformance(string prikaz, Block.Type type)
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
