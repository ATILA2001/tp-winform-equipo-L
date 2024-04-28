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
    public partial class frmModificar : Form
    {
        private Articulo articulo = null;

        public frmModificar()
        {
            InitializeComponent();
        }
        internal frmModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar";
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
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();
                articulo.Imagen = new Imagen();
                articulo.Marca = new Marca();
                articulo.Categoria = new Categoria();
                articulo.CodigoArticulo = txtCodArt.Text;
                articulo.Nombre = txtNombreArt.Text;
                articulo.Descripcion = txtDescripcionArt.Text;
                articulo.Imagen.Url = txtImagenArt.Text;
                articulo.Precio = nudPrecioArt.Value;
                articulo.Marca = (Marca)cbMarcaArt.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoriaArt.SelectedItem;
                
                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("El articulo ha sido modificado exitosamente");
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            //ArticuloNegocio artNegocio = new ArticuloNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            articulo.Imagen = new Imagen();
            try
            {
                cbMarcaArt.DataSource = marcaNegocio.listar();
                cbMarcaArt.ValueMember = "Id";
                cbMarcaArt.DisplayMember = "Descripcion";
                cbCategoriaArt.DataSource = categoriaNegocio.listar();
                cbCategoriaArt.ValueMember = "Id";
                cbCategoriaArt.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodArt.Text = articulo.CodigoArticulo;
                    txtNombreArt.Text = articulo.Nombre;
                    txtDescripcionArt.Text = articulo.Descripcion;
                    txtImagenArt.Text = articulo.Imagen.Url;
                    nudPrecioArt.Value = articulo.Precio;
                    cbMarcaArt.SelectedValue = articulo.Marca.Id;
                    cbCategoriaArt.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
