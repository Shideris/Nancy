using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CREACIONES_NANCY.INVENTARIO;

namespace CREACIONES_NANCY.Intermedios
{
    public partial class INTERMEDIOINVENTARIO : Form
    {
        public Form FormularioVista { get; set; }
        public INTERMEDIOINVENTARIO()
        {
            InitializeComponent();
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            FormularioVista = new NUEVO();
            this.Hide();
            FormularioVista.Show();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            FormularioVista = new MODIFICAR();
            this.Hide();
            FormularioVista.Show();
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            FormularioVista = new BUSQUEDA();
            this.Hide();
            FormularioVista.Show();
        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Inicio v1 = new Inicio();
                this.Hide();
                v1.ShowDialog();
            }
        }
    }
}
