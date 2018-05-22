using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class UserSession : Form
    {

        public UserSession()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientManagement cm = new ClientManagement();

            this.Hide();
            cm.ShowDialog();
            this.Show();
        }

        private void signOutLabel_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Seguro que quiere cerrar sesión", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            
            this.Hide();
            cp.ShowDialog();
            this.Show();
        }

        private void UserSession_Load(object sender, EventArgs e)
        {
            
        }

        private void UserSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RequestsManageButton_Click(object sender, EventArgs e)
        {
            RequestManagement nr = new RequestManagement();
            nr.ShowDialog();
        }
        private void sellsManageButton_Click_1(object sender, EventArgs e) {
            SellsManagement sm = new SellsManagement();

            this.Hide();
            sm.ShowDialog();
            this.Show();
        }
    }
}
