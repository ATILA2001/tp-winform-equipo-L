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
    public partial class frmListadoMarcas : Form
    {
        private List<Marca> listaMarca;
        Marca marcaSeleccionada = new Marca();
        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcionArt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                if (txtDescripcion.Text.Trim() != string.Empty)
                {
                    marca.Descripcion = txtDescripcion.Text.Trim();
                    marcaNegocio.agregar(marca);
                    MessageBox.Show("¡Se agregó el registro!");
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
            cargar();
        }

        private void dgvMarca_SelectionChanged(object sender, EventArgs e)
        {
            marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            DialogResult respuesta = MessageBox.Show("Desea eliminar esta marca?", "Eliminando marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                marcaSeleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                marcaNegocio.eliminar(marcaSeleccionada.Id);
                MessageBox.Show("El articulo ha sido eliminado exitosamente");
                cargar();
            }            
        }

            private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.listar();
            dgvMarca.DataSource = listaMarca;
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                dgvMarca.DataSource = negocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
