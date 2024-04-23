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
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.cbCategoriaArt = new System.Windows.Forms.ComboBox();
            this.cbMarcaArt = new System.Windows.Forms.ComboBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dvgArticulos = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.gbPrecio = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            this.gbPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(492, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 37);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Busqueda por filtros";
            // 
            // nudDesde
            // 
            this.nudDesde.Location = new System.Drawing.Point(99, 35);
            this.nudDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDesde.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(101, 30);
            this.nudDesde.TabIndex = 34;
            // 
            // cbCategoriaArt
            // 
            this.cbCategoriaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaArt.FormattingEnabled = true;
            this.cbCategoriaArt.Location = new System.Drawing.Point(968, 158);
            this.cbCategoriaArt.Name = "cbCategoriaArt";
            this.cbCategoriaArt.Size = new System.Drawing.Size(178, 33);
            this.cbCategoriaArt.TabIndex = 1;
            this.cbCategoriaArt.Text = "Categoria";
            // 
            // cbMarcaArt
            // 
            this.cbMarcaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcaArt.FormattingEnabled = true;
            this.cbMarcaArt.Location = new System.Drawing.Point(664, 158);
            this.cbMarcaArt.Name = "cbMarcaArt";
            this.cbMarcaArt.Size = new System.Drawing.Size(178, 33);
            this.cbMarcaArt.TabIndex = 0;
            this.cbMarcaArt.Text = "Marca";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(580, 159);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(78, 25);
            this.lbMarca.TabIndex = 35;
            this.lbMarca.Text = "Marca: ";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(857, 159);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(108, 25);
            this.lbCategoria.TabIndex = 36;
            this.lbCategoria.Text = "Categoria: ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Location = new System.Drawing.Point(147, 532);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 35);
            this.btnVolver.TabIndex = 37;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Lime;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(862, 530);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(117, 35);
            this.btnFiltrar.TabIndex = 38;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.Location = new System.Drawing.Point(147, 207);
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.RowHeadersWidth = 62;
            this.dvgArticulos.RowTemplate.Height = 28;
            this.dvgArticulos.Size = new System.Drawing.Size(999, 275);
            this.dvgArticulos.TabIndex = 39;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1029, 530);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 35);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudHasta
            // 
            this.nudHasta.Location = new System.Drawing.Point(287, 34);
            this.nudHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHasta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(101, 30);
            this.nudHasta.TabIndex = 34;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(17, 36);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(75, 25);
            this.lblDesde.TabIndex = 41;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(211, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(69, 25);
            this.lblHasta.TabIndex = 41;
            this.lblHasta.Text = "Hasta:";
            // 
            // gbPrecio
            // 
            this.gbPrecio.Controls.Add(this.lblDesde);
            this.gbPrecio.Controls.Add(this.lblHasta);
            this.gbPrecio.Controls.Add(this.nudDesde);
            this.gbPrecio.Controls.Add(this.nudHasta);
            this.gbPrecio.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrecio.Location = new System.Drawing.Point(147, 122);
            this.gbPrecio.Name = "gbPrecio";
            this.gbPrecio.Size = new System.Drawing.Size(406, 73);
            this.gbPrecio.TabIndex = 42;
            this.gbPrecio.TabStop = false;
            this.gbPrecio.Text = "Precio";
            // 
            // frmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 641);
            this.ControlBox = false;
            this.Controls.Add(this.gbPrecio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dvgArticulos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.cbCategoriaArt);
            this.Controls.Add(this.cbMarcaArt);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            this.gbPrecio.ResumeLayout(false);
            this.gbPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.ComboBox cbCategoriaArt;
        private System.Windows.Forms.ComboBox cbMarcaArt;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dvgArticulos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.GroupBox gbPrecio;
    }
}