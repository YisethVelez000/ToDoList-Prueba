using System;

internal class Tarea
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public DateTime? Fecha { get; set; }
    public bool Completada { get; private set; }

    public Tarea(string nombre, string descripcion, DateTime? fecha = null)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Fecha = fecha;
        Completada = false;
    }

    public void Completar()
    {
        Completada = true;
    }

    public void Mostrar()
    {
        if (Completada)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (Fecha.HasValue && Fecha.Value < DateTime.Today)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        string estado = Completada ? "Completada" : "Pendiente";
        string fechaTexto = Fecha.HasValue ? Fecha.Value.ToString("dd/MM/yyyy") : "Sin fecha";
        string nombreTachado = Completada ? $"~{Nombre}~" : Nombre;

        Console.WriteLine($"{nombreTachado} ({fechaTexto}) - {estado}");

        // Reseteamos el color para que no afecte a otros textos
        Console.ResetColor();
    }
}