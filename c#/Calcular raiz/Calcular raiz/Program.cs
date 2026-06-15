namespace Calcular_raiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular las raíces de ax^2 + bx + c");
            Console.WriteLine("Ingrese el valor de a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de c:");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a no puede ser 0.");
            }
            else if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("No existen raíces reales.");
            }
            else
            {
                double raiz1 = ((-b) + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                double raiz2 = ((-b) - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                Console.WriteLine($"Las raíces son: {raiz1} y {raiz2}");
            }
        }
    }
}
