using Productos.Dao;
using Productos.Modelos;
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
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = tbNombre.Text.ToUpper();
            prod.Codigo = tbCodigo.Text.ToUpper();
            prod.Precio = double.Parse(tbPrecio.Text);
            prod.IVA = chkIva.Checked;
            dao.Agregar(prod);
            LlenarGrid();
        }
        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }
    }
}
