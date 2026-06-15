namespace Meses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero del mes que desea ver!");
            int mes = Convert.ToInt32(Console.ReadLine());  
            switch (mes) {
                case 1:
                Console.WriteLine("Enero");
                Console.WriteLine("Enero tiene 31 días");
                break;
                case 2:
                    Console.WriteLine("Febrero");
                    Console.WriteLine("Febrero tiene 28 días");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    Console.WriteLine("Marzo tiene 31 días");
                    break; 
                case 4:
                    Console.WriteLine("Abril");
                    Console.WriteLine("Abril tiene 30 días");
                    break; 
                case 5: 
                    Console.WriteLine("Mayo");
                    Console.WriteLine("Mayo tiene 31 días");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    Console.WriteLine("Junio tiene 30 días");
                    break; 
                case 7:
                    Console.WriteLine("Julio");
                    Console.WriteLine("Julio tiene 31 días");
                    break; 
                case 8:
                    Console.WriteLine("Agosto");
                    Console.WriteLine("Agosto tiene 31 días");
                    break; 
                case 9:
                    Console.WriteLine("Septiembre");
                    Console.WriteLine("Septiembre tiene 30 días");
                    break; 
                case 10:
                    Console.WriteLine("Octubre");
                    Console.WriteLine("Octubre tiene 31 días");
                    break; 
                case 11:
                    Console.WriteLine("Noviembre");
                    Console.WriteLine("Noviembre tiene 30 días");
                    break; 
                case 12:
                    Console.WriteLine("Diciembre");
                    Console.WriteLine("Diciembre tiene 31 días");
                    break;
                default: Console.WriteLine("El numero ingresado no corresponde a un mes del año");
                    break; 
            }
        }
    }
}
