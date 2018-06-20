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

            textBox4.Text = Constants.CurrentUserText;

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
            label4.ForeColor = Color.Black;
        }

        private void dniTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
        }

        private void lastnameTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void districtTextBox_TextChanged(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void districtTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void phoneTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Black;   
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
           
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

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string dni = dniTextBox.Text;
            string name = nameTextBox.Text;
            string surname = lastnameTextBox.Text;
            string district = districtTextBox.Text;
            string email = emailTextBox.Text;
            string phoneNumber = phoneTextBox.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.DniRegex, dni, ref flagOK)) label4.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.NameRegex, name, ref flagOK)) label6.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.SurnameRegex, surname, ref flagOK)) label8.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PlaceRegex, district, ref flagOK)) label5.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.PhoneRegex, phoneNumber, ref flagOK)) label7.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.EmailRegex, email, ref flagOK)) label10.ForeColor = Color.Red;

            if (flagOK) {
                NaturalClient nc = new NaturalClient();
                nc.Dni = dni; nc.Name = name; nc.Surname = surname; nc.Address = district; nc.Email = email; nc.PhoneNumber = phoneNumber;
                try {
                    naturalClientBL.addNaturalClient(nc);
                    MessageBox.Show("El cliente ha sido registrado", "Registro de cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dniTextBox.Clear();
                    nameTextBox.Clear();
                    lastnameTextBox.Clear();
                    districtTextBox.Clear();
                    emailTextBox.Clear();
                    phoneTextBox.Clear();
                }
                catch (Exception ex) {
                    MessageBox.Show("¡Existe un cliente con el mismo DNI!", "Error al añadir cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Uno o más campos son incorrectos. Revise los campos en rojo.", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            String dni = dniModifyClientTextBox.Text;
            String name = nameModifyClientTextBox.Text;
            String surname = surnameModifyClientTextBox.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.IntegerRegex, dni, ref flagOK)) label12.ForeColor = Color.Red;
            else label12.ForeColor = Color.Black;

            dataGridView1.DataSource = naturalClientBL.searchNaturalClients(dni, name, surname);
        }

        private void dniModifyClientTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String dni = dniModifyClientTextBox.Text;
            String name = nameModifyClientTextBox.Text;
            String surname = surnameModifyClientTextBox.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.NameRegex, name, ref flagOK)) label13.ForeColor = Color.Red;
            else label13.ForeColor = Color.Black;

            dataGridView1.DataSource = naturalClientBL.searchNaturalClients(dni, name, surname);
        }

        private void surnameModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {
            String dni = dniModifyClientTextBox.Text;
            String name = nameModifyClientTextBox.Text;
            String surname = surnameModifyClientTextBox.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.SurnameRegex, surname, ref flagOK)) label14.ForeColor = Color.Red;
            else label14.ForeColor = Color.Black;

            dataGridView1.DataSource = naturalClientBL.searchNaturalClients(dni, name, surname);
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

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.DniRegex, dni, ref flagOK)) label12.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.NameRegex, name, ref flagOK)) label13.ForeColor = Color.Red;
            if (!DataValidation.ValidField(Constants.SurnameRegex, surname, ref flagOK)) label14.ForeColor = Color.Red;

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

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void RegisterTabControl_Click(object sender, EventArgs e) {

        }
    }
}
