namespace TP_CatalogoComercio
{
    partial class frmListadoCategoria
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
            this.bnVolver = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcionArt = new System.Windows.Forms.Label();
            this.txtDescripcionArt = new System.Windows.Forms.TextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnVolver
            // 
            this.bnVolver.BackColor = System.Drawing.Color.Red;
            this.bnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnVolver.Location = new System.Drawing.Point(707, 374);
            this.bnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(66, 23);
            this.bnVolver.TabIndex = 44;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = false;
            this.bnVolver.Click += new System.EventHandler(this.bnVolver_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(121, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(141, 245);
            this.listView1.TabIndex = 43;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Listado actual";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(300, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 26);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Listado Categorias";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblDescripcionArt
            // 
            this.lblDescripcionArt.AutoSize = true;
            this.lblDescripcionArt.Location = new System.Drawing.Point(11, 96);
            this.lblDescripcionArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionArt.Name = "lblDescripcionArt";
            this.lblDescripcionArt.Size = new System.Drawing.Size(92, 13);
            this.lblDescripcionArt.TabIndex = 41;
            this.lblDescripcionArt.Text = "Agregar Categoria";
            // 
            // txtDescripcionArt
            // 
            this.txtDescripcionArt.Location = new System.Drawing.Point(121, 96);
            this.txtDescripcionArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionArt.Name = "txtDescripcionArt";
            this.txtDescripcionArt.Size = new System.Drawing.Size(141, 20);
            this.txtDescripcionArt.TabIndex = 40;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Red;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEliminar.Location = new System.Drawing.Point(290, 374);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(66, 23);
            this.btEliminar.TabIndex = 39;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(290, 94);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(66, 23);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescripcionArt);
            this.Controls.Add(this.txtDescripcionArt);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmListadoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoCategoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnVolver;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcionArt;
        private System.Windows.Forms.TextBox txtDescripcionArt;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}