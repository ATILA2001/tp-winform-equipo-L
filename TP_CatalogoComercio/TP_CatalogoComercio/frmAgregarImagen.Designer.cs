namespace TP_CatalogoComercio
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
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(430, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 37);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Agregar Imagen";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblImagenArt
            // 
            this.lblImagenArt.AutoSize = true;
            this.lblImagenArt.Location = new System.Drawing.Point(32, 197);
            this.lblImagenArt.Name = "lblImagenArt";
            this.lblImagenArt.Size = new System.Drawing.Size(67, 20);
            this.lblImagenArt.TabIndex = 36;
            this.lblImagenArt.Text = "Imagen:";
            // 
            // txtImagenArt
            // 
            this.txtImagenArt.Location = new System.Drawing.Point(106, 194);
            this.txtImagenArt.Name = "txtImagenArt";
            this.txtImagenArt.Size = new System.Drawing.Size(210, 26);
            this.txtImagenArt.TabIndex = 35;
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(110, 120);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(210, 26);
            this.txtCodArt.TabIndex = 34;
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(34, 126);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(63, 20);
            this.lblCodArt.TabIndex = 33;
            this.lblCodArt.Text = "Código:";
            // 
            // btnCancelarArt
            // 
            this.btnCancelarArt.BackColor = System.Drawing.Color.Red;
            this.btnCancelarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarArt.Location = new System.Drawing.Point(912, 503);
            this.btnCancelarArt.Name = "btnCancelarArt";
            this.btnCancelarArt.Size = new System.Drawing.Size(99, 35);
            this.btnCancelarArt.TabIndex = 32;
            this.btnCancelarArt.Text = "Cancelar";
            this.btnCancelarArt.UseVisualStyleBackColor = false;
            this.btnCancelarArt.Click += new System.EventHandler(this.btnCancelarArt_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(1070, 503);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 35);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 641);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblImagenArt);
            this.Controls.Add(this.txtImagenArt);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.lblCodArt);
            this.Controls.Add(this.btnCancelarArt);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgregarImagen_Load);
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
    }
}