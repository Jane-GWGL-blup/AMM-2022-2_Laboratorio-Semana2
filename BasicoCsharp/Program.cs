using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            //Declaració variablaes

            int edad = 34;
            string nombre = "hugo";
            decimal sueldo = 10000;
            bool esNuevo = true;

            int edad2;
            string nombre2;
            decimal sueldo2;
            bool esNuevo2;

            edad2 = 34;
            nombre2 = "hugo2";
            sueldo2 = 5000;


            //Sentencias
            if (edad > 18)
            {
                Console.WriteLine("Es Mayor Edad");
            }
            if (sueldo > 2000)
            {
                Console.WriteLine("Millonario");
            }
            else
            {
                Console.WriteLine("Pobre");
            }
            switch (edad2)
            {
                case 20:
                    Console.WriteLine("Es Joven");
                    break;
                case 30:
                    Console.WriteLine("Es Adulto");
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nombre);
            }

            //Clases instanciadas
            Persona persona = new Persona();
            persona.Nombres = "Nicole Jane";
            persona.Apellidos = "Cáceres Serna";
            persona.Edad = 18;

            //otra forma
            Persona persona1 = new Persona {
                Nombres = "Luz Maria",
                Apellidos = "Gutierrez Perez",
                Edad = 19
            };

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

            Console.WriteLine(persona.Nombres);
            Console.WriteLine(persona.Apellidos);
            Console.WriteLine(persona.Edad);
            //.WriteLine(persona.GetNombresCompletos());

            Console.WriteLine(persona1.Nombres);
            Console.WriteLine(persona1.Apellidos);
            Console.WriteLine(persona1.Edad);
            Console.WriteLine(persona1.NombresCompletos);


            int x1, x2, x3, x4;
            int y1, y2, y3, y4;

            Console.WriteLine("Ingrese el eje x del primer vértice: ");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el eje y del primer vértice: ");
            y1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el eje x del segundo vértice: ");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el eje y del segundo vértice: ");
            y2 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Ingrese el eje x del tercer vértice: ");
            x3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el eje y del tercer vértice: ");
            y3 = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Ingrese el eje x del cuarto vértice: ");
            x4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el eje y del cuarto vértice: ");
            y4 = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Las coordenadas son: " + "(" + x1 + ";" + y1 + "), " +
                "(" + x2 + ";" + y2 + "), " + "(" + x3 + ";" + y3 + "), " + "(" + x4 + ";" + y4 + ")");

            if(x1 == x3 && x2 == x4 && y1 == y2 && y3 == y4)
            {
                Vertice Vertice1 = new Vertice
                {
                    x = x1,
                    y = y1
                };
                Vertice Vertice2 = new Vertice
                {
                    x = x2,
                    y = y2
                };
                Vertice Vertice3 = new Vertice
                {
                    x = x3,
                    y = y3
                };
                Vertice Vertice4 = new Vertice
                {
                    x = x4,
                    y = y4
                };
                Rectangulo rec = new Rectangulo
                {
                    v1 = Vertice1,
                    v2 = Vertice2,
                    v3 = Vertice3,
                    v4 = Vertice4
                };

                Console.WriteLine("El perímetro del rectángulo es: " + rec.GetPerimetro());
                Console.WriteLine("El área del rectángulo es: " + rec.GetArea());
                
            }
            else
            {
                Console.WriteLine("Las coordenadas dadas no forman un rectángulo.");
            }
            


            Console.Read();

        }
    }
}
