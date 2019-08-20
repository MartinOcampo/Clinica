using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class Contexto: DbContext // : para heredar clases en C#
    {
        public Contexto(): base("Consultorio") //base = DbContext y los () es instancia.
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //Remover las opciones de Pluralizacion de nombres de tablas
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}
