using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1.Models
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public void hablar()
        {
            Console.WriteLine($"Me llamo {this.nombre}, me considero {this.sexo} y tengo {this.edad} años.");
        }

    }
}