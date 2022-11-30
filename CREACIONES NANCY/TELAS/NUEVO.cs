﻿using System;
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
    public partial class NUEVO : Form
    {
        
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        
        CONEXIONSQLN cn = new CONEXIONSQLN();
        combobox combobox = new combobox();
        combobox color= new combobox();
        public Form FormularioVista { get; set; }
        public NUEVO()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaTELA();
            combobox.seleccionar(TXTMODELO);
            color.color(TXTCOLOR);
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FormularioVista = new NTERMEDIOTELAS();
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
                cn.InsertarTELA(TXTMODELO.Text, TXTCOLOR.Text, TXTPRECIOMENOR.Text);
                dataGridView1.DataSource = cn.ConsultaTELA();
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;


            if (TXTPRECIOMENOR.Text == "")
            {
                ok = false;
                errorProvider1.SetError(TXTPRECIOMENOR, "Ingresar el precio de la tela");
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(TXTMODELO, "");
            errorProvider1.SetError(TXTCOLOR, "");
            errorProvider1.SetError(TXTPRECIOMENOR, "");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    TXTMODELO.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    TXTCOLOR.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    TXTPRECIOMENOR.Text = dataGridView1.SelectedCells[3].Value.ToString();
            }
            catch
            {

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

        private void TXTPRECIOMENOR_Enter(object sender, EventArgs e)
        {
            if (TXTPRECIOMENOR.Text == "PRECIO")
            {
                TXTPRECIOMENOR.Text = "";
                TXTPRECIOMENOR.ForeColor = Color.DarkGray;
            }
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

        private void TXTMODELO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
