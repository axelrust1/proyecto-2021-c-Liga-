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
    class ModeloClubes
    {
   
            static MySqlConnection miConexion = Conexion.getConexion();
            static string sql = "";
            static MySqlCommand comando;
            static MySqlDataReader reader;
            public bool existeClub(Clubes user)
            {
                bool rta = false;
                miConexion.Open();
                sql = "Select * from club where Nombre Like @Nombre";
                comando = new MySqlCommand(sql, miConexion);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                reader = comando.ExecuteReader();
                if ((reader.HasRows))
                    rta = true;
                miConexion.Close();
                return rta;
            }
            public bool registrarClub(Clubes user)
            {
                miConexion.Open();
                sql = "INSERT INTO club (idClub, Nombre, Domicilio, CodigoPostal, FechaFunda)" + " VALUES(@idClub, @Nombre, @Domicilio, @CodigoPostal, @FechaFunda)";
                MySqlCommand comando = new MySqlCommand(sql, miConexion);
                comando.Parameters.AddWithValue("@idClub", null);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Domicilio", user.Domicilio);
                comando.Parameters.AddWithValue("@CodigoPostal", user.Codigopostal);
                comando.Parameters.AddWithValue("@FechaFunda", user.Fundacion);
                int tuplas = comando.ExecuteNonQuery();
                miConexion.Close();
                if (tuplas > 0)
                    return true;
                else
                    return false;
            }
        
    }
}
