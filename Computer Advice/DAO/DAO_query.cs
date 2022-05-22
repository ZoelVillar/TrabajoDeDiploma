using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Corte.CacheFolder;
using System.Data;

namespace DAO
{
    public class DAO_query : DAO_conectionSQL
    {
        protected List<SqlParameter> parametros;

        public void ExecuteNonQuery(string transactSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    foreach(SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }

        protected DataTable ExecuteReader(string transactSql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }

    }
}
