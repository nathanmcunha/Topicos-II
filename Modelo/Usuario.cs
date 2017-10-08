using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Usuario
    {
        private String username;
        private String password;
        private int perfil;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Perfil { get => perfil; set => perfil = value; }
    }

}
