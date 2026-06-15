namespace Aprobado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la calificacion del alumno");
            int calificacion = Convert.ToInt32(Console.ReadLine());
            if (calificacion >= 5)
            {
                Console.WriteLine("El alumno esta aprobado");
            }
            else
            {
                Console.WriteLine("El alumno esta reprobado");
            }
        }
    }
}
