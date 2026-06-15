namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora para areas de triangulos");
            Console.WriteLine("Ingrese la base del triangulo");
            int baseTriangulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            int alturaTriangulo = Convert.ToInt32(Console.ReadLine());
            double area = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine("El area del triangulo es: " + area);
        }
    }
}
