using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Controle
{
    public class Pais_Controle
    {
        public void Inserir_Pais(Pais _pais){
            
            Pais_DAO dao = new Pais_DAO();
            dao.InserirPais(_pais);
        
         }


        public List<Pais> BuscarTodosPaises()
        {
            try
            {
                Pais_DAO dao = new Pais_DAO();

                return dao.BuscarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public Pais BuscarPorPaisID(int id)
        {
            try
            {
                Pais_DAO dao = new Pais_DAO();

                return dao.BuscarPorID(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeletarPais(int id)
        {
            throw new NotImplementedException();
        }
    }
}
