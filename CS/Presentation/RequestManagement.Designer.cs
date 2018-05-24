namespace Presentation
{
    partial class RequestManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sendButton = new System.Windows.Forms.Button();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.problemRadioButton = new System.Windows.Forms.RadioButton();
            this.RequestRadioButton = new System.Windows.Forms.RadioButton();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "< Regresar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 384);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.sendButton);
            this.tabPage1.Controls.Add(this.otherRadioButton);
            this.tabPage1.Controls.Add(this.problemRadioButton);
            this.tabPage1.Controls.Add(this.RequestRadioButton);
            this.tabPage1.Controls.Add(this.requestTextBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Silver;
            this.sendButton.Location = new System.Drawing.Point(206, 320);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 20;
            this.sendButton.Text = "Enviar";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(342, 272);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(45, 17);
            this.otherRadioButton.TabIndex = 19;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Otra";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // problemRadioButton
            // 
            this.problemRadioButton.AutoSize = true;
            this.problemRadioButton.Location = new System.Drawing.Point(238, 272);
            this.problemRadioButton.Name = "problemRadioButton";
            this.problemRadioButton.Size = new System.Drawing.Size(69, 17);
            this.problemRadioButton.TabIndex = 18;
            this.problemRadioButton.TabStop = true;
            this.problemRadioButton.Text = "Problema";
            this.problemRadioButton.UseVisualStyleBackColor = true;
            // 
            // RequestRadioButton
            // 
            this.RequestRadioButton.AutoSize = true;
            this.RequestRadioButton.Location = new System.Drawing.Point(133, 272);
            this.RequestRadioButton.Name = "RequestRadioButton";
            this.RequestRadioButton.Size = new System.Drawing.Size(79, 17);
            this.RequestRadioButton.TabIndex = 17;
            this.RequestRadioButton.TabStop = true;
            this.RequestRadioButton.Text = "Sugerencia";
            this.RequestRadioButton.UseVisualStyleBackColor = true;
            // 
            // requestTextBox
            // 
            this.requestTextBox.Location = new System.Drawing.Point(20, 86);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(473, 166);
            this.requestTextBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(134, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 34);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nueva Solicitud";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar/Eliminar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Solicitudes Enviadas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(210, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la solicitud que desee eliminar o modifique la descripción:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.Type,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(16, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "N°";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 50;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "description";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 270;
            // 
            // RequestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 413);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Name = "RequestManagement";
            this.Text = "Gestionar Nueva Solicitud";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton problemRadioButton;
        private System.Windows.Forms.RadioButton RequestRadioButton;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}