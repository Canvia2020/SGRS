using SGRS.Entity.BaseEF.Response;
using SGRS.Entity.Request;
using SGRS.Entity.Response;
using System;
using System.Collections.Generic;

namespace SGRS.BLL.Interface
{
    public interface IParametroService : IGenericService
    {
        ProcessResult<ParametroResponse> ObtenerParametroPorCodigoSistemaPadreValor(int CodigoSistemaPadre, String Valor);
        ProcessResult<String> ParametrosRuta(Int64 codigoParametro);
   
        ProcessResult<EFParametroResponse> ObtenerParametroPorCodigoParametro(Int32 Codigo);
        ProcessResult<List<ParametroResponse>> ListarParametrosGrilla(ParametroRequest oParametroRequest);
        ProcessResult<string> RegistrarParametro(ParametroRequest oParametroRequest);
       // ProcessResult<string> ActualizarParametro(ParametroRequest oParametroRequest);
        ProcessResult<ParametroResponse> ObtenerParametroPorCodigoSistemaActivo(int CodigoSistema);
        ProcessResult<List<ParametroResponse>> ListarParametroPorCodigoSistemaPadreActivo(int CodigoSistemaPadre);
        ProcessResult<List<ParametroResponse>> ListarParametroPorCodigoPadreActivo(int CodigoPadre);

        ProcessResult<string> ActualizarParametro(EFParametroResponse objEfParametroResponse);
        //ProcessResult<EFParametroResponse> FinById(Int32 codigo);
    }
}
