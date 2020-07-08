using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGRS.Helper.Constantes;

namespace SGRS.Entity.Response
{
    public class AppResponse
    {
        private string _code = DatosConstantes.Response.Exception;

        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                _code = string.IsNullOrEmpty(value) ? DatosConstantes.Response.Exception : value;
            }
        }
        public dynamic Data { get; set; }
        public string Description { get; set; }

        public void SetError(string MessageError)
        {
            this.Code = DatosConstantes.Response.Error;
            this.Description = NormalizeDescription(MessageError);
        }
        public void SetException(string MessageException)
        {
            this.Code = DatosConstantes.Response.Exception;
            this.Description = NormalizeDescription(MessageException);
        }
        public void SetSuccess(string MessageSuccess)
        {
            this.Code = DatosConstantes.Response.Success;
            this.Description = NormalizeDescription(MessageSuccess);
        }
        private string NormalizeDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
                description = description.Length >= 203 ? description.Substring(0, 200) + "..." : description;
            return description;
        }
    }
}
