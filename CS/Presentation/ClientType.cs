using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Presentation
{
    public partial class ClientType : Form
    {
        public ClientType()
        {
            InitializeComponent();
            this.CenterToScreen();
            textBox1.Text = Constants.CurrentUserText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientManagement cm = new ClientManagement();

            this.Hide();
            cm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LegalClientManagement lcm = new LegalClientManagement();

            this.Hide();
            lcm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ClientType_Load(object sender, EventArgs e) {

        }
    }
}
