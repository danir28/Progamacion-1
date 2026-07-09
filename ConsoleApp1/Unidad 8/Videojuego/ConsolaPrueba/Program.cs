using MisClases;
List<Personaje> personajes = new List<Personaje>();
List<Combate> combates = new List<Combate>();

do 
{
    Console.WriteLine("1. Registrar Personaje");
    Console.WriteLine("2. Ver lista de personajes creados");
    Console.WriteLine("3. Iniciar un combate entre dos personajes");
    Console.WriteLine("4. Ver historial de combates");
    Console.WriteLine("5. Ver estadisticas globales de cada personaje");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();
    switch (opcion) {
        case "1":
            Console.WriteLine("Ingrese el nombre del personaje: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Seleccione la clase del personaje: ");
            Console.WriteLine("1. Guerrero");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Arquero");
            Console.Write("Ingrese el número de la clase: ");
            string clase = Console.ReadLine();
            Console.WriteLine("Ingrese el nivel del personaje: ");
            int nivel = int.Parse(Console.ReadLine());
            Personaje personaje;
            switch (clase) {
                case "1":
                    personaje = new Guerrero(nombre, nivel);
                    break;
                case "2":
                    personaje = new Mago(nombre, nivel);
                    break;
                case "3":
                    personaje = new Arquero(nombre, nivel);
                    break;
                default:
                    Console.WriteLine("Clase inválida");
                    continue;
            }
            Console.WriteLine($"Personaje {personaje.Nombre} de clase {clase} creado con éxito.");
            personajes.Add(personaje);
            break;
        case "2":
            if (personajes.Count == 0)
            {
                Console.WriteLine("No hay personajes creados.");
            }
            else {
                Console.WriteLine("Lista de personajes creados:");
                foreach (var p in personajes) 
                {
                    Console.WriteLine($"Nombre: {p.Nombre}, Clase: {p.GetType().Name}, Nivel: {p.Nivel}, Vida: {p.Vida}/{p.VidaMaxima}, Ataque: {p.Ataque}, Defensa: {p.Defensa}");
                }
            }
            break;
        case "3":
            Console.WriteLine("Ingrese el nombre del primer personaje: ");
            string nombre1 = Console.ReadLine();
            Personaje personaje1 = personajes.Find(p => p.Nombre == nombre1);
            if (personaje1 == null) {
                
                Console.WriteLine("Personaje no encontrado.");
                continue;
            }
            Console.WriteLine("Ingrese el nombre del segundo personaje: ");
            string nombre2 = Console.ReadLine();
            Personaje personaje2 = personajes.Find(p => p.Nombre == nombre2);
            if (personaje2 == null)
            {
                Console.WriteLine("Personaje no encontrado.");
                continue;
            }
            if (personaje1 == personaje2)
            {
                Console.WriteLine("No se puede combatir contra uno mismo.");
                continue;
            }
            Console.WriteLine($"Iniciando combate entre {personaje1.Nombre} y {personaje2.Nombre}...");
            Combate combate = new Combate(personaje1, personaje2);
            combate.IniciarCombate();
            combates.Add(combate);
            Console.WriteLine($"El ganador es: {combate.Ganador?.Nombre}");
            Console.WriteLine($"Turnos realizados: {combate.CantidadTurnos}");
            break;
        case "4":
            Console.WriteLine("Historial de combates:");
            if (combates.Count == 0) {
                Console.WriteLine("No hay combates creados.");
            }
            else {
                foreach (var c in combates) {
                    Console.WriteLine($"Combate: {c.Personaje1.Nombre} vs {c.Personaje2.Nombre}");
                    Console.WriteLine($"Ganador: {c.Ganador?.Nombre ?? "Empate"}");
                    Console.WriteLine($"numero de turnos: {c.CantidadTurnos}");
                }
            }
            break;
        case "5":
            Console.WriteLine("Estadísticas globales de cada personaje:");
            if (personajes.Count == 0) {
                Console.WriteLine("No hay personajes creados");
            }
            else {
                foreach (var p in personajes)
                {
                    Console.WriteLine($"Nombre: {p.Nombre}, Clase: {p.GetType().Name}");
                    Console.WriteLine($"El personajes ha jugado {p.CombatesJugados}");
                    Console.WriteLine($"El personaje ha ganado {p.Victorias} combates");
                    Console.WriteLine($"El personaje ha perdido {p.Derrotas} combates");
                    Console.WriteLine($"El personaje ha infligido {p.DanoInfligido} puntos de daño");
                    Console.WriteLine($"El personaje ha recibido {p.DanoRecibido} puntos de daño");
                }
            }
            break;
        case "6":
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (true);