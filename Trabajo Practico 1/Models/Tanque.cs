using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_1.Models
{
    public class Tanque
    {
        public string nombre { get; set; }
        public string nacionalidad { get; set; }
        public int año { get; set; }
        public int peso { get; set; }
        public List<string> aliados { get; set; }

        public Tanque(string nombre, string nacionalidad, int año, int peso, List<string> aliados)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            this.año = año;
            this.peso = peso;
            this.aliados = aliados;
        }

        public void VisualizarGandaor(Tanque Ganador)
        {
            Console.WriteLine($"GANADOR: {Ganador.nombre}");
            Console.WriteLine($"PAIS:    {Ganador.nacionalidad}");
            Console.WriteLine($"AÑO:     {Ganador.año}");
            Console.WriteLine($"PESO:    {Ganador.peso} toneladas");

            Console.WriteLine("ALIADOS:");
            foreach (string elemento in Ganador.aliados)
            {
                Console.WriteLine($"         {elemento}");
            }

        }

        public void VisualizarPerdedor(Tanque Perdedor)
        {
            Console.WriteLine($"PERDEDOR: {Perdedor.nombre}");
            Console.WriteLine($"PAIS:    {Perdedor.nacionalidad}");
            Console.WriteLine($"AÑO:     {Perdedor.año}");
            Console.WriteLine($"PESO:    {Perdedor.peso} toneladas");

            Console.WriteLine("ALIADOS:");
            foreach (string elemento in Perdedor.aliados)
            {
                Console.WriteLine($"         {elemento}");
            }
        }

        public void batalla(Tanque Rivales)
        {
            if (this.año > Rivales.año)
            {
                VisualizarGandaor(this);
            }
         

            if (this.año < Rivales.año)
            {
                VisualizarGandaor(Rivales);
            }
           

            if (this.año == Rivales.año)
            {
                if (this.peso > Rivales.peso)
                {
                    VisualizarGandaor(this);
                }
                

                if (this.peso < Rivales.peso)
                {
                    VisualizarGandaor(Rivales);
                }
                

                if (this.peso == Rivales.peso)
                {
                    Console.WriteLine("Empataron");
                }
            }
        }


    }
}