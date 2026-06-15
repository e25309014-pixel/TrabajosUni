namespace Calculo_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para calcular su factorial!");
            int nume = int.Parse(Console.ReadLine());
            for (int i = nume;i >=2; i--)
            {
                nume = nume * (i - 1);
            }
            Console.WriteLine("El factorial es: " + nume);
        }
    }
}
