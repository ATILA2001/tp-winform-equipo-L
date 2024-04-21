using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CatalogoComercio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mostrarTodosLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmMostrarTodos frmMostrarTodos = new frmMostrarTodos();
            frmMostrarTodos.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmMostrarTodos.MdiParent = this;
            frmMostrarTodos.Show();

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmAgregar.MdiParent = this;
            frmAgregar.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmSeleccionarModificar frmSeleccionar = new frmSeleccionarModificar();
            frmSeleccionar.FormClosed += (s,args) =>
            {
                panelMain.Visible = true; 
            };
            frmSeleccionar.MdiParent = this;
            frmSeleccionar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmEliminar frmEliminar = new frmEliminar();
            frmEliminar.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmEliminar.MdiParent= this;
            frmEliminar.Show();
        }

        private void gestionArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cargarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmAgregarImagen frmAgregarImagen = new frmAgregarImagen();
            frmAgregarImagen.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmAgregarImagen.MdiParent = this;
            frmAgregarImagen.Show();
        }

        private void listadoMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmListadoMarcas frmListadoMarcas = new frmListadoMarcas();
            frmListadoMarcas.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmListadoMarcas.MdiParent = this;
            frmListadoMarcas.Show();
        }

        private void listadoCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmListadoCategoria frmListadoCategoria = new frmListadoCategoria();
            frmListadoCategoria.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmListadoCategoria.MdiParent = this;
            frmListadoCategoria.Show();
        }

        private void busquedaConFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmFiltros frmFiltros = new frmFiltros();
            frmFiltros.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmFiltros.MdiParent = this;
            frmFiltros.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmAgregar.MdiParent = this;
            frmAgregar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmSeleccionarModificar frmSeleccionar = new frmSeleccionarModificar();
            frmSeleccionar.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmSeleccionar.MdiParent = this;
            frmSeleccionar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmEliminar frmEliminar = new frmEliminar();
            frmEliminar.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmEliminar.MdiParent = this;
            frmEliminar.Show();
        }
    }
}
