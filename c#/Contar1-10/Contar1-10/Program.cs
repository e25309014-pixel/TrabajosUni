namespace Contar1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contar hasta 10 con distintos ciclos!");
            Console.WriteLine();
            Console.WriteLine("Ciclo While");
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Ciclo For");
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
            Console.WriteLine("Ciclo Do-While");
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 10);
        }
    }
}
