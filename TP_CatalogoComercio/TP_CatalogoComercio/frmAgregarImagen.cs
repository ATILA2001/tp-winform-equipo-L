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
    public partial class frmAgregarImagen : Form
    {
        private List<Imagen> listaImagen;
        public frmAgregarImagen()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La imagen ha sido cargada exitosamente");
            Close();
        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarImagen_Load(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            listaImagen = negocio.listar();
            //dgvImagenes.Columns["ImagenUrl"].Visible = false;
            dgvImagenes.DataSource = listaImagen;
        }
    }
}
