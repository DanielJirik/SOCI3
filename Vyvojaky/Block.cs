using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Block
    {
        public static Panel pracPanel;

        public Block(Panel _pracPanel)
        {
            pracPanel = _pracPanel;
        }

        //

        public void BlockVar(string typ, string nazev, string hodnota)
        {
            BlockVar blockVar = new BlockVar(typ, nazev, hodnota);
        }

        public void BlockCon(string prikaz)
        {
            BlockCon blockCon = new BlockCon(prikaz);
        }

    }
}