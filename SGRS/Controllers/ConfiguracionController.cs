using GMD.CustomHtmlHelpers.HtmlGenericGrid;
using Newtonsoft.Json;
using SGRS.BLL.Implementacion;
using SGRS.Entity.BaseEF.Response;
using SGRS.Entity.Request;
using SGRS.Entity.Response;
using SGRS.Helper.Constantes;
using SGRS.Models;
using SGRS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace SGRS.Controllers
{
    public class ConfiguracionController : Controller
    {
        #region Propiedades
        private static AppResponse appResponse = new AppResponse();
      //  private readonly IParametroService _parametroDetalleService = new ParametroService();
        public ParametroService _parametroService;

        #endregion

        public ConfiguracionController()
        {
            _parametroService = new ParametroService();
        }

   

        public ActionResult Index(string codigoParametro = "0")
        {
          ViewBag.codigoParametro = codigoParametro;
            EFParametroResponse parametroDetalle;
            if (codigoParametro != "0")
            {
                var texto = _parametroService.ParametrosRuta(int.Parse(codigoParametro)).Result;
                parametroDetalle = _parametroService.ObtenerParametroPorCodigoParametro(Convert.ToInt32(codigoParametro)).Result;
                ViewBag.NombreNivel = ""/*parametroDetalle.Nivel*/;
                ViewBag.NombreParametro = texto;// parametroDetalle.Nombre;
                ViewBag.DBIdCodigoPadre = parametroDetalle.CODIGO_PADRE;
                ViewBag.DBIdCodigoParametro = parametroDetalle.CODIGO_PARAMETRO;
                //ViewBag.codigoParametro = parametroDetalle.CODIGO_PADRE;
            }
            else
            {
                parametroDetalle = new EFParametroResponse();
                ViewBag.NombreNivel = "1";
                ViewBag.NombreParametro = "";
                ViewBag.DBIdCodigoPadre = "0";
                ViewBag.DBIdCodigoParametro = "0";
                //ViewBag.CodigoParametroPadre = "0";
            }

            List<ParametroResponse> listaEstado = new List<ParametroResponse> { new ParametroResponse { Valor = "", Nombre = DatosConstantes.Controles.Combo.Todos } };
          
            listaEstado.AddRange(_parametroService.ListarParametroPorCodigoSistemaPadreActivo(DatosConstantes.Parametro.EstadoRegistro).Result);
            ViewBag.lstEstados = listaEstado;

             return PartialView();
        }

        public ActionResult Paginacion(string arg)
        {
            ViewBag.Acciones = "btnNuevo|btnEditar|btnEliminar|btnExportar|btnAgregar|btnGuardar|btnVisualizar|btnDetalle|btnAtras|btnActualizar|btnBuscar|btnExaminar|btnAceptar|btnNuevo2|btnEncapsular|btnDuplicar|btnDescuento|btnPagarPublic|btnAbrirDetalle|btnCrear|btnLimpiar|btnReciclar|btnDescargar|BTNSINCRO|   |btnRequisitos|btnRecotizar|btnVerificar|btnObservar|btnPublicCrear|btnCrearTitular|btnGuardarRevis";
       
            var modelData = JsonConvert.DeserializeObject<GMDGridModel<ParametroResponse>>(arg);
            ParametroRequest oParametroRequest = new ParametroRequest();
            oParametroRequest.IsPaginate = true;
            oParametroRequest.PageIndex = modelData.CurrentPageIndex;
            oParametroRequest.SortColumn = modelData.OrderBy;
            oParametroRequest.RowsPerPage = modelData.RowsPerPage;
            oParametroRequest.SortDirection = modelData.DirectionOrder;

            if (modelData.Filters != null)
                oParametroRequest.Filters = Funciones.Conversion.ListaToDatatable<GMDFilter>(modelData.Filters.ToList());

            if (modelData.isFirstLoad)
                modelData.Data = _parametroService.ListarParametrosGrilla(oParametroRequest).Result;
            else
                modelData.Data = new List<ParametroResponse>();

            modelData.TotalRows = oParametroRequest.TotalRows;

            return PartialView(modelData);
        }


        public ActionResult Mantenimiento(string estado,string codigoParametro, string DBIdCodigoParametro, string DBIdCodigoPadre)
        {
            ParametroViewModel oParametroModel = new ParametroViewModel();

            int iCodigoParametro = Convert.ToInt32(estado);
            if (iCodigoParametro == 0)
            {
                oParametroModel.ePar = new EFParametroResponse();
                oParametroModel.ePar.CODIGO_PARAMETRO = Convert.ToInt32(codigoParametro);
                oParametroModel.ePar.CODIGO_PADRE = Convert.ToInt32(DBIdCodigoPadre);
                oParametroModel.CODIGO_PARAMETRO_PADRE = Convert.ToInt32(DBIdCodigoParametro);
                oParametroModel.NOMBRE_PANTALLA = "NUEVO REGISTRO";
                oParametroModel.BESTADO_REGISTRO = true;
            }
            else
            {
                oParametroModel.ePar = _parametroService.ObtenerParametroPorCodigoParametro(Convert.ToInt32( codigoParametro)).Result;
                oParametroModel.CODIGO_PARAMETRO_PADRE = Convert.ToInt32(oParametroModel.ePar.CODIGO_PADRE);
                oParametroModel.CO_ESTADO_REGISTRO = (oParametroModel.ePar.ESTADO_REGISTRO == DatosConstantes.EstadoRegistro.Activo);
                oParametroModel.NOMBRE_PANTALLA = "EDITAR REGISTRO"; //ParametroResource.TituloEdicion;
                oParametroModel.BESTADO_REGISTRO = false;
                DBIdCodigoParametro = codigoParametro;
            }
            if (DBIdCodigoParametro != "0")
            {
                var texto = _parametroService.ParametrosRuta(int.Parse(DBIdCodigoParametro)).Result;
                oParametroModel.NOMBRE_PANTALLA += " " + texto;
            }
            oParametroModel.ePar.DESCRIPCION_NOTIFICACION = HttpUtility.UrlDecode(oParametroModel.ePar.DESCRIPCION_NOTIFICACION);

            return PartialView(oParametroModel);
        }


        public JsonResult Guardar(ParametroViewModel parametroViewModel, string descripcionValor)
        {
            try
            {
                EFParametroResponse objEfParametroResponse= new EFParametroResponse();

                objEfParametroResponse = parametroViewModel.ePar;

                if (objEfParametroResponse != null)
                {
                    //string a = HttpUtility.UrlDecode(objEfParametroResponse.DescripcionNotificacion);  Model.EndDate.Value.ToShortDateString()
                    //string b = HttpUtility.HtmlEncode(objEfParametroResponse.DescripcionNotificacion);
                    objEfParametroResponse.DESCRIPCION_NOTIFICACION = HttpUtility.UrlDecode(objEfParametroResponse.DESCRIPCION_NOTIFICACION);

                    var DescripcionNotificacion = Server.UrlDecode(objEfParametroResponse.DESCRIPCION_NOTIFICACION);
                    objEfParametroResponse.TIPO_PARAMETRO = DatosConstantes.TipoParametro.Publico;
                    if (objEfParametroResponse.VALOR_FECHA != null)
                    {
                        objEfParametroResponse.VALOR_FECHA = DateUtils.getDateTimeddMMyyyy(objEfParametroResponse.VALOR_FECHA.Value.ToShortDateString());
                    }

                    appResponse = new AppResponse
                    {
                        Code = DatosConstantes.Response.Success,
                        Description = (objEfParametroResponse.CODIGO_PARAMETRO == 0 ? "Registro Satisfactorio." : "Actualización Satisfactoria."),
                    };


                    if (parametroViewModel.BESTADO_REGISTRO)
                    {
                        EFParametroResponse parametroPadre = _parametroService.ObtenerParametroPorCodigoParametro(objEfParametroResponse.CODIGO_PADRE).Result;
                       
                        List<ParametroResponse> ParametrosPadre = _parametroService.ListarParametroPorCodigoSistemaPadreActivo(objEfParametroResponse.CODIGO_PADRE).Result;

                        int cantidadParametro = ParametrosPadre.Count;

                        var parametrosIgualNombre = ParametrosPadre.Where(x => x.Nombre.Trim() == objEfParametroResponse.NOMBRE.Trim()).ToList();

                        if (parametrosIgualNombre.Count == 0)
                        {
                            objEfParametroResponse.ESTADO_REGISTRO = parametroViewModel.CO_ESTADO_REGISTRO ? "1" :"0" ;
                            objEfParametroResponse.FECHA_CREACION = DateTime.Now;
                            objEfParametroResponse.USUARIO_CREACION = "1";
                            objEfParametroResponse.TERMINAL_CREACION = Environment.MachineName;
                            objEfParametroResponse.ORDEN = cantidadParametro + 1;
                            objEfParametroResponse.NIVEL = objEfParametroResponse.CODIGO_PADRE == 0 ? 0 : (parametroPadre.NIVEL == null ? 0 : parametroPadre.NIVEL) + 1;

                            var result = _parametroService.RegistrarParametro(objEfParametroResponse);
                            if (!result.IsSuccess)
                            {
                                appResponse.Code = DatosConstantes.Response.Exception;
                                appResponse.Description = "Error al realizar el proceso.";
                            }

                        }
                        else
                        {
                            appResponse.Code = DatosConstantes.Response.Exception;
                            appResponse.Description = "";
                        }
                    }
                    else
                    {
                        EFParametroResponse parametroAnterior = _parametroService.ObtenerParametroPorCodigoParametro(objEfParametroResponse.CODIGO_PARAMETRO).Result;

                        objEfParametroResponse.FECHA_MODIFICACION = DateTime.Now;
                        objEfParametroResponse.USUARIO_MODIFICACION = "1";// Login.Obtener.Usuario.Codigo();
                        objEfParametroResponse.TERMINAL_MODIFICACION = Environment.MachineName;
                        objEfParametroResponse.NIVEL = objEfParametroResponse.CODIGO_PADRE == 0 ? 0 : objEfParametroResponse.NIVEL;
                        objEfParametroResponse.ORDEN = parametroAnterior.ORDEN;

                        objEfParametroResponse.USUARIO_CREACION = parametroAnterior.USUARIO_CREACION;
                        objEfParametroResponse.FECHA_CREACION = parametroAnterior.FECHA_CREACION;
                        objEfParametroResponse.TERMINAL_CREACION = parametroAnterior.TERMINAL_CREACION;

                        var result = _parametroService.ActualizarParametro(objEfParametroResponse);
                        if (!result.IsSuccess)
                        {
                            appResponse.Code = DatosConstantes.Response.Exception;
                            appResponse.Description = "Error al realizar el proceso.";
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                appResponse = new AppResponse
                {
                    Code = DatosConstantes.Response.Exception,
                    Description = ex.Message// "Error al realizar el proceso."
                };
               // Log.RegistrarError(ex);
            }
            return Json(appResponse);
        }


        public ActionResult ConfiguracionEmail()
        {
            return View();
        }

    }
}