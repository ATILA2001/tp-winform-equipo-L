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
    public partial class frmSeleccionarModificar : Form
    {
        List<Articulo> listaArticulo;
        public frmSeleccionarModificar()
        {
            InitializeComponent();
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo artSeleccionado;
                artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmModificar frmModificar = new frmModificar(artSeleccionado);
                frmModificar.ShowDialog();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSeleccionarModificar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["Imagen"].Visible = false;
        }
    }
}
