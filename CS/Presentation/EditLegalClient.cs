﻿using System;
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
    public partial class EditLegalClient : Form
    {
        private LegalClient selectedClient;
        private LegalClientBL legalClientBL;
        public EditLegalClient(LegalClient lc)
        {
            InitializeComponent();
            legalClientBL = new LegalClientBL();
            selectedClient = lc;
            textBox1.Text = Constants.CurrentUserText;
            textBox2.Text = selectedClient.CompanyName;
            textBox4.Text = selectedClient.Address;
            textBox5.Text = selectedClient.PhoneNumber;
            textBox6.Text = selectedClient.Email;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            this.CenterToScreen();
        }

        private void namesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (namesCheckBox.Checked) textBox2.Enabled = true;
            else textBox2.Enabled = false;
        }

        private void districtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namesCheckBox.Checked || districtCheckBox.Checked || phoneCheckBox.Checked || emailCheckBox.Checked)
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta Seguro de que desea cambiar el/los campo(s)?", "Cambio de cmapos de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Debe ingresar algún campo", "Cambio de cmapos de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            namesCheckBox.ForeColor = Color.Black;
        }

        private void districtCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (districtCheckBox.Checked) textBox4.Enabled = true;
            else textBox4.Enabled = false;
        }

        private void phoneCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (phoneCheckBox.Checked) textBox5.Enabled = true;
            else textBox5.Enabled = false;
        }

        private void emailCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (emailCheckBox.Checked) textBox6.Enabled = true;
            else textBox6.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e) {
            string companyName = textBox2.Text;
            string address = textBox4.Text;
            string phoneNumber = textBox5.Text;
            string email = textBox6.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.CompanyNameRegex, companyName, ref flagOK)) namesCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PlaceRegex, address, ref flagOK)) districtCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PhoneRegex, phoneNumber, ref flagOK)) phoneCheckBox.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.EmailRegex, email, ref flagOK)) emailCheckBox.ForeColor = Color.Red;

            if (flagOK) {
                DialogResult result;
                result = MessageBox.Show("¿Esta Seguro de que desea cambiar el/los campo(s)?", "Cambio de cmapos de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes) {
                    if (namesCheckBox.Checked) selectedClient.CompanyName = companyName;
                    if (districtCheckBox.Checked) selectedClient.Address = address;
                    if (phoneCheckBox.Checked) selectedClient.PhoneNumber = phoneNumber;
                    if (emailCheckBox.Checked) selectedClient.Email = email;
                    legalClientBL.updateLegalClient(selectedClient);
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

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            districtCheckBox.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            phoneCheckBox.ForeColor = Color.Black;
        }

        private void textBox6_TextChanged(object sender, EventArgs e) {
            emailCheckBox.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}