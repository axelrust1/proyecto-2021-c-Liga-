using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaPro22
{
    class Jugadores
    {
            private int id;
            private int dni;
            private string nombre;
            private string apellido;
            private string domicilio;
            private int codigopostal;
            private string sexo;
            private DateTime fechanac;
            private int idclub;

        public int Id { get => id; set => id = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public int Codigopostal
            {
                get => codigopostal; set => codigopostal = value;
            }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
        public int IdClub { get => idclub; set => idclub = value; }


    }
    
    }

