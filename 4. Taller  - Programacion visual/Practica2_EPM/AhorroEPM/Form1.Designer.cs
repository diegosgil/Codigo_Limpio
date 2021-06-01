
namespace AhorroEPM
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
            this.lbAhorro = new System.Windows.Forms.Label();
            this.lbEstrato = new System.Windows.Forms.Label();
            this.lbConsumoActual = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbCedula = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbAsterisco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.maskedtxtboxCedula = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtboxConsumoActual = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtboxMetaAhorro = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCedulaValorTotal = new System.Windows.Forms.Button();
            this.lbEPM = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.maskedtxtboxValorTotalCedula = new System.Windows.Forms.MaskedTextBox();
            this.lbCedulaValorTotal = new System.Windows.Forms.Label();
            this.lbCedulaValorTotalCliente = new System.Windows.Forms.Label();
            this.txtCedulaValorTotal = new System.Windows.Forms.TextBox();
            this.txtPorcentajeEstrato = new System.Windows.Forms.TextBox();
            this.txtPromedioConsumo = new System.Windows.Forms.TextBox();
            this.lbPromedioConsumo = new System.Windows.Forms.Label();
            this.lbPromedioConsumoActual = new System.Windows.Forms.Label();
            this.btPromedioConsumo = new System.Windows.Forms.Button();
            this.lbPorcentajeAhorroEstrato = new System.Windows.Forms.Label();
            this.lbPorcentajeAhorroEstrato2 = new System.Windows.Forms.Label();
            this.btPorcentajeAhorroEstrato = new System.Windows.Forms.Button();
            this.lbClienteCobroAdicional = new System.Windows.Forms.Label();
            this.btClienteCobroAdicional = new System.Windows.Forms.Button();
            this.txtValorTotalDescuentos = new System.Windows.Forms.TextBox();
            this.lbValorTotalDescuentos = new System.Windows.Forms.Label();
            this.lbValorTotalDesc = new System.Windows.Forms.Label();
            this.btValorTotalDescuentos = new System.Windows.Forms.Button();
            this.txtClienteCobroAdicional = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAhorro
            // 
            this.lbAhorro.AutoSize = true;
            this.lbAhorro.Location = new System.Drawing.Point(33, 178);
            this.lbAhorro.Name = "lbAhorro";
            this.lbAhorro.Size = new System.Drawing.Size(83, 13);
            this.lbAhorro.TabIndex = 6;
            this.lbAhorro.Text = "Meta de Ahorro:";
            // 
            // lbEstrato
            // 
            this.lbEstrato.AutoSize = true;
            this.lbEstrato.Location = new System.Drawing.Point(33, 122);
            this.lbEstrato.Name = "lbEstrato";
            this.lbEstrato.Size = new System.Drawing.Size(43, 13);
            this.lbEstrato.TabIndex = 8;
            this.lbEstrato.Text = "Estrato:";
            // 
            // lbConsumoActual
            // 
            this.lbConsumoActual.AutoSize = true;
            this.lbConsumoActual.Location = new System.Drawing.Point(30, 236);
            this.lbConsumoActual.Name = "lbConsumoActual";
            this.lbConsumoActual.Size = new System.Drawing.Size(86, 13);
            this.lbConsumoActual.TabIndex = 2;
            this.lbConsumoActual.Text = "Consumo actual:";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(33, 283);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Location = new System.Drawing.Point(33, 72);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(43, 13);
            this.lbCedula.TabIndex = 0;
            this.lbCedula.Text = "Cedula:";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(727, 341);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(123, 28);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbAsterisco
            // 
            this.lbAsterisco.AutoSize = true;
            this.lbAsterisco.ForeColor = System.Drawing.Color.Red;
            this.lbAsterisco.Location = new System.Drawing.Point(139, 259);
            this.lbAsterisco.Name = "lbAsterisco";
            this.lbAsterisco.Size = new System.Drawing.Size(11, 13);
            this.lbAsterisco.TabIndex = 13;
            this.lbAsterisco.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(139, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Location = new System.Drawing.Point(33, 138);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(100, 21);
            this.cmbEstrato.TabIndex = 1;
            // 
            // maskedtxtboxCedula
            // 
            this.maskedtxtboxCedula.Location = new System.Drawing.Point(33, 88);
            this.maskedtxtboxCedula.Mask = "9999999999";
            this.maskedtxtboxCedula.Name = "maskedtxtboxCedula";
            this.maskedtxtboxCedula.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtboxCedula.TabIndex = 0;
            this.maskedtxtboxCedula.ValidatingType = typeof(int);
            // 
            // maskedtxtboxConsumoActual
            // 
            this.maskedtxtboxConsumoActual.Location = new System.Drawing.Point(33, 252);
            this.maskedtxtboxConsumoActual.Name = "maskedtxtboxConsumoActual";
            this.maskedtxtboxConsumoActual.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtboxConsumoActual.TabIndex = 3;
            this.maskedtxtboxConsumoActual.ValidatingType = typeof(int);
            // 
            // maskedtxtboxMetaAhorro
            // 
            this.maskedtxtboxMetaAhorro.Location = new System.Drawing.Point(33, 194);
            this.maskedtxtboxMetaAhorro.Name = "maskedtxtboxMetaAhorro";
            this.maskedtxtboxMetaAhorro.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtboxMetaAhorro.TabIndex = 2;
            this.maskedtxtboxMetaAhorro.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(139, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // btCedulaValorTotal
            // 
            this.btCedulaValorTotal.Location = new System.Drawing.Point(196, 149);
            this.btCedulaValorTotal.Name = "btCedulaValorTotal";
            this.btCedulaValorTotal.Size = new System.Drawing.Size(100, 25);
            this.btCedulaValorTotal.TabIndex = 6;
            this.btCedulaValorTotal.Text = "Consultar";
            this.btCedulaValorTotal.UseVisualStyleBackColor = true;
            this.btCedulaValorTotal.Click += new System.EventHandler(this.btMostrarResultados_Click);
            // 
            // lbEPM
            // 
            this.lbEPM.AutoSize = true;
            this.lbEPM.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEPM.Location = new System.Drawing.Point(323, 21);
            this.lbEPM.Name = "lbEPM";
            this.lbEPM.Size = new System.Drawing.Size(224, 16);
            this.lbEPM.TabIndex = 19;
            this.lbEPM.Text = "Central Hidro-Ituango de EPM";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Location = new System.Drawing.Point(195, 185);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(96, 13);
            this.lbValorTotal.TabIndex = 22;
            this.lbValorTotal.Text = "Valor total a pagar:";
            // 
            // maskedtxtboxValorTotalCedula
            // 
            this.maskedtxtboxValorTotalCedula.Location = new System.Drawing.Point(196, 119);
            this.maskedtxtboxValorTotalCedula.Mask = "9999999999";
            this.maskedtxtboxValorTotalCedula.Name = "maskedtxtboxValorTotalCedula";
            this.maskedtxtboxValorTotalCedula.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtboxValorTotalCedula.TabIndex = 5;
            this.maskedtxtboxValorTotalCedula.ValidatingType = typeof(int);
            // 
            // lbCedulaValorTotal
            // 
            this.lbCedulaValorTotal.AutoSize = true;
            this.lbCedulaValorTotal.Location = new System.Drawing.Point(195, 103);
            this.lbCedulaValorTotal.Name = "lbCedulaValorTotal";
            this.lbCedulaValorTotal.Size = new System.Drawing.Size(43, 13);
            this.lbCedulaValorTotal.TabIndex = 25;
            this.lbCedulaValorTotal.Text = "Cedula:";
            // 
            // lbCedulaValorTotalCliente
            // 
            this.lbCedulaValorTotalCliente.AutoSize = true;
            this.lbCedulaValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedulaValorTotalCliente.Location = new System.Drawing.Point(195, 75);
            this.lbCedulaValorTotalCliente.Name = "lbCedulaValorTotalCliente";
            this.lbCedulaValorTotalCliente.Size = new System.Drawing.Size(155, 13);
            this.lbCedulaValorTotalCliente.TabIndex = 26;
            this.lbCedulaValorTotalCliente.Text = "VALOR TOTAL POR CLIENTE";
            // 
            // txtCedulaValorTotal
            // 
            this.txtCedulaValorTotal.Location = new System.Drawing.Point(198, 201);
            this.txtCedulaValorTotal.Multiline = true;
            this.txtCedulaValorTotal.Name = "txtCedulaValorTotal";
            this.txtCedulaValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaValorTotal.TabIndex = 27;
            // 
            // txtPorcentajeEstrato
            // 
            this.txtPorcentajeEstrato.Location = new System.Drawing.Point(625, 152);
            this.txtPorcentajeEstrato.Multiline = true;
            this.txtPorcentajeEstrato.Name = "txtPorcentajeEstrato";
            this.txtPorcentajeEstrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorcentajeEstrato.Size = new System.Drawing.Size(115, 61);
            this.txtPorcentajeEstrato.TabIndex = 18;
            // 
            // txtPromedioConsumo
            // 
            this.txtPromedioConsumo.Location = new System.Drawing.Point(387, 143);
            this.txtPromedioConsumo.Multiline = true;
            this.txtPromedioConsumo.Name = "txtPromedioConsumo";
            this.txtPromedioConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioConsumo.TabIndex = 33;
            // 
            // lbPromedioConsumo
            // 
            this.lbPromedioConsumo.AutoSize = true;
            this.lbPromedioConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromedioConsumo.Location = new System.Drawing.Point(386, 74);
            this.lbPromedioConsumo.Name = "lbPromedioConsumo";
            this.lbPromedioConsumo.Size = new System.Drawing.Size(192, 13);
            this.lbPromedioConsumo.TabIndex = 32;
            this.lbPromedioConsumo.Text = "PROMEDIO DEL CONSUMO ACTUAL";
            // 
            // lbPromedioConsumoActual
            // 
            this.lbPromedioConsumoActual.AutoSize = true;
            this.lbPromedioConsumoActual.Location = new System.Drawing.Point(384, 127);
            this.lbPromedioConsumoActual.Name = "lbPromedioConsumoActual";
            this.lbPromedioConsumoActual.Size = new System.Drawing.Size(145, 13);
            this.lbPromedioConsumoActual.TabIndex = 29;
            this.lbPromedioConsumoActual.Text = "Valor total por descuento es: ";
            // 
            // btPromedioConsumo
            // 
            this.btPromedioConsumo.Location = new System.Drawing.Point(387, 90);
            this.btPromedioConsumo.Name = "btPromedioConsumo";
            this.btPromedioConsumo.Size = new System.Drawing.Size(138, 25);
            this.btPromedioConsumo.TabIndex = 7;
            this.btPromedioConsumo.Text = "Consultar Promedio";
            this.btPromedioConsumo.UseVisualStyleBackColor = true;
            this.btPromedioConsumo.Click += new System.EventHandler(this.btPromedioConsumo_Click);
            // 
            // lbPorcentajeAhorroEstrato
            // 
            this.lbPorcentajeAhorroEstrato.AutoSize = true;
            this.lbPorcentajeAhorroEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentajeAhorroEstrato.Location = new System.Drawing.Point(622, 77);
            this.lbPorcentajeAhorroEstrato.Name = "lbPorcentajeAhorroEstrato";
            this.lbPorcentajeAhorroEstrato.Size = new System.Drawing.Size(233, 13);
            this.lbPorcentajeAhorroEstrato.TabIndex = 36;
            this.lbPorcentajeAhorroEstrato.Text = "PORCENTAJE DE AHORROS POR ESTRATO";
            // 
            // lbPorcentajeAhorroEstrato2
            // 
            this.lbPorcentajeAhorroEstrato2.AutoSize = true;
            this.lbPorcentajeAhorroEstrato2.Location = new System.Drawing.Point(622, 131);
            this.lbPorcentajeAhorroEstrato2.Name = "lbPorcentajeAhorroEstrato2";
            this.lbPorcentajeAhorroEstrato2.Size = new System.Drawing.Size(139, 13);
            this.lbPorcentajeAhorroEstrato2.TabIndex = 35;
            this.lbPorcentajeAhorroEstrato2.Text = "El porcentaje por estrato es:";
            // 
            // btPorcentajeAhorroEstrato
            // 
            this.btPorcentajeAhorroEstrato.Location = new System.Drawing.Point(625, 94);
            this.btPorcentajeAhorroEstrato.Name = "btPorcentajeAhorroEstrato";
            this.btPorcentajeAhorroEstrato.Size = new System.Drawing.Size(138, 25);
            this.btPorcentajeAhorroEstrato.TabIndex = 9;
            this.btPorcentajeAhorroEstrato.Text = "Consultar Porcentaje";
            this.btPorcentajeAhorroEstrato.UseVisualStyleBackColor = true;
            this.btPorcentajeAhorroEstrato.Click += new System.EventHandler(this.btPorcentajeAhorroEstrato_Click);
            // 
            // lbClienteCobroAdicional
            // 
            this.lbClienteCobroAdicional.AutoSize = true;
            this.lbClienteCobroAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteCobroAdicional.Location = new System.Drawing.Point(622, 248);
            this.lbClienteCobroAdicional.Name = "lbClienteCobroAdicional";
            this.lbClienteCobroAdicional.Size = new System.Drawing.Size(153, 13);
            this.lbClienteCobroAdicional.TabIndex = 38;
            this.lbClienteCobroAdicional.Text = "CLIENTE COBRO ADICIONAL";
            // 
            // btClienteCobroAdicional
            // 
            this.btClienteCobroAdicional.Location = new System.Drawing.Point(623, 264);
            this.btClienteCobroAdicional.Name = "btClienteCobroAdicional";
            this.btClienteCobroAdicional.Size = new System.Drawing.Size(138, 25);
            this.btClienteCobroAdicional.TabIndex = 10;
            this.btClienteCobroAdicional.Text = "Consultar cobro adicional";
            this.btClienteCobroAdicional.UseVisualStyleBackColor = true;
            this.btClienteCobroAdicional.Click += new System.EventHandler(this.btClienteCobroAdicional_Click);
            // 
            // txtValorTotalDescuentos
            // 
            this.txtValorTotalDescuentos.Location = new System.Drawing.Point(391, 280);
            this.txtValorTotalDescuentos.Multiline = true;
            this.txtValorTotalDescuentos.Name = "txtValorTotalDescuentos";
            this.txtValorTotalDescuentos.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotalDescuentos.TabIndex = 44;
            // 
            // lbValorTotalDescuentos
            // 
            this.lbValorTotalDescuentos.AutoSize = true;
            this.lbValorTotalDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalDescuentos.Location = new System.Drawing.Point(388, 209);
            this.lbValorTotalDescuentos.Name = "lbValorTotalDescuentos";
            this.lbValorTotalDescuentos.Size = new System.Drawing.Size(184, 13);
            this.lbValorTotalDescuentos.TabIndex = 43;
            this.lbValorTotalDescuentos.Text = "VALOR TOTAL POR DESCUENTOS";
            // 
            // lbValorTotalDesc
            // 
            this.lbValorTotalDesc.AutoSize = true;
            this.lbValorTotalDesc.Location = new System.Drawing.Point(388, 264);
            this.lbValorTotalDesc.Name = "lbValorTotalDesc";
            this.lbValorTotalDesc.Size = new System.Drawing.Size(145, 13);
            this.lbValorTotalDesc.TabIndex = 42;
            this.lbValorTotalDesc.Text = "Valor total por descuento es: ";
            // 
            // btValorTotalDescuentos
            // 
            this.btValorTotalDescuentos.Location = new System.Drawing.Point(389, 225);
            this.btValorTotalDescuentos.Name = "btValorTotalDescuentos";
            this.btValorTotalDescuentos.Size = new System.Drawing.Size(142, 34);
            this.btValorTotalDescuentos.TabIndex = 8;
            this.btValorTotalDescuentos.Text = "Consultar valor total descuento";
            this.btValorTotalDescuentos.UseVisualStyleBackColor = true;
            this.btValorTotalDescuentos.Click += new System.EventHandler(this.btValorTotalDescuentos_Click);
            // 
            // txtClienteCobroAdicional
            // 
            this.txtClienteCobroAdicional.Location = new System.Drawing.Point(625, 295);
            this.txtClienteCobroAdicional.Multiline = true;
            this.txtClienteCobroAdicional.Name = "txtClienteCobroAdicional";
            this.txtClienteCobroAdicional.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCobroAdicional.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 381);
            this.Controls.Add(this.txtClienteCobroAdicional);
            this.Controls.Add(this.txtValorTotalDescuentos);
            this.Controls.Add(this.lbValorTotalDescuentos);
            this.Controls.Add(this.lbValorTotalDesc);
            this.Controls.Add(this.btValorTotalDescuentos);
            this.Controls.Add(this.btClienteCobroAdicional);
            this.Controls.Add(this.lbClienteCobroAdicional);
            this.Controls.Add(this.lbPorcentajeAhorroEstrato);
            this.Controls.Add(this.lbPorcentajeAhorroEstrato2);
            this.Controls.Add(this.btPorcentajeAhorroEstrato);
            this.Controls.Add(this.txtPromedioConsumo);
            this.Controls.Add(this.lbPromedioConsumo);
            this.Controls.Add(this.lbPromedioConsumoActual);
            this.Controls.Add(this.btPromedioConsumo);
            this.Controls.Add(this.txtCedulaValorTotal);
            this.Controls.Add(this.lbCedulaValorTotalCliente);
            this.Controls.Add(this.lbCedulaValorTotal);
            this.Controls.Add(this.maskedtxtboxValorTotalCedula);
            this.Controls.Add(this.lbValorTotal);
            this.Controls.Add(this.lbEPM);
            this.Controls.Add(this.txtPorcentajeEstrato);
            this.Controls.Add(this.btCedulaValorTotal);
            this.Controls.Add(this.maskedtxtboxMetaAhorro);
            this.Controls.Add(this.maskedtxtboxConsumoActual);
            this.Controls.Add(this.maskedtxtboxCedula);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAsterisco);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lbEstrato);
            this.Controls.Add(this.lbAhorro);
            this.Controls.Add(this.lbConsumoActual);
            this.Controls.Add(this.lbCedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAhorro;
        private System.Windows.Forms.Label lbEstrato;
        private System.Windows.Forms.Label lbConsumoActual;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbAsterisco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstrato;
        private System.Windows.Forms.MaskedTextBox maskedtxtboxCedula;
        private System.Windows.Forms.MaskedTextBox maskedtxtboxConsumoActual;
        private System.Windows.Forms.MaskedTextBox maskedtxtboxMetaAhorro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCedulaValorTotal;
        private System.Windows.Forms.Label lbEPM;
        private System.Windows.Forms.TextBox txtCedulaValorTotal;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.MaskedTextBox maskedtxtboxValorTotalCedula;
        private System.Windows.Forms.Label lbCedulaValorTotal;
        private System.Windows.Forms.Label lbCedulaValorTotalCliente;
        private System.Windows.Forms.TextBox txtPorcentajeEstrato;
        private System.Windows.Forms.TextBox txtPromedioConsumo;
        private System.Windows.Forms.Label lbPromedioConsumo;
        private System.Windows.Forms.Label lbPromedioConsumoActual;
        private System.Windows.Forms.Button btPromedioConsumo;
        private System.Windows.Forms.Label lbPorcentajeAhorroEstrato;
        private System.Windows.Forms.Label lbPorcentajeAhorroEstrato2;
        private System.Windows.Forms.Button btPorcentajeAhorroEstrato;
        private System.Windows.Forms.Label lbClienteCobroAdicional;
        private System.Windows.Forms.Button btClienteCobroAdicional;
        private System.Windows.Forms.TextBox txtValorTotalDescuentos;
        private System.Windows.Forms.Label lbValorTotalDescuentos;
        private System.Windows.Forms.Label lbValorTotalDesc;
        private System.Windows.Forms.Button btValorTotalDescuentos;
        private System.Windows.Forms.TextBox txtClienteCobroAdicional;
    }
}

