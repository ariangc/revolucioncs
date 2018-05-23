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
    public partial class SellsManagement : Form
    {
        private ProductBL productBL;
        private NaturalClientBL naturalClientBL;
        private LegalClientBL legalClientBL;

        static int cliente = 0;
        static int productos = 0;
        static double totalSale = 0.0;

        private BindingList<Product> listAdded;

        public SellsManagement()
        {
            cliente = productos = 0;
            InitializeComponent();
            this.CenterToScreen();

            label2.Text = Constants.CurrentUserText;

            productBL = new ProductBL();
            naturalClientBL = new NaturalClientBL();
            legalClientBL = new LegalClientBL();

            DateTime thisDay = DateTime.Today;
            fechaTextBox.Text = thisDay.ToString("d");

            dataGridView3.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            listAdded = new BindingList<Product>();
            dataGridView2.DataSource = productBL.listProducts();
            dataGridView3.DataSource = listAdded;
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
            String docClient = textBox1.Text;
            String document = (comboBox1.SelectedIndex == 0 ? "DNI" : "RUC");
            if (docClient.Equals("")) {
                MessageBox.Show("Por favor, inserte el " + document + " del cliente", "Falta " + document, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((document == "DNI" && docClient.Length != 8) || (document == "RUC" && docClient.Length != 11) || !docClient.All(char.IsDigit)) {
                MessageBox.Show("Por favor, inserte un " + document + " valido", document + " invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listAdded.Count == 0) {
                MessageBox.Show("Por favor, ingrese los productos a vender", "No hay productos seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (document == "DNI") {
                    int idNaturalClient = naturalClientBL.searchNaturalClient(docClient);
                    if (idNaturalClient == -1) {
                        MessageBox.Show("No se encontró un cliente con DNI " + docClient, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Se deberia insertar Ticket", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    int idLegalClient = legalClientBL.searchLegalClient(docClient);
                    if (idLegalClient == -1) {
                        MessageBox.Show("No se encontró un cliente con RUC " + docClient, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Se deberia insertar Ticket", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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

            dataGridView2.DataSource = productBL.listProductsByName(productName);
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e) {
            String productName = textBox2.Text;
            String symptoms = textBox6.Text;

            dataGridView2.DataSource = productBL.listProductsByName(productName);
        }

        private void textBox6_TextChanged(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {
            String quantity = textBox7.Text;
            if (quantity.Equals("")) {
                MessageBox.Show("Por favor ingrese la cantidad a vender", "Falta cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int quantitySale;
                if (Int32.TryParse(quantity, out quantitySale)) {
                    Product p = (Product)dataGridView2.CurrentRow.DataBoundItem;
                    p.QuantitySale = quantitySale;

                    listAdded.Add(p);
                    dataGridView3.DataSource = listAdded;
                    totalSale += p.Subtotal;
                    textBox8.Text = totalSale.ToString("0.00");
                    MessageBox.Show("Producto " + p.Name + " agregado " + listAdded.Count, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Ingrese una cantidad numerica", "Cantidad no numerica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            int positionDelete = dataGridView3.CurrentRow.Index;
            totalSale -= listAdded[positionDelete].Subtotal;
            textBox8.Text = totalSale.ToString("0.00");

            listAdded.RemoveAt(positionDelete);
            dataGridView3.DataSource = listAdded;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) label3.Text = "DNI del Cliente";
            else label3.Text = "RUC de la Empresa";
        }

        private void label3_Click_1(object sender, EventArgs e) {

        }
    }
}
