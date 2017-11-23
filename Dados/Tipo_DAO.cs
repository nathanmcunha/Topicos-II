using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo; 
using System.Data.SqlServerCe;

namespace Dados
{
   public class Tipo_DAO
    {
       
       public void InserirTipo(Tipo _tipo)
       {
           string SQL = String.Format("INSERT INTO tipo (nome) VALUES ('{0}')", _tipo.Nome);

           BD.ExecutarSQLAlter(SQL);
       }


       public List<Tipo> BuscarTodos()
       {
           List<Tipo> listaTipos = new List<Tipo>();
           try
           {
               String SQL = "SELECT * FROM tipo";

               SqlCeDataReader data = BD.ExecutarSelect(SQL);

               while (data.Read())
               {
                   Tipo tipo = new Tipo();

                   tipo.Id = data.GetInt32(0);
                   tipo.Nome = data.GetString(1);

                   listaTipos.Add(tipo);
               }

               data.Close();
               BD.FecharConexao();

               return listaTipos;
           }
           catch (Exception e)
           {
               throw new Exception(e.Message);
           }    
       
       
       }
   
   }
}
