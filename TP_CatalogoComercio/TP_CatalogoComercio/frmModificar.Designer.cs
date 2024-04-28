namespace TP_CatalogoComercio
{
    partial class frmModificar
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
            this.btnCancelarArt = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbOpcionalArt = new System.Windows.Forms.GroupBox();
            this.cbCategoriaArt = new System.Windows.Forms.ComboBox();
            this.cbMarcaArt = new System.Windows.Forms.ComboBox();
            this.gbArt = new System.Windows.Forms.GroupBox();
            this.nudPrecioArt = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioArt = new System.Windows.Forms.Label();
            this.lblImagenArt = new System.Windows.Forms.Label();
            this.lblDescripcionArt = new System.Windows.Forms.Label();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.txtImagenArt = new System.Windows.Forms.TextBox();
            this.txtDescripcionArt = new System.Windows.Forms.TextBox();
            this.txtNombreArt = new System.Windows.Forms.TextBox();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.gbOpcionalArt.SuspendLayout();
            this.gbArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(266, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modificar Artículo";
            // 
            // btnCancelarArt
            // 
            this.btnCancelarArt.BackColor = System.Drawing.Color.Red;
            this.btnCancelarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarArt.Location = new System.Drawing.Point(480, 329);
            this.btnCancelarArt.Name = "btnCancelarArt";
            this.btnCancelarArt.Size = new System.Drawing.Size(99, 35);
            this.btnCancelarArt.TabIndex = 19;
            this.btnCancelarArt.Text = "Cancelar";
            this.btnCancelarArt.UseVisualStyleBackColor = false;
            this.btnCancelarArt.Click += new System.EventHandler(this.btnCancelarArt_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Lime;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(638, 329);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 35);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gbOpcionalArt
            // 
            this.gbOpcionalArt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbOpcionalArt.Controls.Add(this.cbCategoriaArt);
            this.gbOpcionalArt.Controls.Add(this.cbMarcaArt);
            this.gbOpcionalArt.Location = new System.Drawing.Point(458, 109);
            this.gbOpcionalArt.Name = "gbOpcionalArt";
            this.gbOpcionalArt.Size = new System.Drawing.Size(292, 165);
            this.gbOpcionalArt.TabIndex = 17;
            this.gbOpcionalArt.TabStop = false;
            this.gbOpcionalArt.Text = "Opcional";
            // 
            // cbCategoriaArt
            // 
            this.cbCategoriaArt.FormattingEnabled = true;
            this.cbCategoriaArt.Location = new System.Drawing.Point(86, 102);
            this.cbCategoriaArt.Name = "cbCategoriaArt";
            this.cbCategoriaArt.Size = new System.Drawing.Size(121, 28);
            this.cbCategoriaArt.TabIndex = 1;
            this.cbCategoriaArt.Text = "Categoria";
            this.cbCategoriaArt.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaArt_SelectedIndexChanged);
            // 
            // cbMarcaArt
            // 
            this.cbMarcaArt.FormattingEnabled = true;
            this.cbMarcaArt.Location = new System.Drawing.Point(86, 40);
            this.cbMarcaArt.Name = "cbMarcaArt";
            this.cbMarcaArt.Size = new System.Drawing.Size(121, 28);
            this.cbMarcaArt.TabIndex = 0;
            this.cbMarcaArt.Text = "Marca";
            this.cbMarcaArt.SelectedIndexChanged += new System.EventHandler(this.cbMarcaArt_SelectedIndexChanged);
            // 
            // gbArt
            // 
            this.gbArt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbArt.Controls.Add(this.nudPrecioArt);
            this.gbArt.Controls.Add(this.lblPrecioArt);
            this.gbArt.Controls.Add(this.lblImagenArt);
            this.gbArt.Controls.Add(this.lblDescripcionArt);
            this.gbArt.Controls.Add(this.lblNombreArt);
            this.gbArt.Controls.Add(this.txtImagenArt);
            this.gbArt.Controls.Add(this.txtDescripcionArt);
            this.gbArt.Controls.Add(this.txtNombreArt);
            this.gbArt.Controls.Add(this.txtCodArt);
            this.gbArt.Controls.Add(this.lblCodArt);
            this.gbArt.Location = new System.Drawing.Point(48, 109);
            this.gbArt.Name = "gbArt";
            this.gbArt.Size = new System.Drawing.Size(356, 285);
            this.gbArt.TabIndex = 16;
            this.gbArt.TabStop = false;
            this.gbArt.Text = "Artículo";
            // 
            // nudPrecioArt
            // 
            this.nudPrecioArt.Location = new System.Drawing.Point(123, 225);
            this.nudPrecioArt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPrecioArt.Name = "nudPrecioArt";
            this.nudPrecioArt.Size = new System.Drawing.Size(210, 26);
            this.nudPrecioArt.TabIndex = 15;
            this.nudPrecioArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecioArt
            // 
            this.lblPrecioArt.AutoSize = true;
            this.lblPrecioArt.Location = new System.Drawing.Point(58, 228);
            this.lblPrecioArt.Name = "lblPrecioArt";
            this.lblPrecioArt.Size = new System.Drawing.Size(57, 20);
            this.lblPrecioArt.TabIndex = 30;
            this.lblPrecioArt.Text = "Precio:";
            // 
            // lblImagenArt
            // 
            this.lblImagenArt.AutoSize = true;
            this.lblImagenArt.Location = new System.Drawing.Point(48, 182);
            this.lblImagenArt.Name = "lblImagenArt";
            this.lblImagenArt.Size = new System.Drawing.Size(67, 20);
            this.lblImagenArt.TabIndex = 29;
            this.lblImagenArt.Text = "Imagen:";
            // 
            // lblDescripcionArt
            // 
            this.lblDescripcionArt.AutoSize = true;
            this.lblDescripcionArt.Location = new System.Drawing.Point(21, 132);
            this.lblDescripcionArt.Name = "lblDescripcionArt";
            this.lblDescripcionArt.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcionArt.TabIndex = 28;
            this.lblDescripcionArt.Text = "Descripción:";
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Location = new System.Drawing.Point(48, 86);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(69, 20);
            this.lblNombreArt.TabIndex = 27;
            this.lblNombreArt.Text = "Nombre:";
            // 
            // txtImagenArt
            // 
            this.txtImagenArt.Location = new System.Drawing.Point(123, 178);
            this.txtImagenArt.Name = "txtImagenArt";
            this.txtImagenArt.Size = new System.Drawing.Size(210, 26);
            this.txtImagenArt.TabIndex = 25;
            // 
            // txtDescripcionArt
            // 
            this.txtDescripcionArt.Location = new System.Drawing.Point(123, 129);
            this.txtDescripcionArt.Name = "txtDescripcionArt";
            this.txtDescripcionArt.Size = new System.Drawing.Size(210, 26);
            this.txtDescripcionArt.TabIndex = 24;
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(123, 83);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(210, 26);
            this.txtNombreArt.TabIndex = 23;
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(123, 34);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(210, 26);
            this.txtCodArt.TabIndex = 22;
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(48, 40);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(63, 20);
            this.lblCodArt.TabIndex = 21;
            this.lblCodArt.Text = "Código:";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1467, 837);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarArt);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbOpcionalArt);
            this.Controls.Add(this.gbArt);
            this.Controls.Add(this.lblTitulo);
            this.MaximumSize = new System.Drawing.Size(1489, 893);
            this.Name = "frmModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Articulos";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.gbOpcionalArt.ResumeLayout(false);
            this.gbArt.ResumeLayout(false);
            this.gbArt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelarArt;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbOpcionalArt;
        private System.Windows.Forms.ComboBox cbCategoriaArt;
        private System.Windows.Forms.ComboBox cbMarcaArt;
        private System.Windows.Forms.GroupBox gbArt;
        private System.Windows.Forms.NumericUpDown nudPrecioArt;
        private System.Windows.Forms.Label lblPrecioArt;
        private System.Windows.Forms.Label lblImagenArt;
        private System.Windows.Forms.Label lblDescripcionArt;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.TextBox txtImagenArt;
        private System.Windows.Forms.TextBox txtDescripcionArt;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.Label lblCodArt;
    }
}