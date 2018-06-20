using BussinessLogic;
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
    public partial class changePassword : Form
    {
        private EmployeeBL bussinessLogic;
        public changePassword()
        {
            InitializeComponent();
            this.CenterToScreen();
            bussinessLogic = new EmployeeBL();
            textBox1.Text = Constants.CurrentUserText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!prevPasswordTextBox.Text.Equals(Constants.CurrentPassword)) {
                MessageBox.Show("La contraseña actual no es correcta", "Error en contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newPasswordTextBox.Text != repeatPasswordTextbox.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (prevPasswordTextBox.Text == newPasswordTextBox.Text)
            {
                MessageBox.Show("La contraseña nueva debe ser diferente a la anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Se reliza el cambio de contraseña
                string pass = newPasswordTextBox.Text;
                bussinessLogic.changePassword(pass);
                MessageBox.Show("La contraseña fue actualizada corectamente", "Contraseña Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
                
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void changePassword_Load(object sender, EventArgs e) {

        }
    }
}
