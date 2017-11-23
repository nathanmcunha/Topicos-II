using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dados
{
   public  class Cerveja_DAO
    {
       public void InserirCerveja(Cerveja cerveja)
       {
           string SQL = String.Format("INSERT INTO cerveja (nome,pais,qtd,tipo) VALUES ('{0}' ,'{1}', '{2}' ,'{3}')", cerveja.Nome, cerveja.Pais,cerveja.Qtd,cerveja.Tipo);

           BD.ExecutarSQLAlter(SQL);
       }

       public void DeletarCerveja(int id)
       {
           try
           {
               string SQL = String.Format("DELETE FROM cerveja WHERE id = {0}", id);

               BD.ExecutarSQLAlter(SQL);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
       }
    }
}
