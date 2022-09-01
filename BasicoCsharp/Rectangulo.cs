using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    public class Rectangulo {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }

        public double GetPerimetro()
        {
            double base1 = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double altura = Math.Sqrt(Math.Pow(v3.x - v1.x, 2) + Math.Pow(v3.y - v1.y, 2));
            double perimetro = 2 * (altura + base1);
            return perimetro;
        }

        public double GetArea()
        {
            double base1 = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
            double altura= Math.Sqrt(Math.Pow(v3.x - v1.x, 2) + Math.Pow(v3.y - v1.y, 2));
            return base1 * altura;

        }
       
    }
}
