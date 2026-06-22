namespace numerosrepetidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arreglo = new List<int>();
            arreglo = [1, 2, 3, 4, 5, 1, 1, 1, 2, 2, 4, 6]
            List<int> arreglocopia = new List<int>();
            arreglocopia = arreglo;
            for (int i = 0; i <= arreglo.length(); i++;)
            {
                //fila por fila
                for(int j=0;j<arreglo.length;j++)
                {
                    //columna por columna
                    List<int> arreglocopia = new List<int>();
                    arreglocopia = arreglo;
                    if (arreglocopia[j] == arreglo[i])
                    {
                        Console.WriteLine("Se repitio el numero " + j);
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
