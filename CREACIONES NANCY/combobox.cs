using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREACIONES_NANCY
{
    public class combobox
    {
        static string conexionstring = "server=localhost ; database = NANCY ; integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void seleccionar (ComboBox cb)
        {
           cb.Items.Clear();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from MODELO", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            conexion.Close();
            cb.Items.Insert(0, "----MODELO----");
            cb.SelectedIndex = 0;
        }

        public void color(ComboBox cd)
        {
            cd.Items.Clear();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from COLORES", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cd.Items.Add(dr[1].ToString());
            }
            conexion.Close();
            cd.Items.Insert(0, "----COLORES----");
            cd.SelectedIndex = 0;
        }

        public void Tela (ComboBox tl)
        {
            tl.Items.Clear();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from TELAS_VENTA", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tl.Items.Add(dr[0].ToString());
            }
            conexion.Close();
            tl.Items.Insert(0, "----TELAS----");
            tl.SelectedIndex = 0;
        }


        public void Diseno(ComboBox tl)
        {
            tl.Items.Clear();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from DISENO", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tl.Items.Add(dr[1].ToString());
            }
            conexion.Close();
            tl.Items.Insert(0, "----DISEÑO----");
            tl.SelectedIndex = 0;
        }
    }
}
