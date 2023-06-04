namespace v680s_RFID
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
            this.components = new System.ComponentModel.Container();
            this.IP_LABEL = new System.Windows.Forms.TextBox();
            this.PORT_LABEL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonConectar = new System.Windows.Forms.Button();
            this.botonDesconectar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.INICIO_LEER = new System.Windows.Forms.TextBox();
            this.CANTIDAD_LEER = new System.Windows.Forms.TextBox();
            this.leer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.escribir = new System.Windows.Forms.Button();
            this.INICIO_ESCRIBIR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.INFORMACION = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // IP_LABEL
            // 
            this.IP_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IP_LABEL.Location = new System.Drawing.Point(12, 71);
            this.IP_LABEL.Name = "IP_LABEL";
            this.IP_LABEL.Size = new System.Drawing.Size(266, 20);
            this.IP_LABEL.TabIndex = 0;
            // 
            // PORT_LABEL
            // 
            this.PORT_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PORT_LABEL.Location = new System.Drawing.Point(284, 71);
            this.PORT_LABEL.Name = "PORT_LABEL";
            this.PORT_LABEL.Size = new System.Drawing.Size(68, 20);
            this.PORT_LABEL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos de conexión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dirección IP";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puerto";
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(11, 106);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(170, 30);
            this.botonConectar.TabIndex = 6;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // botonDesconectar
            // 
            this.botonDesconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonDesconectar.Location = new System.Drawing.Point(182, 106);
            this.botonDesconectar.Name = "botonDesconectar";
            this.botonDesconectar.Size = new System.Drawing.Size(170, 30);
            this.botonDesconectar.TabIndex = 7;
            this.botonDesconectar.Text = "Desconectar";
            this.botonDesconectar.UseVisualStyleBackColor = true;
            this.botonDesconectar.Click += new System.EventHandler(this.botonDesconectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Leer";
            // 
            // INICIO_LEER
            // 
            this.INICIO_LEER.Location = new System.Drawing.Point(11, 200);
            this.INICIO_LEER.Name = "INICIO_LEER";
            this.INICIO_LEER.Size = new System.Drawing.Size(50, 20);
            this.INICIO_LEER.TabIndex = 9;
            this.INICIO_LEER.Text = "0";
            // 
            // CANTIDAD_LEER
            // 
            this.CANTIDAD_LEER.Location = new System.Drawing.Point(67, 200);
            this.CANTIDAD_LEER.Name = "CANTIDAD_LEER";
            this.CANTIDAD_LEER.Size = new System.Drawing.Size(50, 20);
            this.CANTIDAD_LEER.TabIndex = 10;
            this.CANTIDAD_LEER.Text = "10";
            // 
            // leer
            // 
            this.leer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leer.Location = new System.Drawing.Point(123, 190);
            this.leer.Name = "leer";
            this.leer.Size = new System.Drawing.Size(229, 30);
            this.leer.TabIndex = 11;
            this.leer.Text = "Leer";
            this.leer.UseVisualStyleBackColor = true;
            this.leer.Click += new System.EventHandler(this.leer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Inicio";
            // 
            // escribir
            // 
            this.escribir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.escribir.Location = new System.Drawing.Point(11, 305);
            this.escribir.Name = "escribir";
            this.escribir.Size = new System.Drawing.Size(341, 30);
            this.escribir.TabIndex = 18;
            this.escribir.Text = "Escribir";
            this.escribir.UseVisualStyleBackColor = true;
            this.escribir.Click += new System.EventHandler(this.escribir_Click);
            // 
            // INICIO_ESCRIBIR
            // 
            this.INICIO_ESCRIBIR.Location = new System.Drawing.Point(12, 276);
            this.INICIO_ESCRIBIR.Name = "INICIO_ESCRIBIR";
            this.INICIO_ESCRIBIR.Size = new System.Drawing.Size(50, 20);
            this.INICIO_ESCRIBIR.TabIndex = 16;
            this.INICIO_ESCRIBIR.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Escribir";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(12, 370);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(341, 116);
            this.textBox.TabIndex = 14;
            this.textBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Información";
            // 
            // INFORMACION
            // 
            this.INFORMACION.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.INFORMACION.Location = new System.Drawing.Point(68, 276);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(284, 20);
            this.INFORMACION.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Envio/salida";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.Color.Red;
            this.Estado.Location = new System.Drawing.Point(244, 24);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(108, 16);
            this.Estado.TabIndex = 23;
            this.Estado.Text = "Desconectado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 501);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.escribir);
            this.Controls.Add(this.INFORMACION);
            this.Controls.Add(this.INICIO_ESCRIBIR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leer);
            this.Controls.Add(this.CANTIDAD_LEER);
            this.Controls.Add(this.INICIO_LEER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonDesconectar);
            this.Controls.Add(this.botonConectar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PORT_LABEL);
            this.Controls.Add(this.IP_LABEL);
            this.Name = "Form1";
            this.Text = "v680s RFID";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_LABEL;
        private System.Windows.Forms.TextBox PORT_LABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.Button botonDesconectar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox INICIO_LEER;
        private System.Windows.Forms.TextBox CANTIDAD_LEER;
        private System.Windows.Forms.Button leer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button escribir;
        private System.Windows.Forms.TextBox INICIO_ESCRIBIR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox INFORMACION;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Estado;
    }
}

