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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Está a punto de cerrar su sesión, ¿confirma ? ", "Liga del Sur", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Form1 sesion = new Form1();
                this.Close(); //Cierra el formulario actual, el principal.
                sesion.Show(); //Muestra el de sesión otra vez.
            }
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmJugadores sesion = new frmJugadores();
            this.Close(); //Cierra el formulario actual, el principal.
            sesion.Show(); //Muestra el de sesión otra vez.
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClubes s = new frmClubes();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSANCIONES s = new frmSANCIONES();
            this.Visible = false; //Oculta el formulario de inicio de sesión.
            s.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
