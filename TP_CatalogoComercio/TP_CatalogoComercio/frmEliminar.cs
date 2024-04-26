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
            Articulo art = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            string codeToDelete = txtCodArt.Text.Trim();
            string id = articuloNegocio.searchId(codeToDelete);
            articuloNegocio.eliminar(id);
            MessageBox.Show("El articulo ha sido eliminado exitosamente");
            limpiarControles();
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
        private void limpiarControles()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                txtCodArt.Text = string.Empty;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
