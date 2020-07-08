using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SGRS.Helper.Constantes
{
    public static class Log
    {


        public static void RegistrarError(System.Exception exc)
        {
            String sPath = "";
            try
            {//HttpRuntime.AppDomainAppPath +
                try
                {
                    sPath = HttpRuntime.AppDomainAppPath;
                }
                catch (System.Exception)
                {
                    sPath = sPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }

                sPath += ConfigurationManager.AppSettings["RutaLog"];
                string LogActivo = ConfigurationManager.AppSettings["LogErrorActivo"];
                if (LogActivo == "1")
                {
                    //sPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    //sPath = System.IO.Path.GetDirectoryName(sPath);

                    string msg = "Error de Servicio: " + exc.Message + "\r\n" +
                        @"StackTrace: " + exc.StackTrace + "\r\nHora Equipo: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


                    //Consola
                    Console.WriteLine(new String(Convert.ToChar("="), 200));
                    Console.WriteLine(msg);

                    //Crear directorio Log en el aplicativo
                    if (!Directory.Exists(sPath))
                        Directory.CreateDirectory(sPath);

                    string FileName = sPath + @"/" + DateTime.Now.ToString("yyyyMMdd") + ".log";

                    //Crear txt y registrar el error
                    using (StreamWriter sw = new StreamWriter(FileName, true))
                    {
                        sw.WriteLine();
                        sw.WriteLine(new String(Convert.ToChar("="), 200));
                        sw.WriteLine(msg);
                        sw.WriteLine();
                    }
                }
            }
            catch (System.Exception ex)
            {
                //sPath = System.Environment.CurrentDirectory;
                EventLog.WriteEntry("Error de Servicio: ", ex.Message + " | " + ex.StackTrace + "| Ruta Config: " + sPath);
            }
        }

        public static void RegistrarEvento(string descripcion)
        {
            String sPath = "";
            try
            {//HttpRuntime.AppDomainAppPath +
                try
                {
                    sPath = HttpRuntime.AppDomainAppPath;
                }
                catch (System.Exception)
                {
                    sPath = sPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                }

                sPath += ConfigurationManager.AppSettings["RutaLog"];
                string LogActivo = ConfigurationManager.AppSettings["LogEventoActivo"];
                if (LogActivo == "1")
                {
                    //sPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    //sPath = System.IO.Path.GetDirectoryName(sPath);

                    string msg = descripcion + "\r\nHora Equipo: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //Consola
                    Console.WriteLine(new String(Convert.ToChar("="), 200));
                    Console.WriteLine(msg);

                    //Crear directorio Log en el aplicativo
                    if (!Directory.Exists(sPath))
                        Directory.CreateDirectory(sPath);

                    string FileName = sPath + @"/" + DateTime.Now.ToString("yyyyMMdd") + ".log";

                    //Crear txt y registrar el error
                    using (StreamWriter sw = new StreamWriter(FileName, true))
                    {
                        sw.WriteLine();
                        sw.WriteLine(new String(Convert.ToChar("="), 200));
                        sw.WriteLine(msg);
                        sw.WriteLine();
                    }
                }
            }
            catch (System.Exception)
            {
                //sPath = System.Environment.CurrentDirectory;
                EventLog.WriteEntry("Descripcion Evento: ", descripcion + " | Ruta Config: " + sPath);
            }
        }
    }
}
