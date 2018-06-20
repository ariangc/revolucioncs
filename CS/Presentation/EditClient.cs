using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogic;
using Model;
using Utils;

namespace Presentation
{
    public partial class EditClient : Form
    {
        private NaturalClientBL naturalClientBL;
        private NaturalClient selectedClient;
        public EditClient(NaturalClient nc)
        {
            InitializeComponent();
            naturalClientBL = new NaturalClientBL();
            selectedClient = nc;
            textBox1.Text = Constants.CurrentUserText;
            textBox2.Text = nc.Name;
            textBox3.Text = nc.Surname;
            textBox4.Text = nc.Address;
            textBox5.Text = nc.PhoneNumber;
            textBox6.Text = nc.Email;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void namesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (namesCheckBox.Checked) textBox2.Enabled = true;
            else textBox2.Enabled = false;
        }

        private void surnameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (surnameCheckBox.Checked) textBox3.Enabled = true;
            else textBox3.Enabled = false;
        }

        private void districtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (districtCheckBox.Checked) textBox4.Enabled = true;
            else textBox4.Enabled = false;
        }

        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneCheckBox.Checked) textBox5.Enabled = true;
            else textBox5.Enabled = false;
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (emailCheckBox.Checked) textBox6.Enabled = true;
            else textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string surname = textBox3.Text;
            string district = textBox4.Text;
            string phoneNumber = textBox5.Text;
            string email = textBox6.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.NameRegex, name, ref flagOK)) namesCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.SurnameRegex, surname, ref flagOK)) surnameCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PlaceRegex, district, ref flagOK)) districtCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PhoneRegex, phoneNumber, ref flagOK)) phoneCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.EmailRegex, email, ref flagOK)) emailCheckBox.ForeColor = Color.Red;

            if (flagOK) {
                DialogResult result;
                result = MessageBox.Show("¿Esta Seguro de que desea cambiar el/los campo(s)?", "Cambio de cmapos de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes) {
                    if (namesCheckBox.Checked) selectedClient.Name = name;
                    if (surnameCheckBox.Checked) selectedClient.Surname = surname;
                    if (districtCheckBox.Checked) selectedClient.Address = district ;
                    if (phoneCheckBox.Checked) selectedClient.PhoneNumber = phoneNumber;
                    if (emailCheckBox.Checked) selectedClient.Email = email;
                    naturalClientBL.updateNaturalClient(selectedClient);
                    MessageBox.Show("Se modifico al cliente", "Modificacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Uno o más campos son incorrectos. Revise los campos en rojo.", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            namesCheckBox.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            surnameCheckBox.ForeColor = Color.Black;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            districtCheckBox.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            phoneCheckBox.ForeColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) {
            emailCheckBox.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
