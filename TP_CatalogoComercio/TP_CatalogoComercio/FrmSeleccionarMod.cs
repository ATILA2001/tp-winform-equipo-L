using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

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
                if(txtCodArt.Text.Trim().Length > 0)
                {
                    frmAgregar frmAgregar = new frmAgregar();
                    frmAgregar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("¡Tiene que cargar un Código de Artículo!");
                }
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
        }

        private void txtCodArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
