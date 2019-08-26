using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Persona
    {
        public int id { get; set; }
        public String apellidos { get; set; }
        public String nombres { get; set; }
        public String nombreCompleto { get; set; }
        public int edad { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Persona(int id, string apellidos, string nombres, DateTime fechaNacimiento)
        {
            this.id = id;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}
