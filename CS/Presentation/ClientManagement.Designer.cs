namespace Presentation
{
    partial class ClientManagement
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
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ModifyTabControl = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.modifyClientButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdentityDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButon = new System.Windows.Forms.Button();
            this.surnameModifyClientTextBox = new System.Windows.Forms.TextBox();
            this.nameModifyClientTextBox = new System.Windows.Forms.TextBox();
            this.dniModifyClientTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RegisterTabControl = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTabControl = new System.Windows.Forms.TabControl();
            this.ModifyTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RegisterTabControl.SuspendLayout();
            this.clientTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "< Regresar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ModifyTabControl
            // 
            this.ModifyTabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ModifyTabControl.Controls.Add(this.refreshButton);
            this.ModifyTabControl.Controls.Add(this.modifyClientButton);
            this.ModifyTabControl.Controls.Add(this.label14);
            this.ModifyTabControl.Controls.Add(this.label13);
            this.ModifyTabControl.Controls.Add(this.label12);
            this.ModifyTabControl.Controls.Add(this.dataGridView1);
            this.ModifyTabControl.Controls.Add(this.searchButon);
            this.ModifyTabControl.Controls.Add(this.surnameModifyClientTextBox);
            this.ModifyTabControl.Controls.Add(this.nameModifyClientTextBox);
            this.ModifyTabControl.Controls.Add(this.dniModifyClientTextBox);
            this.ModifyTabControl.Controls.Add(this.label9);
            this.ModifyTabControl.Controls.Add(this.label11);
            this.ModifyTabControl.Location = new System.Drawing.Point(4, 22);
            this.ModifyTabControl.Name = "ModifyTabControl";
            this.ModifyTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyTabControl.Size = new System.Drawing.Size(434, 403);
            this.ModifyTabControl.TabIndex = 1;
            this.ModifyTabControl.Text = "Modificar/Eliminar";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Silver;
            this.refreshButton.Location = new System.Drawing.Point(254, 119);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(89, 31);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Refrescar";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // modifyClientButton
            // 
            this.modifyClientButton.BackColor = System.Drawing.Color.Silver;
            this.modifyClientButton.Location = new System.Drawing.Point(162, 361);
            this.modifyClientButton.Name = "modifyClientButton";
            this.modifyClientButton.Size = new System.Drawing.Size(89, 33);
            this.modifyClientButton.TabIndex = 7;
            this.modifyClientButton.Text = "Modificar";
            this.modifyClientButton.UseVisualStyleBackColor = false;
            this.modifyClientButton.Click += new System.EventHandler(this.modifyClientButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Apellido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nombres:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "DNI:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentityDoc,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(9, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 194);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // IdentityDoc
            // 
            this.IdentityDoc.DataPropertyName = "Dni";
            this.IdentityDoc.HeaderText = "DNI";
            this.IdentityDoc.Name = "IdentityDoc";
            this.IdentityDoc.ReadOnly = true;
            this.IdentityDoc.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Nombres";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Surname";
            this.Column3.HeaderText = "Apellidos";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PhoneNumber";
            this.Column5.HeaderText = "Telefono";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.HeaderText = "E-mail";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // searchButon
            // 
            this.searchButon.BackColor = System.Drawing.Color.Silver;
            this.searchButon.Location = new System.Drawing.Point(88, 119);
            this.searchButon.Name = "searchButon";
            this.searchButon.Size = new System.Drawing.Size(89, 31);
            this.searchButon.TabIndex = 12;
            this.searchButon.Text = "Buscar";
            this.searchButon.UseVisualStyleBackColor = false;
            this.searchButon.Click += new System.EventHandler(this.searchButon_Click_1);
            // 
            // surnameModifyClientTextBox
            // 
            this.surnameModifyClientTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.surnameModifyClientTextBox.Location = new System.Drawing.Point(319, 93);
            this.surnameModifyClientTextBox.Name = "surnameModifyClientTextBox";
            this.surnameModifyClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameModifyClientTextBox.TabIndex = 11;
            this.surnameModifyClientTextBox.Click += new System.EventHandler(this.surnameModifyClientTextBox_Click);
            this.surnameModifyClientTextBox.TextChanged += new System.EventHandler(this.surnameModifyClientTextBox_TextChanged);
            // 
            // nameModifyClientTextBox
            // 
            this.nameModifyClientTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameModifyClientTextBox.Location = new System.Drawing.Point(166, 93);
            this.nameModifyClientTextBox.Name = "nameModifyClientTextBox";
            this.nameModifyClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameModifyClientTextBox.TabIndex = 10;
            this.nameModifyClientTextBox.Click += new System.EventHandler(this.nameModifyClientTextBox_Click);
            this.nameModifyClientTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dniModifyClientTextBox
            // 
            this.dniModifyClientTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dniModifyClientTextBox.Location = new System.Drawing.Point(11, 93);
            this.dniModifyClientTextBox.Name = "dniModifyClientTextBox";
            this.dniModifyClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniModifyClientTextBox.TabIndex = 9;
            this.dniModifyClientTextBox.Click += new System.EventHandler(this.dniModifyClientTextBox_Click);
            this.dniModifyClientTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(65, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Complete los campos del cliente a buscar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(82, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 34);
            this.label11.TabIndex = 7;
            this.label11.Text = "Modificar Cliente";
            // 
            // RegisterTabControl
            // 
            this.RegisterTabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RegisterTabControl.Controls.Add(this.label10);
            this.RegisterTabControl.Controls.Add(this.label8);
            this.RegisterTabControl.Controls.Add(this.label7);
            this.RegisterTabControl.Controls.Add(this.label6);
            this.RegisterTabControl.Controls.Add(this.label5);
            this.RegisterTabControl.Controls.Add(this.label4);
            this.RegisterTabControl.Controls.Add(this.ConfirmButton);
            this.RegisterTabControl.Controls.Add(this.emailTextBox);
            this.RegisterTabControl.Controls.Add(this.phoneTextBox);
            this.RegisterTabControl.Controls.Add(this.districtTextBox);
            this.RegisterTabControl.Controls.Add(this.lastnameTextBox);
            this.RegisterTabControl.Controls.Add(this.nameTextBox);
            this.RegisterTabControl.Controls.Add(this.dniTextBox);
            this.RegisterTabControl.Controls.Add(this.label2);
            this.RegisterTabControl.Controls.Add(this.label1);
            this.RegisterTabControl.Location = new System.Drawing.Point(4, 22);
            this.RegisterTabControl.Name = "RegisterTabControl";
            this.RegisterTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTabControl.Size = new System.Drawing.Size(434, 403);
            this.RegisterTabControl.TabIndex = 0;
            this.RegisterTabControl.Text = "Registrar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "E-mail*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Apellidos*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Telefono*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nombres*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Distrito*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Número de DNI*";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Silver;
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmButton.Location = new System.Drawing.Point(163, 347);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirmar";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailTextBox.Location = new System.Drawing.Point(235, 294);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 16;
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTextBox.Location = new System.Drawing.Point(235, 216);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 15;
            this.phoneTextBox.Click += new System.EventHandler(this.phoneTextBox_Click);
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // districtTextBox
            // 
            this.districtTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.districtTextBox.Location = new System.Drawing.Point(235, 144);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(100, 20);
            this.districtTextBox.TabIndex = 14;
            this.districtTextBox.Click += new System.EventHandler(this.districtTextBox_Click);
            this.districtTextBox.TextChanged += new System.EventHandler(this.districtTextBox_TextChanged);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastnameTextBox.Location = new System.Drawing.Point(78, 294);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 13;
            this.lastnameTextBox.Click += new System.EventHandler(this.lastnameTextBox_Click);
            this.lastnameTextBox.TextChanged += new System.EventHandler(this.lastnameTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextBox.Location = new System.Drawing.Point(78, 216);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // dniTextBox
            // 
            this.dniTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dniTextBox.Location = new System.Drawing.Point(78, 144);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 11;
            this.dniTextBox.Click += new System.EventHandler(this.dniTextBox_Click);
            this.dniTextBox.TextChanged += new System.EventHandler(this.dniTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario: Daniela Argumanis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registrar Cliente Natural";
            // 
            // clientTabControl
            // 
            this.clientTabControl.Controls.Add(this.RegisterTabControl);
            this.clientTabControl.Controls.Add(this.ModifyTabControl);
            this.clientTabControl.Location = new System.Drawing.Point(6, 0);
            this.clientTabControl.Name = "clientTabControl";
            this.clientTabControl.SelectedIndex = 0;
            this.clientTabControl.Size = new System.Drawing.Size(442, 429);
            this.clientTabControl.TabIndex = 6;
            this.clientTabControl.SelectedIndexChanged += new System.EventHandler(this.clientTabControl_SelectedIndexChanged);
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientTabControl);
            this.Name = "ClientManagement";
            this.Text = "Administración de clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientManagement_FormClosing);
            this.Load += new System.EventHandler(this.ClientManagement_Load);
            this.ModifyTabControl.ResumeLayout(false);
            this.ModifyTabControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RegisterTabControl.ResumeLayout(false);
            this.RegisterTabControl.PerformLayout();
            this.clientTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage ModifyTabControl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButon;
        private System.Windows.Forms.TextBox surnameModifyClientTextBox;
        private System.Windows.Forms.TextBox nameModifyClientTextBox;
        private System.Windows.Forms.TextBox dniModifyClientTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage RegisterTabControl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl clientTabControl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button modifyClientButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}