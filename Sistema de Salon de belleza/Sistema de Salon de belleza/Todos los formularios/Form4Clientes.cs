﻿using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Salon_de_belleza
{
    public partial class Form4Clientes : Form
    {
        ClientesBL _clientes; 

        public Form4Clientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClientesDataGridView.DataSource = _clientes.ObtenerClientes();
           
        }

        private void Form4Clientes_Load(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
