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
    public partial class MODIFICAR : Form
    {
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        CONEXIONSQLN cn = new CONEXIONSQLN();
        combobox combobox = new combobox();
        combobox tela = new combobox();
        combobox diseno = new combobox();
        public Form FormularioVista { get; set; }
        public MODIFICAR()
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

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            if (ValidarInven() == true)
            {
                conexion.Open();
                int flag = 0;
                string cadena = "update INVENTARIO set ID_TELA='" + TXTIDTELA.Text + "', ID_MODELO='" + TXTMODELO.Text + "', CODIGO='" + TXTCODIGO.Text + "', CANTIDAD_COLORES='" + TXTCOLORES.Text + "', METROS_TOTAL='" + TXTMETROSTOTAL.Text + "', PRECIO_MAYOR='" + TXTPRECIOMAYOR.Text + "', PRECIO_MENOR='" + TXTPRECIOMENOR.Text + "', PRECIO_COMPRA='" + TXTPRECIOCOMPRA.Text + "',ID_BODEGA='" + TXTBODEGA.Text + "',ID_DISEÑO='" + TXTDISENO.Text + "' where ID_INVENTARIO='" + TXTINVEN.Text + "'";
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

        private bool ValidarInven()
        {
            bool val = false;

            if (TXTIDTELA.Text == "")
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
            string query = "Select * from INVENTARIO";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;
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
            TXTCOLORES.Text = "";
            TXTMETROSTOTAL.Text = "";
            TXTPRECIOMAYOR.Text = "";
            TXTPRECIOMENOR.Text = "";
            TXTPRECIOCOMPRA.Text = "";
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
                TXTCOLORES.Text = dataGridView1.SelectedCells[4].Value.ToString();
                TXTMETROSTOTAL.Text = dataGridView1.SelectedCells[5].Value.ToString();
                TXTPRECIOMAYOR.Text = dataGridView1.SelectedCells[6].Value.ToString();
                TXTPRECIOMENOR.Text = dataGridView1.SelectedCells[7].Value.ToString();
                TXTPRECIOCOMPRA.Text = dataGridView1.SelectedCells[8].Value.ToString();
                TXTBODEGA.Text = dataGridView1.SelectedCells[9].Value.ToString();
                TXTDISENO.Text = dataGridView1.SelectedCells[10].Value.ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.EliminarINV(TXTIDTELA.Text);
            dataGridView1.DataSource = cn.ConsultaINV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }

        public void ExportarDatos(DataGridView detallelistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indececolumna = 0;

            foreach (DataGridViewColumn column in detallelistado.Columns)
            {
                indececolumna++;

                exportarexcel.Cells[1, indececolumna] = column.Name;
            }
            int indicefila = 0;

            foreach (DataGridViewRow fila in detallelistado.Rows)
            {
                indicefila++;
                indececolumna = 0;
                foreach (DataGridViewColumn column in detallelistado.Columns)
                {
                    indececolumna++;
                    exportarexcel.Cells[indicefila + 1, indececolumna] = fila.Cells[column.Name].Value;
                }
            }

            exportarexcel.Visible = true;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TXTPRECIOCOMPRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void TXTCODIGO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTMETROSTOTAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOCOMPRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TXTDISENO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTMODELO_Enter(object sender, EventArgs e)
        {

        }
    }
}
