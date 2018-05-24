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
            if(namesCheckBox.Checked || surnameCheckBox.Checked || districtCheckBox.Checked || phoneCheckBox.Checked || emailCheckBox.Checked)
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta Seguro de que desea cambiar el/los campo(s)?", "Cambio de cmapos de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (namesCheckBox.Checked) selectedClient.Name = textBox2.Text;
                    if (surnameCheckBox.Checked) selectedClient.Surname = textBox3.Text;
                    if (districtCheckBox.Checked) selectedClient.Address = textBox4.Text;
                    if (phoneCheckBox.Checked) selectedClient.PhoneNumber = textBox5.Text;
                    if (emailCheckBox.Checked) selectedClient.Email = textBox6.Text;
                    naturalClientBL.updateNaturalClient(selectedClient);
                    MessageBox.Show("Se modifico al cliente", "Modificacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else MessageBox.Show("Debe ingresar algún campo", "Cambio de cmapos de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
