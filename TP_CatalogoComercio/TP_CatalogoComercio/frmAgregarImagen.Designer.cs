﻿namespace TP_CatalogoComercio
{
    partial class frmAgregarImagen
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
            this.lblImagenArt = new System.Windows.Forms.Label();
            this.txtImagenArt = new System.Windows.Forms.TextBox();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.btnCancelarArt = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(287, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 26);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Agregar Imagen";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblImagenArt
            // 
            this.lblImagenArt.AutoSize = true;
            this.lblImagenArt.Location = new System.Drawing.Point(21, 128);
            this.lblImagenArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenArt.Name = "lblImagenArt";
            this.lblImagenArt.Size = new System.Drawing.Size(45, 13);
            this.lblImagenArt.TabIndex = 36;
            this.lblImagenArt.Text = "Imagen:";
            // 
            // txtImagenArt
            // 
            this.txtImagenArt.Location = new System.Drawing.Point(71, 126);
            this.txtImagenArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtImagenArt.Name = "txtImagenArt";
            this.txtImagenArt.Size = new System.Drawing.Size(141, 20);
            this.txtImagenArt.TabIndex = 35;
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(73, 78);
            this.txtCodArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(141, 20);
            this.txtCodArt.TabIndex = 34;
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(23, 82);
            this.lblCodArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(43, 13);
            this.lblCodArt.TabIndex = 33;
            this.lblCodArt.Text = "Código:";
            // 
            // btnCancelarArt
            // 
            this.btnCancelarArt.BackColor = System.Drawing.Color.Red;
            this.btnCancelarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarArt.Location = new System.Drawing.Point(608, 327);
            this.btnCancelarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarArt.Name = "btnCancelarArt";
            this.btnCancelarArt.Size = new System.Drawing.Size(66, 23);
            this.btnCancelarArt.TabIndex = 32;
            this.btnCancelarArt.Text = "Cancelar";
            this.btnCancelarArt.UseVisualStyleBackColor = false;
            this.btnCancelarArt.Click += new System.EventHandler(this.btnCancelarArt_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(713, 327);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 23);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.Location = new System.Drawing.Point(73, 183);
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.Size = new System.Drawing.Size(139, 150);
            this.dgvImagenes.TabIndex = 37;
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblImagenArt);
            this.Controls.Add(this.txtImagenArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.lblCodArt);
            this.Controls.Add(this.btnCancelarArt);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgregarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblImagenArt;
        private System.Windows.Forms.TextBox txtImagenArt;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Button btnCancelarArt;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvImagenes;
    }
}