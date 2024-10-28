using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaPro22
{
    class Faltas
    {
        private DateTime fecha;
        private int idJugador;
        private int amarilla;
        private int roja;
        private string explicacion;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdJugador { get => idJugador; set => idJugador = value; }
        public int Amarilla { get => amarilla; set => amarilla = value; }
        public int Roja { get => roja; set => roja = value; }
        public string Explicacion { get => explicacion; set => explicacion = value; }
    }
}
