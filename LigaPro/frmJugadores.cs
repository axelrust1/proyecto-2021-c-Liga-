using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace LigaPro22
{
    public partial class frmJugadores : Form
    {
        public frmJugadores()
        {
            InitializeComponent();
            dni.Focus();
            cargarCodigoPostal();
            llenas_tabla();
            cargarClub();
        }
        private void cargarCodigoPostal()
        {
            CodigPostal.DataSource = null;
            CodigPostal.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from localidad";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                CodigPostal.ValueMember = "CodigoPostal";
                CodigPostal.DisplayMember = "CodigoPostal";
                CodigPostal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void cargarClub()
        {
            Club.DataSource = null;
            Club.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from club";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                Club.ValueMember = "idClub";
                Club.DisplayMember = "Nombre";
                Club.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void llenas_tabla()
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string consulta = "Select * from jugadores";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    Jugadores user = new Jugadores();
                    user.Dni = int.Parse(dni.Text);
                    user.Nombre = Nom.Text;
                    user.Apellido = Ape.Text;
                    user.Domicilio = Domi.Text;
                    user.Codigopostal = int.Parse(CodigPostal.Text);
                    user.Sexo = Sexo.Text;
                    user.Fechanac = Convert.ToDateTime(FechaN.Text);
                    user.IdClub = int.Parse(Club.SelectedValue.ToString());
                    ControlJugadores control = new ControlJugadores();
                    MessageBox.Show(control.ctrlRegistroJugadores(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    llenas_tabla();
                    limpiar_tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void limpiar_tabla()
        {
            
            dni.Clear();
            Nom.Clear();
            Ape.Clear();
            Domi.Clear();
            Sexo.Clear();
            dni.Focus();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dni.Text = "";
            Nom.Text = "";
            Ape.Text = "";
            Sexo.Text = "";
            Domi.Text = "";
            CodigPostal.Text = "";
            Club.Text = "";
            FechaN.Text = "";
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            
            string consulta = "UPDATE jugadores SET  DNI ="+ int.Parse(dni.Text) + ", Nombre='" + Nom.Text + "', Apellido='" + Ape.Text + "', Domicilio='" + Domi.Text + "', CodigoPostal='"+ int.Parse(CodigPostal.Text) + "', Sexo='" + Sexo.Text + "', FechaNac='" + FechaN.Text + "', Club=" + int.Parse(Club.Text) + " DNI =" + int.Parse(dni.Text)+ "";  //SEGUIR HACIENDO NO ANDA
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizacion realizada correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            con.Close();
            llenas_tabla();
            limpiar_tabla();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string consulta = "delete from jugadores where DNI=" + dni.Text + "";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Jugador Eliminado!");
            con.Close();
            llenas_tabla();
            limpiar_tabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                dni.Text = dataGridView1.SelectedCells[1].Value.ToString();
                Nom.Text = dataGridView1.SelectedCells[2].Value.ToString();
                Ape.Text = dataGridView1.SelectedCells[3].Value.ToString();
                Domi.Text = dataGridView1.SelectedCells[4].Value.ToString();
                CodigPostal.Text = dataGridView1.SelectedCells[5].Value.ToString();
                Sexo.Text = dataGridView1.SelectedCells[6].Value.ToString();
                FechaN.Text = dataGridView1.SelectedCells[7].Value.ToString();
                Club.Text = dataGridView1.SelectedCells[8].Value.ToString();
                

        }

        private void BuscarDNI_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string consulta = "select * from jugadores where DNI=" + BuscarDNI.Text + "";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, con);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader lector;
            lector = comando.ExecuteReader();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            llenas_tabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal p = new frmPrincipal();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            p.Show();
        }

        private void CodigPostal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            dni.Text = "";
            Nom.Text = "";
            Ape.Text = "";
            Sexo.Text = "";
            Domi.Text = "";
            CodigPostal.Text = "";
            Club.Text = "";
            FechaN.Text = "";

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    Jugadores user = new Jugadores();
                    if ((string.IsNullOrEmpty(dni.Text)) || (string.IsNullOrEmpty(Nom.Text)) || (string.IsNullOrEmpty(Ape.Text)) || (string.IsNullOrEmpty(Domi.Text)) || (string.IsNullOrEmpty(Sexo.Text)))
                    {
                        MessageBox.Show("Error. Complete todos los campos.");
                    }
                    else
                    {

                    user.Dni = int.Parse(dni.Text);
                    user.Nombre = Nom.Text;
                    user.Apellido = Ape.Text;
                    user.Domicilio = Domi.Text;
                    user.Codigopostal = int.Parse(CodigPostal.Text);
                    user.Sexo = Sexo.Text;
                    user.Fechanac = Convert.ToDateTime(FechaN.Text);
                    user.IdClub = int.Parse(Club.SelectedValue.ToString());
                    ControlJugadores control = new ControlJugadores();
                    MessageBox.Show(control.ctrlRegistroJugadores(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    llenas_tabla();
                    limpiar_tabla();
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            if ((string.IsNullOrEmpty(dni.Text)) || (string.IsNullOrEmpty(Nom.Text)) || (string.IsNullOrEmpty(Ape.Text)) || (string.IsNullOrEmpty(Domi.Text)) || (string.IsNullOrEmpty(Sexo.Text)))
            {
                MessageBox.Show("Error. Complete todos los campos.");
            }
            else
            {
                string consulta = "UPDATE jugadores SET  DNI =" + int.Parse(dni.Text) + ", Nombre='" + Nom.Text + "', Apellido='" + Ape.Text + "', Domicilio='" + Domi.Text + "', CodigoPostal='" + int.Parse(CodigPostal.Text) + "', Sexo='" + Sexo.Text + "', FechaNac='" + FechaN.Text + "', Club=" + int.Parse(Club.Text) + " WHERE DNI =" + int.Parse(dni.Text) + "";  //SEGUIR HACIENDO NO ANDA
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizacion realizada correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            }

            con.Close();
            llenas_tabla();
            limpiar_tabla();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            if ((string.IsNullOrEmpty(dni.Text)) || (string.IsNullOrEmpty(Nom.Text)) || (string.IsNullOrEmpty(Ape.Text)) || (string.IsNullOrEmpty(Domi.Text)) || (string.IsNullOrEmpty(Sexo.Text)))
            {
                MessageBox.Show("Error. Complete todos los campos.");
            }
            else
            {
                string consulta = "delete from jugadores where DNI=" + dni.Text + "";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Jugador Eliminado!");
            con.Close();
            llenas_tabla();
            limpiar_tabla();
        }
            }

        private void frmJugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
