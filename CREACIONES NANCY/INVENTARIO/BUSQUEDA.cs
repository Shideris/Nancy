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

namespace CREACIONES_NANCY.INVENTARIO
{

    public partial class BUSQUEDA : Form
    {
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        CONEXIONSQLN cn = new CONEXIONSQLN();
        combobox combobox = new combobox();
        combobox tela = new combobox();
        combobox diseno = new combobox();
        public Form FormularioVista { get; set; }
        public BUSQUEDA()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaINV();
            combobox.seleccionar(TXTMODELO);
            tela.Tela(TXTIDTELA);
            diseno.Diseno(TXTDISENO);
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FormularioVista = new INTERMEDIOINVENTARIO();
                this.Hide();
                FormularioVista.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
            
        }
        public void ExportarDatos(DataGridView detallelistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel= new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indececolumna = 0;

            foreach(DataGridViewColumn column in detallelistado.Columns)
            {
                indececolumna++;

                exportarexcel.Cells[1, indececolumna] = column.Name;
            }
            int indicefila = 0;

            foreach(DataGridViewRow fila in detallelistado.Rows)
            {
                indicefila++;
                indececolumna = 0;
                foreach(DataGridViewColumn column in detallelistado.Columns)
                {
                    indececolumna++;
                    exportarexcel.Cells[indicefila + 1, indececolumna] = fila.Cells[column.Name].Value;
                }
            }

            exportarexcel.Visible = true;
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            conexion.Open();

            String consulta = "select bus.* from INVENTARIO as bus where ID_TELA = '" + TXTIDTELA.Text + "'OR MODELO = '" + TXTMODELO.Text + "' OR BODEGA= '" + TXTBODEGA.Text + "' OR DISEÑO = '" + TXTDISENO.Text + "'  OR CODIGO = '" + TXTCODIGO.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conexion.Close();
        }

        private void BTNREFRESCAR_Click(object sender, EventArgs e)
        {
            String consulta = "select * from INVENTARIO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            TXTIDTELA.Text = "";
            TXTMODELO.Text = "";
            TXTCODIGO.Text = "";
            TXTBODEGA.Text = "";
            TXTDISENO.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                TXTIDTELA.Text = dataGridView1.SelectedCells[1].Value.ToString();
                TXTMODELO.Text = dataGridView1.SelectedCells[2].Value.ToString();
                TXTCODIGO.Text = dataGridView1.SelectedCells[3].Value.ToString();
                TXTBODEGA.Text = dataGridView1.SelectedCells[9].Value.ToString();
                TXTDISENO.Text = dataGridView1.SelectedCells[10].Value.ToString();
            }
            catch
            {

            }
        }

        private void TXTINVEN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDTELA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void TXTCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras, sin caracteres especiales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTCOLORES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTMETROSTOTAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTPRECIOMAYOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void TXTPRECIOCOMPRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTBODEGA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTBODEGA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTDISEÑO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TXTDISENO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
