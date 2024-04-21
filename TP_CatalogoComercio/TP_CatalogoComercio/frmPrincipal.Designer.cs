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
            this.imagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem,
            this.gestionArticulosToolStripMenuItem,
            this.imagenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosLosArticulosToolStripMenuItem,
            this.busquedaConFiltrosToolStripMenuItem});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // mostrarTodosLosArticulosToolStripMenuItem
            // 
            this.mostrarTodosLosArticulosToolStripMenuItem.Name = "mostrarTodosLosArticulosToolStripMenuItem";
            this.mostrarTodosLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.mostrarTodosLosArticulosToolStripMenuItem.Text = "Mostrar todos los articulos";
            this.mostrarTodosLosArticulosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosLosArticulosToolStripMenuItem_Click);
            // 
            // busquedaConFiltrosToolStripMenuItem
            // 
            this.busquedaConFiltrosToolStripMenuItem.Name = "busquedaConFiltrosToolStripMenuItem";
            this.busquedaConFiltrosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.busquedaConFiltrosToolStripMenuItem.Text = "Busqueda con filtros";
            this.busquedaConFiltrosToolStripMenuItem.Click += new System.EventHandler(this.busquedaConFiltrosToolStripMenuItem_Click);
            // 
            // gestionArticulosToolStripMenuItem
            // 
            this.gestionArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.gestionArticulosToolStripMenuItem.Name = "gestionArticulosToolStripMenuItem";
            this.gestionArticulosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.gestionArticulosToolStripMenuItem.Text = "Gestion Articulos";
            this.gestionArticulosToolStripMenuItem.Click += new System.EventHandler(this.gestionArticulosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // imagenesToolStripMenuItem
            // 
            this.imagenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarImagenToolStripMenuItem,
            this.listadoMarcasToolStripMenuItem,
            this.listadoCategoriasToolStripMenuItem});
            this.imagenesToolStripMenuItem.Name = "imagenesToolStripMenuItem";
            this.imagenesToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.imagenesToolStripMenuItem.Text = "Editar";
            this.imagenesToolStripMenuItem.Click += new System.EventHandler(this.imagenesToolStripMenuItem_Click);
            // 
            // cargarImagenToolStripMenuItem
            // 
            this.cargarImagenToolStripMenuItem.Name = "cargarImagenToolStripMenuItem";
            this.cargarImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarImagenToolStripMenuItem.Text = "Cargar imagen";
            this.cargarImagenToolStripMenuItem.Click += new System.EventHandler(this.cargarImagenToolStripMenuItem_Click);
            // 
            // listadoMarcasToolStripMenuItem
            // 
            this.listadoMarcasToolStripMenuItem.Name = "listadoMarcasToolStripMenuItem";
            this.listadoMarcasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoMarcasToolStripMenuItem.Text = "Listado marcas";
            this.listadoMarcasToolStripMenuItem.Click += new System.EventHandler(this.listadoMarcasToolStripMenuItem_Click);
            // 
            // listadoCategoriasToolStripMenuItem
            // 
            this.listadoCategoriasToolStripMenuItem.Name = "listadoCategoriasToolStripMenuItem";
            this.listadoCategoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoCategoriasToolStripMenuItem.Text = "Listado categorias";
            this.listadoCategoriasToolStripMenuItem.Click += new System.EventHandler(this.listadoCategoriasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem imagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoCategoriasToolStripMenuItem;
    }
}

