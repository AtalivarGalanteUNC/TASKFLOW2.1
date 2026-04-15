using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TaskFlow.Models;

namespace TaskFlow.Utils
{
    public static class ConsoleHelper
    {

        public static string FormatearEstado(TaskFlow.Models.TaskStatus status)
        {
            return status switch
            {
                TaskFlow.Models.TaskStatus.EnProgreso => "En Progreso",
                TaskFlow.Models.TaskStatus.Pendiente => "Pendiente",
                TaskFlow.Models.TaskStatus.Completada => "Completada",
                _ => status.ToString()
            };
        }

        public static void MostrarTareas(List<TaskItem> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas.");
                return;
            }

            Console.WriteLine("=== LISTADO DE TAREAS ===\n");

            foreach (var t in tareas)
            {
                Console.WriteLine($"ID: {t.Id}");
                Console.WriteLine($"Título: {t.Title}");
                Console.WriteLine($"Responsable: {t.Responsible}");
                Console.WriteLine($"Estado: {FormatearEstado(t.Status)}");
                Console.WriteLine($"Creada: {t.CreatedAt}");

                if (t.UpdatedAt != null)
                    Console.WriteLine($"Actualizada: {t.UpdatedAt}");

                Console.WriteLine("------------------------");
            }
        }
    }
}
