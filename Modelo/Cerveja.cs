using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cerveja
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
        private int pais;

        public int Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        private int tipo;

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int qtd;

        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        } 
    }
}
