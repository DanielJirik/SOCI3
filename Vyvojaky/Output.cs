using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Output
    {
        public Output() 
        { 
            
        }

        public void Processing(string input, bool creation)
        {
            if (Promenne.FindVar(input, "type") != null)
            {
                if (creation) 
                {
                    Creation(input);
                }
                else
                {
                    MessageBox.Show($"Output: {Promenne.FindVar(input, "value")}");
                }
            }
            else
            {
                if (input[0] == '"' && input[input.Length - 1] == '"')
                {
                    if (creation)
                    {
                        Creation(input);
                    }
                    else
                    {
                        MessageBox.Show($"Output: {input}");
                    }
                }
                else if (input[0].ToString() == "'" && input[input.Length - 1].ToString() == "'")
                {
                    if (creation)
                    {
                        Creation(input);
                    }
                    else
                    {
                        MessageBox.Show($"Output: {input}");
                    }
                }
                else if (int.TryParse(input, out int a))
                {
                    if (creation)
                    {
                        Creation(a.ToString());
                    }
                    else
                    {
                        MessageBox.Show($"Output: {a.ToString()}");
                    }
                }
                else if (float.TryParse(input, out float b))
                {
                    if (creation)
                    {
                        Creation(b.ToString());
                    }
                    else
                    {
                        MessageBox.Show($"Output: {b.ToString()}");
                    }
                }
                else if (double.TryParse(input, out double c))
                {
                    if (creation)
                    {
                        Creation(c.ToString());
                    }
                    else
                    {
                        MessageBox.Show($"Output: {c.ToString()}");
                    }
                }
                else if (bool.TryParse(input, out bool d))
                {
                    if (creation)
                    {
                        Creation(d.ToString());
                    }
                    else
                    {
                        MessageBox.Show($"Output: {d.ToString()}");
                    }
                }
                else
                {
                    MessageBox.Show("Něco je špatně!");
                }
            }
        }

        public static void Creation(string input)
        {
            Block.BlockOutput(input);
        }
    }
}
