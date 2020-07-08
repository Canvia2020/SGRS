using SGRS.Entity.BaseEF;
using SGRS.Entity.BaseEF.Response;

namespace SGRS.Models
{
    public class ParametroViewModel
    {
        //public ParametroModel()
        //{
        //    ePar = new EFParametroResponse();
        //}

        public EFParametroResponse ePar { get; set; }

        public string NOMBRE_PANTALLA { get; set; }
        public int CODIGO_PARAMETRO_PADRE { get; set; }
        public bool BESTADO_REGISTRO { get; set; }
        /// <summary>
        /// conversion de estado por que viene en formato 1 se tiene que pasar a boolean
        /// </summary>
        public bool CO_ESTADO_REGISTRO { get; set; }

    }
}