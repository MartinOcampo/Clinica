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
    public partial class FormPacientes : Form
    {
        PacientesBL _pacientes;

        public FormPacientes()
        {
            InitializeComponent();

            _pacientes = new PacientesBL();
            listaPacientesBindingSource.DataSource = _pacientes.ObtenerPacientes(); //Para llevar la informacion de nuestra lista de Pacientes al formulario pacientes
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {

        }

        private void listaPacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e) //Boton de Guardar
        {
            listaPacientesBindingSource.EndEdit(); //EndEdit - Esta instruccion debe decirle a formulario que ya dejamos de escribir

            var paciente = (Paciente)listaPacientesBindingSource.Current; //Current nos servira para definir el Paciente Actual en registro

            var resultado = _pacientes.GuardarPaciente(paciente);

            if (resultado.Exitoso == true) //Validamos los datos recibidos desde Resultado
            {
                listaPacientesBindingSource.ResetBindings(false); //Reset resetea los cambios para la lista
                DesabilitarHabilitarBotones(true);
                MessageBox.Show("Paciente Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje); //Enviamos el mensaje respectivo a cada error posible
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) //
        {
            _pacientes.AgregarPaciente();
            listaPacientesBindingSource.MoveLast(); //MoveLast lleva nos lleva a lo ultimo de la lista

            DesabilitarHabilitarBotones(false);
        }

        private void DesabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor; //! cambia el valor contrario al Bool o negacion del Bool
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) //Boton de Eliminar
        {

            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text); //Convertir el entero de Id para leerlo en el textbox
                    Eliminar(id); //objeto de Metodo para eliminar regirstros
                }   
            }
        }

        private void Eliminar(int id) //Metodo para Eliminar registros
        {
            
            var resultado = _pacientes.ElimiarPaciente(id);

            if (resultado == true)
            {
                listaPacientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al elimiar Paciente");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e) //Funciones para cancelar operaciones y eliminar Id = 0
        {
            DesabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
