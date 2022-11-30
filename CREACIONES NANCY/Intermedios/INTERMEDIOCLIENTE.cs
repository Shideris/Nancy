using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CREACIONES_NANCY.CLIENTE;


namespace CREACIONES_NANCY.Intermedios
{
    public partial class INTERMEDIOCLIENTE : Form
    {
        public Form FormularioVista { get; set; }
        public INTERMEDIOCLIENTE()
        {
            InitializeComponent();
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            FormularioVista = new Cliente();
            this.Hide();
            FormularioVista.Show();
        }
    }
}
