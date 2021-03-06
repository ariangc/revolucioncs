﻿using BussinessLogic;
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
using Utils;

namespace Presentation
{
    public partial class RequestManagement : Form
    {
        private RequestBL bussinessLogic;
        private bool dgvFlag = false;
        public RequestManagement()
        {
            InitializeComponent();
            this.CenterToScreen();

            //añadir las encuestas al datagridview
            bussinessLogic = new RequestBL();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bussinessLogic.listRequests();
            dgvFlag = true;
            textBox1.Text = Constants.CurrentUserText;
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
                    if (RequestRadioButton.Checked == true) r.Type = Enumerators.RequirementType.Sugerencia;
                    else if (problemRadioButton.Checked == true) r.Type = Enumerators.RequirementType.Problema;
                    else r.Type = Enumerators.RequirementType.Otro;

                    r.IdEmployee = bussinessLogic.returnIdUser(Constants.CurrentUserName);
                    bussinessLogic.newRequest(r);
                    dataGridView1.DataSource = bussinessLogic.listRequests();

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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Request r = (Request)dataGridView1.CurrentRow.DataBoundItem;
            bussinessLogic.deleteRequest(r);
            dataGridView1.DataSource = bussinessLogic.listRequests();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFlag)
            {
                Request r = (Request)dataGridView1.CurrentRow.DataBoundItem;
                //Modificar campor descripcion en la BD
                bussinessLogic.modifyRequest(r);
                Console.WriteLine("Des: " + r.Description + " Type: " + r.Type.ToString() + "idEmployee: " + r.IdEmployee);
            }

        }

        private void button1_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
