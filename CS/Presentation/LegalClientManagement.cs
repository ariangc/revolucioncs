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
            textBox4.Text = Constants.CurrentUserText;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
        }

        private void dniModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {
            String ruc = rucModifyTextBox.Text;
            String name = companyNameModifyTextBox.Text;

            bool flagOK = true;
            if (!DataValidation.ValidField(Constants.IntegerRegex, ruc, ref flagOK)) label12.ForeColor = Color.Red;
            else label12.ForeColor = Color.Black;

            dataGridView1.DataSource = legalClientBL.searchLegalClients(ruc, name);
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

        private void button1_Click(object sender, EventArgs e) {
            String ruc = rucTextBox.Text;
            String phone = phoneTextBox.Text;
            String email = emailTextBox.Text;
            String address = addressTextBox.Text;
            String companyName = companyNameTextBox.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.RucRegex, ruc, ref flagOK)) label3.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.CompanyNameRegex, companyName, ref flagOK)) label5.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PlaceRegex, address, ref flagOK)) label8.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PhoneRegex, phone, ref flagOK)) label4.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.EmailRegex, email, ref flagOK)) label6.ForeColor = Color.Red;

            if (flagOK) {
                LegalClient lc = new LegalClient();
                lc.RUC = ruc; lc.PhoneNumber = phone; lc.Email = email; lc.Address = address; lc.CompanyName = companyName;
                try {
                    legalClientBL.addLegalClient(lc);
                    dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
                    MessageBox.Show("El cliente ha sido registrado", "Registro de cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show("Ya existe este cliente con RUC " + ruc, "Error al añadir cliente jurídico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Error en uno o más campos. Revise los campos en rojo.", "Campos incompletas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void modifyClientButton_Click(object sender, EventArgs e)
        {
            EditLegalClient elc = new EditLegalClient((LegalClient)dataGridView1.CurrentRow.DataBoundItem);
            this.Hide();
            elc.ShowDialog();
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e) {

        }

        private void rucTextBox_TextChanged(object sender, EventArgs e) {
            label3.ForeColor = Color.Black;
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e) {
            label5.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e) {
            label6.ForeColor = Color.Black;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e) {
            label8.ForeColor = Color.Black;
        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void companyNameModifyTextBox_TextChanged(object sender, EventArgs e) {
            String ruc = rucModifyTextBox.Text;
            String name = companyNameModifyTextBox.Text;

            bool flagOK = true;
            if (!DataValidation.ValidField(Constants.CompanyNameRegex, name, ref flagOK)) label13.ForeColor = Color.Red;
            else label12.ForeColor = Color.Black;

            dataGridView1.DataSource = legalClientBL.searchLegalClients(ruc, name);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
