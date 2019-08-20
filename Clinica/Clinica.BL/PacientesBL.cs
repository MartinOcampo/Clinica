using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class PacientesBL
    {
        Contexto _contexto;
        public BindingList<Paciente> ListaPacientes { get; set; } //BindingList nos permite crear una lista de pacientes
                                                                  // entre <> se puede poner el tipo de clase
        public PacientesBL() //ctor + 2 tab = creacion de construnctor //El () es el constructor
        {
            _contexto = new Contexto();
            ListaPacientes = new BindingList<Paciente>();
        }

        public BindingList<Paciente> ObtenerPacientes()
        {
            _contexto.Pacientes.Load(); //Carga los datos desde la Lista de Pacientes
            ListaPacientes = _contexto.Pacientes.Local.ToBindingList(); //Pasa todos los datos cargados al bindignList

            return ListaPacientes;
        }

        public Resultado GuardarPaciente(Paciente paciente) //para guardar paciente como parametro
        {
            var resultado = Validar(paciente); //Validacion desde la Funcion Resultado / Validar
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); //Funcion del EntityFrameworks para almacenar Datos.

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarPaciente() //Funcion para agregar pacientes a la lista
        {
            var nuevoPaciente = new Paciente(); //Intancia de variable

            ListaPacientes.Add(nuevoPaciente); //Agregar a la lista
        }

        public bool ElimiarPaciente(int id) //Funcion para Eliminar Pacientes de la lista
        {
            foreach (var paciente in ListaPacientes) //forech -  para recorrer listas de objetos
            {
                if (paciente.Id == id) //definir si es el ID que deseamos eliminar
                {
                    ListaPacientes.Remove(paciente);
                    _contexto.SaveChanges(); //Guarda los cambios de eliminacion en el EntityFrameworks
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Paciente paciente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (string.IsNullOrEmpty(paciente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese Nombre del Paciente";
                resultado.Exitoso = false;
            }
            else {
                if (paciente.Edad < 1)
                {
                    resultado.Mensaje = "Edad Incorrecta";
                    resultado.Exitoso = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(paciente.Sexo) == true)
                    {
                        resultado.Mensaje = "Ingrese Sexo del Paciente";
                        resultado.Exitoso = false;
                    }
                }
            }
           
            return resultado;
        }
    }

    public class Paciente //Propiedades de Paciente
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public double Talla { get; set; }
        public double Peso { get; set; }
        public bool Activo { get; set; }

    }

    public class Resultado //Clase de tipo reseultado con propiedades
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}
