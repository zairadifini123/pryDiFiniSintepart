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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        int intentos = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string modulo = cmbModulo.SelectedItem?.ToString();

            // Validación de cada usuario con sus contraseñas y módulos
            if (usuario == "Adm" && contraseña == "@1a" && (modulo == "ADM" || modulo == "COM" || modulo == "VTA"))
            {
                AbrirBienvenido();
            }
            else if (usuario == "John" && contraseña == "*2b" && modulo == "SIST")
            {
                AbrirBienvenido();
            }
            else if (usuario == "Ceci" && contraseña == "*@3c" && (modulo == "ADM" || modulo == "VTA"))
            {
                AbrirBienvenido();
            }
            else if (usuario == "God" && contraseña == "*@#4d")
            {
                AbrirBienvenido();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                intentos++;

                if (intentos >= 2)
                {
                    this.Close();
                }
            }
        }

        private void AbrirBienvenido()
        {
            this.Hide(); // Oculta el login
            frmBienvenido f = new frmBienvenido(); // Crea el otro formulario
            f.ShowDialog();
            this.Show(); // Vuelve al login cuando se cierre Bienvenida
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cerrar login
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

