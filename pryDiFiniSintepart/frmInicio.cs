using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniSintepart
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        int intentos = 0;
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Adm" &&
                    txtContraseña.Text == "1a@")
                (txtUsuario.Text == "John" &&
                    txtContraseña.Text == "*2b")
                (txtUsuario.Text == "Ceci" &&
                    txtContraseña.Text == "*@3c")
                (txtUsuario.Text == "God" &&
                    txtContraseña.Text == "*@#4d"))
                frmBienvenido ventanaBienvenido = new frmBienvenido();
            ventanaBienvenido.Show(); 

            {
                
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++; // incrementa el contador de intentos fallidos
                if (intentos == 2) // si es 3 se cierra el formulario
                {
                    this.Close();
                }
            }
        }
    }
}

