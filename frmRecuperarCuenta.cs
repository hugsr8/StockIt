﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmRecuperarCuenta : Form
    {
        public frmRecuperarCuenta()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            //Abrir ventana modal que muestra contraseña temporal
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_MouseHover(object sender, EventArgs e)
        {
            btnVolver.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BorderStyle = BorderStyle.None;
        }
    }
}