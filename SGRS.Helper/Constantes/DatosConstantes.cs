using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRS.Helper.Constantes
{
    public class DatosConstantes
    {

        public sealed class TipoParametro
        {
            public const int Sistema = 0;
            public const int Publico = 1;
        }

        public sealed class EstadoRegistro
        {
            /// <summary>
            /// Estado de Registro
            /// </summary>
            public static readonly string Activo = "1";

            /// <summary>
            /// Estado Inactivo
            /// </summary>
            public static readonly string Inactivo = "0";

            /// <summary>
            /// Activo
            /// </summary>
            public static readonly string EstadoActivo = "ACTIVO";

            /// <summary>
            /// Inactivo
            /// </summary>
            public static readonly string EstadoInactivo = "INACTIVO";
        }

        public sealed class Response
        {
            public const string Success = "S";
            public const string Exception = "E";
            public const string Error = "R";
            public const string Warning = "W";
            public const string SessionExpired = "SE";
            public const string Yes = "Y";
            public const string No = "N";
            public const string FuncionAceptar = "F";
            public const string Confirmacion = "C";
        }

        public sealed class TypeNotify
        {
            public const string Danger = "danger";
            public const string Success = "success";
        }

        public sealed class Action
        {
            public const string New = "N";
            public const string Edit = "E";
            public const string Delete = "D";
            public const string Active = "A";
            public const string View = "V";
            //=================================
            public const string Massive = "M";
            public const string Reprogramming = "R";
            public const string Temporal = "T";
        }

        public sealed class ActionRequerimiento
        {
            public const string Confirmar = "C";
            public const string Atencion = "A";
            public const string Visualizar = "V";
        }

        public sealed class GlificonMessage
        {
            public const string Error = "<span class=\"glyphicon glyphicon-remove\"></span>";
            public const string Success = "<span class=\"glyphicon glyphicon-ok\"></span>";
        }

        public sealed class Estado
        {
            public const string Activo = "Activo";
            public const string Inactivo = "Inactivo";
        }

        public sealed class ComboDefault
        {
            public const string Ninguno = "Ninguno";
            public const string Todos = "Todos";
            public const string Seleccione = "Seleccione";
            public const string Vacio = "";
        }
        public sealed class Parametro
        {
            public const short EstadosPublicacion = 1;
            public const short TipoServicio = 2;
            public const short VigenciaCotizacion = 3;
            public const short TipoTarifa = 4;
            public const short Moneda = 5;

            public const short ArchAyudaAvisoSinArte = 297;
            public const short ArchProcAvisoSinArte = 298;
            public const short ParametroGespo = 317;
            public const short HoraMaxima1 = 647;
            public const short HoraMaxima2 = 648;
            public const short pPerfilCliente = 649;
            public const short EstadoRegistro = 91;

        }

        public static class Controles
        {
            public static class Combo
            {
                public const string Seleccione = "Seleccione";
                public const string Todos = "Todos";
                public const string Otros = "Otros";
            }

            public static class Paginacion
            {
                public static class Descripcion
                {
                    public const string Primero = "Primero";
                    public const string Anterior = "Anterior";
                    public const string Siguieunte = "Siguiente";
                    public const string Ultimo = "Ultimo";
                }

                public static class Orientacion
                {
                    public const string Ascendente = "Ascending";
                    public const string Descendente = "Descending";
                }

                public static class FilasPorPagina
                {
                    public const int Normal = 10;
                    public const int Muchos = 20;
                    public const int Detalle = 5;
                    public const int Todos = 0;
                    public const int PaginaDefecto = 1;
                    public const int Maximo = 5000;
                }
            }


        }

    }
}