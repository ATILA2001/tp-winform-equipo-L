namespace TP_CatalogoComercio
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosLosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaConFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem,
            this.gestionArticulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosLosArticulosToolStripMenuItem,
            this.busquedaConFiltrosToolStripMenuItem});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // mostrarTodosLosArticulosToolStripMenuItem
            // 
            this.mostrarTodosLosArticulosToolStripMenuItem.Name = "mostrarTodosLosArticulosToolStripMenuItem";
            this.mostrarTodosLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.mostrarTodosLosArticulosToolStripMenuItem.Text = "Mostrar todos los articulos";
            this.mostrarTodosLosArticulosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosLosArticulosToolStripMenuItem_Click);
            // 
            // busquedaConFiltrosToolStripMenuItem
            // 
            this.busquedaConFiltrosToolStripMenuItem.Name = "busquedaConFiltrosToolStripMenuItem";
            this.busquedaConFiltrosToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.busquedaConFiltrosToolStripMenuItem.Text = "Busqueda con filtros";
            // 
            // gestionArticulosToolStripMenuItem
            // 
            this.gestionArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.gestionArticulosToolStripMenuItem.Name = "gestionArticulosToolStripMenuItem";
            this.gestionArticulosToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.gestionArticulosToolStripMenuItem.Text = "Gestion Articulos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Comercio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosLosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaConFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}

