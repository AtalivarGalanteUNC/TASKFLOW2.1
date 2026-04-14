using TaskFlow.Services;
using TaskFlow.Utils;

class Program
{
    static void Main(string[] args)
    {
        var service = new TaskService();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("===== TASKFLOW =====");
            Console.WriteLine("1. Crear tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Salir");
            Console.Write("Elegí una opción: ");

            var opcion = Console.ReadLine();

            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Título: ");
                    var titulo = Console.ReadLine();

                    Console.Write("Descripción: ");
                    var descripcion = Console.ReadLine();

                    Console.Write("Responsable: ");
                    var responsable = Console.ReadLine();

                    service.CrearTarea(titulo, descripcion, responsable);

                    Console.WriteLine("✅ Tarea creada\n");
                    break;

                case "2":
                    var tareas = service.ListarTareas();
                    ConsoleHelper.MostrarTareas(tareas);
                    Console.WriteLine();
                    break;

                case "3":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("❌ Opción inválida\n");
                    break;
            }
        }
    }
}