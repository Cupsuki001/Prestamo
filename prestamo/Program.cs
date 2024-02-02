// See https://aka.ms/new-console-template for more information
using prestamo;

public class prest 
{
    public static void Main(string [] args) 
    {

        Class1 p = new Class1();
        double mont =0 , montt;
        int op , s;
        do 
        {

            do
            {
                Console.WriteLine("BANCO LAFISE");
                mont = p.validar("Ingrse el monto que desea: ");
                Console.WriteLine("//////////////////////");

            }while(mont < 100 || mont > 5000);

            do
            {
                p.tiempo();
                op = p.validar("Ingrese la opcion a pagar: ");
                Console.WriteLine("//////////////////////");
                

            } while (op <= 0 || op > 7);

            montt = p.plazo1(mont);
            montt = p.plazo2(mont);
            montt = p.plazo3(mont);
            montt = p.plazo4(mont);
            montt = p.plazo5(mont);
            montt = p.plazo6(mont);
            montt = p.plazo7(mont);

            switch (op) 
            {
              case 1: 
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: "+mont);
                        Console.WriteLine("Plazo: 6 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Plazo: 9 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Plazo: 12 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Plazo: 18 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Plazo: 24 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Plazo: 36 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Plazo: 48 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
            }
            do 
            {
                s = p.validar("Desea seguir? 1.si  2.No");

            }while (s <= 0 || s > 2);
           


        } while (s==1);
        Console.WriteLine("Buen dia");
    }
}
