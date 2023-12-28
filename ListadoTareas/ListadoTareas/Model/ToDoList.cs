using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoTareas.Model
{
    public class ToDoList
    {
        private List<string> tareas;

        public ToDoList()
        {
            tareas = new List<string>();
        }

        public void MostrarTareas()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas en la lista.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
        }

        public void AgregarTarea(string tarea)
        {
            tareas.Add(tarea);
        }

        public void MarcarTareaComoCompletada(int numeroTarea)
        {
            if (numeroTarea > 0 && numeroTarea <= tareas.Count)
            {
                // Restamos 1 porque la lista comienza en índice 0
                tareas.RemoveAt(numeroTarea - 1);
            }
        }

        public bool ExisteTarea(int numeroTarea)
        {
            return numeroTarea > 0 && numeroTarea <= tareas.Count;
        }
    }
}