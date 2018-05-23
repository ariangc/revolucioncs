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
    public partial class EditLegalClient : Form
    {
        public EditLegalClient()
        {
            InitializeComponent();
        }

        private void namesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (namesCheckBox.Checked) textBox2.Enabled = true;
            else textBox2.Enabled = false;
        }

        private void districtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (districtCheckBox.Checked) textBox4.Enabled = true;
            else textBox4.Enabled = false;
        }

        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneCheckBox.Checked) textBox5.Enabled = true;
            else textBox5.Enabled = false;
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (emailCheckBox.Checked) textBox6.Enabled = true;
            else textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namesCheckBox.Checked || districtCheckBox.Checked || phoneCheckBox.Checked || emailCheckBox.Checked)
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta Seguro de que desea cambiar el/los campo(s)?", "Cambio de cmapos de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else MessageBox.Show("Debe ingresar algún campo", "Cambio de cmapos de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}