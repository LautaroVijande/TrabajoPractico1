using System;
using System.Collections.Generic;
using Trabajo_Practico_1.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------- PERSONA:\n");
        Persona persona1 = new Persona("Lautaro", 24, "M");
        persona1.hablar();

        Console.WriteLine("\n\n--------BARCO:\n");
        Barco barco1 = new Barco(50, 25);
        int pesoNeto = barco1.valeLaPenaSaquear();
        if (pesoNeto > 20)
        {
            Console.WriteLine($"SI Vale la pena saquear este barco (cargamento: {pesoNeto})");
        }
        else
        {
            Console.WriteLine($"NO Vale la pena saquear este barco (cargamento: {pesoNeto})");
        }
        
        Console.WriteLine("\n\n--------TANQUE:\n");
        Tanque tanque1 = new Tanque ("Tanque T110E5", "Estado Unidos", 1954, 56, new List<string> { "FRANCE", "ENGLAND", "RUSS", "SWEDEN", "CZECHOSLOVAKIA\n" });
        Tanque tanque2 = new Tanque ("Tanque MAUS", "Alemania", 1942, 188, new List<string> { "ITALY", "JAPAN",});

        tanque1.batalla(tanque2);

        Console.WriteLine("\n\n-------- BLOQUE:\n");
        Bloque bloque1 = new Bloque(100, 100, 10);
        int largo = bloque1.obtenerLargo();
        int ancho = bloque1.obtenerAncho();
        int alto = bloque1.obtenerAlto();
        int volumen = bloque1.obtenerVolumen();
        int areaSuperficie = bloque1.obtenerArea();

        Console.WriteLine($"El bloque tiene {largo} cm de largo");
        Console.WriteLine($"El bloque tiene {ancho} cm de ancho");
        Console.WriteLine($"El bloque tiene {alto} cm de alto");
        Console.WriteLine($"El bloque tiene un volumen de {volumen} cm³");
        Console.WriteLine($"El bloque tiene un area de {areaSuperficie} cm²");

        Console.WriteLine("\n\n___________________FIN________________________________\n");
    }
}