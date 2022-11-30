using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEGOCIO;

namespace CREACIONES_NANCY
{
    
    public partial class LOGIN : Form
    {
        CONEXIONSQLN cn = new CONEXIONSQLN();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void BTNENTRAR_Click(object sender, EventArgs e)
        {
            if (/*cn.consqlogin(TXTUSUARIO.Text, TXTCONTRASENA.Text)*/1== 1)
            {
                MessageBox.Show("El usuario ha sido encontrado");
                this.Hide();
                Inicio V1 = new Inicio();
                V1.Show();
            }
            else
            {
                MessageBox.Show("El usuario no a sido encontrado");
            }
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por entrar al programa", "LOGIN", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void BTNVER_Click(object sender, EventArgs e)
        {
            if (TXTCONTRASENA.PasswordChar == '*')
            {
                TXTCONTRASENA.PasswordChar = '\0';
            }
            else
            {
                TXTCONTRASENA.PasswordChar = '*';
            }
        }
    }
}
