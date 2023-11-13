using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyvojaky
{
    public partial class formNovySoubor : Form
    {
        public formNovySoubor()
        {
            InitializeComponent();
        }

        private void btVytvorit_Click(object sender, EventArgs e)
        {
            Form tvorba = new formHlavniProTvorbu();
            tvorba.Show();
            this.Close();
        }

        private void formNovySoubor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!formHlavniProTvorbu.MainIsOpen)
                Environment.Exit(0);
        }
    }
}
