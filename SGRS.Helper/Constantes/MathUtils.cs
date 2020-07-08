using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRS.Helper.Constantes
{
    public class MathUtils
    {

        #region Validación de números
        /// <summary>
        /// Función que valida si es un número Int
        /// </summary>
        /// <param name="number">Número a validar</param>
        /// <returns>Boolean con la validación</returns>
        public static Boolean isValidIntNumber(String number)
        {
            Boolean flag = true;
            try
            {
                Convert.ToInt32(number);
            }
            catch (System.Exception e)
            {
                flag = false;
                Log.RegistrarError(e);
            }
            return flag;
        }

        /// <summary>
        /// Función que valida si es un número Int64
        /// </summary>
        /// <param name="number">Número a validar</param>
        /// <returns>Boolean con la validación</returns>
        public static Boolean isValidInt64Number(String number)
        {
            Boolean flag = true;
            try
            {
                Convert.ToInt64(number);
            }
            catch (System.Exception e)
            {
                Log.RegistrarError(e);
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// Función que valida si es un número Double
        /// </summary>
        /// <param name="number">Número a validar</param>
        /// <returns>Boolean con la validación</returns>
        public static Boolean isValidDecimalNumber(String number)
        {
            Boolean flag = true;

            if (!(number != null && number != ""))
            {
                return false;
            }

            try
            {
                Convert.ToDouble(number);
            }
            catch (System.Exception e)
            {
                Log.RegistrarError(e);
                flag = false;
            }
            return flag;
        }
        #endregion

        /// <summary>
        /// Función que convierte el ángulo en grados a Radianes
        /// </summary>
        /// <param name="angle">Ángulo en grados </param>
        /// <returns>Ángulo convertido a radianes</returns>
        private static double convertToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
        public static string FormatNumber<T>(T number, int maxDecimals = 4)
        {
            try
            {
                //return Regex.Replace(String.Format("{0:n" + maxDecimals + "}", number),
                //     @"[" + System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "]?0+$", "");
                var decimales = ("").PadLeft(maxDecimals, '0');
                var formato = "{0:0." + decimales + "}";
                var cero = String.Format(formato, number);
                return cero;// String.Format("{0:0."+("").PadLeft(maxDecimals,'0')+"}", number);
            }
            catch (System.Exception ex)
            {
                Log.RegistrarError(ex);
                throw;
            }
        }
    }
}

