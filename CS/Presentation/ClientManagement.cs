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
using Utils;
using BussinessLogic;

namespace Presentation
{
    public partial class ClientManagement : Form
    {

        private static int dniModify;
        private static int nameModify;
        private static int surnameModify;

        private bool dgvFlag = false;

        private NaturalClientBL naturalClientBL;

        public ClientManagement()
        {
            
            dniModify = nameModify = surnameModify = 0;
            InitializeComponent();

            naturalClientBL = new NaturalClientBL();

            this.CenterToScreen();

            label2.Text = Constants.CurrentUserText;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = naturalClientBL.listNaturalClients("","","");
            dgvFlag = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ClientManagement_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            
        }

        private void dniTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dniTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lastnameTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void districtTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void districtTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void phoneTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(dniTextBox.Text== "" || nameTextBox.Text=="" || lastnameTextBox.Text=="" || districtTextBox.Text=="" || phoneTextBox.Text=="" || emailTextBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (dniTextBox.Text.Length != 8 || !dniTextBox.Text.All(char.IsDigit)) {
                MessageBox.Show("El campo DNI debe tener 8 dígitos", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phoneTextBox.Text.All(char.IsDigit)) {
                MessageBox.Show("El campo teléfono debe ser un número", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string name = nameTextBox.Text;
                string surname = lastnameTextBox.Text;
                string district = districtTextBox.Text;
                string email = emailTextBox.Text;

                NaturalClient nc = new NaturalClient();
                nc.Address = district;
                nc.Dni = dniTextBox.Text;
                nc.Name = name;
                nc.Surname = surname;
                nc.Email = email;
                nc.PhoneNumber = phoneTextBox.Text;

                naturalClientBL.addNaturalClient(nc);
                dataGridView1.DataSource = naturalClientBL.listNaturalClients("", "", "");

                MessageBox.Show("El cliente ha sido registrado", "Registro de cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dniTextBox.Text = "";
                nameTextBox.Text = "";
                lastnameTextBox.Text = "";
                districtTextBox.Text = "";
                phoneTextBox.Text = "";
                emailTextBox.Text = "";
            }
        }

        private void searchButon_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dniModifyClientTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void surnameModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameModifyClientTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void surnameModifyClientTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void searchButon_Click_1(object sender, EventArgs e)
        {
            String dni = dniModifyClientTextBox.Text;
            String name = nameModifyClientTextBox.Text;
            String surname = surnameModifyClientTextBox.Text;
            //dataGridView1.DataSource = naturalClientBL.listNaturalClients(dni, name, surname);
            dataGridView1.DataSource = naturalClientBL.searchNaturalClients(dni, name, surname);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dniModifyClientTextBox.Text = "";
            nameModifyClientTextBox.Text = "";
            surnameModifyClientTextBox.Text = "";
            dataGridView1.DataSource = naturalClientBL.listNaturalClients("","","");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvFlag) dataGridView1.DataSource = naturalClientBL.listNaturalClients("", "", "");
        }

        private void modifyClientButton_Click(object sender, EventArgs e)
        {
            NaturalClient nc = (NaturalClient)dataGridView1.CurrentRow.DataBoundItem;
            EditClient ec = new EditClient(nc);
            this.Hide();
            ec.ShowDialog();
            dataGridView1.DataSource = naturalClientBL.listNaturalClients("", "", "");
            this.Show();
        }

        private void ClientManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void clientTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
