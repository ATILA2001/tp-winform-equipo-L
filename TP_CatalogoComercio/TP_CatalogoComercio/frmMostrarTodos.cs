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
    public partial class frmMostrarTodos : Form
    {
        private List<Articulo> listaArticulo;
        public frmMostrarTodos()
        {
            InitializeComponent();
            
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmMostrarTodos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            //pbxArt.Load(listaArticulo[0].Imagen.Url);
    
        }

        //private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        //{
        //    Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
        //    artSeleccionado.Imagen = new Imagen();
        //    cargarImagen(artSeleccionado.Imagen.Url);
        //}
        //private void cargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbxArt.Load(imagen);
        //    }
        //    catch (Exception)
        //    {
        //        pbxArt.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg");
        //    }

        //}
    }
}
