﻿using Microsoft.VisualBasic.Devices;
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
        public static List<int> indexes = new List<int>();

        public Block(Panel _pracPanel)
        {
            pracPanel = _pracPanel;
        }

        //

        public static int BlockIndex()
        {
            int index = indexes.Count() > 0 ? indexes.Last() + 1 : 1;
            indexes.Add(index);
            return index;
        }

        public void BlockVar(string typ, string nazev, string hodnota)
        {
            BlockVar blockVar = new BlockVar(typ, nazev, hodnota);
        }

        public void BlockCon(string prikaz)
        {
            BlockCon blockCon = new BlockCon(prikaz);
        }

        public void BlockSwitch(int pocetMoznosti, string vstupPromenna, List<TextBox> boxy)
        {
            BlockSwitches blockSwitch = new BlockSwitches(pocetMoznosti, vstupPromenna, boxy);
        }

    }
}