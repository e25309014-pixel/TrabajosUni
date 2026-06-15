using System.Diagnostics.CodeAnalysis;

namespace Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dado [] dados=new Dado[5];
            dados[0] = new Dado();
            dados[1] = new Dado(10);
            dados[2] = new Dado(20);
            dados[3] = new Dado();
            dados[4] = new Dado(12);
            int suma = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i].TirarDado();
                suma += dados[i].resultado;
            }
            foreach (Dado dado in dados)
            {
                Console.WriteLine(dado);
            }
            Console.WriteLine($"Suma de los resultados: {suma}");
        }
    }
    public class Dado
    {
        private int lados;
        public int resultado;
        private static Random random = new Random();
        public Dado () {
            this.lados = 6;
        }
        public Dado(int lados)
        {
            if (lados < 2)
            {
                this.lados = 6;
            }
            else
            {
                this.lados = lados;
            }
        }
        public int TirarDado()
        {
            this.resultado = random.Next(1, this.lados + 1);
            return this.resultado;
        }
        public override string ToString()
        {
                return ($"Dado de {this.lados} lados, resultado: {this.resultado}");
        }
    }

}
