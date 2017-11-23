using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Controle
{
    public class Cerveja_Controle
    {

        public void Inserir_Cerveja(Cerveja cerveja)
        {

            Cerveja_DAO dao = new Cerveja_DAO();
            dao.InserirCerveja(cerveja);

        }
        
        public void Deletar_Cerveja(int id)
        {

            Cerveja_DAO dao = new Cerveja_DAO();
            dao.DeletarCerveja(id);

        }
    
    }
}
