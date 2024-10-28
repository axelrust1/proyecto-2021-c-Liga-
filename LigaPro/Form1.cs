using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaPro22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = txtUsuario.Text;
                String pass = txtPassword.Text;
                controlSesion control = new controlSesion();
                String respuestaControlador = control.ctrlLogin(usuario, pass);
                if (respuestaControlador == "¡Bienvenido!")
                {
                    MessageBox.Show(control.ctrlLogin(usuario, pass), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal p = new frmPrincipal();
                    this.Visible = false; //Oculta el formulario de inicio de sesión.
                    p.Show();
                }
                else
                {
                    MessageBox.Show(respuestaControlador, "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txtUsuario.Text == "")
                    {
                        txtUsuario.Focus();
                    }
                    else
                        {
                            txtPassword.Focus();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea Salir?", "Liga del Sur", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            frmUsuarios s = new frmUsuarios();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            s.Show();
        }
    }
}
