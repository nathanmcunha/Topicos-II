using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SqlServerCe;
using System.Data;

namespace Dados
{
    class BD
    {
        static SqlCeConnection conn = new SqlCeConnection();
        static string strConn = @"Data Source=C:\GITHUB\Topicos-II\Shabba.sdf;Password=1234";
        
        public static void AbrirConexao()
        {
            try
            {
                conn.ConnectionString = strConn;

                if (conn != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    else
                    {
                        conn = new SqlCeConnection();
                        conn.Open();
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static SqlCeDataReader ExecutarSelect(String _sql)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_sql, conn);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }
        }

        public static int ExecutarSQLAlter(String _SQL)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conn);

                linhasAfetadas = comando.ExecuteNonQuery();

                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                BD.FecharConexao();
                throw new Exception(ex.Message);
            }

            return linhasAfetadas;
        }

        internal static SqlCeDataReader ExecutarSQLSelect(string SQL)
        {
            throw new NotImplementedException();
        }
    }
}

