using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDADES;

namespace DATOS
{
    public class CONEXIONSQL
    {
        static string conexionstring = "server=localhost; database=NANCY;" +
           "integrated security=true";
        SqlConnection con = new SqlConnection(conexionstring);


        public int consultalogin(string USUARIO, string CONTRASENA)
        {
            int count;
            con.Open();
            string Query = "Select count(*) From PERSONAL WHERE USUARIO='" + USUARIO + "' and CONTRASENA= '" + CONTRASENA + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
        //VENTA TELAS
        public int InsertarTELA(string MODELO, string COLOR, string PRECIO)
        {
            int flag = 0;
            con.Open();
            string query = "insert into TELAS_VENTA values('" + MODELO + "','" + COLOR + "','" + PRECIO + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarTELA(string MODELO, string COLOR, string PRECIO, string ID_TELA)
        {
            int flag = 0;
            con.Open();
            string query = "Update TELAS_VENTA set MODELO='" + MODELO + "', COLOR='" + COLOR + "', PRECIO='" + PRECIO + "' where ID_TELA='" + ID_TELA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarTELA(string MODELO, string COLOR)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from TELAS_VENTA where MODELO='" + MODELO + "'AND COLOR='" + COLOR+ "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaTELA()
        {
            string query = "select * from TELAS_VENTA";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            int v = data.Fill(tabla);

            return tabla;
        }
        //INVENTARIO
        public int InsertarINV(string ID_TELA, string ID_MODELO, string CODIGO, string CANTIDAD_COLORES,string METROS_TOTAL, string PRECIO_MAYOR, string PRECIO_MENOR, string PRECIO_COMPRA, string ID_BODEGA, string DISEÑO)
        {
            int flag = 0;
            con.Open();
            string query = "insert into INVENTARIO (ID_TELA, MODELO, CODIGO, CANTIDAD_COLORES, METROS_TOTAL, PRECIO_MAYOR, PRECIO_MENOR, PRECIO_COMPRA, BODEGA, DISEÑO)values('" + ID_TELA + "','" + ID_MODELO + "','" + CODIGO + "','" + CANTIDAD_COLORES + "','" + METROS_TOTAL + "','" + PRECIO_MAYOR + "','" + PRECIO_MENOR + "','" + PRECIO_COMPRA + "','" + ID_BODEGA + "','" + DISEÑO + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarINV(string ID_TELA, string ID_MODELO, string CODIGO, string CANTIDAD_COLORES, string METROS_TOTAL, string PRECIO_MAYOR, string PRECIO_MENOR, string PRECIO_COMPRA, string ID_BODEGA, string DISEÑO, string ID_INVENTARIO)
        {
            int flag = 0;
            con.Open();
            string query = "Update INVENTARIO  where ID_INVENTARIO='" + ID_INVENTARIO + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarINV(string ID_INVENTARIO)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from INVENTARIO  where ID_INVENTARIO='" + ID_INVENTARIO + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaINV()
        {
            string query = "select * from INVENTARIO ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        //USUARIO 
        public int InsertarUsuario(string CI, string NOM_EMP, string APE_EMP, string EDAD, string SEXO, string DIRECCION, string TELEFONO, string CARGO, string USUARIO, string CONTRASENA, string ID_TIENDA)
        {
            int flag = 0;
            con.Open();
            string query = "insert into PERSONAL values('" + CI + "','" + NOM_EMP + "','" + APE_EMP + "','" + EDAD + "','" + SEXO + "','" + DIRECCION + "','" + TELEFONO + "','" + CARGO + "','" + USUARIO + "','" + CONTRASENA + "', '" + ID_TIENDA + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarUsuario(string CI, string NOM_EMP, string APE_EMP, string EDAD, string SEXO, string DIRECCION, string TELEFONO, string CARGO, string USUARIO, string CONTRASENA, string ID_FAR)
        {
            int flag = 0;
            con.Open();
            string query = "Update PERSONAL set CI='" + CI + "', NOM_EMP='" + NOM_EMP + "', APE_EMP='" + APE_EMP + "', EDAD='" + EDAD + "', SEXO='" + SEXO + "',DIRECCION='" + DIRECCION + "',TELEFONO='" + TELEFONO + "', CARGO='" + CARGO + "', USUARIO='" + USUARIO + "', CONTRASENA='" + CONTRASENA + "', ID_FAR='" + ID_FAR + "' where CI='" + CI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarUsuario(string CI)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from PERSONAL where CI='" + CI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaUsuarioDG()
        {
            string query = "select * from PERSONAL";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        //PROVEEDOR
        public int InsertarPROV(string CI, string NOM_PROV, string APE_PROV, string FABRICA, string DIRECCION, string EDAD, string SEXO, string TELEFONO, string ID_TIENDA)
        {
            int flag = 0;
            con.Open();
            string query = "insert into PROVEEDOR values('" + CI + "','" + NOM_PROV + "','" + APE_PROV + "','" + FABRICA + "','" + DIRECCION + "','" + EDAD + "','" + SEXO + "','" + TELEFONO + "', '" + ID_TIENDA + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarPROV(string CI, string NOM_PROV, string APE_PROV, string FABRICA, string DIRECCION, string EDAD, string SEXO, string TELEFONO, string ID_TIENDA)
        {
            int flag = 0;
            con.Open();
            string query = "Update PROVEEDOR set CI='" + CI + "', NOM_PROV='" + NOM_PROV + "', APE_PROV='" + APE_PROV + "',FABRICA='" + FABRICA + "',DIRECCION='" + DIRECCION + "', EDAD='" + EDAD + "', SEXO='" + SEXO + "', TELEFONO='" + TELEFONO + "', ID_FAR='" + ID_TIENDA + "' where CI='" + CI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarPROV(string CI)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from PROVEEDOR where CI='" + CI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaPROVEDG()
        {
            string query = "select * from PROVEEDOR";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        //CLIENTE
        public int InsertarCLI(string NOM_CLI, string APE_CLI, long NIT_O_CI)
        {
            int flag = 0;
            con.Open();
            string query = "insert into CLIENTE values('" + NOM_CLI + "','" + APE_CLI + "','" + NIT_O_CI + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarCLI(string NOM_CLI, string APE_CLI, long NIT_O_CI)
        {
            int flag = 0;
            con.Open();
            string query = "Update CLIENTE set NOM_CLI='" + NOM_CLI + "', APE_CLI='" + APE_CLI + "', NIT_O_CI='" + NIT_O_CI + "' where NIT_O_CI='" + NIT_O_CI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarCLI(long NIT_O_CI)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from CLIENTE where NIT_O_CI='" + NIT_O_CI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaCLI()
        {
            con.Open();
            string query = "select * from CLIENTE";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            con.Close();
            return tabla;
        }

        //BODEGA

        public int InsertarBOG(string SECCION)
        {
            int flag = 0;
            con.Open();
            string query = "insert into BODEGA values('" + SECCION + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int ModificarBOG(string SECCION, string ID_BODEGA)
        {
            int flag = 0;
            con.Open();
            string query = "Update BODEGA set SECCION='" + SECCION + "' where ID_BODEGA='" + ID_BODEGA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarBOG(string SECCION)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from BODEGA where SECCION='" + SECCION + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public DataTable ConsultaBOG()
        {
            string query = "select * from BODEGA";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        //REGISTRO EMPLEADO

        public int InsertarRegistroEM(string ID_PER, string NOMBRE, string APELLIDOS, string HORARIO_ENTRADA, string HORARIO_SALIDA, string CARGO, string UBICACION_EMPLEADO)
        {
            int flag = 0;
            con.Open();
            string query = "insert into REGISTRO_EMPLEADO values('" + ID_PER + "','" + NOMBRE + "','" + APELLIDOS + "','" + HORARIO_ENTRADA + "','" + HORARIO_SALIDA + "','" + CARGO + "','" + UBICACION_EMPLEADO + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarRegistroEM(string ID_PER, string NOMBRE, string APELLIDOS, string HORARIO_ENTRADA, string HORARIO_SALIDA, string CARGO, string UBICACION_EMPLEADO)
        {
            int flag = 0;
            con.Open();
            string query = "Update REGISTRO_EMPLEADO set ID_PER='" + ID_PER + "', NOMBRE='" + NOMBRE + "', APELLIDOS='" + APELLIDOS + "', HORARIO_ENTRADA='" + HORARIO_ENTRADA + "', HORARIO_SALIDA='" + HORARIO_SALIDA + "',CARGO='" + CARGO + "',UBICACION_EMPLEADO='" + UBICACION_EMPLEADO + "' where ID_PER='" + ID_PER + "' AND HORARIO_ENTRADA='" + HORARIO_ENTRADA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarRegistroEM(string ID_PER, string HORARIO_ENTRADA)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from REGISTRO_EMPLEADO where ID_PER='" + ID_PER + "' AND HORARIO_ENTRADA='" + HORARIO_ENTRADA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaRegistroEm()
        {
            string query = "select * from REGISTRO_EMPLEADO";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        //VENTAS
        public int InsertarVENTA(string ID_FACTURA, string ID_TELA, string ID_PER, string CANTIDAD)
        {
            int flag = 0;
            con.Open();
            string query = "insert into VENTAS values('" + ID_FACTURA + "', '" + ID_TELA + "', '" + ID_PER + "', '" + CANTIDAD + "' )";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public int ModificarVENTA(string ID_FACTURA, string ID_TELA, string ID_PER, string CANTIDAD)
        {
            int flag = 0;
            con.Open();
            string query = "Update VENTAS set ID_FACTURA='" + ID_FACTURA + "', ID_TELA='" + ID_TELA + "',ID_PER='" + ID_PER + "',CANTIDAD='" + CANTIDAD + "'  where ID_FACTURA='" + ID_FACTURA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarVENTA(string ID_FACTURA)
        {
            int flag = 0;
            con.Open();
            string query = "Delete from VENTAS where ID_FACTURA='" + ID_FACTURA + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
        public DataTable ConsultaVENTA()
        {
            string query = "select * from VENTAS";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        //FACTURA

        public string Consultafactura()
        {
            con.Open();
            string RESULTADO = "NULL";
            string query = "SELECT (Select distinct top 1 NUMERO_FACTURA from FACTURA order by NUMERO_FACTURA desc)+1 AS NUMERO_FACTURA";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                RESULTADO = reg["NUMERO_FACTURA"].ToString();

            }

            con.Close();
            return RESULTADO;
        }
        //INSERTAR 

        public void InsertarFactura(List<FACT> F)
        {
            con.Open();
            foreach (FACT fa in F)
            {
                string query = "insert into FACTURA(NUMERO_FACTURA,FECHA, NOMBRE_COMPRADOR, NIT_CI, ID_TELA, MODELO, CANTIDAD, PRECIO_UNITARIO, IMPORTE, TOTAL_FINAL, EFECTIVO, CAMBIO, IMPORTE_LITERAL, ID_PER, NOMBRE_CAJERO) " +
                    "values (" + Convert.ToInt32(fa.NUMERO_FACTURA) + ",'" + fa.FECHA + fa.HORA + "', '" + fa.NOMBRE_COMPRADOR + "', " + Convert.ToInt32(fa.NIT_CI) + ", " + Convert.ToInt32(fa.ID_TELA) + ", '" + fa.MODELO + "', " + Convert.ToInt32(fa.CANTIDAD) + ", " + float.Parse(fa.PRECIO_UNITARIO) + ", " + float.Parse(fa.IMPORTE) + ", " + float.Parse(fa.TOTAL_FINAL) + ", " + float.Parse(fa.EFECTIVO) + ", " + float.Parse(fa.CAMBIO) + ", '" + fa.IMPORTE_LITERAL + "', " + Convert.ToInt32(fa.ID_PER) + ", '" + fa.NOMBRE_CAJERO + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
