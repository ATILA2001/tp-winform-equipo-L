﻿using System;
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
    public partial class frmSeleccionarModificar : Form
    {
        public frmSeleccionarModificar()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Close();
            frmModificar frmModificar = new frmModificar();
            frmModificar.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSeleccionarModificar_Load(object sender, EventArgs e)
        {

        }
    }
}