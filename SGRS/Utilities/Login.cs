using EDP.PGA.BO.Transversal.Core.Constante;
using System.Configuration;
using System.Web;

namespace EDP.PGA.BO.PresentacionWeb.Utilities
{
    public static class Login
    {
        /// <summary>
        /// Clase para llenar información de usuario logeado en variables de session
        /// </summary>
        public static class Envio
        {
            public static void Empresa(string codigo, string razonSocial, string alias, string ruc, string imagenLogo, string imagenLogoMini, string direccion)
            {
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.Codigo, codigo);
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.RazonSocial, razonSocial);
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.Alias, alias);
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.Ruc, ruc);
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.ImagenLogo, imagenLogo);
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.ImagenLogoMini, imagenLogoMini);
                HttpContext.Current.Session.Add(Constantes.Sesion.Empresa.Direccion, direccion);
            }

            public static void Usuario(string usuario, long codigo, string nombreCompleto, byte[] foto, string correo, string tipoUsuario,string nrodocumento, string direccion, string tipoDocumentoIdent, string Perfil)
            {
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.Login, usuario);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.Codigo, codigo);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.NombreCompleto, nombreCompleto);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.Foto, foto);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.Correo, correo);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.TipoUsuario, tipoUsuario);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.NroDocumento, nrodocumento);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.Direccion, direccion);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.TipoDocumento, tipoDocumentoIdent);
                HttpContext.Current.Session.Add(Constantes.Sesion.Usuario.Perfil, Perfil);
            }
            public static void UsuarioEmpresaPdv(string codigoEmpresa, string DescripcionEmpresa, string codigoPuntoVenta, string descripcionPuntoVenta)
            {
                HttpContext.Current.Session.Add(Constantes.Sesion.EmpresaUsuario.CodigoEmpresa, codigoEmpresa);
                HttpContext.Current.Session.Add(Constantes.Sesion.EmpresaUsuario.DescripcionEmpresa, DescripcionEmpresa);
                HttpContext.Current.Session.Add(Constantes.Sesion.PuntoVentaUsuario.CodigoPuntoVenta, codigoPuntoVenta);
                HttpContext.Current.Session.Add(Constantes.Sesion.PuntoVentaUsuario.DescripcionPuntoVenta, descripcionPuntoVenta);
            }
            public static void LineaCredito(string Credito, string Disponible, string DiasVencido)
            {
                HttpContext.Current.Session.Add(Constantes.Sesion.LineaCredito.Credito, Credito);
                HttpContext.Current.Session.Add(Constantes.Sesion.LineaCredito.Disponible, Disponible);
                HttpContext.Current.Session.Add(Constantes.Sesion.LineaCredito.DiasVencido, DiasVencido);
            }
            public static void Perfil(int codigo, string nombre)
            {
                HttpContext.Current.Session.Add(Constantes.Sesion.Perfil.Nombre, nombre);
                HttpContext.Current.Session.Add(Constantes.Sesion.Perfil.Codigo, codigo);
            }

            public static void Sistema(long codigo, string nombre, string descripcion)
            {
                HttpContext.Current.Session.Add(Constantes.Sesion.Sistema.Nombre, nombre);
                HttpContext.Current.Session.Add(Constantes.Sesion.Sistema.Codigo, codigo);
                HttpContext.Current.Session.Add(Constantes.Sesion.Sistema.Descripcion, descripcion);
            }
        }

        /// <summary>
        /// Clase para obtener información de usuario logeado desde variables de session
        /// </summary>
        public static class Obtener
        {
            public static class LineaCredito
            {
                public static string Credito()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.LineaCredito.Credito] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.LineaCredito.Credito].ToString();
                    return null;
                }
                public static string Disponible()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.LineaCredito.Disponible] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.LineaCredito.Disponible].ToString();
                    return null;
                }
                public static string DiasVencido()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.LineaCredito.DiasVencido] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.LineaCredito.DiasVencido].ToString();
                    return null;
                }
            }
            public static class UsuarioPuntoVenta
            {
                public static string CodigoPuntoVenta()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.PuntoVentaUsuario.CodigoPuntoVenta] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.PuntoVentaUsuario.CodigoPuntoVenta].ToString();
                    return null;
                }
                public static string DescripcionPuntoVenta()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.PuntoVentaUsuario.DescripcionPuntoVenta] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.PuntoVentaUsuario.DescripcionPuntoVenta].ToString();
                    return null;
                }
            }
            public static class Usuario
            {
                public static string Perfil()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Perfil] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.Perfil].ToString();
                    return null;
                }
                public static string Login()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Login] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.Login].ToString();
                    return null;
                }
                public static string Direccion()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Direccion] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.Direccion].ToString();
                    return null;
                }
                public static string NroDocumento()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.NroDocumento] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.NroDocumento].ToString();
                    return null;
                }
                public static string Codigo()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Codigo] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.Codigo].ToString();
                    return null;
                }
                public static string NombreCompleto()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.NombreCompleto] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.NombreCompleto].ToString();
                    return null;
                }
                public static byte[] Foto()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Foto] != null)
                        return (byte[])HttpContext.Current.Session[Constantes.Sesion.Usuario.Foto];
                    return null;
                }
                public static string Correo()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Correo] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.Correo].ToString();
                    return null;
                }
                public static string Area()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.Area] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.Area].ToString();
                    return null;
                }
                public static string CodigoArea()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.CodigoArea] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.CodigoArea].ToString();
                    return null;
                }
                public static string TipoUsuario()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.TipoUsuario] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.TipoUsuario].ToString();
                    return null;
                }
                public static string TipoDocumento()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Usuario.TipoDocumento] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Usuario.TipoDocumento].ToString();
                    return null;
                }
                public static bool EsOperador()
                {
                    if (Usuario.TipoUsuario() == null)
                        return false;
                    else
                    {
                        if (Usuario.TipoUsuario() == DatosConstantes.TipoUsuario.Interno)//|| Usuario.Login() == "admin"
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
                public static int NivelUsuario()
                {
                    if (!Usuario.EsOperador() )
                        return 0;
                    else
                    {
                        if (Usuario.Login() == "admin")
                        {
                            return DatosConstantes.NivelAprobador.Gerente;
                        }
                        else if (Usuario.Login() == "dsanchezl")
                        {
                            return DatosConstantes.NivelAprobador.Supervisor;
                        }
                        else
                        {
                            return DatosConstantes.NivelAprobador.Operador;
                        }
                    }
                }
                public static bool TieneCredito()
                {
                    var LineaCreditoMonto = Obtener.LineaCredito.Disponible();
                    if (LineaCreditoMonto != null)
                    {
                        if (double.Parse(LineaCreditoMonto) > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                public static bool EsFormateador()
                {
                    var keyFormateo = ConfigurationManager.AppSettings["PERFILES_FORMATEO"];
                    if (keyFormateo!=null)
                    {
                        foreach (var item in keyFormateo.Split(','))
                        {
                            if (HttpContext.Current.Session[Constantes.Sesion.Perfil.Codigo].ToString() == item)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                public static bool EsDiagramador()
                {

                    var keyFormateo = ConfigurationManager.AppSettings["PERFILES_DIAGRAMADOR"];
                    if (keyFormateo != null)
                    {
                        foreach (var item in keyFormateo.Split(','))
                        {
                            if (HttpContext.Current.Session[Constantes.Sesion.Perfil.Codigo].ToString() == item)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }

            public static class Perfil
            {
                public static string Nombre()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Perfil.Nombre] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Perfil.Nombre].ToString();
                    return null;
                }

                public static string Codigo()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Perfil.Codigo] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Perfil.Codigo].ToString();
                    return null;
                }
            }

            public static class Sistema
            {
                public static string Nombre()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Sistema.Nombre] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Sistema.Nombre].ToString();
                    return null;
                }

                public static string Codigo()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Sistema.Codigo] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Sistema.Codigo].ToString();
                    return null;
                }

                public static string Descripcion()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Sistema.Descripcion] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Sistema.Descripcion].ToString();
                    return null;
                }
            }

            public static class Empresa
            {
                public static string RazonSocial()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.RazonSocial] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.RazonSocial].ToString();
                    return null;
                }

                public static string Codigo()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.Codigo] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.Codigo].ToString();
                    return null;
                }

                public static string Direccion()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.Direccion] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.Direccion].ToString();
                    return null;
                }
                public static string Alias()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.Alias] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.Alias].ToString();
                    return null;
                }

                public static string Ruc()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.Ruc] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.Ruc].ToString();
                    return null;
                }

                public static string ImagenLogo()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.ImagenLogo] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.ImagenLogo].ToString();
                    return null;
                }

                public static string ImagenLogoMini()
                {
                    if (HttpContext.Current.Session[Constantes.Sesion.Empresa.ImagenLogoMini] != null)
                        return HttpContext.Current.Session[Constantes.Sesion.Empresa.ImagenLogoMini].ToString();
                    return null;
                }
            }
        }

        public static void LogOut()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}