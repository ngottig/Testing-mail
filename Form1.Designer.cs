namespace Testing_mail
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionMail = new System.Windows.Forms.TextBox();
            this.txtClaveMail = new System.Windows.Forms.TextBox();
            this.txtServerMail = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtSSL = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTextoMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puerto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SSL:";
            // 
            // txtDireccionMail
            // 
            this.txtDireccionMail.Location = new System.Drawing.Point(111, 41);
            this.txtDireccionMail.Name = "txtDireccionMail";
            this.txtDireccionMail.Size = new System.Drawing.Size(302, 20);
            this.txtDireccionMail.TabIndex = 5;
            // 
            // txtClaveMail
            // 
            this.txtClaveMail.Location = new System.Drawing.Point(71, 69);
            this.txtClaveMail.Name = "txtClaveMail";
            this.txtClaveMail.Size = new System.Drawing.Size(342, 20);
            this.txtClaveMail.TabIndex = 6;
            // 
            // txtServerMail
            // 
            this.txtServerMail.Location = new System.Drawing.Point(96, 95);
            this.txtServerMail.Name = "txtServerMail";
            this.txtServerMail.Size = new System.Drawing.Size(317, 20);
            this.txtServerMail.TabIndex = 7;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(75, 121);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(338, 20);
            this.txtPuerto.TabIndex = 8;
            // 
            // txtSSL
            // 
            this.txtSSL.Location = new System.Drawing.Point(64, 148);
            this.txtSSL.Name = "txtSSL";
            this.txtSSL.Size = new System.Drawing.Size(349, 20);
            this.txtSSL.TabIndex = 9;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(81, 224);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(332, 20);
            this.txtAsunto.TabIndex = 13;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(104, 197);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(309, 20);
            this.txtDestinatario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Asunto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Destinatario:";
            // 
            // txtTextoMail
            // 
            this.txtTextoMail.Location = new System.Drawing.Point(75, 250);
            this.txtTextoMail.Name = "txtTextoMail";
            this.txtTextoMail.Size = new System.Drawing.Size(338, 20);
            this.txtTextoMail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Texto:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(184, 300);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 335);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtTextoMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSSL);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.txtServerMail);
            this.Controls.Add(this.txtClaveMail);
            this.Controls.Add(this.txtDireccionMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Testing Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionMail;
        private System.Windows.Forms.TextBox txtClaveMail;
        private System.Windows.Forms.TextBox txtServerMail;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtSSL;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTextoMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviar;
    }
}

