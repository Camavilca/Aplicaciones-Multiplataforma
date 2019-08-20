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
            Console.WriteLine("CALCULAR AREA DE RECTANGULO");
            Console.WriteLine(obj.getCoordenadas());
            Console.ReadLine();
        }
     
        private int getCoordenadas()
        {
            Rectangulo1 r = new Rectangulo1();
            getInsert(r);
            double ancho1 = getDistancia(r.p1, r.p2);
            double largo1 = getDistancia(r.p2, r.p3);
            double ancho2 = getDistancia(r.p3, r.p4);
            double largo2 = getDistancia(r.p1, r.p4);

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

        public Punto getNewPunto(){
             Punto punto = new Punto();
             punto.x = Int32.Parse(Console.ReadLine());
             punto.y = Int32.Parse(Console.ReadLine());
             return punto;
        }

        public void getInsert(Rectangulo1 rectangulo){
             Console.WriteLine("Ingrese primera coordenada");
             Punto p1 = getNewPunto();
             Console.WriteLine("Ingrese segunda coordenada");
             Punto p2 = getNewPunto();
             Console.WriteLine("Ingrese tercera coordenada");
             Punto p3 = getNewPunto();
             Console.WriteLine("Ingrese cuarta coordenada");
             Punto p4 = getNewPunto();
             rectangulo.p1 = p1;
             rectangulo.p2 = p2;
             rectangulo.p3 = p3;
             rectangulo.p4 = p4;
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
