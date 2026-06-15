namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para calcular el Fibonacci hasta el:");
            int n = int.Parse(Console.ReadLine());
            int inicio0 = 0;
            int inicio1 = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"{inicio0}, ");
                int fibonacci = inicio0 + inicio1;
                inicio0 = inicio1;
                inicio1 = fibonacci;
            }
        }
    }
}
