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
using Utils;
using Model;


namespace Presentation
{
    public partial class SearchNaturalClient : Form
    {
        private NaturalClientBL naturalClientBL;
        public SearchNaturalClient()
        {
            InitializeComponent();
            this.CenterToScreen();
            textBox3.Text = Constants.CurrentUserText;
            naturalClientBL = new NaturalClientBL();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = naturalClientBL.listNaturalClients("", "", "");
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {

        }

        private void dniModifyClientTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = naturalClientBL.listNaturalClients(dniModifyClientTextBox.Text, textBox1.Text, textBox2.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = naturalClientBL.listNaturalClients(dniModifyClientTextBox.Text, textBox1.Text, textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = naturalClientBL.listNaturalClients(dniModifyClientTextBox.Text, textBox1.Text, textBox2.Text);
        }

        private void searchButon_Click(object sender, EventArgs e)
        {
            ClientSelected = (NaturalClient) dataGridView1.CurrentRow.DataBoundItem;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dniModifyClientTextBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            dataGridView1.DataSource = naturalClientBL.listNaturalClients("", "", "");
        }

        public NaturalClient ClientSelected { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
