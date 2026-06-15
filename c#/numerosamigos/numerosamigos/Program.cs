namespace numerosamigos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] divisores1;
            int[] divisores2;
            Console.WriteLine("Ingrese un numero!");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero!");
            int numero2 = int.Parse(Console.ReadLine());
            divisores1 = ObtenerDivisores(numero);
            divisores2 = ObtenerDivisores(numero2);
            if(numero==divisores2.Sum()&&numero2==divisores1.Sum())
            {
                Console.WriteLine("Los números son amigos.");
            }
            else
            {
                Console.WriteLine("Los números no son amigos.");
            }
        }
        static int[] ObtenerDivisores(int numero)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }
            return divisores.ToArray();
        }
    }
}
