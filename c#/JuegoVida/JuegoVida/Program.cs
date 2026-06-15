using System.Text;

namespace JuegoVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero(0.50);
            tablero.MostrarTablero();
            int i = 1;
            while (i < 2)
            {
                Thread.Sleep(5000);
                tablero.NuevaIteracion();
            }
        }

    }
    class Tablero
    {
        private int dimensiones = 10;
        private Random random;
        private bool[,] celdas;
        public Tablero(double porcentajeCasillasVivas)
        {
            //declarar matriz
            celdas = new bool[dimensiones, dimensiones];

            random = new Random();
            Iniciar(porcentajeCasillasVivas);

        }
        private void Iniciar(double porcentajeCasillasVivas)
        {
            
            //va fila por fila
            for (int fila = 0; fila < dimensiones; fila++)
            {
                //va columna por columna 
                for(int columna=0; columna < dimensiones; columna++)
                {
                    //validacion
                    if (random.NextDouble() >= porcentajeCasillasVivas)
                    {

                        celdas[fila,columna]=false;
                    }
                    else
                    {
                        celdas[fila, columna] = true;
                    }
                }
            }
        }

        private int CalcularVecinos(int Fila, int Columna)
        {
            int Vivos = 0;
            
            //revisar fila anterior, actual y posterior
            for(int i=-1;i<=1;i++)
            {
                
                //revisar columna anterior y posterior
                for(int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        i++;
                        j++;
                    }
                        int filaVerificar = Fila + i;
                        int columnaVerificar = Columna + j;
                        //verificar que esten dentro del rango
                        if (columnaVerificar >= 0 && columnaVerificar < dimensiones && 
                            filaVerificar>=0 && filaVerificar < dimensiones)
                        {
                            if (celdas[filaVerificar, columnaVerificar])
                            {
                                Vivos++;
                            }
                        }
                    
                }   
            }

            return Vivos;
        }

        public void NuevaIteracion()
        {
            bool[,] nuevasCeldas= new bool [dimensiones,dimensiones];
            int VecinosVivos = 0;
            Console.Clear();
            //va fila por fila
            for (int fila = 0; fila < dimensiones; fila++)
            {
                //va columna por columna 
                for (int columna = 0; columna < dimensiones; columna++)
                {
                    VecinosVivos= CalcularVecinos(fila, columna);
                    if (celdas[fila, columna])
                    {
                        if (VecinosVivos == 2 || VecinosVivos == 3 )
                        {
                            nuevasCeldas[fila,columna] = true;
                        }
                        else
                        {
                            if (VecinosVivos<2||VecinosVivos>=4)
                            {
                                nuevasCeldas[fila, columna] = false;   
                            }
                        }
                    }
                    if (!celdas[fila,columna])
                    {
                        if (VecinosVivos == 3)
                        {
                            nuevasCeldas[fila, columna] = true;
                        }
                    }
                }
            }
            celdas = nuevasCeldas;
            MostrarTablero();
        }

        public void MostrarTablero()
        {
            Console.Clear();
            //va fila por fila
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");
            int c = 0;
            for (int fila = 0; fila < dimensiones; fila++)
            {
                Console.Write("|");
                //va columna por columna 
                for (int columna = 0; columna < dimensiones; columna++)
                {
                    //construccion
                    if (!celdas[fila, columna])
                    {
                        Console.Write(" X ");
                    }
                    else
                    {
                        Console.Write(" O ");
                        c++;
                    }
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine($"Cantidad de celdas vivas: {c}");
        }
    }
}
