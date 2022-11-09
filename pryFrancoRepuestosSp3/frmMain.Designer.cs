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
            this.rtbDescripcion1 = new System.Windows.Forms.RichTextBox();
            this.lblMarca1 = new System.Windows.Forms.Label();
            this.lstMarca1 = new System.Windows.Forms.ComboBox();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.lstOrigen = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.rtbDescripcion2 = new System.Windows.Forms.RichTextBox();
            this.lstMarca2 = new System.Windows.Forms.ComboBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
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
            this.mrcDatos.Controls.Add(this.txtNumero1);
            this.mrcDatos.Controls.Add(this.lblPrecio1);
            this.mrcDatos.Controls.Add(this.lblNumero1);
            this.mrcDatos.Controls.Add(this.lblOrigen);
            this.mrcDatos.Controls.Add(this.lblDescripcion1);
            this.mrcDatos.Controls.Add(this.lstMarca1);
            this.mrcDatos.Controls.Add(this.rtbDescripcion1);
            this.mrcDatos.Controls.Add(this.lblMarca1);
            this.mrcDatos.Location = new System.Drawing.Point(12, 12);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(684, 244);
            this.mrcDatos.TabIndex = 0;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos de Repuestos";
            // 
            // rtbDescripcion1
            // 
            this.rtbDescripcion1.Location = new System.Drawing.Point(228, 142);
            this.rtbDescripcion1.MaxLength = 50;
            this.rtbDescripcion1.Name = "rtbDescripcion1";
            this.rtbDescripcion1.Size = new System.Drawing.Size(219, 96);
            this.rtbDescripcion1.TabIndex = 0;
            this.rtbDescripcion1.Text = "";
            // 
            // lblMarca1
            // 
            this.lblMarca1.AutoSize = true;
            this.lblMarca1.Location = new System.Drawing.Point(20, 45);
            this.lblMarca1.Name = "lblMarca1";
            this.lblMarca1.Size = new System.Drawing.Size(37, 13);
            this.lblMarca1.TabIndex = 1;
            this.lblMarca1.Text = "Marca";
            // 
            // lstMarca1
            // 
            this.lstMarca1.FormattingEnabled = true;
            this.lstMarca1.Items.AddRange(new object[] {
            "P",
            "F",
            "R"});
            this.lstMarca1.Location = new System.Drawing.Point(93, 42);
            this.lstMarca1.Name = "lstMarca1";
            this.lstMarca1.Size = new System.Drawing.Size(121, 21);
            this.lstMarca1.TabIndex = 2;
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Location = new System.Drawing.Point(303, 126);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion1.TabIndex = 3;
            this.lblDescripcion1.Text = "Descripcion";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(20, 98);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 4;
            this.lblOrigen.Text = "Origen";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(446, 45);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(44, 13);
            this.lblNumero1.TabIndex = 5;
            this.lblNumero1.Text = "Numero";
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Location = new System.Drawing.Point(446, 98);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio1.TabIndex = 6;
            this.lblPrecio1.Text = "Precio";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(502, 45);
            this.txtNumero1.MaxLength = 6;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 7;
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(502, 98);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio1.TabIndex = 8;
            // 
            // lstOrigen
            // 
            this.lstOrigen.FormattingEnabled = true;
            this.lstOrigen.Items.AddRange(new object[] {
            "N",
            "I"});
            this.lstOrigen.Location = new System.Drawing.Point(93, 90);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(121, 21);
            this.lstOrigen.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(713, 29);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 72);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(713, 262);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(20, 45);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(37, 13);
            this.lblMarca2.TabIndex = 1;
            this.lblMarca2.Text = "Marca";
            // 
            // rtbDescripcion2
            // 
            this.rtbDescripcion2.Location = new System.Drawing.Point(459, 19);
            this.rtbDescripcion2.Name = "rtbDescripcion2";
            this.rtbDescripcion2.Size = new System.Drawing.Size(197, 214);
            this.rtbDescripcion2.TabIndex = 0;
            this.rtbDescripcion2.Text = "";
            // 
            // lstMarca2
            // 
            this.lstMarca2.FormattingEnabled = true;
            this.lstMarca2.Items.AddRange(new object[] {
            "P",
            "R",
            "F"});
            this.lstMarca2.Location = new System.Drawing.Point(93, 42);
            this.lstMarca2.Name = "lstMarca2";
            this.lstMarca2.Size = new System.Drawing.Size(121, 21);
            this.lstMarca2.TabIndex = 2;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Location = new System.Drawing.Point(43, 116);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(200, 100);
            this.mrcOrigen.TabIndex = 9;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(9, 38);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(70, 17);
            this.optNacional.TabIndex = 0;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional ";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(9, 77);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 1;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // mrcRepuestos2
            // 
            this.mrcRepuestos2.Controls.Add(this.mrcOrigen);
            this.mrcRepuestos2.Controls.Add(this.lstMarca2);
            this.mrcRepuestos2.Controls.Add(this.rtbDescripcion2);
            this.mrcRepuestos2.Controls.Add(this.lblMarca2);
            this.mrcRepuestos2.Location = new System.Drawing.Point(12, 262);
            this.mrcRepuestos2.Name = "mrcRepuestos2";
            this.mrcRepuestos2.Size = new System.Drawing.Size(684, 239);
            this.mrcRepuestos2.TabIndex = 1;
            this.mrcRepuestos2.TabStop = false;
            this.mrcRepuestos2.Text = "Repuestos Ingresados";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcRepuestos2);
            this.Controls.Add(this.mrcDatos);
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

