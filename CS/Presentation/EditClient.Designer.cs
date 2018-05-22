namespace Presentation
{
    partial class EditClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.namesCheckBox = new System.Windows.Forms.CheckBox();
            this.surnameCheckBox = new System.Windows.Forms.CheckBox();
            this.districtCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.emailCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(76, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 34);
            this.label11.TabIndex = 8;
            this.label11.Text = "Editar Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(78, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ingrese los campos nuevos";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(218, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(218, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(218, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(218, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(218, 267);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // namesCheckBox
            // 
            this.namesCheckBox.AutoSize = true;
            this.namesCheckBox.Location = new System.Drawing.Point(66, 104);
            this.namesCheckBox.Name = "namesCheckBox";
            this.namesCheckBox.Size = new System.Drawing.Size(68, 17);
            this.namesCheckBox.TabIndex = 17;
            this.namesCheckBox.Text = "Nombres";
            this.namesCheckBox.UseVisualStyleBackColor = true;
            this.namesCheckBox.CheckedChanged += new System.EventHandler(this.namesCheckBox_CheckedChanged);
            // 
            // surnameCheckBox
            // 
            this.surnameCheckBox.AutoSize = true;
            this.surnameCheckBox.Location = new System.Drawing.Point(66, 146);
            this.surnameCheckBox.Name = "surnameCheckBox";
            this.surnameCheckBox.Size = new System.Drawing.Size(66, 17);
            this.surnameCheckBox.TabIndex = 18;
            this.surnameCheckBox.Text = "Apellido:";
            this.surnameCheckBox.UseVisualStyleBackColor = true;
            this.surnameCheckBox.CheckedChanged += new System.EventHandler(this.surnameCheckBox_CheckedChanged);
            // 
            // districtCheckBox
            // 
            this.districtCheckBox.AutoSize = true;
            this.districtCheckBox.Location = new System.Drawing.Point(66, 187);
            this.districtCheckBox.Name = "districtCheckBox";
            this.districtCheckBox.Size = new System.Drawing.Size(61, 17);
            this.districtCheckBox.TabIndex = 19;
            this.districtCheckBox.Text = "Distrito:";
            this.districtCheckBox.UseVisualStyleBackColor = true;
            this.districtCheckBox.CheckedChanged += new System.EventHandler(this.districtCheckBox_CheckedChanged);
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Location = new System.Drawing.Point(66, 225);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(71, 17);
            this.phoneCheckBox.TabIndex = 20;
            this.phoneCheckBox.Text = "Teléfono:";
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            this.phoneCheckBox.CheckedChanged += new System.EventHandler(this.phoneCheckBox_CheckedChanged);
            // 
            // emailCheckBox
            // 
            this.emailCheckBox.AutoSize = true;
            this.emailCheckBox.Location = new System.Drawing.Point(66, 270);
            this.emailCheckBox.Name = "emailCheckBox";
            this.emailCheckBox.Size = new System.Drawing.Size(57, 17);
            this.emailCheckBox.TabIndex = 21;
            this.emailCheckBox.Text = "E-mail:";
            this.emailCheckBox.UseVisualStyleBackColor = true;
            this.emailCheckBox.CheckedChanged += new System.EventHandler(this.emailCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "< Regresar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailCheckBox);
            this.Controls.Add(this.phoneCheckBox);
            this.Controls.Add(this.districtCheckBox);
            this.Controls.Add(this.surnameCheckBox);
            this.Controls.Add(this.namesCheckBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.DoubleBuffered = true;
            this.Name = "EditClient";
            this.Text = "Editar información de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox namesCheckBox;
        private System.Windows.Forms.CheckBox surnameCheckBox;
        private System.Windows.Forms.CheckBox districtCheckBox;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.CheckBox emailCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}