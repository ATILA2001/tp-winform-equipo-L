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
    }
}
