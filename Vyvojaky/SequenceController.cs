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

        public void InstructionOrder(Panel mainPanel)
        {
            //countne vsechny BlockVar instance v mainPanelu
            int n = 0;
            foreach (Control item in mainPanel.Controls)
            {
                if (item is BlockVar)
                    n++;
            }
            MessageBox.Show(n.ToString());
        }
    }
}
