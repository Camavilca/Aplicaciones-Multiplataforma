using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("==============================");
            Console.WriteLine(obj.getCoordenadas());
            Console.ReadLine();
        }
     
        private int getCoordenadas()
        {
            Rectangulo1 r = new Rectangulo1();

            Console.WriteLine("Ingrese primera coordenada");

            Punto p1 = new Punto();
            p1.x = Int32.Parse(Console.ReadLine());
            p1.y = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese segunda coordenada");
            Punto p2 = new Punto();
            p2.x = Int32.Parse(Console.ReadLine());
            p2.y = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese tercera coordenada");
            Punto p3 = new Punto();
            p3.x = Int32.Parse(Console.ReadLine());
            p3.y = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese cuarta coordenada");
            Punto p4 = new Punto();
            p4.x = Int32.Parse(Console.ReadLine());
            p4.y = Int32.Parse(Console.ReadLine());

            
            r.p1 = p1;
            r.p2 = p2;
            r.p3 = p3;
            r.p4 = p4;

            double ancho1 = getDistancia(r.p1, r.p2);
            Console.WriteLine("ancho 1-->  "+ ancho1);

            double largo1 = getDistancia(r.p2, r.p3);
            Console.WriteLine("largo 1---> " + largo1);

            double ancho2 = getDistancia(r.p3, r.p4);
            Console.WriteLine("ancho 2--->  " + ancho2);

            double largo2 = getDistancia(r.p1, r.p4);
            Console.WriteLine("largo 2---> " + largo2);

            double respuesta = 0;

            if (ancho1 == ancho2 && largo1 == largo2)
            {
                respuesta = ancho1 * largo1;
            }
            else
            {
                Console.WriteLine("NO EXIST RECTANGULO");
            }

            int area =  (int)respuesta;

            return area;
        }
        public double getDistancia(Punto p1, Punto p2)
        {
            int cox = p2.x - p1.x;
            int coy = p2.y - p1.y;
            double resx = Math.Pow(cox, 2);
            double resy = Math.Pow(coy, 2);
            double des = resx + resy;
            return Math.Sqrt(des);
        }
    }
}
