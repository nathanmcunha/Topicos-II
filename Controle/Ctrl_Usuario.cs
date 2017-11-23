using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Controle{

    public class Ctrl_Usuario{

        public bool validarUsuario(Usuario _user){
         
            if (_user.Username.Equals("nathanmcunha"))
                _user.Perfil = 1;
            else
            {
                _user.Perfil = 2;
            }
            
            try{
                if (_user.Username.Equals("nathanmcunha") && _user.Password.Equals("1234") || _user.Username.Equals("joao") && _user.Password.Equals("1234"))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex){

                throw new Exception(ex.Message);
            }

           
        }
    }
}
