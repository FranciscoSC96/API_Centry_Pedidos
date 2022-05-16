using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTACETOGENWS.Modelo
{
    class Orden
    {
        public string TIPO_DOCTO { get; set; }

        public string EMPRESA { get; set; }


        public string CODIGO_CLIENTE { get; set; }


        public string CODIGO_SUCURSAL { get; set; }

        public string COD_DIREC { get; set; }

        public string DIRECCION { get; set; }

        public string COMUNA { get; set; }

        public string region { get; set; }

        public string NUM_ORDEN { get; set; }


        public string FECHA { get; set; }


        public string NUM_DOCUMENTO { get; set; }


        public string OCC { get; set; }


        public string NUM_REFERENCIA { get; set; }


        public string FEC_SOLICITADA { get; set; }


        public string FEC_DOCUMENTO { get; set; }


        public string FEC_VENCIMIENTO { get; set; }

        public string OBSERVAC { get; set; }

        public string TRANSPORTE { get; set; }


        public string COD_PRODUCTO { get; set; }


        public string NOM_PRODUCTO { get; set; }

        public string CANT_SOLICITADA { get; set; }
        public string NOM_CLIENTE { get; set; }
        public string BODEGA { get; set; }
    }
}
