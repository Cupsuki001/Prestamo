using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestamo
{
    internal class Class2
    {
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
                    

                }
            } while (v == 0);
            return num;
        }
    }
}
