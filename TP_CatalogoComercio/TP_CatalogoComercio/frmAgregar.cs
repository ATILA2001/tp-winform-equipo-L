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
            Articulo art = new Articulo();
            art.Imagen = new Imagen();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                if (txtCodArt.Text.Trim().Length > 0 && txtNombreArt.Text.Trim() != string.Empty && txtDescripcionArt.Text.Trim() != string.Empty && nudPrecioArt.Value != 0)
                {
                    art.CodigoArticulo = txtCodArt.Text.Trim();
                    art.Nombre = txtNombreArt.Text.Trim();
                    art.Descripcion = txtDescripcionArt.Text.Trim();
                    art.Marca = (Marca)cbMarcaArt.SelectedItem;
                    art.Categoria = (Categoria)cbCategoriaArt.SelectedItem;
                    art.Imagen.Url = txtImagenArt.Text.Trim();
                    art.Precio = nudPrecioArt.Value;

                    artNegocio.agregar(art);
                    artNegocio.MaxId(art);
                    artNegocio.agregarImagen(art);
                    MessageBox.Show("¡Se agregó el registro!");
                    limpiarControles();
                }
                else
                {
                    MessageBox.Show("¡Tiene que llenar los campos!");
                }
            }
            catch (Exception)
            {

                throw;
            }            
            Close();
        }

        private void limpiarControles()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                txtCodArt.Text = string.Empty;
                txtNombreArt.Text = string.Empty;
                txtDescripcionArt.Text = string.Empty;
                cbMarcaArt.DataSource = marca.listar();
                cbCategoriaArt.DataSource = categoria.listar();
                nudPrecioArt.Value = 0;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cbMarcaArt.DataSource = marca.listar();
                cbCategoriaArt.DataSource = categoria.listar();
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void txtImagenArt_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenArt.Text);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArt.Load(imagen);

            }
            catch (Exception)
            {
                pbxArt.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg");
            }

        }
    }
}
