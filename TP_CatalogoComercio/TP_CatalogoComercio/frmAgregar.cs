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
            Marca marca = new Marca(cbMarcaArt.Text);
            Categoria categoria = new Categoria(cbCategoriaArt.Text);
            Imagen imagen = new Imagen(txtImagenArt.Text);
            Articulo articulo = new Articulo(int.Parse(txtCodArt.Text), txtNombreArt.Text, txtDescripcionArt.Text, marca, categoria, imagen, nudPrecioArt.Value);
            //listView1.Items.Add(articulo.ToString());
            MessageBox.Show("El articulo ha sido cargado exitosamente");
            
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

        private void nudPrecioArt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMarcaArt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
