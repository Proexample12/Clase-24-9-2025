using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.Formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void FrmArreglo_Load(object sender, EventArgs e)
        {

        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Agregar();
            }
        }
        
        private void Agregar()
        {
            int edad=0;
            try
            {

                edad = int.Parse(tbEdad.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("no se permiten letras solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                EdadesDao.edades[EdadesDao.pos++] = edad;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No se pueden agregar mas edades", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tbEdad.Clear();
            tbEdad.Focus();
            mostrarEdades();
        }
         
        public void mostrarEdades()
        {   
            lbEdades.DataSource = null;
            lbEdades.DataSource= EdadesDao.edades;
            lbEdades.Refresh();

        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPromedio_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
