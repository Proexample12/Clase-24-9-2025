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

namespace Productos
{
    public partial class Login : Form
    {
        UsuarioDao users = new UsuarioDao();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear();
        }

        private void Logear()
        {
            if (users.Validar(TbUsuario.Text, TbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logear();
            }

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TbPassword.Focus();
            }
        }

        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPw.Checked)
            {
                TbPassword.PasswordChar = '*';
                chkShowPw.Text = "Mostrar Contraseña";
            }
            else
            {
                TbPassword.PasswordChar = '\0';
                chkShowPw.Text = "Ocultar Contraseña";
            }
        }
    }
}
