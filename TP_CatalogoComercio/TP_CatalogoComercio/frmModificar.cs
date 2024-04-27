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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void cbMarcaArt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoriaArt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El articulo ha sido modificado exitosamente");
            Close();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
