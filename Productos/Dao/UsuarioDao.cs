using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Dao
{
    public class UsuarioDao
    {
        public String[] users = { "kenneth", "gallo", "mave","admin" };
        public string[] pws = { "123", "456", "789","admin" };
        public Boolean Validar(String user, String pw)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Equals(user) && pws[i].Equals(pw))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
