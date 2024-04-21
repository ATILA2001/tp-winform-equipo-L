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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El articulo ha sido cargado exitosamente");
            Close();
        }

        private void lblCodArt_Click(object sender, EventArgs e)
        {

        }

        private void txtCodArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblImagenArt_Click(object sender, EventArgs e)
        {

        }

        private void txtImagenArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
