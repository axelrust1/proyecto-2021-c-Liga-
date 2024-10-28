using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaPro22
{
    class Clubes
    {
        private int id;
        private string nombre;
        private string domicilio;
        private int codigopostal;
        private DateTime fundacion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Codigopostal
        {
            get => codigopostal; set => codigopostal = value;
        }
        public DateTime Fundacion { get => fundacion; set => fundacion = value; }
        

    }
}
