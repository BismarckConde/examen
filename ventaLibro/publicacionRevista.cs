using System;
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
    public partial class publicacionRevista : Form
    {
        public publicacionRevista()
        {
            InitializeComponent();
        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlibro_Click(object sender, EventArgs e)
        {
            ListView rev = new ListViewrev(txtlibro.Text);
            rev.Items.Add(txtmen.Text);
            rev.Items.Add(txtse .Text);
            rev.Items.Add(txtqin .Text);
            rev.Items.Add(txtcost .Text);
            

            txtlibro.Clear();
            txtmen.Clear();
            txtcost.Clear();
            txtse .Clear();
            txtqin .Clear();
        }
    }
}
