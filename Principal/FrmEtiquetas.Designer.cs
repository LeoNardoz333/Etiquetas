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
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPiezas
            // 
            this.txtPiezas.Location = new System.Drawing.Point(185, 361);
            this.txtPiezas.Name = "txtPiezas";
            this.txtPiezas.Size = new System.Drawing.Size(69, 26);
            this.txtPiezas.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad de piezas";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(469, 332);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(39, 26);
            this.txtAncho.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "x";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(402, 332);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(39, 26);
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
            this.dtgEtiquetas.Size = new System.Drawing.Size(680, 216);
            this.dtgEtiquetas.TabIndex = 9;
            // 
            // FrmEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 400);
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
    }
}