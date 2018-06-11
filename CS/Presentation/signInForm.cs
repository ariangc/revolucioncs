﻿using BussinessLogic;
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

namespace Presentation
{
    public partial class signInForm : Form
    {
        private string username;
        private string password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        private EmployeeBL employeeBussinessLogic;
        public signInForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            employeeBussinessLogic = new EmployeeBL();
        }

        public signInForm(string newPassword)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text== "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("No ha ingresado todos los datos", "Error al iniciar sesión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (UsernameTextBox.Text.Length != 8)
            {
                MessageBox.Show("Su número de DNI debe tener 8 dígitos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string us = UsernameTextBox.Text;
            string pass = PasswordTextBox.Text;
            int i = 0; bool flag = true;
            while (i < us.Length)
            {
                if (us[i] < '0' || us[i] > '9') flag = false;
                i++;
            }

            bool passFlag = employeeBussinessLogic.passwordVerify(us, pass);
            if (flag && passFlag)
            {
                //success login
                Employee employee = employeeBussinessLogic.getEmployee(us);
                Constants.CurrentUserText = "Usuario: " + employee.FullName;
                Constants.CurrentUserName = us;
                Constants.CurrentPassword = pass;
                Constants.CurrentUserID = employee.Id;
                UserSession session = new UserSession();

                this.Hide();
                session.ShowDialog();
                this.Show();
                this.UsernameTextBox.Text = "";
                this.PasswordTextBox.Text = "";
            }
            else if(!flag){
                MessageBox.Show("Su DNI solo puede tener dígitos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //fail by username
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngresarButton_Enter(object sender, EventArgs e)
        {
            
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresarButton_Click(sender, e);
            }
        }

        private void signInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
