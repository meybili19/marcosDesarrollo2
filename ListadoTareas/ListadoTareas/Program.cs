using ListadoTareas.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        ToDoList toDoList = new ToDoList();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("LISTA DE TAREAS POR HACER");
            Console.WriteLine("1. Mostrar Tareas");
            Console.WriteLine("2. Agregar Tarea");
            Console.WriteLine("3. Marcar Tarea como Completada");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Tareas:");
                    toDoList.MostrarTareas();
                    Console.WriteLine();
                    Console.WriteLine("Presione enter para continuar.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Ingrese la nueva tarea: ");
                    string nuevaTarea = Console.ReadLine();
                    toDoList.AgregarTarea(nuevaTarea);
                    Console.WriteLine("Tarea agregada exitosamente.");
                    Console.WriteLine();
                    Console.WriteLine("Presione enter para continuar.");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Ingrese el número de tarea completada: ");

                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int numeroTarea))
                        {
                            if (toDoList.ExisteTarea(numeroTarea))
                            {
                                toDoList.MarcarTareaComoCompletada(numeroTarea);
                                Console.WriteLine("Tarea marcada como completada.");
                                Console.WriteLine();
                                Console.WriteLine("Presione enter para continuar.");
                                break; // Sale del bucle si la tarea se encuentra y se marca como completada
                            }
                            else
                            {
                                Console.WriteLine("El número de tarea no existe. Vuelva a ingresar el número.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número válido.");
                        }
                    }

                    Console.ReadLine();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione enter para continuar.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}