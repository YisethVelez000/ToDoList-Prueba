using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLIst
{
    internal class Program
    {
        private static List<Tarea> tareas = new List<Tarea>();
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();
                //Validar que la opción sea válida 
                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;
                    case "2":
                        ListarTareas();
                        break;
                    case "3":
                        MarcarTareaComoCompletada();
                        break;
                    case "4":
                        EliminarTarea();
                        break;
                    case "5":
                        Salir();
                        //Ponemos el return para salir del programa 
                        return;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                }
        }


        private static void MostrarMenu()
        {
            Console.WriteLine("Lista De Tareas ");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Marcar tarea como completa");
            Console.WriteLine("4. Eliminar Tarea");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción: ");
        }
        private static void AgregarTarea()
        {
            string nombre = "";
            string descripcion = "";
            DateTime? fecha = null;

            Console.WriteLine("Nombre de la tarea: ");
            //Validamos que el nombre no sea vacío y que no sean solo espacios 
            while (true)
            {
                nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("El nombre no puede ser vacío");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Descripción de la tarea: ");
            //Validamos que la descripción no sea vacia y que no sean solo espacios
            while (true)
            {
                descripcion = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    Console.WriteLine("La descripción no puede ser vacía");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Fecha de la tarea (dd/MM/yyyy) o deja en blanco para 'Sin fecha': ");
            //Validamos que sea una fecha valida o este vacia
            while (true)
            {
                string fechaTexto = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fechaTexto))
                {
                    break;
                }
                else if (DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaValida))
                {
                    fecha = fechaValida;
                    break;
                }
                else
                {
                    Console.WriteLine("Fecha inválida");
                }
            }

            tareas.Add(new Tarea(nombre, descripcion, fecha));
            Console.WriteLine("Tarea agregada con éxito.");
            ListarTareas();
            Console.WriteLine("************************");
        }

        private static void ListarTareas()
        {
            Console.WriteLine("Listado de tareas");
            //Validamos si el array esta vacio
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas");
            }
            else
            {
                //Recorremos el listar de tareas
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    tareas[i].Mostrar();
                }
            }
        }

        private static void MarcarTareaComoCompletada()
        {
            Console.WriteLine("Ingrese el número de la tarea a marcar como completada: ");
            ListarTareas();
            if(int.TryParse(Console.ReadLine(), out int numero))
            {
                //Validamos que ingrese el número de una tarea existente
                if (numero > 0 && numero <= tareas.Count)
                {
                    tareas[numero - 1].Completar();
                    Console.WriteLine("Tarea marcada como completada");
                    ListarTareas();
                    Console.WriteLine("************************");
                }
                else
                {
                    Console.WriteLine("Número de tarea inválido");
                }
            }
            else
            {
                Console.WriteLine("Número de tarea inválido");
            }
        }

        private static void EliminarTarea()
        {
            Console.WriteLine("Ingrese el número de la tarea a eliminar");
            ListarTareas();
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero > 0 && numero <= tareas.Count)
                {
                    tareas.RemoveAt(numero - 1);
                    Console.WriteLine("Tarea eliminada con éxito");
                    ListarTareas();
                    Console.WriteLine("************************");
                }
                else
                {
                    Console.WriteLine("Número de tarea inválido");
                }
            }
            else
            {
                Console.WriteLine("Número de tarea inválido");
            }
        }

        private static void Salir()
        {
            Console.WriteLine("Saliendo del programa");
        }

        }
}
