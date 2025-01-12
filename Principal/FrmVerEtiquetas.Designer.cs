namespace Principal
{
    partial class FrmVerEtiquetas
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
            this.dtgEtiquetas = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEtiquetas
            // 
            this.dtgEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEtiquetas.Location = new System.Drawing.Point(12, 12);
            this.dtgEtiquetas.Name = "dtgEtiquetas";
            this.dtgEtiquetas.Size = new System.Drawing.Size(1049, 303);
            this.dtgEtiquetas.TabIndex = 0;
            this.dtgEtiquetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEtiquetas_CellClick);
            this.dtgEtiquetas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEtiquetas_CellEnter);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 328);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(105, 38);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmVerEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 378);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgEtiquetas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVerEtiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas";
            this.Load += new System.EventHandler(this.FrmVerEtiquetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEtiquetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEtiquetas;
        private System.Windows.Forms.Button btnRegresar;
    }
}