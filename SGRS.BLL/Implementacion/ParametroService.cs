using SGRS.BLL.Interface;
using SGRS.DAL.AdoNet;
using SGRS.DAL.EntityFramework.Base;
using SGRS.Entity.BaseEF.Response;
using SGRS.Entity.Request;
using SGRS.Entity.Response;
using SGRS.Helper.Constantes;
using System;
using System.Collections.Generic;

namespace SGRS.BLL.Implementacion
{
    public class ParametroService : GenericService, IParametroService
    {
        public ParametroDA _parametroDA;
        public EFParametroDA _EFparametroDA;
        public ParametroService()
        {
            _parametroDA = new ParametroDA();
            _EFparametroDA = new EFParametroDA();
        }
        public ProcessResult<string> ActualizarParametro(ParametroRequest oParametroRequest)
        {
            throw new NotImplementedException();
        }

        public ProcessResult<List<ParametroResponse>> ListarParametroPorCodigoPadreActivo(int CodigoPadre)
        {
            throw new NotImplementedException();
        }

        public ProcessResult<List<ParametroResponse>> ListarParametroPorCodigoSistemaPadreActivo(int CodigoSistemaPadre)
        {
            ProcessResult<List<ParametroResponse>> resultado = new ProcessResult<List<ParametroResponse>>();
            try
            {
                List<ParametroResponse> result = new List<ParametroResponse>();
  
                resultado.Result = _parametroDA.GetFiltered(CodigoSistemaPadre ,DatosConstantes.EstadoRegistro.Activo);
                resultado.IsSuccess = true;

            }
            catch (Exception ex)
            {
                //resultado.Exception = new ApplicationLayerException<ParametroService>(ex.Message);
                resultado.IsSuccess = false;
            }
            return resultado;
        }

        public ProcessResult<List<ParametroResponse>> ListarParametrosGrilla(ParametroRequest oParametroRequest)
        {
            ProcessResult<List<ParametroResponse>> resultado = new ProcessResult<List<ParametroResponse>>();
            try
            {
                List<ParametroResponse> listaParametro = _parametroDA.ListarParametrosGrilla(oParametroRequest);
                //List<ParametroResponse> result = new List<ParametroResponse>();
            

                resultado.Result = listaParametro;
                resultado.IsSuccess = true;
            }
            catch (Exception ex)
            {
                //resultado.Exception = new ApplicationLayerException<ParametroService>(ex.Message);
                resultado.IsSuccess = false;
            }
            return resultado;

        }


     //   public EFParametroResponse FinById(Int32 codigo)

        public ProcessResult<EFParametroResponse> ObtenerParametroPorCodigoParametro(Int32 Codigo)
        {
            ProcessResult<EFParametroResponse> resultado = new ProcessResult<EFParametroResponse>();
            try
            {
                EFParametroResponse data = _EFparametroDA.FinById(Codigo);
              
                resultado.Result = data;
            }
            catch (Exception ex)
            {
                resultado.IsSuccess = false;
                //resultado.Exception = new ApplicationLayerException<ParametroService>(e);
            }
            return resultado;
        }

        public ProcessResult<ParametroResponse> ObtenerParametroPorCodigoSistemaActivo(int CodigoSistema)
        {
            throw new NotImplementedException();
        }

        public ProcessResult<ParametroResponse> ObtenerParametroPorCodigoSistemaPadreValor(int CodigoSistemaPadre, string Valor)
        {
            throw new NotImplementedException();
        }

        //retorn el nombre del parametro
        public ProcessResult<string> ParametrosRuta(long codigoParametro)
        {
            ProcessResult<String> resultado = new ProcessResult<String>();

            try
            {
                var texto = _parametroDA.ParametrosRuta(codigoParametro);
                resultado.IsSuccess = true;
                resultado.Result = texto;
            }
            catch (Exception ex)
            {
                //resultado.Exception = new ApplicationLayerException<ParametroService>(ex.Message);
            }

            return resultado;

        }

        public ProcessResult<string> RegistrarParametro(EFParametroResponse oEFParametroResponse)
        {
            ProcessResult<string> resultado = new ProcessResult<string>();
            try
            {

                int CodigoParametroNuevo = _EFparametroDA.Max();
                oEFParametroResponse.CODIGO_PARAMETRO = CodigoParametroNuevo + 1;
               
                _EFparametroDA.Insertar(oEFParametroResponse);

                resultado.IsSuccess = true;
                resultado.Result = "Registro Satisfactorio";
            }
            catch (Exception e)
            {
                resultado.IsSuccess = false;
                //resultado.Exception = new ApplicationLayerException<ParametroService>(e);
            }
            return resultado;
        }

        public ProcessResult<string> RegistrarParametro(ParametroRequest oParametroRequest)
        {
            throw new NotImplementedException();
        }

        public ProcessResult<string> ActualizarParametro(EFParametroResponse objEfParametroResponse)
        {
            ProcessResult<string> resultado = new ProcessResult<string>();

            //EFParametroResponse objEFParametroResponse = _EFparametroDA.FinById(objEfParametroResponse.CODIGO_PARAMETRO);


            //if (objEFParametroResponse.CODIGO_PADRE != 0)
            //{
            //    ParametroEntity oParametroEntityPadre = _EFparametroDA.GetFiltered(x => x.CodigoParametro == oParametroEditar.CodigoPadre).FirstOrDefault();
            //    if (oParametroEntityPadre != null)
            //    {
            //        oParametroEntity.Nivel = oParametroEntityPadre.Nivel == null ? 1 : oParametroEntityPadre.Nivel + 1;
            //    }
            //}


            _EFparametroDA.Actualizar(objEfParametroResponse);

            resultado.IsSuccess = true;
            resultado.Result = "Actualización Satisfactoria";



            return resultado;
        }
    }
}
