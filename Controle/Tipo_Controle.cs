using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Dados;

namespace Controle
{
  public class Tipo_Controle
    {
      
      public void Inserir_Tipo(Tipo _tipo)
      {

          Tipo_DAO dao = new Tipo_DAO();
          dao.InserirTipo(_tipo);

      }

      public List<Tipo> BuscarTodosTipos()
      {
         try
            {
                Tipo_DAO dao = new Tipo_DAO();

                return dao.BuscarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
      }
    }

