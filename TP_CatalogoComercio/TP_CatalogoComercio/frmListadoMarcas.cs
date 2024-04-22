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
    public partial class frmListadoMarcas : Form
    {
        private List<Marca> listaMarca;
        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcionArt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.listar();
            dgvMarca.DataSource = listaMarca;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
