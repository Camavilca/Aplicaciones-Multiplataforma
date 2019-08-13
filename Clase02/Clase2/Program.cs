﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona2> _solicitantes = new List<Persona2>();
            Program obj = new Program();
            obj.getSave(_solicitantes);
            obj.getComplete(_solicitantes, obj);
            obj.getView(_solicitantes);
            Console.Read();
        }

        private void getComplete(List<Persona2> _solicitantes, Program obj)
        {
            foreach (var item in _solicitantes)
            {
                item.NombresCompletos = obj.getNombreCompleto(item.Nombres, item.Apellidos);
                item.Edad = obj.getDate(item.FechaNacimiento);
            }
        }

        private void getView(List<Persona2> _solicitantes)
        {
            int count = 1;
            foreach (var item in _solicitantes)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("PERSONA: " + count);
                Console.WriteLine(item.NombresCompletos + " tiene " + item.Edad + " years de edad");
                Console.WriteLine("================================================");
                Console.WriteLine("\n");
                count++;
            }
        }

        private int getDate(DateTime a)
        {
            DateTime zeroTime = new DateTime(1,1,1);
            DateTime b = new DateTime(2019, 1, 1);
            TimeSpan span = b - a;
            return (zeroTime + span).Year - 1;
        }

        private void getSave(List<Persona2> _solicitantes) {
           Persona2 p0 = new Persona2
            {
                Id = 1,
                Nombres = "Estela",
                Apellidos = "Cammello Rodriguez",
                FechaNacimiento = new DateTime(2007, 1, 1)
        };

            Persona2 p1 = new Persona2
            {
                Id = 2,
                Nombres = "Luis",
                Apellidos = "Aguilar Farfan",
                FechaNacimiento = new DateTime(2008, 1, 1)
    };

            Persona2 p2 = new Persona2
            {
                Id = 3,
                Nombres = "Erick",
                Apellidos = "Fernandes Carrillo",
                FechaNacimiento = new DateTime(2009, 1, 1)
};

            Persona2 p3 = new Persona2
            {
                Id = 4,
                Nombres = "Carlos",
                Apellidos = "Martinez Nuñes",
                FechaNacimiento = new DateTime(2010, 1, 1)
        };

            Persona2 p4 = new Persona2
            {
                Id = 5,
                Nombres = "Ana",
                Apellidos = "Bella Lopez",
                FechaNacimiento = new DateTime(2011, 1, 1)
        };
            _solicitantes.Add(p0);
            _solicitantes.Add(p1);
            _solicitantes.Add(p2);
            _solicitantes.Add(p3);
            _solicitantes.Add(p4);
        }

        private String getNombreCompleto(String nombre, String apellidos)
        {
            String nombreCompleto = nombre + " " + apellidos;
            return nombreCompleto;
        }

    }


    public class Persona2
    {
        public int Id { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string NombresCompletos { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

    
}
