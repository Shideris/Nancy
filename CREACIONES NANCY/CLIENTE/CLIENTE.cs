using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using NEGOCIO;
using DataTable = System.Data.DataTable;

namespace CREACIONES_NANCY.CLIENTE
{
    
    public partial class Cliente : Form
    {
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        CONEXIONSQLN cn = new CONEXIONSQLN();

        public Cliente()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaCLI();
        }

        private void TXTNOMBRES_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTAPELLIDOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "TELAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Inicio V1 = new Inicio();
                this.Hide();
                V1.Show();
            }
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();

            if (ValidarCampos())
            {
                Primary();

            }
            
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            if (valCI())
            {
                String cadena = TXTCI.Text;
                long CI = long.Parse(cadena);
                cn.ModificarCLI(TXTNOMBRES.Text, TXTAPELLIDOS.Text, CI);
                dataGridView1.DataSource = cn.ConsultaCLI();
            }
            else {
                MessageBox.Show("Ingrese un CI valido");
            }
            
        }

        private void Primary()
        {
            
            try {
                String cadena = TXTCI.Text;
                long CI = long.Parse(cadena);
                cn.InsertarCLI(TXTNOMBRES.Text, TXTAPELLIDOS.Text, CI);
                CI = 0;
                dataGridView1.DataSource = cn.ConsultaCLI();
                //conexion.Close();
                //cn.Close();
            }
            catch { 
                MessageBox.Show("Error con el CI");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena = TXTCI.Text;
            long CI = long.Parse(cadena);
            cn.EliminarCLI(CI);
            dataGridView1.DataSource = cn.ConsultaCLI();
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();

            if (ValidarCampos())
            {
                conexion.Open();
                String consulta = "select bus.* from CLIENTE as bus where NIT_O_CI = '" + TXTCI.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                conexion.Close();
            }
        }

        private bool valCI() {
            bool valCI = false;
            long convert = long.Parse(TXTCI.Text);

            if (convert <= 99999999)
            {
                valCI = true;
            }
            else {
                valCI = false;
            }

            return valCI;
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (TXTNOMBRES.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTNOMBRES, "Ingresar nombre");
            }

            if (TXTAPELLIDOS.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTAPELLIDOS, "Ingresar el numero de modelo");
            }


            if (TXTCI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTCI, "Ingresar el color");
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TXTNOMBRES, "");
            errorProvider1.SetError(TXTAPELLIDOS, "");
            errorProvider1.SetError(TXTCI, "");
        }

        private void TXTNOMBRES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras, sin caracteres especiales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTAPELLIDOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras, sin caracteres especiales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                TXTNOMBRES.Text = dataGridView1.SelectedCells[0].Value.ToString();
                TXTAPELLIDOS.Text = dataGridView1.SelectedCells[1].Value.ToString();
                TXTCI.Text = dataGridView1.SelectedCells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("A ocurido un error "+ex);
            }
        }

        private void BTNREFRESCAR_Click(object sender, EventArgs e)
        {
            String consulta = "select * from CLIENTE";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            TXTAPELLIDOS.Text = "";
            TXTNOMBRES.Text = "";
            TXTCI.Text = "";
        }
    }
}
