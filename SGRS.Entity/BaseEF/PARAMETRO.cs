//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGRS.Entity.BaseEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARAMETRO
    {
        public int CODIGO_PARAMETRO { get; set; }
        public int CODIGO_PADRE { get; set; }
        public string NOMBRE { get; set; }
        public string NOMBRE_CORTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string VALOR { get; set; }
        public Nullable<System.DateTime> VALOR_FECHA { get; set; }
        public Nullable<int> ORDEN { get; set; }
        public Nullable<int> NIVEL { get; set; }
        public string DESCRIPCION_NOTIFICACION { get; set; }
        public Nullable<short> TIPO_PARAMETRO { get; set; }
        public string ESTADO_REGISTRO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string TERMINAL_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string TERMINAL_MODIFICACION { get; set; }
        public Nullable<int> CODIGO_SISTEMA { get; set; }
        public Nullable<int> CODIGO_SISTEMA_PADRE { get; set; }
    }
}
