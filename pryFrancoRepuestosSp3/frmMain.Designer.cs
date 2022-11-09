namespace pryFrancoRepuestosSp3
{
    partial class frmMain
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
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lstOrigen = new System.Windows.Forms.ComboBox();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.lstMarca1 = new System.Windows.Forms.ComboBox();
            this.rtbDescripcion1 = new System.Windows.Forms.RichTextBox();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.rtbDescripcion2 = new System.Windows.Forms.RichTextBox();
            this.lstMarca2 = new System.Windows.Forms.ComboBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.mrcRepuestos2 = new System.Windows.Forms.GroupBox();
            this.mrcDatos.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.mrcRepuestos2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lstOrigen);
            this.mrcDatos.Controls.Add(this.txtPrecio1);
            this.mrcDatos.Controls.Add(this.btnRegistrar);
            this.mrcDatos.Controls.Add(this.txtNumero1);
            this.mrcDatos.Controls.Add(this.lblPrecio1);
            this.mrcDatos.Controls.Add(this.lblNumero1);
            this.mrcDatos.Controls.Add(this.lblOrigen);
            this.mrcDatos.Controls.Add(this.lblDescripcion1);
            this.mrcDatos.Controls.Add(this.lstMarca1);
            this.mrcDatos.Controls.Add(this.rtbDescripcion1);
            this.mrcDatos.Controls.Add(this.lblMarca1);
            this.mrcDatos.Location = new System.Drawing.Point(16, 15);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4);
            this.mrcDatos.Size = new System.Drawing.Size(912, 300);
            this.mrcDatos.TabIndex = 0;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos de Repuestos";
            // 
            // lstOrigen
            // 
            this.lstOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstOrigen.FormattingEnabled = true;
            this.lstOrigen.Items.AddRange(new object[] {
            "N",
            "I"});
            this.lstOrigen.Location = new System.Drawing.Point(124, 111);
            this.lstOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(160, 24);
            this.lstOrigen.TabIndex = 9;
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(669, 121);
            this.txtPrecio1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio1.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(751, 248);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(669, 55);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero1.MaxLength = 6;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(132, 22);
            this.txtNumero1.TabIndex = 7;
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Location = new System.Drawing.Point(595, 121);
            this.lblPrecio1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio1.TabIndex = 6;
            this.lblPrecio1.Text = "Precio";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(595, 55);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(55, 16);
            this.lblNumero1.TabIndex = 5;
            this.lblNumero1.Text = "Numero";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(27, 121);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 16);
            this.lblOrigen.TabIndex = 4;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Location = new System.Drawing.Point(404, 155);
            this.lblDescripcion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion1.TabIndex = 3;
            this.lblDescripcion1.Text = "Descripcion";
            // 
            // lstMarca1
            // 
            this.lstMarca1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarca1.FormattingEnabled = true;
            this.lstMarca1.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.lstMarca1.Location = new System.Drawing.Point(124, 52);
            this.lstMarca1.Margin = new System.Windows.Forms.Padding(4);
            this.lstMarca1.Name = "lstMarca1";
            this.lstMarca1.Size = new System.Drawing.Size(160, 24);
            this.lstMarca1.TabIndex = 2;
            // 
            // rtbDescripcion1
            // 
            this.rtbDescripcion1.Location = new System.Drawing.Point(304, 175);
            this.rtbDescripcion1.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescripcion1.MaxLength = 50;
            this.rtbDescripcion1.Name = "rtbDescripcion1";
            this.rtbDescripcion1.Size = new System.Drawing.Size(291, 117);
            this.rtbDescripcion1.TabIndex = 0;
            this.rtbDescripcion1.Text = "";
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Location = new System.Drawing.Point(27, 55);
            this.lblMarca1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(45, 16);
            this.lblMarca1.TabIndex = 1;
            this.lblMarca1.Text = "Marca";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(767, 624);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(751, 207);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(100, 28);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(27, 55);
            this.lblMarca2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(45, 16);
            this.lblMarca2.TabIndex = 1;
            this.lblMarca2.Text = "Marca";
            // 
            // rtbDescripcion2
            // 
            this.rtbDescripcion2.Location = new System.Drawing.Point(304, 23);
            this.rtbDescripcion2.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDescripcion2.Name = "rtbDescripcion2";
            this.rtbDescripcion2.Size = new System.Drawing.Size(289, 243);
            this.rtbDescripcion2.TabIndex = 0;
            this.rtbDescripcion2.Text = "";
            // 
            // lstMarca2
            // 
            this.lstMarca2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarca2.FormattingEnabled = true;
            this.lstMarca2.Items.AddRange(new object[] {
            "P",
            "R",
            "F"});
            this.lstMarca2.Location = new System.Drawing.Point(124, 52);
            this.lstMarca2.Margin = new System.Windows.Forms.Padding(4);
            this.lstMarca2.Name = "lstMarca2";
            this.lstMarca2.Size = new System.Drawing.Size(160, 24);
            this.lstMarca2.TabIndex = 2;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Location = new System.Drawing.Point(57, 143);
            this.mrcOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Padding = new System.Windows.Forms.Padding(4);
            this.mrcOrigen.Size = new System.Drawing.Size(239, 123);
            this.mrcOrigen.TabIndex = 9;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(12, 95);
            this.optImportado.Margin = new System.Windows.Forms.Padding(4);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(89, 20);
            this.optImportado.TabIndex = 1;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(12, 47);
            this.optNacional.Margin = new System.Windows.Forms.Padding(4);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(85, 20);
            this.optNacional.TabIndex = 0;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional ";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // mrcRepuestos2
            // 
            this.mrcRepuestos2.Controls.Add(this.btnConsulta);
            this.mrcRepuestos2.Controls.Add(this.mrcOrigen);
            this.mrcRepuestos2.Controls.Add(this.lstMarca2);
            this.mrcRepuestos2.Controls.Add(this.rtbDescripcion2);
            this.mrcRepuestos2.Controls.Add(this.lblMarca2);
            this.mrcRepuestos2.Location = new System.Drawing.Point(16, 322);
            this.mrcRepuestos2.Margin = new System.Windows.Forms.Padding(4);
            this.mrcRepuestos2.Name = "mrcRepuestos2";
            this.mrcRepuestos2.Padding = new System.Windows.Forms.Padding(4);
            this.mrcRepuestos2.Size = new System.Drawing.Size(912, 294);
            this.mrcRepuestos2.TabIndex = 1;
            this.mrcRepuestos2.TabStop = false;
            this.mrcRepuestos2.Text = "Repuestos Ingresados";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 676);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRepuestos2);
            this.Controls.Add(this.mrcDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.mrcRepuestos2.ResumeLayout(false);
            this.mrcRepuestos2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.ComboBox lstOrigen;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.ComboBox lstMarca1;
        private System.Windows.Forms.RichTextBox rtbDescripcion1;
        private System.Windows.Forms.Label lblMarca1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.RichTextBox rtbDescripcion2;
        private System.Windows.Forms.ComboBox lstMarca2;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.GroupBox mrcRepuestos2;
    }
}

