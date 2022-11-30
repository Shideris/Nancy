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
    public partial class NUEVO : Form
    {
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        CONEXIONSQLN cn = new CONEXIONSQLN();
        combobox combobox = new combobox();
        combobox tela = new combobox();
        combobox diseno = new combobox();
        public Form FormularioVista { get; set; }
        public NUEVO()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaINV();
            combobox.seleccionar(TXTMODELO);
            tela.Tela(TXTIDTELA);
            diseno.Diseno(TXTDISENO);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOMENOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUEVO_Load(object sender, EventArgs e)
        {

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
            BorrarMensajeError();

            if (ValidarCampos())
            {

                MessageBox.Show("Datos Ingresados correctamente");

                cn.InsertarINV(TXTIDTELA.Text, TXTMODELO.Text, TXTCODIGO.Text, TXTCOLORES.Text, TXTMETROSTOTAL.Text, TXTPRECIOMAYOR.Text, TXTPRECIOMENOR.Text, TXTPRECIOCOMPRA.Text, TXTBODEGA.Text, TXTDISENO.Text);
                dataGridView1.DataSource = cn.ConsultaINV();
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (TXTMODELO.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTMODELO, "Ingresar modelo");
            }

            if (TXTCODIGO.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTCODIGO, "Ingresar codigo");
            }

            if (TXTCOLORES.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTCOLORES, "Ingresar la cantidad decolores");
            }

            if (TXTMETROSTOTAL.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTMETROSTOTAL, "Ingresar metros totales");
            }

            if (TXTPRECIOMAYOR.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTPRECIOMAYOR, "Ingresar el precio por mayor");
            }

            if (TXTPRECIOMENOR.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTPRECIOMENOR, "Ingresar el precio por menor");
            }

            if (TXTPRECIOCOMPRA.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTPRECIOCOMPRA, "Ingresar el precio de la compra");
            }

            if (TXTBODEGA.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTBODEGA, "Ingresar la bodega");
            }

            if (TXTDISENO.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTDISENO, "Ingresar el diseño");
            }
            return ok;
        }



        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TXTMODELO, "");
            errorProvider1.SetError(TXTCODIGO, "");
            errorProvider1.SetError(TXTCOLORES, "");
            errorProvider1.SetError(TXTMETROSTOTAL, "");
            errorProvider1.SetError(TXTPRECIOMAYOR, "");
            errorProvider1.SetError(TXTPRECIOMENOR, "");
            errorProvider1.SetError(TXTPRECIOCOMPRA, "");
            errorProvider1.SetError(TXTBODEGA, "");
            errorProvider1.SetError(TXTDISENO, "");
        }

        private void BTNREFRESCAR_Click(object sender, EventArgs e)
        {
            String consulta = "select * from INVENTARIO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
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

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOMAYOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TXTCODIGO_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void TXTDISENO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXTIDTELA_Enter(object sender, EventArgs e)
        {

        }

        private void TXTMODELO_Enter(object sender, EventArgs e)
        {

        }

        private void TXTCODIGO_Enter(object sender, EventArgs e)
        {

        }

        private void TXTCOLORES_Enter(object sender, EventArgs e)
        {

        }

        private void TXTMETROSTOTAL_Enter(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOMAYOR_Enter(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOMENOR_Enter(object sender, EventArgs e)
        {

        }

        private void TXTPRECIOCOMPRA_Enter(object sender, EventArgs e)
        {

        }

        private void TXTBODEGA_Enter(object sender, EventArgs e)
        {

        }

        private void TXTDISENO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTDISENO_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
