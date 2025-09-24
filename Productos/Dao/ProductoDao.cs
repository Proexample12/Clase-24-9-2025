using Productos.Modelos;
using System;
using System.Windows.Forms;


namespace Productos.Dao
{
    public class ProductoDao
    {
        //ok
        private Producto[] carrito = new Producto[10];
        private int pos = 0;

        
      
        public void Agregar(Producto prod)
        {
            try
            {
                carrito[pos++] = prod;
            }
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show("Carrito lleno, no se pueden agregar más productos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        public Producto[] VerCarrito()
        {
            return carrito;
        }
    }
}
