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
            Process,
            Output,
            EndCycle
        }
       
        public static Panel? pracPanel;
        public static Dictionary<int, Type> indexes= new Dictionary<int, Type>();

        //Indexace Blocků
        public static int BlockIndex(Type type)
        {            
            int index = indexes.Count() > 0 ? indexes.Keys.Max() + 1 : 1;
            indexes.Add(index, type);

            return index;
        }

        //Delete block
        public static IBlock markedBlock;
        public static void DeleteBlock(IBlock block)
        {
            if (block.type == Block.Type.Var && ((BlockVar)block).accessValue[0] != null)
            {
                string key = ((BlockVar)block).accessValue[0];
                if (Promenne.Int16V.ContainsKey(key))
                    Promenne.Int16V.Remove(key);
                if (Promenne.Int32V.ContainsKey(key))
                    Promenne.Int32V.Remove(key);
                if (Promenne.Int64V.ContainsKey(key))
                    Promenne.Int64V.Remove(key);
                if (Promenne.FloatV.ContainsKey(key))
                    Promenne.FloatV.Remove(key);
                if (Promenne.DoubleV.ContainsKey(key))
                    Promenne.DoubleV.Remove(key);
                if (Promenne.BoolV.ContainsKey(key))
                    Promenne.BoolV.Remove(key);
                if (Promenne.StringV.ContainsKey(key))
                    Promenne.StringV.Remove(key);
                if (Promenne.CharV.ContainsKey(key))
                    Promenne.CharV.Remove(key);

                Promenne.usedNames.Remove(key);
            }            

            //Dispose
            ((PictureBox)block).Dispose();

            //Remove from drawPoints
            try
            {
                drawPoints.Remove((PictureBox)block);
                var item = drawPoints.First(kvp => kvp.Value == (PictureBox)block);
                drawPoints.Remove(item.Key);
            }
            catch (Exception){}
        }

        //Block instances
        public static void BlockVar(string nazev, string hodnota, string prikaz)
        {
            _ = new BlockVar(nazev, hodnota, prikaz);
        }

        public static void BlockCon(string prikaz)
        {
            _ = new BlockCon(prikaz);
        }

        public static void BlockSwitch(int pocetMoznosti, string vstupPromenna, List<string> boxy)
        {
            _ = new BlockSwitches(pocetMoznosti, vstupPromenna, boxy);
        }

        public static void BlockCycleFor(string nazev, string pocatek, string konec, string inkrement)
        {
            _ = new BlockCycles(nazev, pocatek, konec, inkrement);
        }

        public static void BlockCycleWhileOrDoWhile(string condition, string type)
        {
            _ = new BlockCycles(condition, type);
        }

        public static void BlockProcess(string input)
        {
            _ = new BlockProcess(input);
        }

        public static void BlockOutput(string input)
        { 
            _ = new BlockOutput(input);    
        }

        public static void BlockCycleEnd(string name)
        { 
            _ = new BlockCycleEnd(name);
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
            //Joint control
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

            //Block marking
            if (e.Button == MouseButtons.Left)
                markedBlock = (IBlock)sender;
        }

        public static void ResetJoint(int tag)
        {
            foreach (Control item in pracPanel.Controls)
            {
                if (item is IBlock && ((IBlock)item).joint == tag)
                {
                    ((IBlock)item).joint = null;
                    break;
                }                
            }
        }


        public static void SetJoint(int tag)
        {
            foreach (Control item in pracPanel.Controls)
            {
                if (item is IBlock && Convert.ToInt16(item.Tag) == fromIndex)
                {
                    ((IBlock)item).joint = tag;
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