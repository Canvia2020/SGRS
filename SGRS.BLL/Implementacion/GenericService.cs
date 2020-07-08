using SGRS.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRS.BLL.Implementacion
{
    public abstract class GenericService : IGenericService
    {
        private bool Disposed = false;
        /// <summary>
        /// Finaliza el objeto
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {

                }
            }
            this.Disposed = true;
        }
        /// <summary>
        /// Finaliza el objeto
        /// </summary>        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
