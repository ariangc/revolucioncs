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
    public partial class RequestManagement : Form
    {
        public RequestManagement()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            if (requestTextBox.Text != "")
            {
                if (RequestRadioButton.Checked == false && problemRadioButton.Checked == false && otherRadioButton.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar un tipo de solicitud", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Solicitud enviada", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    requestTextBox.Text = "";
                    RequestRadioButton.Checked = false;
                    problemRadioButton.Checked = false;
                    otherRadioButton.Checked = false;
                }
                
            }
            else if (requestTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar su solicitud", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
