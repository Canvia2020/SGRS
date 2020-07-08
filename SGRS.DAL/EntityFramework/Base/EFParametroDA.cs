using SGRS.Entity.BaseEF;
using SGRS.Entity.BaseEF.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGRS.DAL.EntityFramework.Base
{
    /// Base class for ParametroDataLayer.  Do not make changes to this class,
    /// instead, put additional code in the ParametroDataLayer class
    /// </summary>
    public class EFParametroDA
    {
        // constructor
        public EFParametroDA()
        {

        }

        /// <summary>
        /// Selects a record by primary key(s)
        /// </summary>
        public static PARAMETRO SelectByPrimaryKey(int codigoParametro)
        {
            SGRS_Conexion context = new SGRS_Conexion();
            return context.PARAMETRO.Where(p => p.CODIGO_PARAMETRO == codigoParametro).FirstOrDefault();
        }


        /// <summary>
        /// Selects all PARAMETRO
        /// </summary>
        public static List<PARAMETRO> SelectAll()
        {
            SGRS_Conexion context = new SGRS_Conexion();
            return context.PARAMETRO.ToList();
        }

        public void Insertar(EFParametroResponse oEFParametroResponse)
        {
            PARAMETRO objParametro = Maper_P(oEFParametroResponse);

            using (SGRS_Conexion db = new SGRS_Conexion())
            {
                db.PARAMETRO.Add(objParametro);
                db.SaveChanges();

            }
        }

        private PARAMETRO Maper_P(EFParametroResponse oEFParametroResponse)
        {
            PARAMETRO objParametro= new PARAMETRO();

            objParametro.CODIGO_PARAMETRO = oEFParametroResponse.CODIGO_PARAMETRO;
            objParametro.CODIGO_PADRE = oEFParametroResponse.CODIGO_PADRE;
            objParametro.NOMBRE = oEFParametroResponse.NOMBRE;
            objParametro.NOMBRE_CORTO = oEFParametroResponse.NOMBRE_CORTO;
            objParametro.DESCRIPCION = oEFParametroResponse.DESCRIPCION;
            objParametro.VALOR = oEFParametroResponse.VALOR;
            objParametro.VALOR_FECHA = oEFParametroResponse.VALOR_FECHA;
            objParametro.ORDEN = oEFParametroResponse.ORDEN;
            objParametro.NIVEL = oEFParametroResponse.NIVEL;
            objParametro.DESCRIPCION_NOTIFICACION = oEFParametroResponse.DESCRIPCION_NOTIFICACION;
            objParametro.TIPO_PARAMETRO = oEFParametroResponse.TIPO_PARAMETRO;
            objParametro.ESTADO_REGISTRO = oEFParametroResponse.ESTADO_REGISTRO;
            objParametro.USUARIO_CREACION = oEFParametroResponse.USUARIO_CREACION;
       
            objParametro.FECHA_CREACION = oEFParametroResponse.FECHA_CREACION;
            objParametro.TERMINAL_CREACION = oEFParametroResponse.TERMINAL_CREACION;
            objParametro.USUARIO_MODIFICACION = oEFParametroResponse.USUARIO_MODIFICACION;
            objParametro.FECHA_MODIFICACION = oEFParametroResponse.FECHA_MODIFICACION;
            objParametro.TERMINAL_MODIFICACION = oEFParametroResponse.TERMINAL_MODIFICACION;
            objParametro.CODIGO_SISTEMA = oEFParametroResponse.CODIGO_SISTEMA;
            objParametro.CODIGO_SISTEMA_PADRE = oEFParametroResponse.CODIGO_SISTEMA_PADRE;


            return objParametro;
        }

        public EFParametroResponse FinById(Int32 codigo)
        {
            using (SGRS_Conexion db = new SGRS_Conexion())
            {

                PARAMETRO parametro = db.PARAMETRO.Where(x => x.CODIGO_PARAMETRO == codigo).FirstOrDefault();

                EFParametroResponse EFparametro = Maper(parametro);

                return EFparametro;
            }



        }

        public Int32 Max()
        {
            using (SGRS_Conexion db = new SGRS_Conexion())
            {
                Int32 respuesta = db.PARAMETRO.Max(x => x.CODIGO_PARAMETRO);
                return respuesta;
            }



        }




        private EFParametroResponse Maper(PARAMETRO parametro)
        {

            EFParametroResponse objEfParametroResponse = new EFParametroResponse();

            objEfParametroResponse.CODIGO_PARAMETRO = parametro.CODIGO_PARAMETRO;
            objEfParametroResponse.NOMBRE = parametro.NOMBRE;
            objEfParametroResponse.NOMBRE_CORTO = parametro.NOMBRE_CORTO;
            objEfParametroResponse.DESCRIPCION = parametro.DESCRIPCION;
            objEfParametroResponse.VALOR = parametro.VALOR;
            objEfParametroResponse.VALOR_FECHA = parametro.VALOR_FECHA;
            objEfParametroResponse.ORDEN = parametro.ORDEN;
            objEfParametroResponse.NIVEL = parametro.NIVEL;
            objEfParametroResponse.DESCRIPCION_NOTIFICACION = parametro.DESCRIPCION_NOTIFICACION;
            objEfParametroResponse.TIPO_PARAMETRO = parametro.TIPO_PARAMETRO;
            objEfParametroResponse.ESTADO_REGISTRO = parametro.ESTADO_REGISTRO;
            objEfParametroResponse.USUARIO_CREACION = parametro.USUARIO_CREACION;

            objEfParametroResponse.FECHA_CREACION = parametro.FECHA_CREACION;
            objEfParametroResponse.TERMINAL_CREACION = parametro.TERMINAL_CREACION;
            objEfParametroResponse.USUARIO_MODIFICACION = parametro.USUARIO_MODIFICACION;
            objEfParametroResponse.FECHA_MODIFICACION = parametro.FECHA_MODIFICACION;
            objEfParametroResponse.TERMINAL_MODIFICACION = parametro.TERMINAL_MODIFICACION;
            objEfParametroResponse.CODIGO_SISTEMA = parametro.CODIGO_SISTEMA;
            objEfParametroResponse.CODIGO_SISTEMA_PADRE = parametro.CODIGO_SISTEMA_PADRE;

            return objEfParametroResponse;
        }

        private PARAMETRO Maper(EFParametroResponse parametro)
        {

            EFParametroResponse objEfParametroResponse = new EFParametroResponse();

            objEfParametroResponse.CODIGO_PARAMETRO = parametro.CODIGO_PARAMETRO;
            objEfParametroResponse.NOMBRE = parametro.NOMBRE;
            objEfParametroResponse.NOMBRE_CORTO = parametro.NOMBRE_CORTO;
            objEfParametroResponse.DESCRIPCION = parametro.DESCRIPCION;
            objEfParametroResponse.VALOR = parametro.VALOR;
            objEfParametroResponse.VALOR_FECHA = parametro.VALOR_FECHA;
            objEfParametroResponse.ORDEN = parametro.ORDEN;
            objEfParametroResponse.NIVEL = parametro.NIVEL;
            objEfParametroResponse.DESCRIPCION_NOTIFICACION = parametro.DESCRIPCION_NOTIFICACION;
            objEfParametroResponse.TIPO_PARAMETRO = parametro.TIPO_PARAMETRO;
            objEfParametroResponse.ESTADO_REGISTRO = parametro.ESTADO_REGISTRO;
            objEfParametroResponse.USUARIO_CREACION = parametro.USUARIO_CREACION;

            objEfParametroResponse.FECHA_CREACION = parametro.FECHA_CREACION;
            objEfParametroResponse.TERMINAL_CREACION = parametro.TERMINAL_CREACION;
            objEfParametroResponse.USUARIO_MODIFICACION = parametro.USUARIO_MODIFICACION;
            objEfParametroResponse.FECHA_MODIFICACION = parametro.FECHA_MODIFICACION;
            objEfParametroResponse.TERMINAL_MODIFICACION = parametro.TERMINAL_MODIFICACION;
            objEfParametroResponse.CODIGO_SISTEMA = parametro.CODIGO_SISTEMA;
            objEfParametroResponse.CODIGO_SISTEMA_PADRE = parametro.CODIGO_SISTEMA_PADRE;

            return objEfParametroResponse;
        }

        public void Actualizar(EFParametroResponse objEfParametroResponse)
        {
            using (SGRS_Conexion db = new SGRS_Conexion())
            {
                PARAMETRO parametro = db.PARAMETRO.Where(x => x.CODIGO_PARAMETRO == objEfParametroResponse.CODIGO_PARAMETRO).FirstOrDefault();

                parametro.NOMBRE = objEfParametroResponse.NOMBRE;
                parametro.NOMBRE_CORTO = objEfParametroResponse.NOMBRE_CORTO;
                parametro.DESCRIPCION = objEfParametroResponse.DESCRIPCION;
                parametro.VALOR = objEfParametroResponse.VALOR;
                parametro.VALOR_FECHA = objEfParametroResponse.VALOR_FECHA;
                parametro.ESTADO_REGISTRO = objEfParametroResponse.ESTADO_REGISTRO;

                parametro.ORDEN = objEfParametroResponse.ORDEN;

                parametro.FECHA_MODIFICACION = DateTime.Now;
                parametro.USUARIO_MODIFICACION = objEfParametroResponse.USUARIO_MODIFICACION;
                parametro.TERMINAL_MODIFICACION = Environment.MachineName;
                parametro.NIVEL = objEfParametroResponse.CODIGO_PADRE == 0 ? 0 : objEfParametroResponse.NIVEL;
                parametro.ORDEN = objEfParametroResponse.ORDEN;

                db.SaveChanges();

            }


          

        }



        //PARAMETRO entParametro = context.PARAMETRO.Where(p => p.CodigoParametro == objParametro.CodigoParametro).FirstOrDefault();
        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of PARAMETRO.
        /// </summary>
        //public static List<PARAMETRO> SelectAllDynamicWhere(int? codigoParametro, int? codigoPadre, string nombre, string nombreCorto, string descripcion, string valor, DateTime? valorFecha, int? orden, int? nivel, string descripcionNotificacion, Int16? tipoParametro, string estadoRegistro, string usuarioCreacion, DateTime? fechaCreacion, string terminalCreacion, string usuarioModificacion, DateTime? fechaModificacion, string terminalModificacion, int? codigoSistema, int? codigoSistemaPadre)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();

        //    int codigoParametroValue = int.MinValue;
        //    int codigoPadreValue = int.MinValue;
        //    DateTime valorFechaValue = DateTime.MinValue;
        //    int ordenValue = int.MinValue;
        //    int nivelValue = int.MinValue;
        //    Int16 tipoParametroValue = Int16.MinValue;
        //    DateTime fechaCreacionValue = DateTime.MinValue;
        //    DateTime fechaModificacionValue = DateTime.MinValue;
        //    int codigoSistemaValue = int.MinValue;
        //    int codigoSistemaPadreValue = int.MinValue;

        //    if (codigoParametro != null)
        //        codigoParametroValue = codigoParametro.Value;

        //    if (codigoPadre != null)
        //        codigoPadreValue = codigoPadre.Value;

        //    if (valorFecha != null)
        //        valorFechaValue = valorFecha.Value;

        //    if (orden != null)
        //        ordenValue = orden.Value;

        //    if (nivel != null)
        //        nivelValue = nivel.Value;

        //    if (tipoParametro != null)
        //        tipoParametroValue = tipoParametro.Value;

        //    if (fechaCreacion != null)
        //        fechaCreacionValue = fechaCreacion.Value;

        //    if (fechaModificacion != null)
        //        fechaModificacionValue = fechaModificacion.Value;

        //    if (codigoSistema != null)
        //        codigoSistemaValue = codigoSistema.Value;

        //    if (codigoSistemaPadre != null)
        //        codigoSistemaPadreValue = codigoSistemaPadre.Value;

        //    return context.PARAMETRO
        //        .Where(p =>
        //                  (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                  (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                  (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                  (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                  (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                  (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                  (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                  (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                  (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                  (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //              ).ToList();
        //}
        ///// <summary>
        ///// Selects CodigoParametro and Nombre columns for use with a DropDownList web control
        ///// </summary>
        //public static List<PARAMETRO> SelectParametroDropDownListData()
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();
        //    return (from p in context.PARAMETRO
        //            select new PARAMETRO { CodigoParametro = p.CodigoParametro, Nombre = p.Nombre }).ToList();
        //}
        ///// <summary>
        ///// Inserts a record
        ///// </summary>
        //public static int Insert(PARAMETRO objParametro)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();
        //    PARAMETRO entParametro = new PARAMETRO();

        //    entParametro.CodigoParametro = objParametro.CodigoParametro;
        //    entParametro.CodigoPadre = objParametro.CodigoPadre;
        //    entParametro.Nombre = objParametro.Nombre;
        //    entParametro.NombreCorto = objParametro.NombreCorto;
        //    entParametro.Descripcion = objParametro.Descripcion;
        //    entParametro.Valor = objParametro.Valor;
        //    entParametro.ValorFecha = objParametro.ValorFecha;
        //    entParametro.Orden = objParametro.Orden;
        //    entParametro.Nivel = objParametro.Nivel;
        //    entParametro.DescripcionNotificacion = objParametro.DescripcionNotificacion;
        //    entParametro.TipoParametro = objParametro.TipoParametro;
        //    entParametro.EstadoRegistro = objParametro.EstadoRegistro;
        //    entParametro.UsuarioCreacion = objParametro.UsuarioCreacion;
        //    entParametro.FechaCreacion = objParametro.FechaCreacion;
        //    entParametro.TerminalCreacion = objParametro.TerminalCreacion;
        //    entParametro.UsuarioModificacion = objParametro.UsuarioModificacion;
        //    entParametro.FechaModificacion = objParametro.FechaModificacion;
        //    entParametro.TerminalModificacion = objParametro.TerminalModificacion;
        //    entParametro.CodigoSistema = objParametro.CodigoSistema;
        //    entParametro.CodigoSistemaPadre = objParametro.CodigoSistemaPadre;

        //    context.PARAMETRO.Add(entParametro);
        //    context.SaveChanges();

        //    return entParametro.CodigoParametro;
        //}

        ///// <summary>
        ///// Updates a record
        ///// </summary>
        //public static void Update(PARAMETRO objParametro)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();
        //    PARAMETRO entParametro = context.PARAMETRO.Where(p => p.CodigoParametro == objParametro.CodigoParametro).FirstOrDefault();

        //    if (entParametro != null)
        //    {
        //        entParametro.CodigoPadre = objParametro.CodigoPadre;
        //        entParametro.Nombre = objParametro.Nombre;
        //        entParametro.NombreCorto = objParametro.NombreCorto;
        //        entParametro.Descripcion = objParametro.Descripcion;
        //        entParametro.Valor = objParametro.Valor;
        //        entParametro.ValorFecha = objParametro.ValorFecha;
        //        entParametro.Orden = objParametro.Orden;
        //        entParametro.Nivel = objParametro.Nivel;
        //        entParametro.DescripcionNotificacion = objParametro.DescripcionNotificacion;
        //        entParametro.TipoParametro = objParametro.TipoParametro;
        //        entParametro.EstadoRegistro = objParametro.EstadoRegistro;
        //        entParametro.UsuarioCreacion = objParametro.UsuarioCreacion;
        //        entParametro.FechaCreacion = objParametro.FechaCreacion;
        //        entParametro.TerminalCreacion = objParametro.TerminalCreacion;
        //        entParametro.UsuarioModificacion = objParametro.UsuarioModificacion;
        //        entParametro.FechaModificacion = objParametro.FechaModificacion;
        //        entParametro.TerminalModificacion = objParametro.TerminalModificacion;
        //        entParametro.CodigoSistema = objParametro.CodigoSistema;
        //        entParametro.CodigoSistemaPadre = objParametro.CodigoSistemaPadre;

        //        context.SaveChanges();
        //    }
        //}

        ///// <summary>
        ///// Deletes a record based on primary key(s)
        ///// </summary>
        //public static void Delete(int codigoParametro)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();
        //    var objParametro = context.PARAMETRO.Where(p => p.CodigoParametro == codigoParametro).FirstOrDefault();

        //    if (objParametro != null)
        //    {
        //        context.PARAMETRO.Remove(objParametro);
        //        context.SaveChanges();
        //    }
        //}

        ///// <summary>
        ///// Gets the total number of records in the PARAMETRO table
        ///// </summary>
        //public static int GetRecordCount()
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();
        //    return context.PARAMETRO.Count();
        //}

        ///// <summary>
        ///// Gets the total number of records in the PARAMETRO table based on search parameters
        ///// </summary>
        //public static int GetRecordCountDynamicWhere(int? codigoParametro, int? codigoPadre, string nombre, string nombreCorto, string descripcion, string valor, DateTime? valorFecha, int? orden, int? nivel, string descripcionNotificacion, Int16? tipoParametro, string estadoRegistro, string usuarioCreacion, DateTime? fechaCreacion, string terminalCreacion, string usuarioModificacion, DateTime? fechaModificacion, string terminalModificacion, int? codigoSistema, int? codigoSistemaPadre)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();

        //    int codigoParametroValue = int.MinValue;
        //    int codigoPadreValue = int.MinValue;
        //    DateTime? valorFechaValue = null;
        //    int ordenValue = int.MinValue;
        //    int nivelValue = int.MinValue;
        //    Int16 tipoParametroValue = Int16.MinValue;
        //    DateTime fechaCreacionValue = DateTime.MinValue;
        //    DateTime? fechaModificacionValue = null;
        //    int codigoSistemaValue = int.MinValue;
        //    int codigoSistemaPadreValue = int.MinValue;

        //    if (codigoParametro != null)
        //        codigoParametroValue = codigoParametro.Value;

        //    if (codigoPadre != null)
        //        codigoPadreValue = codigoPadre.Value;

        //    if (valorFecha != null)
        //        valorFechaValue = valorFecha.Value;

        //    if (orden != null)
        //        ordenValue = orden.Value;

        //    if (nivel != null)
        //        nivelValue = nivel.Value;

        //    if (tipoParametro != null)
        //        tipoParametroValue = tipoParametro.Value;

        //    if (fechaCreacion != null)
        //        fechaCreacionValue = fechaCreacion.Value;

        //    if (fechaModificacion != null)
        //        fechaModificacionValue = fechaModificacion.Value;

        //    if (codigoSistema != null)
        //        codigoSistemaValue = codigoSistema.Value;

        //    if (codigoSistemaPadre != null)
        //        codigoSistemaPadreValue = codigoSistemaPadre.Value;

        //    return context.PARAMETRO
        //        .Where(p =>
        //                  (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                  (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                  (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                  (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                  (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                  (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                  (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                  (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                  (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                  (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                  (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //              ).Count();
        //}

        ///// <summary>
        ///// Selects PARAMETRO records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        ///// </summary>
        //public static List<PARAMETRO> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();

        //    if (sortByExpression.Contains(" desc"))
        //    {
        //        switch (sortByExpression)
        //        {
        //            case "CodigoPadre desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.CodigoPadre).Skip(startRowIndex).Take(rows).ToList();
        //            case "Nombre desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.Nombre).Skip(startRowIndex).Take(rows).ToList();
        //            case "NombreCorto desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.NombreCorto).Skip(startRowIndex).Take(rows).ToList();
        //            case "Descripcion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.Descripcion).Skip(startRowIndex).Take(rows).ToList();
        //            case "Valor desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.Valor).Skip(startRowIndex).Take(rows).ToList();
        //            case "ValorFecha desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.ValorFecha).Skip(startRowIndex).Take(rows).ToList();
        //            case "Orden desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.Orden).Skip(startRowIndex).Take(rows).ToList();
        //            case "Nivel desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.Nivel).Skip(startRowIndex).Take(rows).ToList();
        //            case "DescripcionNotificacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.DescripcionNotificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "TipoParametro desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.TipoParametro).Skip(startRowIndex).Take(rows).ToList();
        //            case "EstadoRegistro desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.EstadoRegistro).Skip(startRowIndex).Take(rows).ToList();
        //            case "UsuarioCreacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.UsuarioCreacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "FechaCreacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.FechaCreacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "TerminalCreacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.TerminalCreacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "UsuarioModificacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.UsuarioModificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "FechaModificacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.FechaModificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "TerminalModificacion desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.TerminalModificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "CodigoSistema desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.CodigoSistema).Skip(startRowIndex).Take(rows).ToList();
        //            case "CodigoSistemaPadre desc":
        //                return context.PARAMETRO.OrderByDescending(p => p.CodigoSistemaPadre).Skip(startRowIndex).Take(rows).ToList();
        //            default:
        //                return context.PARAMETRO.OrderByDescending(p => p.CodigoParametro).Skip(startRowIndex).Take(rows).ToList();
        //        }
        //    }
        //    else
        //    {
        //        switch (sortByExpression)
        //        {
        //            case "CodigoPadre":
        //                return context.PARAMETRO.OrderBy(p => p.CodigoPadre).Skip(startRowIndex).Take(rows).ToList();
        //            case "Nombre":
        //                return context.PARAMETRO.OrderBy(p => p.Nombre).Skip(startRowIndex).Take(rows).ToList();
        //            case "NombreCorto":
        //                return context.PARAMETRO.OrderBy(p => p.NombreCorto).Skip(startRowIndex).Take(rows).ToList();
        //            case "Descripcion":
        //                return context.PARAMETRO.OrderBy(p => p.Descripcion).Skip(startRowIndex).Take(rows).ToList();
        //            case "Valor":
        //                return context.PARAMETRO.OrderBy(p => p.Valor).Skip(startRowIndex).Take(rows).ToList();
        //            case "ValorFecha":
        //                return context.PARAMETRO.OrderBy(p => p.ValorFecha).Skip(startRowIndex).Take(rows).ToList();
        //            case "Orden":
        //                return context.PARAMETRO.OrderBy(p => p.Orden).Skip(startRowIndex).Take(rows).ToList();
        //            case "Nivel":
        //                return context.PARAMETRO.OrderBy(p => p.Nivel).Skip(startRowIndex).Take(rows).ToList();
        //            case "DescripcionNotificacion":
        //                return context.PARAMETRO.OrderBy(p => p.DescripcionNotificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "TipoParametro":
        //                return context.PARAMETRO.OrderBy(p => p.TipoParametro).Skip(startRowIndex).Take(rows).ToList();
        //            case "EstadoRegistro":
        //                return context.PARAMETRO.OrderBy(p => p.EstadoRegistro).Skip(startRowIndex).Take(rows).ToList();
        //            case "UsuarioCreacion":
        //                return context.PARAMETRO.OrderBy(p => p.UsuarioCreacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "FechaCreacion":
        //                return context.PARAMETRO.OrderBy(p => p.FechaCreacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "TerminalCreacion":
        //                return context.PARAMETRO.OrderBy(p => p.TerminalCreacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "UsuarioModificacion":
        //                return context.PARAMETRO.OrderBy(p => p.UsuarioModificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "FechaModificacion":
        //                return context.PARAMETRO.OrderBy(p => p.FechaModificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "TerminalModificacion":
        //                return context.PARAMETRO.OrderBy(p => p.TerminalModificacion).Skip(startRowIndex).Take(rows).ToList();
        //            case "CodigoSistema":
        //                return context.PARAMETRO.OrderBy(p => p.CodigoSistema).Skip(startRowIndex).Take(rows).ToList();
        //            case "CodigoSistemaPadre":
        //                return context.PARAMETRO.OrderBy(p => p.CodigoSistemaPadre).Skip(startRowIndex).Take(rows).ToList();
        //            default:
        //                return context.PARAMETRO.OrderBy(p => p.CodigoParametro).Skip(startRowIndex).Take(rows).ToList();
        //        }
        //    }
        //}

        ///// <summary>
        ///// Selects PARAMETRO records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        ///// </summary>
        //public static List<PARAMETRO> SelectSkipAndTakeDynamicWhere(int? codigoParametro, int? codigoPadre, string nombre, string nombreCorto, string descripcion, string valor, DateTime? valorFecha, int? orden, int? nivel, string descripcionNotificacion, Int16? tipoParametro, string estadoRegistro, string usuarioCreacion, DateTime? fechaCreacion, string terminalCreacion, string usuarioModificacion, DateTime? fechaModificacion, string terminalModificacion, int? codigoSistema, int? codigoSistemaPadre, string sortByExpression, int startRowIndex, int rows)
        //{
        //    SGRS_Conexion context = new SGRS_Conexion();

        //    int codigoParametroValue = int.MinValue;
        //    int codigoPadreValue = int.MinValue;
        //    DateTime? valorFechaValue = null;
        //    int ordenValue = int.MinValue;
        //    int nivelValue = int.MinValue;
        //    Int16 tipoParametroValue = Int16.MinValue;
        //    DateTime fechaCreacionValue = DateTime.MinValue;
        //    DateTime? fechaModificacionValue = null;
        //    int codigoSistemaValue = int.MinValue;
        //    int codigoSistemaPadreValue = int.MinValue;

        //    if (codigoParametro != null)
        //        codigoParametroValue = codigoParametro.Value;

        //    if (codigoPadre != null)
        //        codigoPadreValue = codigoPadre.Value;

        //    if (valorFecha != null)
        //        valorFechaValue = valorFecha.Value;

        //    if (orden != null)
        //        ordenValue = orden.Value;

        //    if (nivel != null)
        //        nivelValue = nivel.Value;

        //    if (tipoParametro != null)
        //        tipoParametroValue = tipoParametro.Value;

        //    if (fechaCreacion != null)
        //        fechaCreacionValue = fechaCreacion.Value;

        //    if (fechaModificacion != null)
        //        fechaModificacionValue = fechaModificacion.Value;

        //    if (codigoSistema != null)
        //        codigoSistemaValue = codigoSistema.Value;

        //    if (codigoSistemaPadre != null)
        //        codigoSistemaPadreValue = codigoSistemaPadre.Value;

        //    if (sortByExpression.Contains(" desc"))
        //    {
        //        switch (sortByExpression)
        //        {
        //            case "CodigoPadre desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.CodigoPadre).Skip(startRowIndex).Take(rows).ToList();

        //            case "Nombre desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.Nombre).Skip(startRowIndex).Take(rows).ToList();

        //            case "NombreCorto desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.NombreCorto).Skip(startRowIndex).Take(rows).ToList();

        //            case "Descripcion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.Descripcion).Skip(startRowIndex).Take(rows).ToList();

        //            case "Valor desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.Valor).Skip(startRowIndex).Take(rows).ToList();

        //            case "ValorFecha desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.ValorFecha).Skip(startRowIndex).Take(rows).ToList();

        //            case "Orden desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.Orden).Skip(startRowIndex).Take(rows).ToList();

        //            case "Nivel desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.Nivel).Skip(startRowIndex).Take(rows).ToList();

        //            case "DescripcionNotificacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.DescripcionNotificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "TipoParametro desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.TipoParametro).Skip(startRowIndex).Take(rows).ToList();

        //            case "EstadoRegistro desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.EstadoRegistro).Skip(startRowIndex).Take(rows).ToList();

        //            case "UsuarioCreacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.UsuarioCreacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "FechaCreacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.FechaCreacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "TerminalCreacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.TerminalCreacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "UsuarioModificacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.UsuarioModificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "FechaModificacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.FechaModificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "TerminalModificacion desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.TerminalModificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "CodigoSistema desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.CodigoSistema).Skip(startRowIndex).Take(rows).ToList();

        //            case "CodigoSistemaPadre desc":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.CodigoSistemaPadre).Skip(startRowIndex).Take(rows).ToList();

        //            default:
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderByDescending(p => p.CodigoParametro).Skip(startRowIndex).Take(rows).ToList();
        //        }
        //    }
        //    else
        //    {
        //        switch (sortByExpression)
        //        {
        //            case "CodigoPadre":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.CodigoPadre).Skip(startRowIndex).Take(rows).ToList();

        //            case "Nombre":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.Nombre).Skip(startRowIndex).Take(rows).ToList();

        //            case "NombreCorto":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.NombreCorto).Skip(startRowIndex).Take(rows).ToList();

        //            case "Descripcion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.Descripcion).Skip(startRowIndex).Take(rows).ToList();

        //            case "Valor":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.Valor).Skip(startRowIndex).Take(rows).ToList();

        //            case "ValorFecha":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.ValorFecha).Skip(startRowIndex).Take(rows).ToList();

        //            case "Orden":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.Orden).Skip(startRowIndex).Take(rows).ToList();

        //            case "Nivel":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.Nivel).Skip(startRowIndex).Take(rows).ToList();

        //            case "DescripcionNotificacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.DescripcionNotificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "TipoParametro":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.TipoParametro).Skip(startRowIndex).Take(rows).ToList();

        //            case "EstadoRegistro":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.EstadoRegistro).Skip(startRowIndex).Take(rows).ToList();

        //            case "UsuarioCreacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.UsuarioCreacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "FechaCreacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.FechaCreacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "TerminalCreacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.TerminalCreacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "UsuarioModificacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.UsuarioModificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "FechaModificacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.FechaModificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "TerminalModificacion":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.TerminalModificacion).Skip(startRowIndex).Take(rows).ToList();

        //            case "CodigoSistema":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.CodigoSistema).Skip(startRowIndex).Take(rows).ToList();

        //            case "CodigoSistemaPadre":
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.CodigoSistemaPadre).Skip(startRowIndex).Take(rows).ToList();

        //            default:
        //                return context.PARAMETRO
        //                    .Where(p =>
        //                              (codigoParametro != null ? p.CodigoParametro == codigoParametroValue : 1 == 1) &&
        //                              (codigoPadre != null ? p.CodigoPadre == codigoPadreValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombre) ? p.Nombre.Contains(nombre) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(nombreCorto) ? p.NombreCorto.Contains(nombreCorto) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcion) ? p.Descripcion.Contains(descripcion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(valor) ? p.Valor.Contains(valor) : 1 == 1) &&
        //                              (valorFecha != null ? p.ValorFecha == valorFechaValue : 1 == 1) &&
        //                              (orden != null ? p.Orden == ordenValue : 1 == 1) &&
        //                              (nivel != null ? p.Nivel == nivelValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(descripcionNotificacion) ? p.DescripcionNotificacion.Contains(descripcionNotificacion) : 1 == 1) &&
        //                              (tipoParametro != null ? p.TipoParametro == tipoParametroValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(estadoRegistro) ? p.EstadoRegistro.Contains(estadoRegistro) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioCreacion) ? p.UsuarioCreacion.Contains(usuarioCreacion) : 1 == 1) &&
        //                              (fechaCreacion != null ? p.FechaCreacion == fechaCreacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalCreacion) ? p.TerminalCreacion.Contains(terminalCreacion) : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(usuarioModificacion) ? p.UsuarioModificacion.Contains(usuarioModificacion) : 1 == 1) &&
        //                              (fechaModificacion != null ? p.FechaModificacion == fechaModificacionValue : 1 == 1) &&
        //                              (!String.IsNullOrEmpty(terminalModificacion) ? p.TerminalModificacion.Contains(terminalModificacion) : 1 == 1) &&
        //                              (codigoSistema != null ? p.CodigoSistema == codigoSistemaValue : 1 == 1) &&
        //                              (codigoSistemaPadre != null ? p.CodigoSistemaPadre == codigoSistemaPadreValue : 1 == 1)
        //                          ).OrderBy(p => p.CodigoParametro).Skip(startRowIndex).Take(rows).ToList();
        //        }
        //    }
        //}


    }
}
