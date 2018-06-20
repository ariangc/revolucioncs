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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ModifyTabControl = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.surnameModifyClientTextBox = new System.Windows.Forms.TextBox();
            this.dniModifyClientTextBox = new System.Windows.Forms.TextBox();
            this.nameModifyClientTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.modifyClientButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdentityDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RegisterTabControl = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTabControl = new System.Windows.Forms.TabControl();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ModifyTabControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RegisterTabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.clientTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyTabControl
            // 
            this.ModifyTabControl.BackColor = System.Drawing.Color.White;
            this.ModifyTabControl.Controls.Add(this.groupBox2);
            this.ModifyTabControl.Controls.Add(this.refreshButton);
            this.ModifyTabControl.Controls.Add(this.modifyClientButton);
            this.ModifyTabControl.Controls.Add(this.dataGridView1);
            this.ModifyTabControl.Controls.Add(this.label9);
            this.ModifyTabControl.Controls.Add(this.label11);
            this.ModifyTabControl.Location = new System.Drawing.Point(4, 22);
            this.ModifyTabControl.Name = "ModifyTabControl";
            this.ModifyTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ModifyTabControl.Size = new System.Drawing.Size(501, 380);
            this.ModifyTabControl.TabIndex = 1;
            this.ModifyTabControl.Text = "Modificar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.surnameModifyClientTextBox);
            this.groupBox2.Controls.Add(this.dniModifyClientTextBox);
            this.groupBox2.Controls.Add(this.nameModifyClientTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 69);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // surnameModifyClientTextBox
            // 
            this.surnameModifyClientTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.surnameModifyClientTextBox.Location = new System.Drawing.Point(247, 33);
            this.surnameModifyClientTextBox.MaxLength = 45;
            this.surnameModifyClientTextBox.Name = "surnameModifyClientTextBox";
            this.surnameModifyClientTextBox.Size = new System.Drawing.Size(129, 20);
            this.surnameModifyClientTextBox.TabIndex = 11;
            this.surnameModifyClientTextBox.Click += new System.EventHandler(this.surnameModifyClientTextBox_Click);
            this.surnameModifyClientTextBox.TextChanged += new System.EventHandler(this.surnameModifyClientTextBox_TextChanged);
            // 
            // dniModifyClientTextBox
            // 
            this.dniModifyClientTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dniModifyClientTextBox.Location = new System.Drawing.Point(8, 33);
            this.dniModifyClientTextBox.MaxLength = 8;
            this.dniModifyClientTextBox.Name = "dniModifyClientTextBox";
            this.dniModifyClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniModifyClientTextBox.TabIndex = 9;
            this.dniModifyClientTextBox.Click += new System.EventHandler(this.dniModifyClientTextBox_Click);
            this.dniModifyClientTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nameModifyClientTextBox
            // 
            this.nameModifyClientTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameModifyClientTextBox.Location = new System.Drawing.Point(114, 33);
            this.nameModifyClientTextBox.MaxLength = 45;
            this.nameModifyClientTextBox.Name = "nameModifyClientTextBox";
            this.nameModifyClientTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameModifyClientTextBox.TabIndex = 10;
            this.nameModifyClientTextBox.Click += new System.EventHandler(this.nameModifyClientTextBox_Click);
            this.nameModifyClientTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Apellidos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "DNI:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nombres:";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Silver;
            this.refreshButton.Location = new System.Drawing.Point(405, 107);
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
            this.modifyClientButton.Location = new System.Drawing.Point(406, 340);
            this.modifyClientButton.Name = "modifyClientButton";
            this.modifyClientButton.Size = new System.Drawing.Size(89, 33);
            this.modifyClientButton.TabIndex = 7;
            this.modifyClientButton.Text = "Modificar";
            this.modifyClientButton.UseVisualStyleBackColor = false;
            this.modifyClientButton.Click += new System.EventHandler(this.modifyClientButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 165);
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
            this.IdentityDoc.Width = 55;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Nombres";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Surname";
            this.Column3.HeaderText = "Apellidos";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PhoneNumber";
            this.Column5.HeaderText = "Telefono";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 55;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.HeaderText = "E-mail";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.label9.Location = new System.Drawing.Point(8, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Buscar cliente por DNI, Nombres y/o Apellidos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 20.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(6, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "Modificar Cliente";
            // 
            // RegisterTabControl
            // 
            this.RegisterTabControl.BackColor = System.Drawing.Color.White;
            this.RegisterTabControl.Controls.Add(this.groupBox1);
            this.RegisterTabControl.Controls.Add(this.ConfirmButton);
            this.RegisterTabControl.Controls.Add(this.label1);
            this.RegisterTabControl.Location = new System.Drawing.Point(4, 22);
            this.RegisterTabControl.Name = "RegisterTabControl";
            this.RegisterTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTabControl.Size = new System.Drawing.Size(501, 380);
            this.RegisterTabControl.TabIndex = 0;
            this.RegisterTabControl.Text = "Registrar";
            this.RegisterTabControl.Click += new System.EventHandler(this.RegisterTabControl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.districtTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dniTextBox);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lastnameTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(108, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 255);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // districtTextBox
            // 
            this.districtTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.districtTextBox.Location = new System.Drawing.Point(97, 139);
            this.districtTextBox.MaxLength = 45;
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(176, 20);
            this.districtTextBox.TabIndex = 14;
            this.districtTextBox.Click += new System.EventHandler(this.districtTextBox_Click);
            this.districtTextBox.TextChanged += new System.EventHandler(this.districtTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DNI:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Teléfono:";
            // 
            // dniTextBox
            // 
            this.dniTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dniTextBox.Location = new System.Drawing.Point(97, 29);
            this.dniTextBox.MaxLength = 8;
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 11;
            this.dniTextBox.Click += new System.EventHandler(this.dniTextBox_Click);
            this.dniTextBox.TextChanged += new System.EventHandler(this.dniTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTextBox.Location = new System.Drawing.Point(96, 175);
            this.phoneTextBox.MaxLength = 13;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(140, 20);
            this.phoneTextBox.TabIndex = 15;
            this.phoneTextBox.Click += new System.EventHandler(this.phoneTextBox_Click);
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Apellidos:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailTextBox.Location = new System.Drawing.Point(96, 211);
            this.emailTextBox.MaxLength = 45;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(140, 20);
            this.emailTextBox.TabIndex = 16;
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextBox.Location = new System.Drawing.Point(97, 66);
            this.nameTextBox.MaxLength = 45;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Distrito:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastnameTextBox.Location = new System.Drawing.Point(97, 103);
            this.lastnameTextBox.MaxLength = 45;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(176, 20);
            this.lastnameTextBox.TabIndex = 13;
            this.lastnameTextBox.Click += new System.EventHandler(this.lastnameTextBox_Click);
            this.lastnameTextBox.TextChanged += new System.EventHandler(this.lastnameTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nombres:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Silver;
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmButton.Location = new System.Drawing.Point(205, 328);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(104, 35);
            this.ConfirmButton.TabIndex = 17;
            this.ConfirmButton.Text = "Confirmar";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registrar Cliente Natural";
            // 
            // clientTabControl
            // 
            this.clientTabControl.Controls.Add(this.RegisterTabControl);
            this.clientTabControl.Controls.Add(this.ModifyTabControl);
            this.clientTabControl.Location = new System.Drawing.Point(12, 21);
            this.clientTabControl.Name = "clientTabControl";
            this.clientTabControl.SelectedIndex = 0;
            this.clientTabControl.Size = new System.Drawing.Size(509, 406);
            this.clientTabControl.TabIndex = 6;
            this.clientTabControl.SelectedIndexChanged += new System.EventHandler(this.clientTabControl_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(373, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 45;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Presentation.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(16, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 43);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 1);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 482);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(532, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 482);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 1);
            this.panel4.TabIndex = 26;
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(533, 483);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.clientTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientManagement";
            this.Text = "Administración de clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientManagement_FormClosing);
            this.Load += new System.EventHandler(this.ClientManagement_Load);
            this.ModifyTabControl.ResumeLayout(false);
            this.ModifyTabControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RegisterTabControl.ResumeLayout(false);
            this.RegisterTabControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.clientTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage ModifyTabControl;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}