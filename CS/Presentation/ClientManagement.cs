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
        private static int dni;
        private static int name;
        private static int surname;
        private static int district;
        private static int phone;
        private static int email;

        private static int dniModify;
        private static int nameModify;
        private static int surnameModify;

        private NaturalClientBL naturalClientBL;

        public ClientManagement()
        {
            dni = name = surname = district = phone = email = 0;
            dniModify = nameModify = surnameModify = 0;
            InitializeComponent();

            naturalClientBL = new NaturalClientBL();

            this.CenterToScreen();

            label2.Text = Constants.CurrentUserText;

            /*
            dataGridView1.Rows.Add(71205561,"Sergio André","Rivas Medina","Chorrillos",987976060,"sergio.rivas@pucp.pe");
            dataGridView1.Rows.Add(71205562, "Daniela", "Argumanis Escalante", "Santiago de Surco", 960312264, "daniela.argumanis@pucp.pe");
            dataGridView1.Rows.Add(71205563, "Arian", "Gallardo Callalli", "San Miguel", 993128246, "arian.gallardo@pucp.pe");
            dataGridView1.Rows.Add(71205564, "Pato", "Ávila", "Pueblo Libre", 999909704, "patricio.avila@pucp.pe");
            dataGridView1.Rows.Add(71205565, "Patrick", "Figueroa", "San Miguel", 95906115, "patrick.figueroa@pucp.pe");
            dataGridView1.Rows.Add(66666666, "Daniel Marcelo", "Chapi Alejo", "Magdalena", 944441181, "daniel.chapi@pucp.pe");
            */

            dataGridView1.AutoGenerateColumns = false;
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
            if (dni == 0)
            {
                dniTextBox.Text = "";
                dniTextBox.ForeColor = Color.Black;
                dni++;
            }
        }

        private void dniTextBox_Click(object sender, EventArgs e)
        {
            if (dni == 0)
            {
                dniTextBox.Text = "";
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (name == 0)
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
                name++;
            }
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (name == 0)
            {
                nameTextBox.Text = "";
            }
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (surname == 0)
            {
                lastnameTextBox.Text = "";
                lastnameTextBox.ForeColor = Color.Black;
                surname++;
            }
        }

        private void lastnameTextBox_Click(object sender, EventArgs e)
        {
            if (surname == 0)
            {
                lastnameTextBox.Text = "";
            }
        }

        private void districtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (district == 0)
            {
                districtTextBox.Text = "";
                districtTextBox.ForeColor = Color.Black;
                district++;
            }
        }

        private void districtTextBox_Click(object sender, EventArgs e)
        {
            if (district == 0)
            {
                districtTextBox.Text = "";
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (phone == 0)
            {
                phoneTextBox.Text = "";
                phoneTextBox.ForeColor = Color.Black;
                phone++;
            }
        }

        private void phoneTextBox_Click(object sender, EventArgs e)
        {
            if (phone == 0)
            {
                phoneTextBox.Text = "";
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (email == 0)
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
                email++;
            }
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if (email == 0)
            {
                emailTextBox.Text = "";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool flagDNI = false;
            bool flagPhone = false;

            if(dniTextBox.Text== "" || nameTextBox.Text=="" || lastnameTextBox.Text=="" || districtTextBox.Text=="" || phoneTextBox.Text=="" || emailTextBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            int i = 0;
            string dni = dniTextBox.Text;
            while (i < dni.Length)
            {
                if (dni[i] < '0' || dni[i] > '9')
                {
                    flagDNI = true;
                    break;
                }
                i++;
            }

            i = 0;
            string phone = phoneTextBox.Text;
            while (i < phone.Length)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    flagPhone = true;
                    break;
                }
                i++;
            }

            if (dniTextBox.Text != "" && flagDNI) {
                MessageBox.Show("El campo DNI debe ser un número", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phoneTextBox.Text != "" && flagPhone) {
                MessageBox.Show("El campo teléfono debe ser un número", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string name = nameTextBox.Text;
                string surname = lastnameTextBox.Text;
                string district = districtTextBox.Text;
                string email = emailTextBox.Text;

                NaturalClient nc = new NaturalClient();
                nc.Address = district;
                nc.Dni = dni;
                nc.Name = name;
                nc.Surname = surname;
                nc.Email = email;
                nc.PhoneNumber = phone;

                naturalClientBL.addNaturalClient(nc);

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
            if (dniModify == 0)
            {
                dniModifyClientTextBox.Text = "";
                dniModifyClientTextBox.ForeColor = Color.Black;
                dniModify++;
            }
        }

        private void dniModifyClientTextBox_Click(object sender, EventArgs e)
        {
            if (dniModify == 0)
            {
                dniModifyClientTextBox.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (nameModify == 0)
            {
                nameModifyClientTextBox.Text = "";
                nameModifyClientTextBox.ForeColor = Color.Black;
                nameModify++;
            }
        }

        private void surnameModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {
            if (surnameModify == 0)
            {
                surnameModifyClientTextBox.Text = "";
                surnameModifyClientTextBox.ForeColor = Color.Black;
                surnameModify++;
            }
        }

        private void nameModifyClientTextBox_Click(object sender, EventArgs e)
        {
            if (nameModify == 0)
            {
                nameModifyClientTextBox.Text = "";
            }
        }

        private void surnameModifyClientTextBox_Click(object sender, EventArgs e)
        {
            if (surnameModify == 0)
            {
                surnameModifyClientTextBox.Text = "";
            }
        }

        private void searchButon_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }

            bool flag = true;
            for (int i = 0; i< dataGridView1.RowCount-1; i++)
            {
                if (dniModifyClientTextBox.Text == dataGridView1.Rows[i].Cells[0].Value.ToString()
                    || nameModifyClientTextBox.Text == dataGridView1.Rows[i].Cells[1].Value.ToString()
                    || surnameModifyClientTextBox.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    flag = false;
                }
                else
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
            if (flag) MessageBox.Show("No se encontró el cliente buscado", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dniModifyClientTextBox.Text = "";
                nameModifyClientTextBox.Text = "";
                surnameModifyClientTextBox.Text = "";
                dataGridView1.Rows[i].Visible = true;
            }
        }

        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void modifyClientButton_Click(object sender, EventArgs e)
        {
            EditClient ec = new EditClient();
            ec.ShowDialog();
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
