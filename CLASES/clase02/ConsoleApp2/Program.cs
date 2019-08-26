using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Program obj = new Program();
            obj.getInsertPersona(personas);
            obj.getNomComAndEdad(personas);
            obj.getViewListConsolPerson(personas);
            Console.Read();
        }
        private void getInsertPersona(List<Persona> personas)
        {
            Persona per1 = new Persona(1, "camavilca chavez", "orlando", new DateTime(1999, 6, 1));
            Persona per2 = new Persona(2, "martinez rayme", "diego", new DateTime(1999, 6, 1));
            Persona per3 = new Persona(3, "timoteo torres", "jhon", new DateTime(1999, 6, 1));
            Persona per4 = new Persona(4, "flores artiaga", "rassmir", new DateTime(1999, 6, 1));
            personas.Add(per1);
            personas.Add(per2);
            personas.Add(per3);
            personas.Add(per4);
        }

        private void getNomComAndEdad(List<Persona> personas)
        {
            foreach (var item in personas)
            {
                item.edad = getEdad(item.fechaNacimiento);
                item.nombreCompleto = getNombreCompleto(item.nombres, item.apellidos);
            }
        }

        private int getEdad(DateTime nacimiento)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime actual = new DateTime(2019, 6, 1);
            TimeSpan res = actual - nacimiento;
            int edad = (zeroTime + res).Year - 1;
            return edad;
        }

        private String getNombreCompleto(String nombre, String apellidos)
        {
            return nombre + " " + apellidos;
        }

        private void getViewListConsolPerson(List<Persona> personas)
        {
            int count = 1;
            foreach (var item in personas)
            {
                Console.WriteLine("===>> " + count);
                Console.WriteLine(item.nombres);
                Console.WriteLine(item.apellidos);
                Console.WriteLine(item.edad);
                Console.WriteLine(item.nombreCompleto);
                Console.WriteLine(item.fechaNacimiento);
                Console.WriteLine("\n");
                count++;
            }
        }
    }
}

