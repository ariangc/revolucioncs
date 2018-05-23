using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BussinessLogic;

namespace Presentation
{
    public partial class LegalClientManagement : Form
    {
        private LegalClientBL legalClientBL;
        public LegalClientManagement()
        {
            InitializeComponent();
            legalClientBL = new LegalClientBL();
            this.CenterToScreen();
        }

        private void dniModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButon_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ruc = rucTextBox.Text;
            String phone = phoneTextBox.Text;
            String email = emailTextBox.Text;
            String address = addressTextBox.Text;
            String companyName = companyNameTextBox.Text;

            if(ruc.Length != 11 || !ruc.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un RUC correcto", "Ruc invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ruc.Equals("") || phone.Equals("") || email.Equals("") || address.Equals("") || companyName.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos", "Campos incompletas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese un numero telefonico correcto", "Telefono incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LegalClient lc = new LegalClient();
                lc.Address = address;
                lc.RUC = ruc;
                lc.PhoneNumber = phone;
                lc.CompanyName = companyName;
                lc.Email = email;
                legalClientBL.addLegalClient(lc);
                MessageBox.Show("El cliente ha sido registrado", "Registro de cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyClientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
