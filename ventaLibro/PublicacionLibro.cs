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
    public partial class PublicacionLibro : Form
    {
        public PublicacionLibro()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnlibro_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtlibro.Text);
            item.SubItems.Add(txtauli.Text);
            item.SubItems.Add(DateTime.Now.ToString());
            item.SubItems.Add(txtcost.Text);

            txtlibro.Clear();
            txtauli.Clear();
            txtcost.Clear();
            txtfecha.Clear();

            
        }
    }
}