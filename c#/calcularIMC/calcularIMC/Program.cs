namespace calcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al calculador de IMC");
            Console.WriteLine("Ingrese su peso en kg");
            double peso = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Ingrese su altura en metros"); 
            double altura = Convert.ToDouble(Console.ReadLine());
            double IMC= peso / (altura * altura);
            Console.WriteLine("Su IMC es: " + IMC);
        }
    }
}
