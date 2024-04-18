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
    }
}
