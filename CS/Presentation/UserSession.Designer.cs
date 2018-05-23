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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.clientManageButton = new System.Windows.Forms.Button();
            this.sellsManageButton = new System.Windows.Forms.Button();
            this.RequestsManageButton = new System.Windows.Forms.Button();
            this.signOutLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.userNameLabel.Location = new System.Drawing.Point(42, 36);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(405, 32);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Usuario: Daniela Argumanis";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // clientManageButton
            // 
            this.clientManageButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientManageButton.Location = new System.Drawing.Point(80, 113);
            this.clientManageButton.Name = "clientManageButton";
            this.clientManageButton.Size = new System.Drawing.Size(118, 40);
            this.clientManageButton.TabIndex = 1;
            this.clientManageButton.Text = "Administrar Clientes";
            this.clientManageButton.UseVisualStyleBackColor = true;
            this.clientManageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellsManageButton
            // 
            this.sellsManageButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellsManageButton.Location = new System.Drawing.Point(272, 113);
            this.sellsManageButton.Name = "sellsManageButton";
            this.sellsManageButton.Size = new System.Drawing.Size(124, 40);
            this.sellsManageButton.TabIndex = 2;
            this.sellsManageButton.Text = "Gestionar Ventas";
            this.sellsManageButton.UseVisualStyleBackColor = true;
            this.sellsManageButton.Click += new System.EventHandler(this.sellsManageButton_Click_1);
            // 
            // RequestsManageButton
            // 
            this.RequestsManageButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestsManageButton.Location = new System.Drawing.Point(178, 182);
            this.RequestsManageButton.Name = "RequestsManageButton";
            this.RequestsManageButton.Size = new System.Drawing.Size(117, 42);
            this.RequestsManageButton.TabIndex = 3;
            this.RequestsManageButton.Text = "Gestionar Solicitudes";
            this.RequestsManageButton.UseVisualStyleBackColor = true;
            this.RequestsManageButton.Click += new System.EventHandler(this.RequestsManageButton_Click);
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.Location = new System.Drawing.Point(12, 268);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(97, 13);
            this.signOutLabel.TabIndex = 4;
            this.signOutLabel.Text = "<Cerrar Sesión>";
            this.signOutLabel.Click += new System.EventHandler(this.signOutLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cambiar Contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UserSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.RequestsManageButton);
            this.Controls.Add(this.sellsManageButton);
            this.Controls.Add(this.clientManageButton);
            this.Controls.Add(this.userNameLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserSession";
            this.Text = "La Allternativa - Usuario";
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
        private System.Windows.Forms.Label signOutLabel;
        private System.Windows.Forms.Button button1;
    }
}