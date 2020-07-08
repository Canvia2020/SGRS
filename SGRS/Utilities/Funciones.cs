using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using static SGRS.Helper.Constantes.DatosConstantes;

namespace SGRS.Utilities
{
    public static class Funciones
    {
        public static class Conversion
        {
            public static DataTable ListaToDatatable<T>(IList<T> items)
            {
                var dataTable = new DataTable();
                Type itemsType = typeof(T);
                foreach (PropertyInfo prop in itemsType.GetProperties())
                {
                    var column = new DataColumn(prop.Name)
                    {
                        DataType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType
                    };
                    dataTable.Columns.Add(column);
                }
                foreach (var item in items)
                {
                    int j = 0;
                    object[] newRow = new object[dataTable.Columns.Count];
                    foreach (PropertyInfo prop in itemsType.GetProperties())
                    {
                        newRow[j] = prop.GetValue(item, null);
                        j++;
                    }
                    dataTable.Rows.Add(newRow);
                }
                return dataTable;
            }

            public static DateTime? StringToDatetime(string dateformat, string dateString)
            {
                try
                {
                    DateTime dateValue;
                    if (DateTime.TryParseExact(dateString, dateformat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                        return dateValue;
                    return null;
                }
                catch
                {
                    return null;
                }
            }

            public static int GetPaginaActual(int paginaActual, string PaginaSolicitada, int cantidadTotalFilas, int FilasPorPagina)
            {
                var page = 0;
                if (paginaActual == 0) return 1;

                if (string.IsNullOrEmpty(PaginaSolicitada)) return 1;

                switch (PaginaSolicitada)
                {
                    case Controles.Paginacion.Descripcion.Primero: page = 1; break;
                    case Controles.Paginacion.Descripcion.Anterior: page = paginaActual - 1; break;
                    case Controles.Paginacion.Descripcion.Siguieunte: page = paginaActual + 1; break;
                    case Controles.Paginacion.Descripcion.Ultimo: page = (cantidadTotalFilas / FilasPorPagina) + 1; break;
                }
                return page;
            }
        }
        public static bool IsValidStringToDate(string dateformat, string dateString)
        {
            try
            {
                DateTime dateValue;
                return DateTime.TryParseExact(dateString, dateformat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue);
            }
            catch
            {
                return false;
            }
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
        public static string GetPathTemp(byte[] filedata, string extension = "pdf")
        {
            string filename = GetUrlRoot() + Guid.NewGuid().ToString() + extension;
            if (filedata != null)
            {
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    fs.Write(filedata, 0, filedata.Length);
                }
            }
            return filename;
        }
        public static byte[] readFileContents(HttpPostedFileBase file)
        {
            Stream fileStream = file.InputStream;
            var mStreamer = new MemoryStream();
            mStreamer.SetLength(fileStream.Length);
            fileStream.Read(mStreamer.GetBuffer(), 0, (int)fileStream.Length);
            mStreamer.Seek(0, SeekOrigin.Begin);
            byte[] fileBytes = mStreamer.GetBuffer();
            return fileBytes;
        }
        public static string GetUrlRoot()
        {
            return HttpContext.Current.Server.MapPath("~/FilesTemp/");
        }

        public static string ObtenerVersion()
        {
            try
            {
                string path = HttpContext.Current.Server.MapPath("~/version.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                XmlElement rootElem = xmlDoc.DocumentElement;
                if (rootElem != null)
                {
                    return rootElem.Attributes["suite"].Value;
                }
                else
                {
                    return "0.0.0";
                }
            }
            catch (System.Exception)
            {
                return "0.0.0";
            }
        }

      
    }
    public static class RegexUtilities
    {
        static bool invalid = false;

        public static bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            strIn = Regex.Replace(strIn, @"(@)(.+)$", RegexUtilities.DomainMapper);
            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                   RegexOptions.IgnoreCase);
        }

        private static string DomainMapper(Match match)
        {
            IdnMapping idn = new IdnMapping();
            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }


    public static class FTP
    {
        private static string ftpAddress = ConfigurationManager.AppSettings["FTP_IP"].ToString();
        private static string username = ConfigurationManager.AppSettings["FTP_User"].ToString();
        private static string password = ConfigurationManager.AppSettings["FTP_Pass"].ToString();
        private static string flag = ConfigurationManager.AppSettings["FTP_Flag"].ToString();
        public static bool VerificarConexion()
        {
            bool result = false;
            string url = string.Format("ftp://{0}/{1}", ftpAddress, flag);
            FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create(url);
            ftpClient.Credentials = new System.Net.NetworkCredential(username, password);
            ftpClient.Method = System.Net.WebRequestMethods.Ftp.GetFileSize;
            try
            {
                FtpWebResponse response = (FtpWebResponse)ftpClient.GetResponse();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        public static bool VerificarArchivo(string ruta)
        {
            bool result = false;
            string fileName = Path.GetFileName(ruta);
            string url = string.Format("ftp://{0}/{1}", ftpAddress, fileName);
            FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create(url);
            ftpClient.Credentials = new System.Net.NetworkCredential(username, password);
            ftpClient.Method = System.Net.WebRequestMethods.Ftp.GetFileSize;
            try
            {
                FtpWebResponse response = (FtpWebResponse)ftpClient.GetResponse();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        public static string GuardarArchivo(string ruta)
        {
            string fileName = Path.GetFileName(ruta);
            string url = string.Format("ftp://{0}/{1}", ftpAddress, fileName);
            FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create(url);
            ftpClient.Credentials = new System.Net.NetworkCredential(username, password);
            ftpClient.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            ftpClient.UseBinary = true;
            ftpClient.KeepAlive = true;
            System.IO.FileInfo fi = new System.IO.FileInfo(ruta);
            ftpClient.ContentLength = fi.Length;
            byte[] buffer = new byte[4097];
            int bytes = 0;
            int total_bytes = (int)fi.Length;
            System.IO.FileStream fs = fi.OpenRead();
            System.IO.Stream rs = ftpClient.GetRequestStream();
            while (total_bytes > 0)
            {
                bytes = fs.Read(buffer, 0, buffer.Length);
                rs.Write(buffer, 0, bytes);
                total_bytes = total_bytes - bytes;
            }
            fs.Close();
            fs.Dispose();
            rs.Flush();
            rs.Close();
            fi = null;
            FtpWebResponse uploadResponse = (FtpWebResponse)ftpClient.GetResponse();
            string value = uploadResponse.StatusDescription;
            uploadResponse.Close();

            return url;
        }
        public static byte[] DescargarArchivo(string rutaFTP)
        {
            byte[] fileData;
            using (WebClient request = new WebClient())
            {
                request.Credentials = new NetworkCredential(username, password);
                fileData = request.DownloadData(rutaFTP);
            }
            return fileData;
        }
    }
}