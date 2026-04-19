using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TaskFlow.Models;

namespace TaskFlow.Services
{
    public class TaskService
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        private int nextId = 1;

        public void CrearTarea(string title, string description, string responsible)
        {

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("El título no puede estar vacío.");
                return;
            }

            var tarea = new TaskItem
            {
                Id = nextId++,
                Title = title,
                Description = description,
                Responsible = responsible,
                Status = TaskFlow.Models.TaskStatus.Pendiente,
                CreatedAt = DateTime.Now
            };

            tasks.Add(tarea);
        }

        public List<TaskItem> ListarTareas()
        {
            Console.WriteLine("Cambio Rama 2");
            Console.WriteLine("Cambio Rama 1");
            return tasks;

        }

        
    }
}
