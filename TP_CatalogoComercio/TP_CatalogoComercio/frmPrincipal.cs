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
            frmAgregar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar frmModificar = new frmModificar();
            frmModificar.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar();
            frmEliminar.ShowDialog();
        }
    }
}
