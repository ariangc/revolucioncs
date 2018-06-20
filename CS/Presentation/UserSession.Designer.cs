namespace Presentation
{
    partial class UserSession
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
            this.components = new System.ComponentModel.Container();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.RequestsManageButton = new System.Windows.Forms.Button();
            this.sellsManageButton = new System.Windows.Forms.Button();
            this.clientManageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Calibri Light", 17F);
            this.userNameLabel.Location = new System.Drawing.Point(88, 61);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(268, 28);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Usuario: Daniela Argumanis";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cambiar Contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 316);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 316);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 1);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "¡Bienvenido a La Alternativa Software!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestionar ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gestionar Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gestionar Solicitudes";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Presentation.Properties.Resources.logout;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(12, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 43;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RequestsManageButton
            // 
            this.RequestsManageButton.BackgroundImage = global::Presentation.Properties.Resources.solicitud;
            this.RequestsManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RequestsManageButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestsManageButton.Location = new System.Drawing.Point(284, 119);
            this.RequestsManageButton.Name = "RequestsManageButton";
            this.RequestsManageButton.Size = new System.Drawing.Size(117, 117);
            this.RequestsManageButton.TabIndex = 3;
            this.toolTip3.SetToolTip(this.RequestsManageButton, "Seleccione esta opción si desea enviar una solicitud al administrador");
            this.RequestsManageButton.UseVisualStyleBackColor = true;
            this.RequestsManageButton.Click += new System.EventHandler(this.RequestsManageButton_Click);
            // 
            // sellsManageButton
            // 
            this.sellsManageButton.BackgroundImage = global::Presentation.Properties.Resources.venta;
            this.sellsManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sellsManageButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellsManageButton.Location = new System.Drawing.Point(38, 119);
            this.sellsManageButton.Name = "sellsManageButton";
            this.sellsManageButton.Size = new System.Drawing.Size(116, 117);
            this.sellsManageButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.sellsManageButton, "Seleccione esta opción si desea realizar una venta a un cliente");
            this.sellsManageButton.UseVisualStyleBackColor = true;
            this.sellsManageButton.Click += new System.EventHandler(this.sellsManageButton_Click_1);
            // 
            // clientManageButton
            // 
            this.clientManageButton.BackgroundImage = global::Presentation.Properties.Resources.cliente;
            this.clientManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientManageButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientManageButton.Location = new System.Drawing.Point(160, 119);
            this.clientManageButton.Name = "clientManageButton";
            this.clientManageButton.Size = new System.Drawing.Size(118, 117);
            this.clientManageButton.TabIndex = 1;
            this.toolTip2.SetToolTip(this.clientManageButton, "Seleccione esta opción si desea agregar/modificar un cliente determinado");
            this.clientManageButton.UseVisualStyleBackColor = true;
            this.clientManageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(450, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RequestsManageButton);
            this.Controls.Add(this.sellsManageButton);
            this.Controls.Add(this.clientManageButton);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSession";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSession_FormClosing);
            this.Load += new System.EventHandler(this.UserSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button clientManageButton;
        private System.Windows.Forms.Button sellsManageButton;
        private System.Windows.Forms.Button RequestsManageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button button2;
    }
}