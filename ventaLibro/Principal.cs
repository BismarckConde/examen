﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventaLibro
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicacionLibro publicacionLibro = new PublicacionLibro();
            publicacionLibro.ShowDialog();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            publicacionRevista publicacionRevista= new publicacionRevista();
            publicacionRevista.ShowDialog();
        }
    }
}
