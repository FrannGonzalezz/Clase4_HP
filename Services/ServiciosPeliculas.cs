using Clase_4.Models;

namespace Clase_4.Services;

public static class ServicioPeli
{
    static List<Pelicula> Peliculas { get; set; }

    static ServicioPeli()
    {
        Peliculas = new List<Pelicula>
        {
            new Pelicula { Código = 1, Nombre = "Top gun: Maverick", Direccion = "Joseph Kosinski", Género = "Acción/Drama", Duración = 131, Puntuación = 7},
            new Pelicula { Código = 2, Nombre = "The Batman", Direccion = "Matt Reeves",Género = "Acción", Duración = 175, Puntuación = 7},
            new Pelicula { Código = 3, Nombre = "Avatar: The Way of Water", Direccion = "James Cameron",Género = "Ciencia ficción", Duración = 192, Puntuación = 6.7},
            new Pelicula { Código = 4, Nombre = "Everything  Everywhere All at Once", Direccion = "Dan Kwan, Daniel Scheinert",Género = "Comedia/Acción", Duración = 139, Puntuación = 6.6},
            new Pelicula { Código = 5, Nombre = "The Northman", Direccion = "Robert Eggers",Género = "Aventuras/Acción", Duración = 136, Puntuación = 6.5},
            new Pelicula { Código = 6, Nombre = "Turning Red", Direccion = "Domee Shi",Género = "Animación/Fantasía", Duración = 100, Puntuación = 6.5},
            new Pelicula { Código = 7, Nombre = "The Black Phone", Direccion = "Scott Derrickson",Género = "Terror", Duración = 102, Puntuación = 6.3},
            new Pelicula { Código = 8, Nombre = "Glass Onion: A Knives out Mystery", Direccion = "Rian Jhonson",Género = "Comedia/Crimen", Duración = 139, Puntuación = 6.1},
            new Pelicula { Código = 9, Nombre = "Nope", Direccion = "Jordan Peele",Género = "Fantasía/Terror", Duración = 130, Puntuación = 6},
            new Pelicula { Código = 10, Nombre = "Black Panther: Wakanda Forever", Direccion = "Ryan Coogler",Género = "Fantasía/Acción", Duración = 161, Puntuación = 5.5}
        };
    }
    public static List<Pelicula> GetAll() => Peliculas;

    public static void Add(Pelicula obj)
    {
        if (obj == null)
        {
            return;
        }
        Peliculas.Add(obj);
    }

    public static Pelicula? Get(int codigo) => Peliculas.FirstOrDefault(x => x.Código == codigo);

    public static void Eliminar(int codigo)
    {
        var peliABorrar = Get(codigo);
        if (peliABorrar != null)
        {
            Peliculas.Remove(peliABorrar);
        }
    }
}

public static class ServicioUltLanz
{
    static List<UltimoLanzamiento> UltLanz { get; set; }

    static ServicioUltLanz()
    {
        UltLanz = new List<UltimoLanzamiento>()
        { 
            new UltimoLanzamiento {ID = 1, Nombre = "Mario Bros", FechaLanzamiento = "07/04/2023"},
            new UltimoLanzamiento {ID = 2, Nombre = "Guardianes de la Galaxia", FechaLanzamiento = "21/04/2023"},
            new UltimoLanzamiento {ID = 3, Nombre = "Creed III", FechaLanzamiento = "10/04/2023"}
        };
    }
    public static List<UltimoLanzamiento> GetAll() => UltLanz;
}