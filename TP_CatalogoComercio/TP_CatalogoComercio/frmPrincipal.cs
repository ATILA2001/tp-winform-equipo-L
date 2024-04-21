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
            frmMostrarTodos frmMostrarTodos = new frmMostrarTodos();
            frmMostrarTodos.MdiParent = this;
            frmMostrarTodos.Show();

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.MdiParent = this;
            frmAgregar.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeleccionarModificar frmSeleccionar = new frmSeleccionarModificar();
            frmSeleccionar.MdiParent = this;
            frmSeleccionar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar();
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
            frmAgregarImagen frmAgregarImagen = new frmAgregarImagen();
            frmAgregarImagen.MdiParent = this;
            frmAgregarImagen.Show();
        }

        private void listadoMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoMarcas frmListadoMarcas = new frmListadoMarcas();
            frmListadoMarcas.MdiParent = this;
            frmListadoMarcas.Show();
        }

        private void listadoCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoCategoria frmListadoCategoria = new frmListadoCategoria();
            frmListadoCategoria.MdiParent = this;
            frmListadoCategoria.Show();
        }

        private void busquedaConFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltros frmFiltros = new frmFiltros();
            frmFiltros.MdiParent = this;
            frmFiltros.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
