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

namespace Presentation {
    public partial class SearchLegalClient : Form {

        private LegalClientBL legalClientBL;
        

        public SearchLegalClient() {
            InitializeComponent();
            legalClientBL = new LegalClientBL();
            dataGridView1.AutoGenerateColumns = false;
            this.CenterToScreen();
            textBox3.Text = Constants.CurrentUserText;
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
        }

        private void dniModifyClientTextBox_TextChanged(object sender, EventArgs e) {
            dataGridView1.DataSource = legalClientBL.listLegalClients(rucTextBox.Text, companyNameTextBox.Text);
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e) {
            dataGridView1.DataSource = legalClientBL.listLegalClients(rucTextBox.Text, companyNameTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            rucTextBox.Text = "";
            companyNameTextBox.Text = "";
            dataGridView1.DataSource = legalClientBL.listLegalClients("", "");
        }

        private void searchButon_Click(object sender, EventArgs e) {
            SelectedClient = (LegalClient)dataGridView1.CurrentRow.DataBoundItem;
            this.Close();
        }

        public LegalClient SelectedClient { get; set; }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }
    }
}
