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
    class ModeloFaltas
    {
        static MySqlConnection miConexion = Conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;

        public bool registrarFalta(Faltas falta)
        {
            miConexion.Open();
            sql = "INSERT INTO faltas (fecha, idJugador, amarilla, roja, Explicacion)" + " VALUES(@Fecha, @IdJugador, @Amarilla, @Roja, @Explicacion)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Fecha", falta.Fecha);
            comando.Parameters.AddWithValue("@IdJugador", falta.IdJugador);
            comando.Parameters.AddWithValue("@Amarilla", falta.Amarilla);
            comando.Parameters.AddWithValue("@Roja", falta.Roja);
            comando.Parameters.AddWithValue("@Explicacion", falta.Explicacion);


            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}
