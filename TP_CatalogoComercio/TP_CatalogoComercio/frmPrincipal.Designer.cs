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
            this.imagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbGestion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbBúsqueda = new System.Windows.Forms.GroupBox();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gbGestion.SuspendLayout();
            this.gbBúsqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaToolStripMenuItem,
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelMain.Controls.Add(this.gbGestion);
            this.panelMain.Controls.Add(this.gbBúsqueda);
            this.panelMain.Location = new System.Drawing.Point(0, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 424);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // gbGestion
            // 
            this.gbGestion.Controls.Add(this.btnEliminar);
            this.gbGestion.Controls.Add(this.btnModificar);
            this.gbGestion.Controls.Add(this.btnAgregar);
            this.gbGestion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestion.Location = new System.Drawing.Point(70, 99);
            this.gbGestion.Name = "gbGestion";
            this.gbGestion.Size = new System.Drawing.Size(182, 216);
            this.gbGestion.TabIndex = 1;
            this.gbGestion.TabStop = false;
            this.gbGestion.Text = "Gestión de artículos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(30, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(30, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(30, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbBúsqueda
            // 
            this.gbBúsqueda.Controls.Add(this.btnFiltros);
            this.gbBúsqueda.Controls.Add(this.btnVerTodos);
            this.gbBúsqueda.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBúsqueda.Location = new System.Drawing.Point(300, 99);
            this.gbBúsqueda.Name = "gbBúsqueda";
            this.gbBúsqueda.Size = new System.Drawing.Size(182, 216);
            this.gbBúsqueda.TabIndex = 0;
            this.gbBúsqueda.TabStop = false;
            this.gbBúsqueda.Text = "Búsqueda";
            // 
            // btnFiltros
            // 
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.Location = new System.Drawing.Point(30, 125);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(122, 23);
            this.btnFiltros.TabIndex = 0;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.Location = new System.Drawing.Point(30, 75);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(122, 23);
            this.btnVerTodos.TabIndex = 2;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Comercio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.gbGestion.ResumeLayout(false);
            this.gbBúsqueda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosLosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaConFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoCategoriasToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbGestion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbBúsqueda;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnVerTodos;
    }
}

