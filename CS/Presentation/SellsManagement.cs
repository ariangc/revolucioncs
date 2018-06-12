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
        private TicketBL ticketBL;
        private EmployeeBL employeeBL;

        static int cliente = 0;
        static int productos = 0;
        static double totalSale = 0.0;

        private BindingList<Product> listAdded;

        public SellsManagement()
        {
            cliente = productos = 0;
            InitializeComponent();
            this.CenterToScreen();
            
            productBL = new ProductBL();
            naturalClientBL = new NaturalClientBL();
            legalClientBL = new LegalClientBL();
            ticketBL = new TicketBL();

            DateTime thisDay = DateTime.Today;
            fechaTextBox.Text = thisDay.ToString("d");

            dataGridView3.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;

            listAdded = new BindingList<Product>();
            dataGridView2.DataSource = productBL.listProducts();
            dataGridView3.DataSource = listAdded;

            textBox4.Text = Constants.CurrentUserText;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.SelectedIndex);
            if (comboBox1.SelectedIndex == 0) {
                SearchNaturalClient snc = new SearchNaturalClient();
                this.Hide();
                snc.ShowDialog();
                this.Show();
                NaturalClient nc = snc.ClientSelected;
                if (nc != null) {
                    textBox1.Text = nc.Dni;
                    textBox3.Text = nc.Name + " " + nc.Surname;
                }
            }
            else {
                Console.WriteLine("Searching Legal Client");
                SearchLegalClient slc = new SearchLegalClient();
                this.Hide();
                slc.ShowDialog();
                this.Show();
                LegalClient lc = slc.SelectedClient;
                if (lc != null) {
                    textBox1.Text = lc.RUC;
                    textBox3.Text = lc.CompanyName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Venta Registrada", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ticketBL.addTicket(listAdded, idNaturalClient, Constants.CurrentUserID, 0, checkBox1.Checked);
                        dataGridView2.DataSource = productBL.listProductsByName("");
                        listAdded.Clear();
                        dataGridView3.DataSource = listAdded;
                    }
                }
                else {
                    int idLegalClient = legalClientBL.searchLegalClient(docClient);
                    if (idLegalClient == -1) {
                        MessageBox.Show("No se encontró un cliente con RUC " + docClient, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Venta Registrada", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ticketBL.addTicket(listAdded, idLegalClient, Constants.CurrentUserID, 1, checkBox1.Checked);
                        dataGridView2.DataSource = productBL.listProductsByName("");
                        listAdded.Clear();
                        dataGridView3.DataSource = listAdded;
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

            dataGridView2.DataSource = productBL.lstProductXTagByLetters(symptoms);
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
                    Product selectedProd = (Product)dataGridView2.CurrentRow.DataBoundItem;
                    if(selectedProd.TotalItems < quantitySale)
                    {
                        MessageBox.Show("La cantidad solicitada es mayor al stock disponible del producto: " + selectedProd.Name , "Insuficiente Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int pos = 0, flag = 1;
                    foreach (Product x in listAdded) {
                        if (x.Id == selectedProd.Id) {
                            flag = 0;
                        }
                        if (flag == 0) break;
                        pos++;
                    }
                    Product p;

                    if (flag == 0) {
                        p = listAdded[pos];
                        totalSale -= p.Subtotal;
                        p.QuantitySale += quantitySale;
                        totalSale += p.Subtotal;
                    }
                    else {
                        p = new Product(selectedProd.Id, selectedProd.Name, selectedProd.Price, selectedProd.NeedsPrescription, selectedProd.Utility, selectedProd.Points);
                        p.QuantitySale = quantitySale;
                        listAdded.Add(p);
                        totalSale += p.Subtotal;
                    }
                    
                    dataGridView3.DataSource = listAdded;
                    textBox8.Text = totalSale.ToString("0.00");
                    textBox2.Text = ""; textBox6.Text = ""; textBox7.Text = "";
                    dataGridView2.DataSource = productBL.listProductsByName("");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = "DNI del Cliente";
                label10.Text = "Nombre completo";
                
            }
            else
            {
                label3.Text = "RUC de la Empresa";
                label10.Text = "Razon Social";
            }
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void label3_Click_1(object sender, EventArgs e) {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.SelectedIndex);
            if (comboBox1.SelectedIndex == 0) {
                SearchNaturalClient snc = new SearchNaturalClient();
                this.Hide();
                snc.ShowDialog();
                this.Show();
                NaturalClient nc = snc.ClientSelected;
                if (nc != null) {
                    textBox1.Text = nc.Dni;
                    textBox3.Text = nc.Name + " " + nc.Surname;
                }
            }
            else {
                Console.WriteLine("Searching Legal Client");
                SearchLegalClient slc = new SearchLegalClient();
                this.Hide();
                slc.ShowDialog();
                this.Show();
                LegalClient lc = slc.SelectedClient;
                if (lc != null) {
                    textBox1.Text = lc.RUC;
                    textBox3.Text = lc.CompanyName;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
