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
    public partial class frmSANCIONES : Form
    {
        public frmSANCIONES()
        {
            InitializeComponent();
            llenas_tabla();
            cargarJugador();
        }

        
            
        
       

        private void cargarJugador()
        {
            Jugador.DataSource = null;
            Jugador.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from jugadores";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                Jugador.ValueMember = "idJugadores";
                Jugador.DisplayMember = "Nombre";
                Jugador.DataSource = dt;
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
            string consulta = "Select * from faltas";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
        
                try
                {
                    MySqlConnection con = Conexion.getConexion();
                    con.Open();
                    Faltas falta = new Faltas();
                    falta.Fecha = Convert.ToDateTime(dateTimePicker1.Text);
                    falta.IdJugador = int.Parse(Jugador.SelectedValue.ToString());
                    falta.Explicacion = textBox1.Text;   
                if (((falta.Fecha) == null) || (((falta.IdJugador) == 0)) || (((textBox1.Text) == null)))
            {
                    MessageBox.Show ("Datos incompletos");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    falta.Amarilla = 1;
                    falta.Roja = 0;
                    string consulta = "UPDATE jugadores SET TarjetasAmarillas = (TarjetasAmarillas+1)";
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(consulta, con);
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    falta.Roja = 1;
                    falta.Amarilla = 0;
                    string consulta = "UPDATE jugadores SET TarjetasRojas = (TarjetasRojas+1)";
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(consulta, con);
                        comando.ExecuteNonQuery();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
               
                ControlFaltas control = new ControlFaltas();
                MessageBox.Show(control.ctrlRegistroFaltas(falta), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                llenas_tabla();
                }
                con.Close();

                llenas_tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            
            llenas_tabla();
        }
    

    private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal p = new frmPrincipal();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            p.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
