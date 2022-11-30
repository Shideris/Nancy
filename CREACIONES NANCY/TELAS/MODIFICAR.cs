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
using CREACIONES_NANCY.Intermedios;
using NEGOCIO;

namespace CREACIONES_NANCY.Telas
{
    public partial class MODIFICAR : Form
    {
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        CONEXIONSQLN cn = new CONEXIONSQLN();
        combobox combobox = new combobox();
        combobox color = new combobox();
        public Form FormularioVista { get; set; }
        public MODIFICAR()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaTELA();
            combobox.seleccionar(TXTMODELO);
            color.color(TXTCOLOR);
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "TELAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FormularioVista = new NTERMEDIOTELAS();
                this.Hide();
                FormularioVista.Show();
            }
        }

        private bool val()
        {
            bool valor = false;
            String cadena = "";

            if (TXTMODELO.Text == cadena || TXTCOLOR.Text == cadena || TXTPRECIOMENOR.Text == cadena)
            {
                valor = false;
            }
            else
            {
                valor = true;
            }

            return valor;
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            bool valor = val();

            if (valor == false)
            {
                MessageBox.Show("Ingrese todos los datos en los campos");
            }
            else
            {
                if (ValidarInven() == true)
                {
                    conexion.Open();
                    int flag = 0;
                    string cadena = "update TELAS_VENTA set MODELO='" + TXTMODELO.Text + "', COLOR='" + TXTCOLOR.Text + "',  PRECIO='" + TXTPRECIOMENOR.Text + "' where ID_TELA='" + TXTIDTELA.Text + "'";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    flag = comando.ExecuteNonQuery();
                    if (flag == 1)
                    {
                        MessageBox.Show("Se Actualizo el registro correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se actualizo el registro");
                    }

                    consulta();
                    conexion.Close();
                }
                else
                {
                    ValidarInven();
                }
            }

        }
        private bool ValidarInven()
        {
            bool val = false;

            if (TXTMODELO.Text == "")
            {
                MessageBox.Show("Ingrese un valor para buscar");
                val = false;
            }
            else
            {
                val = true;
            }

            return val;
        }

        public void consulta()
        {
            string query = "Select * from TELAS_VENTA";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.EliminarTELA(TXTMODELO.Text, TXTCOLOR.Text);
            dataGridView1.DataSource = cn.ConsultaTELA();
        }

        private void BTNREFRESCAR_Click(object sender, EventArgs e)
        {
            String consulta = "select * from TELAS_VENTA";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            TXTMODELO.Text = "";
            TXTCOLOR.Text = "";
            TXTPRECIOMENOR.Text = "";
        }


        private void TXTMODELO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTCOLOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras, sin caracteres especiales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTPRECIOMENOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOMENOR_KeyPress(object sender, KeyPressEventArgs e)
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
                TXTIDTELA.Text = dataGridView1.SelectedCells[0].Value.ToString();
                TXTMODELO.Text = dataGridView1.SelectedCells[1].Value.ToString();
                TXTCOLOR.Text = dataGridView1.SelectedCells[2].Value.ToString();
                TXTPRECIOMENOR.Text = dataGridView1.SelectedCells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTMODELO_Enter(object sender, EventArgs e)
        {
            if (TXTMODELO.Text == "----MODELO----")
            {
                TXTMODELO.Text = "";
                TXTMODELO.ForeColor = Color.DarkGray;
            }
        }

        private void TXTCOLOR_Enter(object sender, EventArgs e)
        {
            if (TXTCOLOR.Text == "----COLORES----")
            {
                TXTCOLOR.Text = "";
                TXTCOLOR.ForeColor = Color.DarkGray;
            }
        }

        private void TXTPRECIOMENOR_Enter(object sender, EventArgs e)
        {
            if (TXTPRECIOMENOR.Text == "PRECIO")
            {
                TXTPRECIOMENOR.Text = "";
                TXTPRECIOMENOR.ForeColor = Color.DarkGray;
            }
        }

        private void TXTIDTELA_Enter(object sender, EventArgs e)
        {
            if (TXTIDTELA.Text == "NUMERO DE TELA")
            {
                TXTIDTELA.Text = "";
                TXTIDTELA.ForeColor = Color.DarkGray;
            }
        }

        private void TXTMODELO_Leave(object sender, EventArgs e)
        {
            if (TXTMODELO.Text == "")
            {
                TXTMODELO.Text = "----MODELO----";
                TXTMODELO.ForeColor = Color.DarkGray;
            }
        }

        private void TXTCOLOR_Leave(object sender, EventArgs e)
        {
            if (TXTCOLOR.Text == "")
            {
                TXTCOLOR.Text = "----COLORES----";
                TXTCOLOR.ForeColor = Color.DarkGray;
            }
        }

        private void TXTPRECIOMENOR_Leave(object sender, EventArgs e)
        {
            if (TXTPRECIOMENOR.Text == "")
            {
                TXTPRECIOMENOR.Text = "PRECIO";
                TXTPRECIOMENOR.ForeColor = Color.DarkGray;
            }
        }

        private void TXTIDTELA_Leave(object sender, EventArgs e)
        {
            if (TXTIDTELA.Text == "")
            {
                TXTIDTELA.Text = "NUMERO DE TELA";
                TXTIDTELA.ForeColor = Color.DarkGray;
            }
        }

        private void TXTMODELO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
