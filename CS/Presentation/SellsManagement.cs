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
    public partial class SellsManagement : Form
    {
        private ProductBL productBL;

        static int cliente = 0;
        static int productos = 0;


        public SellsManagement()
        {
            cliente = productos = 0;
            InitializeComponent();
            this.CenterToScreen();

            productBL = new ProductBL();

            DateTime thisDay = DateTime.Today;
            fechaTextBox.Text = thisDay.ToString("d");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            dataGridView2.DataSource = productBL.listProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (cliente == 0) {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                cliente++;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e) {
            if (cliente == 0) {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            if (productos == 0) {
                fechaTextBox.Text = "";
                fechaTextBox.ForeColor = Color.Black;
                productos++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            MessageBox.Show("La venta ha sido registrada", "Registro de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) {
            
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) {
            String productName = textBox2.Text;
            String symptoms = textBox6.Text;
            if (productName.Equals("") && symptoms.Equals("")) {
                MessageBox.Show("Por favor ingrese el nombre del producto o el sintoma a buscar", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!productName.Equals("")) {
                dataGridView2.DataSource = productBL.listProductsByName(productName);
            }
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e) {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) {

        }
    }
}
