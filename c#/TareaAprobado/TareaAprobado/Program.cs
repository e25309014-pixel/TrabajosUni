namespace TareaAprobado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la calificacion del alumno!");
            int calificacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El alumno entrego la tarea? (1=si, 2=no)");
            int tareaEntregada = Convert.ToInt32(Console.ReadLine());
            if (calificacion >= 5 && tareaEntregada == 1)
            {
                Console.WriteLine("El alumno aprobo la materia.");
            }
            else
            {
                Console.WriteLine("El alumno no aprobo la materia.");
            }
        }
    }
}
