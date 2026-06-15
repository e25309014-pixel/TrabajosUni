namespace Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año para saber si es bisiesto!");
            double año = Convert.ToDouble(Console.ReadLine());
            
            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0)&&año!=0)
            {
                Console.WriteLine("El año {0} es bisiesto.", año);
            }
            else
            {
                Console.WriteLine("El año {0} no es bisiesto.", año);
            }
        }
    }
}
