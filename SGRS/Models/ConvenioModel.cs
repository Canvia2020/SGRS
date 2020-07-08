using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGRS.Models
{
    public class ConvenioModel
    {
        /// <summary> 
        /// Gets or Sets CodigoConvenio 
        /// </summary> 
        
        public int CodigoConvenio { get; set; }

        /// <summary> 
        /// Gets or Sets AnnoMesaDialogo 
        /// </summary> 
   
        public int? AnnoMesaDialogo { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Anno Mesa Dialogo")]
        //public string AnnoMesaDialogoHidden { get; set; }

        /// <summary> 
        /// Gets or Sets CodigoMesaDialogo 
        /// </summary> 
        public int? CodigoMesaDialogo { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Codigo Mesa Dialogo")]
        //public string CodigoMesaDialogoHidden { get; set; }

        /// <summary> 
        /// Gets or Sets AnnoSolicitud 
        /// </summary> 
       
        public int? AnnoSolicitud { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Anno Solicitud")]
        //public string AnnoSolicitudHidden { get; set; }

        /// <summary> 
        /// Gets or Sets CodigoSolicitud 
        /// </summary> 
    
        public int? CodigoSolicitud { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Codigo Solicitud")]
        //public string CodigoSolicitudHidden { get; set; }

        /// <summary> 
        /// Gets or Sets CodigoComunidad 
        /// </summary> 
        public int? CodigoComunidad { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Codigo Comunidad")]
        //public string CodigoComunidadHidden { get; set; }

        /// <summary> 
        /// Gets or Sets CodigoInstitucion 
        /// </summary> 
        public int? CodigoInstitucion { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Codigo Institucion")]
        //public string CodigoInstitucionHidden { get; set; }

        /// <summary> 
        /// Gets or Sets TipoConvenio 
        /// </summary> 
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
        //[Display(Name = "Tipo Convenio")]
        public int? TipoConvenio { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Tipo Convenio")]
        //public string TipoConvenioHidden { get; set; }

        /// <summary> 
        /// Gets or Sets DescripcionConvenio 
        /// </summary> 

        public string DescripcionConvenio { get; set; }

        /// <summary> 
        /// Gets or Sets FechaInicio 
        /// </summary> 
        //[RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
        //[DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Inicio")]
        public DateTime? FechaInicio { get; set; }

        /// <summary> 
        /// Gets or Sets FechaFin 
        /// </summary> 
        //[RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
        //[DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Fin")]
        public DateTime? FechaFin { get; set; }

        /// <summary> 
        /// Gets or Sets EstadoConvenio 
        /// </summary> 
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
        //[Display(Name = "Estado Convenio")]
        public int? EstadoConvenio { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Estado Convenio")]
        //public string EstadoConvenioHidden { get; set; }

        /// <summary> 
        /// Gets or Sets NombreArchivo 
        /// </summary> 
        //[StringLength(100, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Nombre Archivo")]
        public string NombreArchivo { get; set; }

        /// <summary> 
        /// Gets or Sets Propietario 
        /// </summary> 
        //[StringLength(100, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Propietario")]
        public string Propietario { get; set; }

        /// <summary> 
        /// Gets or Sets Tamaño 
        /// </summary> 
        //[Display(Name = "Tamaño")]
        public decimal? Tamaño { get; set; }

        /// <summary> 
        /// Gets or Sets MontoPresupuesto 
        /// </summary> 
        //[Display(Name = "Monto Presupuesto")]
        public decimal? MontoPresupuesto { get; set; }

        /// <summary> 
        /// Gets or Sets FechaTrasferencia 
        /// </summary> 
        //[RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
        //[DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Trasferencia")]
        public DateTime? FechaTrasferencia { get; set; }

        /// <summary> 
        /// Gets or Sets DocumentoSd 
        /// </summary> 
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
        //[Display(Name = "Documento Sd")]
        public int? DocumentoSd { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Documento Sd")]
        //public string DocumentoSdHidden { get; set; }

        /// <summary> 
        /// Gets or Sets FechaSd 
        /// </summary> 
        //[RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
        //[DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Sd")]
        public DateTime? FechaSd { get; set; }

        /// <summary> 
        /// Gets or Sets EstadoConvenioPpto 
        /// </summary> 
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
        //[Display(Name = "Estado Convenio Ppto")]
        public int? EstadoConvenioPpto { get; set; }

        //[NotMapped]
        //[RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
        //[Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
        //[Display(Name = "Estado Convenio Ppto")]
        //public string EstadoConvenioPptoHidden { get; set; }

        /// <summary> 
        /// Gets or Sets NombreArchivoPpto 
        /// </summary> 
        //[StringLength(100, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Nombre Archivo Ppto")]
        public string NombreArchivoPpto { get; set; }

        /// <summary> 
        /// Gets or Sets PropietarioPpto 
        /// </summary> 
        //[StringLength(100, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Propietario Ppto")]
        public string PropietarioPpto { get; set; }

        /// <summary> 
        /// Gets or Sets TamañoPpto 
        /// </summary> 
        //[Display(Name = "Tamaño Ppto")]
        public decimal? TamañoPpto { get; set; }

        /// <summary> 
        /// Gets or Sets UsuarioCreacion 
        /// </summary> 
        //[StringLength(20, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Usuario Creacion")]
        public string UsuarioCreacion { get; set; }

        /// <summary> 
        /// Gets or Sets FechaCreacion 
        /// </summary> 
        //[RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
        //[DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Creacion")]
        public DateTime? FechaCreacion { get; set; }

        /// <summary> 
        /// Gets or Sets TerminalCreacion 
        /// </summary> 
        //[StringLength(40, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Terminal Creacion")]
        public string TerminalCreacion { get; set; }

        /// <summary> 
        /// Gets or Sets UsuarioModificacion 
        /// </summary> 
        //[StringLength(20, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Usuario Modificacion")]
        public string UsuarioModificacion { get; set; }

        /// <summary> 
        /// Gets or Sets FechaModificacion 
        /// </summary> 
        //[RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
        //[DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Fecha Modificacion")]
        public DateTime? FechaModificacion { get; set; }

        /// <summary> 
        /// Gets or Sets TerminalModificacion 
        /// </summary> 
        //[StringLength(40, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
        //[Display(Name = "Terminal Modificacion")]
        public string TerminalModificacion { get; set; }

    }
}
