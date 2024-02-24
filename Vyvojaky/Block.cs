using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Block
    {
        public enum Type
        {
            Switch,
            Cycle,
            Con,
            Start,
            Var,
            Process
        }

        //Joint points
        

        public static Panel? pracPanel;
        public static Dictionary<int, Type> indexes= new Dictionary<int, Type>();

        //Indexace Blocků
        public static int BlockIndex(Type type)
        {            
            int index = indexes.Count() > 0 ? indexes.Keys.Max() + 1 : 1;
            indexes.Add(index, type);

            return index;
        }

        //Block instances
        public static void BlockVar(string typ, string nazev, string hodnota)
        {
            BlockVar blockVar = new BlockVar(typ, nazev, hodnota);            
        }

        public static void BlockCon(string prikaz)
        {
            BlockCon blockCon = new BlockCon(prikaz, Podminky.isTrue(prikaz));
        }

        public static void BlockSwitch(int pocetMoznosti, string vstupPromenna, List<string> boxy)
        {
            BlockSwitches blockSwitch = new BlockSwitches(pocetMoznosti, vstupPromenna, boxy);
        }

        public static void BlockCycleFor(string nazev, string pocatek, string konec, string inkrement)
        {
            BlockCycles blockFor = new BlockCycles(nazev, pocatek, konec, inkrement);
        }

        public void BlockCycleWhileOrDoWhile(string condition, string type)
        {
            BlockCycles blockWhileOrDoWhile = new BlockCycles(condition, type);
        }

        public static void BlockProcess(string input)
        {
            BlockProcess process = new BlockProcess(input);
        }

        //Disable control method
        public static void DisableControl(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            foreach (Label l in p.Controls)
            {
                l.Enabled = false;
            }
        }

        //Enable control method
        public static void EnableControl(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            foreach (Label l in p.Controls)
            {
                l.Enabled = true;
            }
        }



        //Drag and drop vars
        public static bool dragging;
        public static int xPos, yPos;

        //Drag and Drop methods
        public static void OnMouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                xPos = e.X; yPos = e.Y;
            }
        }

        public static void OnMouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public static void OnMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pbRequest = (PictureBox)sender;
            if (dragging)
            {
                pbRequest.Top = e.Y + pbRequest.Top - yPos;
                pbRequest.Left = e.X + pbRequest.Left - xPos;
            }
        }


        //Right-click behaviour
        public static bool swap = false;
        public static int fromIndex;

        public static void OnMouseClick(object sender, MouseEventArgs e)
        {
            PictureBox block = (PictureBox)sender;
            if (e.Button == MouseButtons.Right && !swap)
            {
                SwapIndex(Convert.ToInt32(block.Tag), sender);
                swap = true;
            }
            else if (e.Button == MouseButtons.Left && swap)
            {
                SwapIndex(Convert.ToInt32(block.Tag), sender);
                swap = false;
            }
        }

        public static void ResetJoint(int tag)
        {
            foreach (Control item in pracPanel.Controls)
            {
                if (item is BlockVar && ((BlockVar)item).joint == tag)
                {
                    ((BlockVar)item).joint = null;
                    break;
                }
                else if (item is BlockCon && ((BlockCon)item).joint == tag)
                {
                    ((BlockCon)item).joint = null;
                    break;
                }
                else if (item is BlockCycles && ((BlockCycles)item).joint == tag)
                {
                    ((BlockCycles)item).joint = null;
                    break;
                }
                else if (item is BlockSwitches && ((BlockSwitches)item).joint == tag)
                {
                    ((BlockSwitches)item).joint = null;
                    break;
                }
                else if (item is BlockStart && ((BlockStart)item).joint == tag)
                {
                    ((BlockStart)item).joint = null;
                    break;
                }
            }
        }


        public static void SetJoint(int tag)
        {
            foreach (Control item in pracPanel.Controls)
            {
                if (item is BlockVar && Convert.ToInt16(((BlockVar)item).Tag) == fromIndex)
                {
                    ((BlockVar)item).joint = tag;
                    //MessageBox.Show(((BlockVar)item).joint.ToString());
                    break;
                }
                else if (item is BlockCon && Convert.ToInt16(((BlockCon)item).Tag) == fromIndex)
                {
                    ((BlockCon)item).joint = tag;
                    //MessageBox.Show(((BlockCon)item).joint.ToString());
                    break;
                }
                else if (item is BlockCycles && Convert.ToInt16(((BlockCycles)item).Tag) == fromIndex)
                {
                    ((BlockCycles)item).joint = tag;
                    //MessageBox.Show(((BlockCycles)item).joint.ToString());
                    break;
                }
                else if (item is BlockSwitches && Convert.ToInt16(((BlockSwitches)item).Tag) == fromIndex)
                {
                    ((BlockSwitches)item).joint = tag;
                    //MessageBox.Show(((BlockSwitches)item).joint.ToString());
                    break;
                }
                else if (item is BlockStart && Convert.ToInt16(((BlockStart)item).Tag) == fromIndex)
                {
                    ((BlockStart)item).joint = tag;
                    //MessageBox.Show(((BlockStart)item).joint.ToString());
                    break;
                }
            }
        }

        public static PictureBox fromPic, jointPic;
        public static Dictionary<PictureBox, PictureBox> drawPoints = new Dictionary<PictureBox, PictureBox>();
        public static void SwapIndex(int tag, object sender)
        {
            if (!swap)
            {
                //Získání hodnoty pro určení počátku
                fromIndex = tag;
                fromPic = (PictureBox)sender;
            }
            else if(swap && tag != 0)
            {
                jointPic = (PictureBox)sender;

                if (!drawPoints.ContainsKey(fromPic))
                    drawPoints.Add(fromPic, jointPic);
                else
                {
                    drawPoints.Remove(fromPic);
                    drawPoints.Add(fromPic, jointPic);
                }

                ResetJoint(tag);
                SetJoint(tag);
            }
        }
    }
}