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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPacientes = new FormPacientes();
            formPacientes.MdiParent = this; 
            formPacientes.Show();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMedicos = new FormMedicos();
            formMedicos.MdiParent = this;
            formMedicos.Show();
        }

        private void citasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formCitas = new FormCitas();
            formCitas.MdiParent = this;
            formCitas.Show();
        }

        private void resetariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRecetarios = new FormRecetarios();
            formRecetarios.MdiParent = this;
            formRecetarios.Show();
        }

        private void reporteDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteCitas = new FormReporteCitas();
            formReporteCitas.MdiParent = this;
            formReporteCitas.Show();
        }

        private void reporteDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportePacientes = new FormReportePacientes();
            formReportePacientes.MdiParent = this;
            formReportePacientes.Show();
        }

        private void reporteDePatologiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportePatologias = new FormReportePatologias();
            formReportePatologias.MdiParent = this;
            formReportePatologias.Show();
        }

        private void reporteDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteMedicamentos = new FormReporteMedicamentos();
            formReporteMedicamentos.MdiParent = this;
            formReporteMedicamentos.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAcercaPrograma = new FormAcercaPrograma();
            formAcercaPrograma.MdiParent = this;
            formAcercaPrograma.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salida = MessageBox.Show("¿Desea salir del Programa?", "Salir", MessageBoxButtons.YesNo);
            if (salida == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
