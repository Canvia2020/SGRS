using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Web;

namespace SGRS.Helper.Constantes
{
    public class Utils
    {
        //public static string directorioPreFirma = Path.Combine(Utils.ObtenerUbicacion(), "FilesTemp", "PreFirma");

        public static string GeneraCodigo(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }
        public static string SubstringCadena(String descripcion, int tamano)
        {
            int longC = descripcion.Length;
            ///var r = descripcion.Substring(0, tamano);
            if (longC > tamano)
            {
                return descripcion.Substring(0, tamano);
            }
            return descripcion;
        }
        //public static string ObtenerUbicacion()
        //{
        //    String sPath = "";
        //    try
        //    {
        //        sPath = HttpRuntime.AppDomainAppPath;
        //    }
        //    catch (System.Exception)
        //    {
        //        sPath = sPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //    }

        //    return sPath;
        //}
        //public static string ComprimirDirectorio(string direcTem)
        //{
        //    string ddirecTemZip = direcTem + ".zip";
        //    ZipFile.CreateFromDirectory(direcTem, ddirecTemZip);
        //    return ddirecTemZip;
        //}
        //public static string DesComprimirDirectorio(string ddirecTemZip, string direcTem = "", bool DirActual = true)
        //{
        //    if (DirActual)
        //    {
        //        direcTem = ddirecTemZip.Replace(".zip", "");
        //    }
        //    ZipFile.ExtractToDirectory(ddirecTemZip, direcTem);
        //    return ddirecTemZip;
        //}
        //public static string CrearDirectorioPreFirma(string direcTem, bool removeDirectory = true)
        //{
        //    var direcTemFinal = Path.Combine(directorioPreFirma, direcTem);
        //    if (Directory.Exists(direcTemFinal))
        //    {
        //        if (removeDirectory)
        //        {
        //            Directory.Delete(direcTemFinal, true);
        //            Directory.CreateDirectory(direcTemFinal);
        //        }
        //    }
        //    else
        //        Directory.CreateDirectory(direcTemFinal);

        //    return direcTemFinal;
        //}
        //public static bool CopiarArchivoLocalAndRemove(string origen, string destino, bool remove = false)
        //{
        //    try
        //    {
        //        File.Copy(origen, destino, true);
        //        if (remove)
        //        {
        //            File.Delete(origen);
        //        }
        //        return true;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Log.RegistrarError(ex);
        //        return false;
        //    }
        //}
        //public static string CrearDirectorioCotizaArchivo(string direcTem)
        //{
        //    var direcTemFinal = Path.Combine(Utils.ObtenerUbicacion(), "FilesTemp", "ArchPga", direcTem);
        //    if (Directory.Exists(direcTemFinal))
        //        Directory.Delete(direcTemFinal, true);
        //    Directory.CreateDirectory(direcTemFinal);
        //    return direcTemFinal;
        //}
        //public static DataRequest ObtnerDatosRequest(HttpRequestBase Request)
        //{
        //    DataRequest datos = new DataRequest();
        //    datos.ServerName = Request.ServerVariables["SERVER_NAME"];
        //    datos.RemoteHost = Request.ServerVariables["REMOTE_HOST"];
        //    //datos.RemoteAddr = Request.ServerVariables["REMOTE_ADDR"]; 
        //    datos.LogonUser = Request.ServerVariables["LOGON_USER"];
        //    datos.RequestMethod = Request.ServerVariables["REQUEST_METHOD"];

        //    datos.RemoteAddr = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        //    if (string.IsNullOrEmpty(datos.RemoteAddr))
        //    {
        //        datos.RemoteAddr = Request.ServerVariables["REMOTE_ADDR"];
        //    }

        //    Log.RegistrarEvento("REMOTE_ADDR: " + datos.RemoteAddr);
        //    Log.RegistrarEvento("REMOTE_HOST: " + datos.RemoteHost);
        //    Log.RegistrarEvento("REQUEST_METHOD: " + datos.RequestMethod);
        //    Log.RegistrarEvento("LOGON_USER: " + datos.LogonUser);
        //    Log.RegistrarEvento("SERVER_NAME: " + datos.ServerName);

        //    return datos;
        //}
        public static string ObtenerIp()
        {
            string localIP = "";
            try
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
            }
            catch (System.Exception ex)
            {
                localIP = "::1";
                //Log.RegistrarError(ex);
            }
            return localIP;
        }
        public static bool EliminarArchivos(string ruta)
        {
            try
            {
                System.IO.File.Delete(ruta);
                return true;
            }
            catch (System.Exception ex)
            {
                //Log.RegistrarError(ex);
                return false;
            }
        }
    }
    public class DataRequest
    {
        public String ServerName { get; set; }
        public String RemoteHost { get; set; }
        public String RemoteAddr { get; set; }
        public String LogonUser { get; set; }
        public String RequestMethod { get; set; }

    }
}