using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo; 
using System.Data.SqlServerCe;

namespace Dados
{
    public class Pais_DAO
    {
        public void InserirPais(Pais pais)
        {
            string SQL = String.Format("INSERT INTO pais (nome) VALUES ('{0}')", pais.Nome);

            BD.ExecutarSQLAlter(SQL);
        }


        public List<Pais> BuscarTodos()
        {
            List<Pais> listapais = new List<Pais>();
            try
            {
                String SQL = "SELECT * FROM pais";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pais pais = new Pais();

                    pais.Id = data.GetInt32(0);
                    pais.Nome = data.GetString(1);

                    listapais.Add(pais);
                }

                data.Close();
                BD.FecharConexao();

                return listapais;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       
        public Boolean DeletaPais()
        {

            return true;
        }




        public Pais BuscarPorID(int id)
        {
            Pais pais = null;
            
            try
            {
                String SQL = String.Format("SELECT * FROM pais WHERE id = {0}", id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    pais = new Pais();

                    pais.Id = data.GetInt32(0);
                    pais.Nome = data.GetString(1);
                    
            
                }

                data.Close();
                BD.FecharConexao();

                return pais;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
