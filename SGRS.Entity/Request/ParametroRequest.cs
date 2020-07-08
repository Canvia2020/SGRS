using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGRS.Entity.Base;

namespace SGRS.Entity.Request
{
    public class ParametroRequest:Filtro
    {


        /// <summary>
        /// Campo CodigoParametro
        /// </summary>
        public int CodigoParametro { get; set; }

        /// <summary>
        /// Campo CodigoPadre
        /// </summary>
        public int CodigoPadre { get; set; }

        /// <summary>
        /// Campo Nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Campo NombreCorto
        /// </summary>
        public string NombreCorto { get; set; }

        /// <summary>
        /// Campo Descripcion
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Campo Valor
        /// </summary>
        public string Valor { get; set; }

        /// <summary>
        /// Campo ValorFecha
        /// </summary>
        public Nullable<System.DateTime> ValorFecha { get; set; }

        /// <summary>
        /// Campo Orden
        /// </summary>
        public Nullable<int> Orden { get; set; }

        /// <summary>
        /// Campo Nivel
        /// </summary>
        public Nullable<int> Nivel { get; set; }

        /// <summary>
        /// Campo DescripcionNotificacion
        /// </summary>
        public string DescripcionNotificacion { get; set; }

        /// <summary>
        /// Campo TipoParametro
        /// </summary>
        public Nullable<short> TipoParametro { get; set; }

        /// <summary>
        /// Campo EstadoRegistro
        /// </summary>
        public string EstadoRegistro { get; set; }

        /// <summary>
        /// Campo UsuarioCreacion
        /// </summary>
        public string UsuarioCreacion { get; set; }

        /// <summary>
        /// Campo FechaCreacion
        /// </summary>
        public System.DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Campo TerminalCreacion
        /// </summary>
        public string TerminalCreacion { get; set; }

        /// <summary>
        /// Campo UsuarioModificacion
        /// </summary>
        public string UsuarioModificacion { get; set; }

        /// <summary>
        /// Campo FechaModificacion
        /// </summary>
        public Nullable<System.DateTime> FechaModificacion { get; set; }

        /// <summary>
        /// Campo TerminalModificacion
        /// </summary>
        public string TerminalModificacion { get; set; }

        /// <summary>
        /// Campo CodigoSistema
        /// </summary>
        public Nullable<int> CodigoSistema { get; set; }

        /// <summary>
        /// Campo CodigoSistemaPadre
        /// </summary>
        public Nullable<int> CodigoSistemaPadre { get; set; }
    }
}
