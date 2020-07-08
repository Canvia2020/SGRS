using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRS.Entity.Base
{

    public class Filtro
    {
        /// <summary>
        /// Valor inicial numero mde pagina
        /// </summary>
        protected int _NumeroPagina;
        /// <summary>
        /// Clase Filtro
        /// </summary>
        public Filtro()
        {
            this.NumeroPagina = 0;
            this.RegistrosPagina = 1000;
        }
        /// <summary>
        /// Pagina solicitada
        /// </summary>
        public int NumeroPagina
        {
            get { return this._NumeroPagina + 1; }
            set { this._NumeroPagina = value; }
        }
        /// <summary>
        /// Registros por Pagina
        /// </summary>
        public int RegistrosPagina { get; set; }

        /// <summary>
        /// Alias del usaurio en sesión
        /// </summary>
        public string UsuarioSession { get; set; }

        /// <summary>
        /// Accion a realizar por edición
        /// </summary>
        public string Accion { get; set; }

        /// <summary>
        /// NumeroFila
        /// </summary>
        public int NumeroFila { get; set; }
        /// <summary>
        /// filtros de paginacion
        /// </summary>
        public DataTable Filters { get; set; }
        /// <summary>
        /// valida si es paginado
        /// </summary>
        public bool IsPaginate { get; set; }
        public int PageIndex { get; set; }
        public int RowsPerPage { get; set; }
        public int TotalRows { get; set; }
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public string TypeGrid { get; set; }
        public string Identifier { get; set; }
        public string User { get; set; }
    }
}
