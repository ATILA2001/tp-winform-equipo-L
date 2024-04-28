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
    public partial class frmFiltros : Form
    {
        private List<Articulo> listaArticulo;
        public frmFiltros()
        {
            InitializeComponent();
        }

        private void frmFiltros_Load(object sender, EventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            art.Marca = new Marca();
            art.Categoria = new Categoria();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                art.Marca = (Marca)cbMarcaArt.SelectedItem;
                art.Categoria = (Categoria)cbCategoriaArt.SelectedItem;
                listaArticulo = artNegocio.listarConFiltro(nudDesde.Value, nudHasta.Value ,art.Marca, art.Categoria);
                dvgArticulos.DataSource = listaArticulo;
                dvgArticulos.Columns["Imagen"].Visible = false;
                dvgArticulos.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("¡Utilice el punto en vez de una coma para decimales!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dvgArticulos.DataSource = string.Empty;
            nudDesde.Value = 0;
            nudHasta .Value = 0;
            cbCategoriaArt .SelectedIndex = 0;
            cbMarcaArt .SelectedIndex = 0;
        }

        private void dvgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
