namespace Principal
{
    partial class FrmEtiquetas
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
            this.txtPiezas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pCodigo = new System.Windows.Forms.Panel();
            this.dtgEtiquetas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPiezas
            // 
            this.txtPiezas.Location = new System.Drawing.Point(381, 361);
            this.txtPiezas.Name = "txtPiezas";
            this.txtPiezas.Size = new System.Drawing.Size(69, 26);
            this.txtPiezas.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad de piezas";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(381, 262);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(106, 26);
            this.txtAncho.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "x";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(515, 262);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(106, 26);
            this.txtAltura.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Barra",
            "QR"});
            this.cmbTipo.Location = new System.Drawing.Point(180, 262);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(157, 28);
            this.cmbTipo.TabIndex = 11;
            // 
            // pCodigo
            // 
            this.pCodigo.Location = new System.Drawing.Point(12, 235);
            this.pCodigo.Name = "pCodigo";
            this.pCodigo.Size = new System.Drawing.Size(162, 152);
            this.pCodigo.TabIndex = 10;
            // 
            // dtgEtiquetas
            // 
            this.dtgEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEtiquetas.Location = new System.Drawing.Point(12, 12);
            this.dtgEtiquetas.Name = "dtgEtiquetas";
            this.dtgEtiquetas.Size = new System.Drawing.Size(609, 216);
            this.dtgEtiquetas.TabIndex = 9;
            this.dtgEtiquetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEtiquetas_CellClick);
            this.dtgEtiquetas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEtiquetas_CellEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ancho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Altura";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(627, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(46, 33);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Barra",
            "QR"});
            this.cmbProducto.Location = new System.Drawing.Point(185, 359);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(136, 28);
            this.cmbProducto.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(547, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 38);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 400);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPiezas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.pCodigo);
            this.Controls.Add(this.dtgEtiquetas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEtiquetas";
            this.Load += new System.EventHandler(this.FrmEtiquetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPiezas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Panel pCodigo;
        private System.Windows.Forms.DataGridView dtgEtiquetas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnGuardar;
    }
}