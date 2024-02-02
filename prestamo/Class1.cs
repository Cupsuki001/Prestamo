using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestamo
{
    internal class Class1
    {
        double p;

        public Class1(){}

        public Class1(double p) 
        {
          this.p = p;
        }

        public void tiempo() 
        {
            Console.WriteLine("PLAZOS");
            Console.WriteLine("[1] 6  meses");
            Console.WriteLine("[2] 9  meses");
            Console.WriteLine("[3] 12 meses");
            Console.WriteLine("[4] 18 meses");
            Console.WriteLine("[5] 24 meses");
            Console.WriteLine("[6] 36 meses");
            Console.WriteLine("[7] 48 meses");
        }

        public double plazo1(double p) 
        {

            return p + (p * 0.12);

        }
        public double plazo2(double p)
        {

            return p + (p * 0.18);

        }

        public double plazo3(double p)
        {

            return p + (p * 0.24);

        }

        public double plazo4(double p)
        {

            return p + (p * 0.36);

        }

        public double plazo5(double p)
        {

            return p + (p * 0.48);

        }

        public double plazo6(double p)
        {

            return p + (p * 0.72);

        }

        public double plazo7(double p)
        {

            return p + (p * 0.96);

        }
        public int validar(String Mensaje)
        {

            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("////////////////////////////////////");
                    Console.WriteLine("No se aceptan letras", error.Message);
                    Console.WriteLine("////////////////////////////////////");
                    tiempo();

                }
            } while (v == 0);
            return num;
        }
    }
}
