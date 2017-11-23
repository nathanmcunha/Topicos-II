using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pais
    
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
