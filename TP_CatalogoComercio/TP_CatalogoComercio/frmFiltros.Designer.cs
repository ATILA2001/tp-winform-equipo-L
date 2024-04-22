namespace TP_CatalogoComercio
{
    partial class frmFiltros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbCategoriaArt = new System.Windows.Forms.ComboBox();
            this.cbMarcaArt = new System.Windows.Forms.ComboBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(289, 35);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 26);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Busqueda por filtros";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(11, 109);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 33;
            this.lblPrecio.Text = "Precio: ";
            this.lblPrecio.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 34;
            // 
            // cbCategoriaArt
            // 
            this.cbCategoriaArt.FormattingEnabled = true;
            this.cbCategoriaArt.Location = new System.Drawing.Point(69, 204);
            this.cbCategoriaArt.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoriaArt.Name = "cbCategoriaArt";
            this.cbCategoriaArt.Size = new System.Drawing.Size(120, 21);
            this.cbCategoriaArt.TabIndex = 1;
            this.cbCategoriaArt.Text = "Categoria";
            // 
            // cbMarcaArt
            // 
            this.cbMarcaArt.FormattingEnabled = true;
            this.cbMarcaArt.Location = new System.Drawing.Point(69, 156);
            this.cbMarcaArt.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarcaArt.Name = "cbMarcaArt";
            this.cbMarcaArt.Size = new System.Drawing.Size(120, 21);
            this.cbMarcaArt.TabIndex = 0;
            this.cbMarcaArt.Text = "Marca";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(11, 159);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(43, 13);
            this.lbMarca.TabIndex = 35;
            this.lbMarca.Text = "Marca: ";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(11, 207);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(58, 13);
            this.lbCategoria.TabIndex = 36;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Location = new System.Drawing.Point(648, 298);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(66, 23);
            this.btnVolver.TabIndex = 37;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.cbCategoriaArt);
            this.Controls.Add(this.cbMarcaArt);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbCategoriaArt;
        private System.Windows.Forms.ComboBox cbMarcaArt;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btnVolver;
    }
}