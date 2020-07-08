using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRS.BLL.Interface
{
    public class ProcessResult<T> where T : class
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ProcessResult()
        {
            this.IsSuccess = false;

        }
        /// <summary>
        /// Indicador del estado de la operación
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Exceción generada en caso de error
        /// </summary>
        //public IGenericException Exception { get; set; }
        /// <summary>
        /// Resultado del proceso
        /// </summary>
        public T Result { get; set; }
    }
}
