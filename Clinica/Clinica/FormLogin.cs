using Clinica.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad; //Trayendo la libreria de CLinica BL

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL(); // _seguridad es una variable global
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
                textBox1.Text = ""; //Codigo para borrar usuario
                textBox2.Text = ""; //Codigo para borrar contraseña
                textBox1.Focus(); //Codigo para volver al Textbox Usuario

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
