namespace ciudades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> ciudades = new List<String>();
            ciudades = ["Bogotá", "Medellín", "Cali", "Barranquilla", "Cartagena", "Cúcuta", "Bucaramanga", "Pereira", "Santa Marta", "Ibagué"];
            Console.WriteLine("Ingrese el nombre de una ciudad:");
            string ciudad = Console.ReadLine();
            int co = 0;
            foreach (string c in ciudades)
            {
                if (c == ciudad)
                {
                    Console.WriteLine("La ciudad " + ciudad + " se encuentra en la lista, y su posicion es la "+co);
                    return;
                }
                co++;
            }
        }
    }
}
