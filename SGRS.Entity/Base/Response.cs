using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRS.Entity.Base
{
    public class Response<T> where T : class
    {
        /// <summary>
        /// Campo message
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// Campo isSuccess
        /// </summary>
        public bool isSuccess { get; set; }
        /// <summary>
        /// Campo t : clase
        /// </summary>
        public T result { get; set; }
    }
}