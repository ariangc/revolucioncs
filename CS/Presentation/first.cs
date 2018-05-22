using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Visible = false;

            signInForm signIn = new signInForm();
            signIn.ShowDialog();
        }

        private void first_Load(object sender, EventArgs e)
        {

        }
    }
}
