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
    public partial class frmListadoCategoria : Form
    {
        private List<Categoria> listaCategoria;
        Categoria categoriaSeleccionada = new Categoria();
        public frmListadoCategoria()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                if (txtDescripcion.Text.Trim() != string.Empty)
                {
                    categoria.Descripcion = txtDescripcion.Text.Trim();
                    categoriaNegocio.agregar(categoria);
                    MessageBox.Show("¡Se agregó el registro!");
                }
                else
                {
                    MessageBox.Show("¡Tiene que llenar los campos!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            cargar();
        }


        private void frmListadoCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.listar();
            dgvCategoria.DataSource = listaCategoria;

        }

        private void lblDescripcionArt_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            DialogResult respuesta = MessageBox.Show("Desea eliminar esta marca?", "Eliminando marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                categoriaNegocio.eliminar(categoriaSeleccionada.Id);
                MessageBox.Show("El articulo ha sido eliminado exitosamente");
                cargar();
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            categoriaSeleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
        }
        private void cargar()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                dgvCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}