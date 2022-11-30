using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CREACIONES_NANCY.Intermedios;

namespace CREACIONES_NANCY
{
    public partial class Inicio : Form
    {
        public Form FormularioVista { get; set; }
        public Inicio()
        {
            InitializeComponent();
        }

        private void BTNETELAS_Click(object sender, EventArgs e)
        {
            FormularioVista = new NTERMEDIOTELAS();
            this.Hide();
            FormularioVista.Show();

        }

        private void BTNINVENTARIO_Click(object sender, EventArgs e)
        {
            FormularioVista = new INTERMEDIOINVENTARIO();
            this.Hide();
            FormularioVista.Show();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                LOGIN v0 = new LOGIN();
                this.Hide();
                v0.ShowDialog();
            }
        }
    }
}
