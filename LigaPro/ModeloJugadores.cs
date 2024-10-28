using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LigaPro22
{
    class ModeloJugadores
    {
        static MySqlConnection miConexion = Conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public bool existeJugador(Jugadores user)
        {
            bool rta = false;
            miConexion.Open();
            sql = "Select * from jugadores where DNI Like @DNI";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@DNI", user.Dni);
            reader = comando.ExecuteReader();
            if ((reader.HasRows))
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool registrarJugador(Jugadores user)
        {
            miConexion.Open();
            sql = "INSERT INTO jugadores (idJugadores, DNI, Nombre, Apellido, Domicilio, CodigoPostal, Sexo, FechaNac, Club)" + " VALUES(@idJugadores, @DNI, @Nombre, @Apellido, @Domicilio, @CodigoPostal, @Sexo, @FechaNac, @Club)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@idJugadores", null);
            comando.Parameters.AddWithValue("@DNI", user.Dni);
            comando.Parameters.AddWithValue("@Nombre", user.Nombre);
            comando.Parameters.AddWithValue("@Apellido", user.Apellido);
            comando.Parameters.AddWithValue("@Domicilio", user.Domicilio);
            comando.Parameters.AddWithValue("@CodigoPostal", user.Codigopostal);
            comando.Parameters.AddWithValue("@Sexo", user.Sexo);
            comando.Parameters.AddWithValue("@FechaNac", user.Fechanac);
            comando.Parameters.AddWithValue("@Club", user.IdClub);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }

    }
}
