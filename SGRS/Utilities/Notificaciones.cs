using EDP.PGA.BO.Aplicacion.Core.Common;
using EDP.PGA.BO.Aplicacion.Core.ServiceContract;
using EDP.PGA.BO.Aplicacion.TransferObject.Request;
using EDP.PGA.BO.Aplicacion.TransferObject.Response;
using EDP.PGA.BO.Transversal.Core.Constante;
using EDP.PGA.BO.Transversal.Core.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EDP.PGA.BO.PresentacionWeb.Utilities
{
    public class Notificaciones
    {
        public IParametroService parametroService { get; set; }

        //public AppResponse centralNotificacion(int TipoNotificacion,String [] ParametroMensaje, List<string> toList, List<string> ccList = null, List<string> coList = null)
        //{
        //    String remitente = "";
        //    String remitenteContrasena = "";
        //    var notificacion = parametroService.ObtenerParametro(TipoNotificacion).Result;
        //    var parametrosNotificacion = parametroService.listarParametrosHijos(new ParametroRequest { CodigoParametro = TipoNotificacion, EstadoRegistro = DatosConstantes.EstadoRegistro.Activo }).Result.OrderBy(x => x.Orden).ToArray();
        //    String mensaje = notificacion.DescripcionNotificacion;
        //    var asunto = parametrosNotificacion[0].Descripcion;
        //    if (parametrosNotificacion.Length>1)
        //    {
        //        remitente = parametrosNotificacion[1].Descripcion;
        //        remitenteContrasena = parametrosNotificacion[2].Descripcion;
        //    }
        //    else
        //    {
        //        remitente= ConfigurationManager.AppSettings["EWS_Email"].ToString();
        //        remitenteContrasena = ConfigurationManager.AppSettings["EWS_Password"].ToString();
        //    }
        //    switch (TipoNotificacion)
        //    {
        //        case DatosConstantes.TipoNotificaciones.NotificacionCodigoPago:
        //            break;
        //        default:
        //            break;
        //    }
        //    var cuerpo = string.Format(mensaje, ParametroMensaje);
        //    return enviarCorreo(remitente, remitenteContrasena, cuerpo, asunto, toList, ccList, coList);
        //}
        //public AppResponse enviarCorreo(String remitente,String remitenteContrasena, String Cuerpo,String Asunto, List<string> toList, List<string> ccList = null, List<string> coList = null)
        //{
        //    using (EnvioNotificacionServiceClient proxy = new EnvioNotificacionServiceClient())
        //    {
        //        var SmtpUser = remitente;//ConfigurationManager.AppSettings["EWS_UserName"].ToString();
        //        var SmtpPass = remitenteContrasena;// ConfigurationManager.AppSettings["EWS_Password"];
        //        var dominio = ConfigurationManager.AppSettings["EWS_Domain"].ToString();
        //        var emailSource = remitente;// ConfigurationManager.AppSettings["EWS_Email"].ToString();
        //        var puerto = int.Parse( ConfigurationManager.AppSettings["SmptPuerto"].ToString());
        //        //var SmptServer = ConfigurationManager.AppSettings["SmptServer"].ToString();
        //        //var ExchangeVersion = ConfigurationManager.AppSettings["ExchangeVersion"].ToString();
        //        var SmtpServer = ConfigurationManager.AppSettings["SmptServer"].ToString();
        //        var destinationList = ConfigurationManager.AppSettings["EmailTo"].ToString().Split(',').ToList();
        //        destinationList.RemoveAll(x => x==null || x == "" );
        //        toList.RemoveAll(x => x==null || x == "" );
        //        if (toList != null)
        //        {
        //            toList.AddRange(destinationList);
        //        } else toList = new List<string>();

        //        var destinationCCList = ConfigurationManager.AppSettings["EmailCC"].ToString().Split(',').ToList();
        //        destinationCCList.RemoveAll(x => x == "");
        //        if (ccList != null)
        //        {
        //            ccList.AddRange(destinationCCList);
        //        }
        //        else ccList = new List<string>();

        //        var destinationCCOList = ConfigurationManager.AppSettings["EmailCCO"].ToString().Split(',').ToList();
        //        destinationCCOList.RemoveAll(x => x == "");
        //        if (coList!= null)
        //        {
        //            coList.AddRange(destinationCCOList);

        //        }
        //        else coList = new List<string>();
        //        //var ErrorList = proxy.EnvioCorreoEx(Cuerpo, coList.ToArray(), ccList.ToArray(),
        //        //                                                    toList.ToArray(),
        //        //                                                    dominio,
        //        //                                                    SmtpPass,
        //        //                                                    SmtpUser,
        //        //                                                    ObtenerVersionExchange(ExchangeVersion),
        //        //                                                    FormatoCorreo.Html,
        //        //                                                    emailSource,
        //        //                                                    Asunto
        //        //                                                  );
        //        var ErrorList = proxy.EnvioCorreo(Cuerpo, coList.ToArray(), ccList.ToArray(),
        //                                                            toList.ToArray(),
        //                                                            dominio,FormatoCorreo.Html,
        //                                                            emailSource,
        //                                                            puerto,
        //                                                            SmtpPass,
        //                                                            "true",
        //                                                            SmtpServer,
        //                                                            SmtpUser,
        //                                                            Asunto
        //                                                          );
        //        if (ErrorList.Length > 0)
        //        {
        //            var errores = "";
        //            foreach (var itemMail in ErrorList)
        //            {
        //                errores +=" " + itemMail.Message;
        //                Log.RegistrarEvento(itemMail.Message);
        //            }
        //            return new AppResponse { Code = DatosConstantes.Response.Exception, Data= errores };
        //        }
        //        return new AppResponse { Code = DatosConstantes.Response.Success };
        //    }
        //}
        //public static VersionExchange ObtenerVersionExchange(String version)
        //{
        //    VersionExchange infoVersion = new VersionExchange();
        //    switch (version)
        //    {
        //        case "Exchange2007_SP1":
        //            infoVersion = VersionExchange.Exchange2007_SP1;
        //            break;
        //        case "Exchange2010":
        //            infoVersion = VersionExchange.Exchange2010;
        //            break;
        //        case "Exchange2010_SP1":
        //            infoVersion = VersionExchange.Exchange2010_SP1;
        //            break;
        //        case "Exchange2010_SP2":
        //            infoVersion = VersionExchange.Exchange2010_SP2;
        //            break;
        //        case "Exchange2013":
        //            infoVersion = VersionExchange.Exchange2013;
        //            break;
        //        case "Exchange2013_SP1":
        //            infoVersion = VersionExchange.Exchange2013_SP1;
        //            break;
        //    }

        //    return infoVersion;
        //}
    }
}