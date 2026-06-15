namespace divisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> divisores = new List<int>();
            Console.WriteLine("Ingrese un numero!");
            int numero = int.Parse(Console.ReadLine());
            double residuo = 0;
            if (numero <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número positivo.");
                return;
            }
            else
            {
                for (int i = 1; i < numero; i++)
                {
                    residuo = numero % i;
                    if (residuo == 0)
                    {
                        divisores.Add(i);
                    }
                }
                foreach (int divisor in divisores)
                {
                    Console.WriteLine($"Divisor: {divisor}");
                }
                int SumaDivisores = divisores.Sum();
                if (SumaDivisores==numero)
                {
                    Console.WriteLine("El número es igual a sus divisores.");
                }
                else
                {
                    Console.WriteLine("El número no es igual a sus divisores.");
                }
            }
        }
    }
}
