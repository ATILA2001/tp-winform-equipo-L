using dominio;
using negocio;
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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmAgregar.MdiParent = this;
            frmAgregar.Show();
        }

        private void cargarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmAgregarImagen frmAgregarImagen = new frmAgregarImagen();
            frmAgregarImagen.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmAgregarImagen.MdiParent = this;
            frmAgregarImagen.Show();
        }

        private void listadoMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmListadoMarcas frmListadoMarcas = new frmListadoMarcas();
            frmListadoMarcas.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmListadoMarcas.MdiParent = this;
            frmListadoMarcas.Show();
        }

        private void listadoCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmListadoCategoria frmListadoCategoria = new frmListadoCategoria();
            frmListadoCategoria.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmListadoCategoria.MdiParent = this;
            frmListadoCategoria.Show();
        }

        private void busquedaConFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmFiltros frmFiltros = new frmFiltros();
            frmFiltros.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmFiltros.MdiParent = this;
            frmFiltros.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //panelMain.Visible = false;
            //frmAgregar frmAgregar = new frmAgregar();
            //frmAgregar.FormClosed += (s, args) =>
            //{
            //    panelMain.Visible = true;
            //};
            //frmAgregar.MdiParent = this;
            //frmAgregar.Show();
            //cargar();
            Articulo artSeleccionado;
            artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado;
            artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmModificar frmModificar = new frmModificar(artSeleccionado);
            frmModificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            Articulo seleccionado;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este artículo?", "Eliminando artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(seleccionado.Id.ToString());
                    MessageBox.Show("El articulo ha sido eliminado exitosamente");
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            //Close();
        }


        private void btnFiltros_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            frmFiltros frmFiltros = new frmFiltros();
            frmFiltros.FormClosed += (s, args) =>
            {
                panelMain.Visible = true;
            };
            frmFiltros.MdiParent = this;
            frmFiltros.Show();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(artSeleccionado.Imagenes[0].Url);
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
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
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                dgvArticulos.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
