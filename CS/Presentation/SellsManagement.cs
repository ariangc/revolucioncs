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
    public partial class SellsManagement : Form {
        private ProductBL productBL;
        private NaturalClientBL naturalClientBL;
        private LegalClientBL legalClientBL;
        private TicketBL ticketBL;
        private EmployeeBL employeeBL;

        private int cliente = 0;
        private int productos = 0;
        private double totalSale = 0.0;
        private double totalSaleDisc = 0.0;

        private BindingList<Product> listAdded;
        private Dictionary<int, double> discountFactor;
        private Dictionary<int, int> addedQuantity;
        private int idClient = -1;

        public SellsManagement() {
            cliente = productos = 0;
            InitializeComponent();
            this.CenterToScreen();

            productBL = new ProductBL();
            naturalClientBL = new NaturalClientBL();
            legalClientBL = new LegalClientBL();
            ticketBL = new TicketBL();

            addedQuantity = new Dictionary<int, int>();

            DateTime thisDay = DateTime.Today;
            fechaTextBox.Text = thisDay.ToString("d");

            dataGridView3.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;

            listAdded = new BindingList<Product>();
            dataGridView2.DataSource = productBL.listProducts();
            dataGridView3.DataSource = listAdded;

            textBox4.Text = Constants.CurrentUserText;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            textBox2.Show();
            textBox6.Hide();

            BindingList<Product> products = productBL.listProducts();

            foreach (Product p in products) {
                addedQuantity.Add(p.Id, 0);
            }
        }

        private void updateDictionary() {
            if (idClient != -1) {
                discountFactor = ticketBL.getDiscounts(listAdded, idClient, (comboBox1.SelectedIndex));
                totalSaleDisc = 0;
                foreach (Product p in listAdded) {
                    if (discountFactor.ContainsKey(p.Id)) p.SubtotalDisc = p.Subtotal * discountFactor[p.Id];
                    else p.SubtotalDisc = p.Subtotal;
                    totalSaleDisc += p.SubtotalDisc;
                }
            }
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
                    updateDictionary();
                    if (idNaturalClient == -1) {
                        MessageBox.Show("No se encontró un cliente con DNI " + docClient, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Venta a Cliente Natural Registrada", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ticketBL.addTicket(listAdded, idNaturalClient, Constants.CurrentUserID, 0, discountFactor);
                        dataGridView2.DataSource = productBL.listProductsByName("");
                        listAdded.Clear();
                        dataGridView3.DataSource = listAdded;
                        totalSale = 0.0;
                        totalSaleDisc = 0.0;
                        textBox8.Text = ""; textBox5.Text = ""; textBox9.Text = "";
                        idClient = -1;
                        textBox1.Text = ""; textBox3.Text = ""; pointsTextBox.Text = "";
                        addedQuantity.Clear();
                        BindingList<Product> products = productBL.listProducts();
                        foreach (Product p in products) {
                            addedQuantity.Add(p.Id, 0);
                        }
                    }
                }
                else {
                    int idLegalClient = legalClientBL.searchLegalClient(docClient);
                    updateDictionary();
                    if (idLegalClient == -1) {
                        MessageBox.Show("No se encontró un cliente con RUC " + docClient, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Venta a Cliente jurídico Registrada", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ticketBL.addTicket(listAdded, idLegalClient, Constants.CurrentUserID, 1, discountFactor);
                        dataGridView2.DataSource = productBL.listProductsByName("");
                        listAdded.Clear();
                        dataGridView3.DataSource = listAdded;
                        totalSale = 0.0;
                        totalSaleDisc = 0.0;
                        textBox8.Text = ""; textBox5.Text = ""; textBox9.Text = "";
                        idClient = -1;
                        textBox1.Text = ""; textBox3.Text = ""; pointsTextBox.Text = "";
                        addedQuantity.Clear();
                        BindingList<Product> products = productBL.listProducts();
                        foreach (Product p in products) {
                            addedQuantity.Add(p.Id, 0);
                        }
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
            
        }

        private void textBox2_TextChanged_2(object sender, EventArgs e) {
            String productName = textBox2.Text;
            String symptoms = textBox6.Text;

            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.NameRegex, productName, ref flagOK)) label13.ForeColor = Color.Red;
            else label13.ForeColor = Color.Black;

            dataGridView2.DataSource = productBL.listProductsByName(productName);
        }

        private void textBox6_TextChanged(object sender, EventArgs e) {
            String productName = textBox2.Text;
            String symptoms = textBox6.Text;

            dataGridView2.DataSource = productBL.lstProductXTagByLetters(symptoms);
        }

        private void button6_Click(object sender, EventArgs e) {
            String quantity = textBox7.Text;
            Console.WriteLine("ID del cliente: " + idClient);
            bool flagOK = true;
            if (quantity.Equals("")) {
                MessageBox.Show("Por favor ingrese la cantidad a vender", "Falta cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!DataValidation.ValidField(Constants.IntegerRegex, quantity, ref flagOK)){
                MessageBox.Show("Por favor ingrese una cantidad correcta vender", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idClient == -1) {
                MessageBox.Show("Por favor, primero seleccione el cliente", "Falta cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int quantitySale;
                if (Int32.TryParse(quantity, out quantitySale)) {
                    Product selectedProd = (Product)dataGridView2.CurrentRow.DataBoundItem;
                    if (selectedProd.TotalItems < addedQuantity[selectedProd.Id] + quantitySale) {
                        MessageBox.Show("La cantidad solicitada es mayor al stock disponible del producto: " + selectedProd.Name, "Insuficiente Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        p.QuantitySale += quantitySale;;
                        totalSale += p.Subtotal;
                    }
                    else {
                        p = new Product(selectedProd.Id, selectedProd.Name, selectedProd.Price, selectedProd.NeedsPrescription, selectedProd.Utility, selectedProd.Points);
                        p.QuantitySale = quantitySale;
                        listAdded.Add(p);
                        totalSale += p.Subtotal;
                    }

                    updateDictionary();
                    dataGridView3.DataSource = listAdded;
                    textBox8.Text = totalSale.ToString("0.00");
                    textBox5.Text = totalSaleDisc.ToString("0.00");
                    if (checkBox1.Checked) {
                        textBox9.Text = textBox5.Text;
                    }
                    else {
                        textBox9.Text = textBox8.Text;
                    }
                    textBox2.Text = ""; textBox6.Text = ""; textBox7.Text = "";
                    addedQuantity[p.Id] += quantitySale;
                    dataGridView2.DataSource = productBL.listProductsByName("");
                    dataGridView3.DataSource = listAdded;
                }
                else {
                    MessageBox.Show("Ingrese una cantidad numerica", "Cantidad no numerica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            if (idClient != -1) {
                int positionDelete = dataGridView3.CurrentRow.Index;
                totalSale -= listAdded[positionDelete].Subtotal;
                totalSaleDisc -= listAdded[positionDelete].SubtotalDisc;
                textBox8.Text = totalSale.ToString("0.00");
                textBox5.Text = totalSaleDisc.ToString("0.00");
                if (checkBox1.Checked) {
                    textBox9.Text = textBox5.Text;
                }
                else {
                    textBox9.Text = textBox8.Text;
                }
                textBox2.Text = ""; textBox6.Text = ""; textBox7.Text = "";
                addedQuantity[listAdded[positionDelete].Id] -= listAdded[positionDelete].QuantitySale;
                listAdded.RemoveAt(positionDelete);
                dataGridView3.DataSource = listAdded;
                updateDictionary();
            }
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
            pointsTextBox.Text = "";
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
                    pointsTextBox.Text = nc.Points.ToString();

                    nc.IdPerson = naturalClientBL.searchNaturalClient(nc.Dni);

                    idClient = nc.IdPerson;
                    Console.WriteLine("ID del cliente natural: " + nc.IdPerson);
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
                    pointsTextBox.Text = lc.Points.ToString();

                    lc.IdPerson = legalClientBL.searchLegalClient(lc.RUC);
                    idClient = lc.IdPerson;
                    Console.WriteLine("ID del cliente legal: " + lc.IdPerson);
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string quantity = textBox7.Text;
            bool flagOK = true;

            if (!DataValidation.ValidField(Constants.IntegerRegex, quantity, ref flagOK)) label16.ForeColor = Color.Red;
            else label16.ForeColor = Color.Black;
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

        private void textBox8_TextChanged(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            String docClient = textBox1.Text;
            String document = (comboBox1.SelectedIndex == 0 ? "DNI" : "RUC");
            if (docClient.Equals("")) {
                if (checkBox1.Checked == false) return;
                MessageBox.Show("Por favor, inserte el " + document + " del cliente", "Falta " + document, MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox1.Checked = false;
            }
            else if ((document == "DNI" && docClient.Length != 8) || (document == "RUC" && docClient.Length != 11) || !docClient.All(char.IsDigit)) {
                MessageBox.Show("Por favor, inserte un " + document + " valido", document + " invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox1.Checked = false;
            }
            else {
                updateDictionary();
                if (checkBox1.Checked) {
                    dataGridView3.Columns[3].DataPropertyName = "SubtotalDisc";
                    textBox9.Text = textBox5.Text;
                }
                else {
                    dataGridView3.Columns[3].DataPropertyName = "Subtotal";
                    textBox9.Text = textBox8.Text;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {

        }

        private void textBox9_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine(comboBox2.SelectedIndex);
            if (comboBox2.SelectedIndex == 0) {
                
                textBox2.Show();
                textBox6.Hide();

                textBox2.Text = ""; textBox6.Text = "";
                label13.Text = "Nombre del Producto";
            }
            else {
                textBox2.Hide();
                textBox6.Show();

                textBox2.Text = ""; textBox6.Text = "";
                label13.Text = "Sintomas asociados";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void SellsManagement_Load(object sender, EventArgs e) {

        }
    }
}
