using System.Runtime.CompilerServices;

namespace Vyvojaky
{
    public partial class formUvitaci : Form
    {

        public formUvitaci()
        {
            InitializeComponent();
        }


        private void btNovySoubor_Click(object sender, EventArgs e)
        {
            Form tvorba = new formHlavniProTvorbu();
            tvorba.Show();
            this.Hide();
        }
    }
}
