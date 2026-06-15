namespace ConversorUnidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al conversor de unidades");
            Console.WriteLine("Ingrese la medida en metros que desea convertir:");
            double metros = double.Parse(Console.ReadLine());
            double pulgadas = metros * 39.3701;
            double pies = metros * 3.28084;
            double centimetros = metros * 100;
            double milimetros = metros * 1000;
            Console.WriteLine("La medida en pulgadas es: " + pulgadas);
            Console.WriteLine("La medida en pies es: " + pies);
            Console.WriteLine("La medida en centímetros es: " + centimetros);
            Console.WriteLine("La medida en milímetros es: " + milimetros);
        }
    }
}
