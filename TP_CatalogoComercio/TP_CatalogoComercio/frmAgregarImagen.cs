﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_CatalogoComercio
{
    public partial class frmAgregarImagen : Form
    {
        private List<Imagen> listaImagen;
        public frmAgregarImagen()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*
            Imagen imagen= new Imagen();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            ArticuloNegocio negocio= new ArticuloNegocio();
            List<Articulo> listaArticulos = new List<Articulo>();
            try
            {
                if (txtCodArt.Text.Trim().Length > 0 && txtImagen.Text.Trim() != string.Empty)
                {
                    string codArt = txtCodArt.Text.Trim();
                    imagen.Url = txtImagen.Text.Trim();

                    imagen.Id = imagenNegocio.searchId(codArt);
                    if (imagen.Id == "0")
                        Close();
                    listaArticulos = negocio.listar();
                    foreach (Articulo articulo in listaArticulos)
                    {
                        if(codArt == articulo.CodigoArticulo)
                        {
                            articulo.Imagenes.Add(imagen);
                        }
                    }
                    imagenNegocio.agregar(imagen);
                    MessageBox.Show("¡Se agregó el registro!");
                    Close();
                }
                else
                {
                    MessageBox.Show("¡Tiene que llenar los campos!");
                }
            }
            catch (Exception)
            {

                throw;
            }*/
            
        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarImagen_Load(object sender, EventArgs e)
        {
            ImagenNegocio imagen = new ImagenNegocio();
            listaImagen = imagen.listar();
            dgvImagenes.DataSource = listaImagen;
            dgvImagenes.Columns["Id"].Visible = false;
            dgvImagenes.Columns["Url"].Visible = false;
        }

        private void txtImagenArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImagenArt_Leave(object sender, EventArgs e)
        {
            //cargarImagen(txtImagen.Text);
        }

        private void pbxImagen_Click(object sender, EventArgs e)
        {

        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImg.Load(imagen);
            }
            catch (Exception)
            {
                pbxImg.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txtCodArt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {


            Imagen imgSeleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
            cargarImagen(imgSeleccionado.Url);
            dgvImagenes.Columns["Url"].Visible = false;
            dgvImagenes.Columns["Id"].Visible = false;
        }
        
            
            }
    }

