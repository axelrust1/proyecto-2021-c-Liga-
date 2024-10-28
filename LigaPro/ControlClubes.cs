using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaPro22
{
    class ControlClubes
    {
        public string ctrlRegistroClubes(Clubes user)
        {
            ModeloClubes modelo = new ModeloClubes();
            string rta = "";
            if ((string.IsNullOrEmpty(user.Nombre)) || (string.IsNullOrEmpty(user.Domicilio)) || ((user.Codigopostal) == 0) || (user.Fundacion == null))  {
                rta = "Datos incompletos";
            }
            else
            {
              
                    if (modelo.existeClub(user))
                    {
                        rta = "Su club no puede ser inscrito con el nombre " + user.Nombre + " porque ya esta en uso.";
                    }
                    else
                    {
                        modelo.registrarClub(user);
                        rta = "¡Su Club ha sido inscrito satisfactoriamente!";
                    }
              
            
            }
            return rta;
        }
       
    }
}
