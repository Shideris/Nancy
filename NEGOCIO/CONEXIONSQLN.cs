using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CONEXIONSQLN
    {
        CONEXIONSQL cn = new CONEXIONSQL();
        public int consqlogin(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }
        //TELA A LA VENTA
        public DataTable ConsultaTELA()
        {
            return cn.ConsultaTELA();
        }
        public int InsertarTELA(string ID_MODELO, string COLOR, string PRECIO)
        {
            return cn.InsertarTELA(ID_MODELO, COLOR, PRECIO);
        }
        public int ModificarTELA(string ID_MODELO, string COLOR, string PRECIO, string ID_TELA)
        {
            return cn.ModificarTELA(ID_MODELO, COLOR, PRECIO, ID_TELA);
        }
        public int EliminarTELA(string MODELO, string COLOR)
        {
            return cn.EliminarTELA(MODELO, COLOR);
        }
        //INVENTARIO
        public DataTable ConsultaINV()
        {
            return cn.ConsultaINV();
        }
        public int InsertarINV(string ID_TELA, string ID_MODELO, string CODIGO, string CANTIDAD_COLORES,string METROS_TOTAL, string PRECIO_MAYOR, string PRECIO_MENOR, string PRECIO_COMPRA, string ID_BODEGA, string DISEÑO)
        {
            return cn.InsertarINV(ID_TELA, ID_MODELO, CODIGO, CANTIDAD_COLORES, METROS_TOTAL, PRECIO_MAYOR, PRECIO_MENOR, PRECIO_COMPRA, ID_BODEGA, DISEÑO);
        }
        public int ModificarINV(string ID_TELA, string ID_MODELO, string CODIGO, string CANTIDAD_COLORES,string METROS_TOTAL, string PRECIO_MAYOR, string PRECIO_MENOR, string PRECIO_COMPRA, string ID_BODEGA, string DISEÑO, string ID_INVENTARIO)
        {
            return cn.ModificarINV(ID_TELA, ID_MODELO, CODIGO, CANTIDAD_COLORES, METROS_TOTAL, PRECIO_MAYOR, PRECIO_MENOR, PRECIO_COMPRA, ID_BODEGA, DISEÑO, ID_INVENTARIO);
        }
        public int EliminarINV(string ID_INVENTARIO)
        {
            return cn.EliminarINV(ID_INVENTARIO);
        }

        public int InsertarUsuario(string CI, string NOMBRES, string APELLIDOS, string EDAD, string SEXO, string DIRECCION, string TELEFONO, string CARGO, string USUARIO, string CONTRASENA, string ID_TIENDA)
        {

            return cn.InsertarUsuario(CI, NOMBRES, APELLIDOS, EDAD, SEXO, DIRECCION, TELEFONO, CARGO, USUARIO, CONTRASENA, ID_TIENDA);
        }

        public int ModificarUsuario(string CI, string NOMBRES, string APELLIDOS, string EDAD, string SEXO, string DIRECCION, string TELEFONO, string CARGO, string USUARIO, string CONTRASENA, string ID_TIENDA)
        {
            return cn.ModificarUsuario(CI, NOMBRES, APELLIDOS, EDAD, SEXO, DIRECCION, TELEFONO, CARGO, USUARIO, CONTRASENA, ID_TIENDA);

        }

        public int EliminarUsuario(string CI)
        {
            return cn.EliminarUsuario(CI);

        }

        //PROVEEDOR

        public DataTable ConsultaPROVEDG()
        {
            return cn.ConsultaPROVEDG();
        }
        public int InsertarPROV(string CI, string NOM_PROV, string APE_PROV, string FABRICA, string DIRECCION, string EDAD, string SEXO, string TELEFONO, string ID_TIENDA)
        {
            return cn.InsertarPROV(CI, NOM_PROV, APE_PROV, FABRICA, DIRECCION, EDAD, SEXO, TELEFONO, ID_TIENDA);
        }
        public int ModificarPROV(string CI, string NOM_PROV, string APE_PROV, string LABORATORIO, string DIRECCION, string EDAD, string SEXO, string TELEFONO, string ID_TIENDA)
        {
            return cn.ModificarPROV(CI, NOM_PROV, APE_PROV, LABORATORIO, DIRECCION, EDAD, SEXO, TELEFONO, ID_TIENDA);
        }
        public int EliminarPROV(string CI)
        {
            return cn.EliminarPROV(CI);
        }

        //CLIENTE

        public DataTable ConsultaCLI()
        {
            return cn.ConsultaCLI();
        }

        public int InsertarCLI(string NOM_CLI, string APE_CLI, string NIT_O_CI)
        {
            return cn.InsertarCLI(NOM_CLI, APE_CLI, NIT_O_CI);
        }

        public int ModificarCLI(string NOM_CLI, string APE_CLI, string NIT_O_CI)
        {
            return cn.ModificarCLI(NOM_CLI, APE_CLI, NIT_O_CI);
        }

        public int EliminarCLI(string NIT_O_CI)
        {
            return cn.EliminarCLI(NIT_O_CI);
        }

        //BODEGA

        public DataTable ConsultaBOG()
        {
            return cn.ConsultaBOG();
        }
        public int InsertarBOG(string SECCION)
        {
            return cn.InsertarBOG(SECCION);
        }
        public int ModificarBOG(string SECCION, string ID_BODEGA)
        {
            return cn.ModificarBOG(SECCION, ID_BODEGA);
        }
        public int EliminarBOG(string SECCION)
        {
            return cn.EliminarBOG(SECCION);
        }

        //REGISTRO EMPLEADO
        public int InsertarRegistroEM(string ID_PER, string NOMBRE, string APELLIDOS, string HORARIO_ENTRADA, string HORARIO_SALIDA, string CARGO, string UBICACION)
        {
            return cn.InsertarRegistroEM(ID_PER, NOMBRE, APELLIDOS, HORARIO_ENTRADA, HORARIO_SALIDA, CARGO, UBICACION);
        }
        public int ModificarRegistroEM(string ID_PER, string NOMBRE, string APELLIDOS, string HORARIO_ENTRADA, string HORARIO_SALIDA, string CARGO, string UBICACION)
        {
            return cn.ModificarRegistroEM(ID_PER, NOMBRE, APELLIDOS, HORARIO_ENTRADA, HORARIO_SALIDA, CARGO, UBICACION);
        }
        public int EliminarRegistroEM(string ID_PER, string HORARIO_ENTRADA)
        {
            return cn.EliminarRegistroEM(ID_PER, HORARIO_ENTRADA);
        }
        public DataTable ConsultaRegistroEm()
        {
            return cn.ConsultaRegistroEm();
        }

        //VENTAS
        public int InsertarVENTA(string ID_FACTURA, string ID_TELA, string ID_PER, string CANTIDAD)
        {
            return cn.InsertarVENTA(ID_FACTURA, ID_TELA, ID_PER, CANTIDAD);
        }
        public int ModificarVENTA(string ID_FACTURA, string ID_TELA, string ID_PER, string CANTIDAD)
        {
            return cn.ModificarVENTA(ID_FACTURA, ID_TELA, ID_PER, CANTIDAD);
        }
        public int EliminarVENTA(string ID_FACTURA)
        {
            return cn.EliminarVENTA(ID_FACTURA);
        }
        public DataTable ConsultaVENTA()
        {
            return cn.ConsultaVENTA();
        }

        //FACTURA

        public string Consultafactura()
        {
            return cn.Consultafactura();
        }

        public void InsertarFactura(List<FACT> F)
        {
            cn.InsertarFactura(F);
        }
    }
}
