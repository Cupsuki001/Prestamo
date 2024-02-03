// See https://aka.ms/new-console-template for more information
using prestamo;

public class prest 
{
    public static void Main(string [] args) 
    {

        Class1 p = new Class1();
        Class2 p2 = new Class2();
        double mont =0 , montt;
        int op , s;
        do 
        {

            do
            {
                Console.WriteLine("BANCO LAFISE");
                mont = p2.validar("Ingrse el monto que desea: ");
                Console.WriteLine("//////////////////////");

            }while(mont < 100 || mont > 5000);

            do
            {
                p.tiempo();
                op = p.validar("Ingrese la opcion a pagar: ");
                Console.WriteLine("//////////////////////");
                

            } while (op <= 0 || op > 7);
            

            switch (op) 
            {
              case 1: 
                    {
                        montt = p.plazo1(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: "+mont);
                        Console.WriteLine("Interes: "+ (montt - mont));
                        Console.WriteLine("Plazo: 6 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 2:
                    {
                        montt = p.plazo2(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Interes: " + (montt - mont));
                        Console.WriteLine("Plazo: 9 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 3:
                    {
                        montt = p.plazo3(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Interes: " + (montt - mont));
                        Console.WriteLine("Plazo: 12 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 4:
                    {
                        montt = p.plazo4(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Interes: " + (montt - mont));
                        Console.WriteLine("Plazo: 18 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 5:
                    {
                        montt = p.plazo5(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Interes: " + (montt - mont));
                        Console.WriteLine("Plazo: 24 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 6:
                    {
                        montt = p.plazo6(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Interes: " + (montt - mont));
                        Console.WriteLine("Plazo: 36 meses");
                        Console.WriteLine("Monto total: " + montt);
                        Console.WriteLine("-------------------------//");
                    }
                    break;
                case 7:
                    {
                        montt = p.plazo7(mont);
                        Console.WriteLine("-------------------------//");
                        Console.WriteLine("Monto a prestar: " + mont);
                        Console.WriteLine("Interes: " + (montt - mont));
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
