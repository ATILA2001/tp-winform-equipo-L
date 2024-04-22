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
    public partial class frmListadoCategoria : Form
    {
        private List<Categoria> listaCategoria;
        public frmListadoCategoria()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.listar();
            dgvCategoria.DataSource = listaCategoria;

        }

        private void lblDescripcionArt_Click(object sender, EventArgs e)
        {

        }
    }
}
