using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaPro22
{
    class ControlJugadores
    {
        public string ctrlRegistroJugadores(Jugadores user)
        {
            ModeloJugadores modelo = new ModeloJugadores();
            string rta = "";
            if (((user.Dni) == 0) || ((string.IsNullOrEmpty(user.Nombre)) || ((string.IsNullOrEmpty(user.Apellido)) || (string.IsNullOrEmpty(user.Domicilio)) || ((user.Codigopostal) == 0) || ((string.IsNullOrEmpty(user.Sexo)) || (user.Fechanac == null)) || ((user.IdClub) == 0))))
            {
                rta = "Datos incompletos";
            }
            else
            {

                if (modelo.existeJugador(user))
                {
                    rta = "El jugador con DNI: " + user.Dni + " no puede ser ingresado porque ya esta inscrito.";
                }
                else
                {
                    modelo.registrarJugador(user);
                    rta = "¡El jugador "+user.Nombre+" "+user.Apellido+" ha sido inscrito satisfactoriamente!";
                }


            }
            return rta;
        }
    }
}
