using BussinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class RequestManagement : Form
    {
        //private RequestBL bussinessLogic;
        public RequestManagement()
        {
            InitializeComponent();
            this.CenterToScreen();

            //añadir las encuestas al datagridview
         //   bussinessLogic = new RequestBL();
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = bussinessLogic.listRequests();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            if (requestTextBox.Text != "")
            {
                if (RequestRadioButton.Checked == false && problemRadioButton.Checked == false && otherRadioButton.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar un tipo de solicitud", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //se logra enviar solicitud
                    Request r = new Request();
                    r.Description = requestTextBox.Text;
                    if (RequestRadioButton.Checked == true) r.Type2 = 0;
                    else if (problemRadioButton.Checked == true) r.Type2 = 1;
                    else r.Type2 = 2;
                    r.Username = 12345678;
         //           bussinessLogic.newRequest(r);

                    MessageBox.Show("Solicitud enviada", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    requestTextBox.Text = "";
                    RequestRadioButton.Checked = false;
                    problemRadioButton.Checked = false;
                    otherRadioButton.Checked = false;
                }
                
            }
            else if (requestTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar su solicitud", "Estado de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
