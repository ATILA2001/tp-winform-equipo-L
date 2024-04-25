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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El articulo ha sido eliminado exitosamente");
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {

        }

        private void txtCodArt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
