using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaPro22
{
    class ControlFaltas
    {
        public string ctrlRegistroFaltas(Faltas falta)
        {
            ModeloFaltas modelo = new ModeloFaltas();
            string rta = "";
            if (((falta.Fecha) == null) || (((falta.IdJugador)==0)) || (((falta.Explicacion) == null)))
            {
                rta = "Datos incompletos";
            }
            else
            {

            
                {
                    modelo.registrarFalta(falta);
                    rta = "La sancion fue inscrita correctamente.";
                }


            }
            return rta;
        }
    }
}
