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
using Utils;

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
            label2.Text = Constants.CurrentUserText;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
        }

        private void dniModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButon_Click(object sender, EventArgs e)
        {
            String ruc = rucModifyTextBox.Text;
            String name = companyNameModifyTextBox.Text;
            dataGridView1.DataSource =  legalClientBL.searchLegalClients(ruc, name);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            rucModifyTextBox.Text = "";
            companyNameModifyTextBox.Text = "";
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
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

        private bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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

            else if (!isValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("El campo E-mail debe ser correo electronico válido", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //se logra la conexión con la BD
                LegalClient lc = new LegalClient();
                lc.Address = address;
                lc.RUC = ruc;
                lc.PhoneNumber = phone;
                lc.CompanyName = companyName;
                lc.Email = email;
                try
                {
                    legalClientBL.addLegalClient(lc);
                }catch(Exception ex)
                {
                    MessageBox.Show("Ya existe este cliente con RUC "+ruc, "Error al añadir cliente jurídico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
                MessageBox.Show("El cliente ha sido registrado", "Registro de cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyClientButton_Click(object sender, EventArgs e)
        {
            EditLegalClient elc = new EditLegalClient((LegalClient)dataGridView1.CurrentRow.DataBoundItem);
            this.Hide();
            elc.ShowDialog();
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
            this.Show();
        }
    }
}
