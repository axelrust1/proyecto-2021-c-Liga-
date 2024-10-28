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

namespace LigaPro22
{
    public partial class frmClubes : Form
    {
        public frmClubes()
        {
            InitializeComponent();
            NombreClub.Focus();
            cargarCodigoPostal();
            cargarTabla();
        }

        

        

      
        private void cargarCodigoPostal()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from localidad";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                comboBox1.ValueMember = "CodigoPostal";
                comboBox1.DisplayMember = "CodigoPostal";
                comboBox1.DataSource = dt;
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

        private void frmClubes_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            NombreClub.Text = "";
            Domicilio.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void Domicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    Clubes user = new Clubes();
                    user.Nombre = NombreClub.Text;
                    user.Domicilio = Domicilio.Text;
                    user.Codigopostal = int.Parse(comboBox1.SelectedValue.ToString());
                    user.Fundacion = Convert.ToDateTime(dateTimePicker1.Text);
                    ControlClubes control = new ControlClubes();
                    MessageBox.Show(control.ctrlRegistroClubes(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    llenas_tabla();
                    limpiar_tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal p = new frmPrincipal();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            p.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void llenas_tabla()
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string consulta = "Select * from club";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void cargarTabla()
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                dataGridView1.DataSource = null;
                string consulta = "Select * from club";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            finally
            {
                con.Close();
            }

        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
                Clubes user = new Clubes();
                user.Nombre = NombreClub.Text;
                user.Domicilio = Domicilio.Text;
                user.Codigopostal = int.Parse(comboBox1.Text);
            user.Fundacion = Convert.ToDateTime(dateTimePicker1.Text);
            string consulta = "UPDATE club SET idClub='" + textBox1.Text + "', Nombre='" + user.Nombre + "', Domicilio='" + user.Domicilio + "', CodigoPostal='" + user.Codigopostal + "', FechaFunda='" + user.Fundacion + "' WHERE idClub='" + textBox1.Text + "'";  //SEGUIR HACIENDO NO ANDA
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void limpiar_tabla()
        {
            textBox1.Clear();
            NombreClub.Clear();
            Domicilio.Clear();

            NombreClub.Focus();
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            NombreClub.Text = dataGridView1.SelectedCells[1].Value.ToString();
            Domicilio.Text = dataGridView1.SelectedCells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedCells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedCells[4].Value.ToString(); 
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            string consulta = "delete from club where idClub="+textBox1.Text+"";
                MySqlCommand comando = new MySqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Club Eliminado!");
            con.Close();
            llenas_tabla();
            limpiar_tabla();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void NombreClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            NombreClub.Text = "";
            Domicilio.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    Clubes user = new Clubes();
                    user.Nombre = NombreClub.Text;
                    user.Domicilio = Domicilio.Text;
                    user.Codigopostal = int.Parse(comboBox1.SelectedValue.ToString());
                    user.Fundacion = Convert.ToDateTime(dateTimePicker1.Text);
                    ControlClubes control = new ControlClubes();
                    MessageBox.Show(control.ctrlRegistroClubes(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    llenas_tabla();
                    limpiar_tabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            
                MySqlConnection con = Conexion.getConexion();
                con.Open();

          
            
                Clubes user = new Clubes();
                user.Nombre = NombreClub.Text;
                user.Domicilio = Domicilio.Text;
                user.Codigopostal = int.Parse(comboBox1.Text);
                user.Fundacion = Convert.ToDateTime(dateTimePicker1.Text);
            if ((string.IsNullOrEmpty(user.Nombre)) || (string.IsNullOrEmpty(user.Domicilio)))
            {
                MessageBox.Show("Error. Complete todos los campos.");
            }
            else
            {

            
                
                string consulta = "UPDATE club SET idClub='" + textBox1.Text + "', Nombre='" + user.Nombre + "', Domicilio='" + user.Domicilio + "', CodigoPostal='" + user.Codigopostal + "', FechaFunda='" + user.Fundacion + "' WHERE idClub='" + textBox1.Text + "'";
            
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
            }


            llenas_tabla();
            limpiar_tabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            if ((string.IsNullOrEmpty(NombreClub.Text)) || (string.IsNullOrEmpty(Domicilio.Text)))
            {
                MessageBox.Show("Error. Complete todos los campos.");
            }
            else
            {

            
            string consulta = "delete from club where idClub=" + textBox1.Text + "";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Club Eliminado!");
            con.Close();
            }
            llenas_tabla();
            limpiar_tabla();
        }
    }
    }

