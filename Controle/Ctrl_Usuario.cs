using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Controle{

    public class Ctrl_Usuario{

        public bool validarUsuario(Usuario _user){

            try{
                if (_user.Username.Equals("nathanmcunha") && _user.Password.Equals("1234"))
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
