namespace DesgloseMonedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de cambio");
            int cantidad500 = 0;
            int cantidad200 = 0;
            int cantidad100 = 0;
            int cantidad50 = 0;
            int cantidad20 = 0;
            int cantidad10 = 0;
            int cantidad5 = 0;
            int cantidad2 = 0;
            int cantidad1 = 0;
            Console.WriteLine("Ingrese la cantidad a desglosar:");
            double cantidad = double.Parse(Console.ReadLine());
            while (cantidad >= 1)
            {
                
                switch (cantidad)
                {
                    case >= 500:
                        cantidad500 = (int)(cantidad / 500);
                        cantidad -= cantidad500 * 500;
                        break;
                    case >= 200:
                        cantidad200 = (int)(cantidad / 200);
                        cantidad -= cantidad200 * 200;
                        break;
                    case >= 100:
                        cantidad100 = (int)(cantidad / 100);
                        cantidad -= cantidad100 * 100;
                        break;
                    case >= 50:
                        cantidad50 = (int)(cantidad / 50);
                        cantidad -= cantidad50 * 50;
                        break;
                    case >= 20:
                        cantidad20 = (int)(cantidad / 20);
                        cantidad -= cantidad20 * 20;
                        break;
                    case >= 10:
                        cantidad10 = (int)(cantidad / 10);
                        cantidad -= cantidad10 * 10;
                        break;
                    case >= 5:
                        cantidad5 = (int)(cantidad / 5);
                        cantidad -= cantidad5 * 5;
                        break;
                    case >= 2:
                        cantidad2 = (int)(cantidad / 2);
                        cantidad -= cantidad2 * 2;
                        break;
                    case >= 1:
                        cantidad1 = (int)(cantidad / 1);
                        cantidad -= cantidad1 * 1;
                        break;
                }
            }
            Console.WriteLine("Desglose de cambio:");
            Console.WriteLine($"Billetes de 500: {cantidad500}");
            Console.WriteLine($"Billetes de 200: {cantidad200}");
            Console.WriteLine($"Billetes de 100: {cantidad100}");
            Console.WriteLine($"Billetes de 50: {cantidad50}");
            Console.WriteLine($"Billetes de 20: {cantidad20}");
            Console.WriteLine($"Monedas de 10: {cantidad10}");
            Console.WriteLine($"Monedas de 5: {cantidad5}");
            Console.WriteLine($"Monedas de 2: {cantidad2}");
            Console.WriteLine($"Monedas de 1: {cantidad1}");
            Console.WriteLine($"Cambio en centavos: {Math.Round(cantidad, 2)}");
        }
    }
}
