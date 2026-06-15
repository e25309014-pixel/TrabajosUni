namespace Tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero para mostrar su tabla del 1-10!");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tabla del {n}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
