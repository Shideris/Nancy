using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class FACT
    {
        private string nOMBRE_COMPRADOR = "";
        private string nIT_CI = "";
        private string iD_TELA = "";
        private string mODELO = "";
        private string cANTIDAD = "";
        private string pRECIO_UNITARIO = "";
        private string iMPORTE = "";
        private string tOTAL_FINAL = "";
        private string eFECTIVO = "";
        private string cAMBIO = "";
        private string iMPORTE_LITERAL = "";
        private string iD_PER = "";
        private string nOMBRE_CAJERO = "";
        private string nUMERO_FACTURA = "";
        private string fECHA;
        private string hORA;

        public string NOMBRE_COMPRADOR { get => nOMBRE_COMPRADOR; set => nOMBRE_COMPRADOR = value; }
        public string NIT_CI { get => nIT_CI; set => nIT_CI = value; }
        public string ID_TELA { get => iD_TELA; set => iD_TELA = value; }
        public string MODELO { get => mODELO; set => mODELO = value; }
        public string CANTIDAD { get => cANTIDAD; set => cANTIDAD = value; }
        public string PRECIO_UNITARIO { get => pRECIO_UNITARIO; set => pRECIO_UNITARIO = value; }
        public string IMPORTE { get => iMPORTE; set => iMPORTE = value; }
        public string TOTAL_FINAL { get => tOTAL_FINAL; set => tOTAL_FINAL = value; }
        public string EFECTIVO { get => eFECTIVO; set => eFECTIVO = value; }
        public string CAMBIO { get => cAMBIO; set => cAMBIO = value; }
        public string ID_PER { get => iD_PER; set => iD_PER = value; }
        public string NOMBRE_CAJERO { get => nOMBRE_CAJERO; set => nOMBRE_CAJERO = value; }
        public string NUMERO_FACTURA { get => nUMERO_FACTURA; set => nUMERO_FACTURA = value; }
        public string IMPORTE_LITERAL { get => iMPORTE_LITERAL; set => iMPORTE_LITERAL = value; }
        public string FECHA { get => fECHA; set => fECHA = value; }
        public string HORA { get => hORA; set => hORA = value; }
    }
}
