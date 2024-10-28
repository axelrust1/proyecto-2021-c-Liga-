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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            NyA.Focus();
            cargarUsuarios();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NyA.Text = "";
            comboBox1.Text = "";
            NameUser.Text = "";
            Pss.Text = "";
            CpAss.Text = "";
        }
    private void cargarUsuarios()
            {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
                con.Open();
                try
                {
                    string consulta = "Select * from tipousuarios";
                    MySqlCommand comando = new MySqlCommand(consulta, con);
                    MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    mysqldt.Fill(dt);
                comboBox1.ValueMember = "idUsuario";
                comboBox1.DisplayMember = "Nombre";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Usuario user = new Usuario();
                user.Usuarios = NameUser.Text;
                user.Password = Pss.Text;
                user.PasswordConfirma = CpAss.Text;
                user.Nombre = NyA.Text;
                user.IdTipo = int.Parse(comboBox1.SelectedValue.ToString());
                controlUsuarios control = new controlUsuarios();
                MessageBox.Show(control.ctrlRegistroUsuarios(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            s.Show();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
