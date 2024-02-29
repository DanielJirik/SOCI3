using System;
using System.Collections.Generic;
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
        public List<int> blocksSorted = new List<int>();

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
