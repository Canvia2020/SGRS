using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGRS.Entity.Base;

namespace SGRS.Entity.BaseEF.Entity
{
    public  class ParametroResponse : PARAMETRO
    {
        /// <summary>
        /// Total Registros por busqueda
        /// </summary>
        public int? FilasTotal { get; set; }
        /// <summary>
        /// Identificador de la fila
        /// </summary>
        public int NumeroFila { get; set; }
        /// <summary>
        /// Pagina solicitada
        /// </summary>
        public int? NumeroPagina { get; set; }
        /// <summary>
        /// Registros por Pagina
        /// </summary>
        public int RegistrosPagina { get; set; }
        /// <summary>
        /// Registros por Pagina
        /// </summary>
        public int TotalRegistro { get; set; }
        /// <summary>
        /// Estado de Registro del elemento
        /// </summary>
        public string EstadoRegistro { get; set; }

        /// <summary>
        /// Estado Registro (Activo/Inactivo)
        /// </summary>
        public string EstadoRegistroDescripcion { get; set; }

    }

}
