namespace Clase_4.Models;

public class Pelicula
{
    public int Código { get; set; }

    public string Nombre { get; set; }

    public string Género { get; set; }

    public string Direccion { get; set; }

    public int Duración { get; set; }

    public double Puntuación { get; set; }
}

public class UltimoLanzamiento
{
    public int ID { get; set; }

    public string Nombre { get; set; }

    public string FechaLanzamiento { get; set; }
}
