﻿namespace TP_CatalogoComercio
{
    partial class frmAgregar
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
            this.gbOpcionalArt = new System.Windows.Forms.GroupBox();
            this.cbCategoriaArt = new System.Windows.Forms.ComboBox();
            this.cbMarcaArt = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelarArt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioArt)).BeginInit();
            this.gbOpcionalArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(177, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Artículo";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
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
            this.gbArt.Location = new System.Drawing.Point(20, 55);
            this.gbArt.Margin = new System.Windows.Forms.Padding(2);
            this.gbArt.Name = "gbArt";
            this.gbArt.Padding = new System.Windows.Forms.Padding(2);
            this.gbArt.Size = new System.Drawing.Size(237, 185);
            this.gbArt.TabIndex = 11;
            this.gbArt.TabStop = false;
            this.gbArt.Text = "Artículo";
            // 
            // nudPrecioArt
            // 
            this.nudPrecioArt.DecimalPlaces = 2;
            this.nudPrecioArt.Location = new System.Drawing.Point(82, 146);
            this.nudPrecioArt.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioArt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPrecioArt.Name = "nudPrecioArt";
            this.nudPrecioArt.Size = new System.Drawing.Size(141, 20);
            this.nudPrecioArt.TabIndex = 15;
            this.nudPrecioArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrecioArt.ValueChanged += new System.EventHandler(this.nudPrecioArt_ValueChanged);
            // 
            // lblPrecioArt
            // 
            this.lblPrecioArt.AutoSize = true;
            this.lblPrecioArt.Location = new System.Drawing.Point(39, 148);
            this.lblPrecioArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioArt.Name = "lblPrecioArt";
            this.lblPrecioArt.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArt.TabIndex = 30;
            this.lblPrecioArt.Text = "Precio:";
            // 
            // lblImagenArt
            // 
            this.lblImagenArt.AutoSize = true;
            this.lblImagenArt.Location = new System.Drawing.Point(32, 118);
            this.lblImagenArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenArt.Name = "lblImagenArt";
            this.lblImagenArt.Size = new System.Drawing.Size(45, 13);
            this.lblImagenArt.TabIndex = 29;
            this.lblImagenArt.Text = "Imagen:";
            this.lblImagenArt.Click += new System.EventHandler(this.lblImagenArt_Click);
            // 
            // lblDescripcionArt
            // 
            this.lblDescripcionArt.AutoSize = true;
            this.lblDescripcionArt.Location = new System.Drawing.Point(14, 86);
            this.lblDescripcionArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionArt.Name = "lblDescripcionArt";
            this.lblDescripcionArt.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionArt.TabIndex = 28;
            this.lblDescripcionArt.Text = "Descripción:";
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Location = new System.Drawing.Point(32, 56);
            this.lblNombreArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArt.TabIndex = 27;
            this.lblNombreArt.Text = "Nombre:";
            // 
            // txtImagenArt
            // 
            this.txtImagenArt.Location = new System.Drawing.Point(82, 116);
            this.txtImagenArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagenArt.Name = "txtImagenArt";
            this.txtImagenArt.Size = new System.Drawing.Size(141, 20);
            this.txtImagenArt.TabIndex = 25;
            this.txtImagenArt.TextChanged += new System.EventHandler(this.txtImagenArt_TextChanged);
            // 
            // txtDescripcionArt
            // 
            this.txtDescripcionArt.Location = new System.Drawing.Point(82, 84);
            this.txtDescripcionArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionArt.Name = "txtDescripcionArt";
            this.txtDescripcionArt.Size = new System.Drawing.Size(141, 20);
            this.txtDescripcionArt.TabIndex = 24;
            // 
            // txtNombreArt
            // 
            this.txtNombreArt.Location = new System.Drawing.Point(82, 54);
            this.txtNombreArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreArt.Name = "txtNombreArt";
            this.txtNombreArt.Size = new System.Drawing.Size(141, 20);
            this.txtNombreArt.TabIndex = 23;
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(82, 22);
            this.txtCodArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(141, 20);
            this.txtCodArt.TabIndex = 22;
            this.txtCodArt.TextChanged += new System.EventHandler(this.txtCodArt_TextChanged);
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(32, 26);
            this.lblCodArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(43, 13);
            this.lblCodArt.TabIndex = 21;
            this.lblCodArt.Text = "Código:";
            this.lblCodArt.Click += new System.EventHandler(this.lblCodArt_Click);
            // 
            // gbOpcionalArt
            // 
            this.gbOpcionalArt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbOpcionalArt.Controls.Add(this.cbCategoriaArt);
            this.gbOpcionalArt.Controls.Add(this.cbMarcaArt);
            this.gbOpcionalArt.Location = new System.Drawing.Point(293, 55);
            this.gbOpcionalArt.Margin = new System.Windows.Forms.Padding(2);
            this.gbOpcionalArt.Name = "gbOpcionalArt";
            this.gbOpcionalArt.Padding = new System.Windows.Forms.Padding(2);
            this.gbOpcionalArt.Size = new System.Drawing.Size(195, 107);
            this.gbOpcionalArt.TabIndex = 12;
            this.gbOpcionalArt.TabStop = false;
            this.gbOpcionalArt.Text = "Opcional";
            // 
            // cbCategoriaArt
            // 
            this.cbCategoriaArt.FormattingEnabled = true;
            this.cbCategoriaArt.Location = new System.Drawing.Point(57, 66);
            this.cbCategoriaArt.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoriaArt.Name = "cbCategoriaArt";
            this.cbCategoriaArt.Size = new System.Drawing.Size(82, 21);
            this.cbCategoriaArt.TabIndex = 1;
            this.cbCategoriaArt.Text = "Categoria";
            // 
            // cbMarcaArt
            // 
            this.cbMarcaArt.FormattingEnabled = true;
            this.cbMarcaArt.Location = new System.Drawing.Point(57, 26);
            this.cbMarcaArt.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarcaArt.Name = "cbMarcaArt";
            this.cbMarcaArt.Size = new System.Drawing.Size(82, 21);
            this.cbMarcaArt.TabIndex = 0;
            this.cbMarcaArt.Text = "Marca";
            this.cbMarcaArt.SelectedIndexChanged += new System.EventHandler(this.cbMarcaArt_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(413, 198);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelarArt
            // 
            this.btnCancelarArt.BackColor = System.Drawing.Color.Red;
            this.btnCancelarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarArt.Location = new System.Drawing.Point(308, 198);
            this.btnCancelarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarArt.Name = "btnCancelarArt";
            this.btnCancelarArt.Size = new System.Drawing.Size(66, 23);
            this.btnCancelarArt.TabIndex = 14;
            this.btnCancelarArt.Text = "Cancelar";
            this.btnCancelarArt.UseVisualStyleBackColor = false;
            this.btnCancelarArt.Click += new System.EventHandler(this.btnCancelarArt_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(534, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(228, 243);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCancelarArt);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbOpcionalArt);
            this.Controls.Add(this.gbArt);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbArt.ResumeLayout(false);
            this.gbArt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioArt)).EndInit();
            this.gbOpcionalArt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbArt;
        private System.Windows.Forms.Label lblPrecioArt;
        private System.Windows.Forms.Label lblImagenArt;
        private System.Windows.Forms.Label lblDescripcionArt;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.TextBox txtImagenArt;
        private System.Windows.Forms.TextBox txtDescripcionArt;
        private System.Windows.Forms.TextBox txtNombreArt;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.GroupBox gbOpcionalArt;
        private System.Windows.Forms.ComboBox cbMarcaArt;
        private System.Windows.Forms.ComboBox cbCategoriaArt;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelarArt;
        private System.Windows.Forms.NumericUpDown nudPrecioArt;
        private System.Windows.Forms.ListView listView1;
    }
}