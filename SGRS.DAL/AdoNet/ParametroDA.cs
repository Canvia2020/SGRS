using SGRS.Entity.Request;
using SGRS.Entity.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SGRS.DAL.AdoNet
{
    public class ParametroDA : BaseData
    {

        //public static Int32 InsertPedido_DetallePedido(Int32 intCodigoConsultora)
        //{
        //    Int32 Error = 0;           

        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "TBPedido_InsertPedido_PedidoDetalle";
        //    command.CommandType = CommandType.StoredProcedure;
        //    SqlConnection objConnection = new SqlConnection(StaticConnectionString);
        //    command.Connection = objConnection;

        //    objConnection.Open();

        //    try
        //    {
        //        command.Parameters.AddWithValue("@intCodigoConsultora", intCodigoConsultora);
        //        SqlParameter ret = command.Parameters.Add("@intError", SqlDbType.Int);
        //        ret.Direction = ParameterDirection.Output;
        //        ret.Value = 0;

        //        command.ExecuteNonQuery();

        //        Error = Convert.ToInt32(command.Parameters["@intError"].Value);

        //    }
        //    catch (Exception ex)
        //    {
        //        Error = 0;
        //    }
        //    finally
        //    {
        //        command.Dispose();
        //    }


        //    return Error;
        //}

        public  String ParametrosRuta(Int64 codigoParametro)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "MAN.USP_SEL_PARAMETROS_RUTA";
            command.CommandType = CommandType.StoredProcedure;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;

            String resp = "";

            DataTable dt = new DataTable("tb");
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            try
            {
                command.Parameters.AddWithValue("@CODIGO_PARAMETRO", codigoParametro);

                staticConnection.Open();
                sqlAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    resp = dt.Rows[0][0].ToString();
                }
               
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }

            return resp;

        }

        public List<ParametroResponse> GetFiltered(int codigoSistemaPadre, string activo)
        {
            List<ParametroResponse> listEntidadLogic = new List<ParametroResponse>();
            try
            {
                SQLServer.OpenConection();
                SQLServer.CreateCommand("MAN.SP_SEL_PARAMETRO", CommandType.StoredProcedure,
                    SQLServer.CreateParameter("CODIGO_PADRE", SqlDbType.Int, codigoSistemaPadre),
                    SQLServer.CreateParameter("ESTADO_REGISTRO", SqlDbType.Char, activo),
                    SQLServer.CreateParameter("TIPO", SqlDbType.Char, "1")
                    );

                using (IDataReader oReader = SQLServer.GetDataReader(CommandBehavior.CloseConnection))
                {
                    listEntidadLogic = new GenericInstance<ParametroResponse>().readDataReaderList(oReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLServer.CloseConection();
            }
            return listEntidadLogic;
        }


        //public String ParametrosRuta(Int64 codigoParametro)
        //{

        //    SqlParameter[] parametros = new SqlParameter[]
        //    {
        //            new SqlParameter("CODIGO_PARAMETRO", SqlDbType.Int) { Value = codigoParametro },
        //    };

        //    var resultado = this.dataBaseProvider.ExecuteStoreProcedure<String>(DatosConstantes.EsquemasBd.Man + ".USP_SEL_PARAMETROS_RUTA", parametros).ToList();
        //    var Texto = "";
        //    if (resultado.Count > 0)
        //    {
        //        Texto = resultado[0];
        //    }
        //    return Texto;
        //    //try
        //    //{
        //    //    SQLServer.OpenConection();
        //    //    SQLServer.CreateCommand(DatosConstantes.EsquemasBd.Man+".USP_SEL_PARAMETROS_RUTA", CommandType.StoredProcedure,
        //    //        SQLServer.CreateParameter("CODIGO_PARAMETRO", SqlDbType.Int, codigoParametro)
        //    //    );
        //    //    using (IDataReader oReader = SQLServer.GetDataReader(CommandBehavior.CloseConnection))
        //    //    {
        //    //        String texto = "";
        //    //        while (oReader.Read())
        //    //        {
        //    //            texto  =oReader["ruta"].ToString();
        //    //        }
        //    //        return texto;
        //    //    }

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw ex;
        //    //}
        //    //finally
        //    //{
        //    //    SQLServer.CloseConection();
        //    //}
        //}
        //public List<ParametroLogic> listarParametros(ParametroRequest oPublicacionRequest)
        //{
        //    List<ParametroLogic> listEntidadLogic = new List<ParametroLogic>();
        //    try
        //    {
        //        SQLServer.OpenConection();
        //        SQLServer.CreateCommand(DatosConstantes.EsquemasBd.Man + ".USP_SEL_PARAMETRO_DETALLE_LISTAR", CommandType.StoredProcedure,
        //            SQLServer.CreateParameter("CODIGO_PARAMETRO", SqlDbType.Int, oPublicacionRequest.CodigoParametro)
        //        );
        //        using (IDataReader oReader = SQLServer.GetDataReader(CommandBehavior.CloseConnection))
        //        {
        //            listEntidadLogic = new GenericInstance<ParametroLogic>().readDataReaderList(oReader);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        SQLServer.CloseConection();
        //    }
        //    return listEntidadLogic;
        //}

        public List<ParametroResponse> ListarParametrosGrilla(ParametroRequest oParametroRequest)
        {
            List<ParametroResponse> listEntidadLogic = new List<ParametroResponse>();
            try
            {
                SQLServer.OpenConection();
                SQLServer.CreateCommand("MAN.USP_SEL_PARAMETRO_PAG", CommandType.StoredProcedure,
                SQLServer.CreateParameter("SORTDIRECTION", SqlDbType.VarChar, oParametroRequest.SortDirection),
                SQLServer.CreateParameter("SORTCOLUMN", SqlDbType.VarChar, oParametroRequest.SortColumn),
                SQLServer.CreateParameter("ROWSPERPAGE", SqlDbType.VarChar, oParametroRequest.RowsPerPage),
                SQLServer.CreateParameter("PAGEINDEX", SqlDbType.Int, oParametroRequest.PageIndex),
                SQLServer.CreateParameter("PAGINATE", SqlDbType.Bit, oParametroRequest.IsPaginate),
                SQLServer.CreateParameter("FILTERS", SqlDbType.Structured, oParametroRequest.Filters));
                using (IDataReader oReader = SQLServer.GetDataReader(CommandBehavior.CloseConnection))
                {
                    listEntidadLogic = new GenericInstance<ParametroResponse>().readDataReaderList(oReader);
                }
                oParametroRequest.TotalRows = listEntidadLogic.Count > 0 ? listEntidadLogic[0].TotalRegistro : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLServer.CloseConection();
            }
            return listEntidadLogic;
        }

        //public void Insertar(ParametroRequest oParametroRequest)
        //{
        //    SqlParameter[] parametros = new SqlParameter[]
        //    {
        //        new SqlParameter("CODIGO_PARAMETRO", SqlDbType.Int) { Value = oParametroRequest.CodigoParametro },
        //        new SqlParameter("CODIGO_PADRE", SqlDbType.Int) { Value = oParametroRequest.CodigoPadre },
        //        new SqlParameter("NOMBRE", SqlDbType.VarChar) { Value = oParametroRequest.Nombre },
        //        new SqlParameter("NOMBRE_CORTO", SqlDbType.VarChar) { Value = oParametroRequest.NombreCorto },
        //        new SqlParameter("DESCRIPCION", SqlDbType.VarChar) { Value = oParametroRequest.Descripcion ?? "" },
        //        new SqlParameter("VALOR", SqlDbType.VarChar) { Value = oParametroRequest.Valor ?? SqlString.Null },
        //        new SqlParameter("VALOR_FECHA", SqlDbType.DateTime) { Value = oParametroRequest.ValorFecha ?? SqlDateTime.Null },
        //        new SqlParameter("ORDEN", SqlDbType.Int) { Value = oParametroRequest.Orden ?? SqlInt32.Null },
        //        new SqlParameter("NIVEL", SqlDbType.Int) { Value = oParametroRequest.Nivel ?? SqlInt32.Null },
        //        new SqlParameter("DESCRIPCION_NOTIFICACION", SqlDbType.NVarChar) { Value = oParametroRequest.DescripcionNotificacion ?? SqlString.Null},
        //        new SqlParameter("TIPO_PARAMETRO", SqlDbType.SmallInt) { Value = oParametroRequest.TipoParametro ?? SqlInt16.Null},
        //        new SqlParameter("ESTADO_REGISTRO", SqlDbType.Char) { Value = oParametroRequest.EstadoRegistro ?? SqlString.Null},
        //        new SqlParameter("USUARIO_CREACION", SqlDbType.VarChar) { Value = oParametroRequest.UsuarioCreacion },
        //        new SqlParameter("TERMINAL_CREACION", SqlDbType.VarChar) { Value = oParametroRequest.TerminalCreacion },
        //        new SqlParameter("CODIGO_SISTEMA", SqlDbType.Int) { Value = oParametroRequest.CodigoSistema ?? SqlInt32.Null},
        //        new SqlParameter("CODIGO_SISTEMA_PADRE", SqlDbType.Int) { Value = oParametroRequest.CodigoSistemaPadre ?? SqlInt32.Null},
        //    };

        //    var resultado = this.dataBaseProvider.ExecuteStoreProcedureNonQuery(DatosConstantes.EsquemasBd.Man + ".SP_INS_PARAMETRO", parametros);

        //}

    }
}

