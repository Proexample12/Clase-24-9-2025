using Productos.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sAlirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProductos().Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void edadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             FrmArreglo frm = new FrmArreglo();
            frm.ShowDialog();

        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
