namespace Sumatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");

            int numero = int.Parse(Console.ReadLine());

            double suma = 0;

            for (int i = 1; i <= numero; i++)
            {
                suma += (1.0/i);
            }

            Console.WriteLine($"La suma de fracciones es: {suma}");
        }
    }
}
