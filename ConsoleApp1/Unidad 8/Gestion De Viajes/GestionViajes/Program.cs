using System.Linq;
using Clases;
List<Vehiculo> listaVehiculos = new List<Vehiculo>();

Console.WriteLine("¡Bienvenido!");
int opcion = 0;

while (true)
{
    Console.WriteLine("\n--- SISTEMA GESTIÓN DE VIAJES ---");
    Console.WriteLine("1. Agregar un vehículo");
    Console.WriteLine("2. Registrar un viaje para un vehículo");
    Console.WriteLine("3. Mostrar información de un vehículo");
    Console.WriteLine("4. Mostrar todos las patentes y tipo de vehículo");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    // Si elige la opción de salida, salir.
    if (opcion == 5)
    {
        Console.WriteLine("Saliendo...");
        break;
    }

    switch (opcion)
    {
        case 1:
            //AgregarVehiculo(listaVehiculos);
            Console.WriteLine("Ingrese el tipo de vehículo (1: Camión, 2: Motocicleta, 3: Furgoneta): ");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la patente del vehiculo: ");
            string patenteVehiculo = Console.ReadLine();
            if (listaVehiculos.Any(v => v.Patente == patenteVehiculo))
            {
                Console.WriteLine("Ya existe un vehículo con esa patente.");
                break;
            }
            Console.WriteLine("Ingrese el kilometraje del vehiculo: ");
            int kilometrajeVehiculo = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Ingrese la capacidad de carga del camion: ");
                    int capacidadCarga = int.Parse(Console.ReadLine());
                    Camion camion = new Camion(patenteVehiculo, kilometrajeVehiculo, capacidadCarga);
                    listaVehiculos.Add(camion);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la capacidad de pasajeros de la motocicleta: ");
                    int capacidadPasajerosMotocicleta = int.Parse(Console.ReadLine());
                    Motocicleta motocicleta = new Motocicleta(patenteVehiculo, kilometrajeVehiculo, capacidadPasajerosMotocicleta);
                    listaVehiculos.Add(motocicleta);
                    break;
                case 3:
                    Console.WriteLine("Ingrese la capacidad de pasajeros de la furgoneta: ");
                    int capacidadPasajerosFurgoneta = int.Parse(Console.ReadLine());
                    Furgoneta furgoneta = new Furgoneta(patenteVehiculo, kilometrajeVehiculo, capacidadPasajerosFurgoneta);
                    listaVehiculos.Add(furgoneta);
                    break;
                default:
                    Console.WriteLine("Opción inválida. No se agregó ningún vehículo.");
                    break;
            }
            break;
        case 2:
            //RegistrarViaje(listaVehiculos);
            Console.WriteLine("Ingrese la patente del vehículo: ");
            string patenteV = Console.ReadLine();
            Vehiculo vehiculoBuscado = listaVehiculos.Find(v => v.Patente == patenteV);
            if (vehiculoBuscado != null)
            {
                Console.WriteLine("Ingrese la distancia del viaje: ");
                int distancia = int.Parse(Console.ReadLine());
                if (vehiculoBuscado is Camion)
                {
                    Console.WriteLine("Ingrese la carga transportada (en kg): ");
                    int cargaTransportada = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha del viaje (dd/MM/yyyy): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());
                    Viaje nuevoViaje = new Viaje(distancia, cargaTransportada, fecha);
                    vehiculoBuscado.AgregarViaje(nuevoViaje);
                    Console.WriteLine("Viaje registrado exitosamente.");
                }
                else if (vehiculoBuscado is Motocicleta || vehiculoBuscado is Furgoneta)
                {
                    Console.WriteLine("Ingrese la cantidad de pasajeros transportados: ");
                    int pasajerosTransportados = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha del viaje (dd/MM/yyyy): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());
                    Viaje nuevoViaje = new Viaje(distancia, pasajerosTransportados, fecha);
                    vehiculoBuscado.AgregarViaje(nuevoViaje);
                    Console.WriteLine("Viaje registrado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Tipo de vehículo no soportado para registrar viajes.");
                }
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
            break;
        case 3:
            //MostrarVehiculo(listaVehiculos);
            Console.WriteLine("Ingrese la patente del vehículo: ");
            string patente = Console.ReadLine();
            Vehiculo vehiculoEncontrado = listaVehiculos.Find(v => v.Patente == patente);
            if (vehiculoEncontrado != null)
            {
                Console.WriteLine($"Tipo: {vehiculoEncontrado.GetType().Name}");
                Console.WriteLine($"Patente: {vehiculoEncontrado.Patente}");
                Console.WriteLine($"Kilometraje: {vehiculoEncontrado.Kilometraje}");
                Console.WriteLine($"Distancia total recorrida: {vehiculoEncontrado.CalcularDistancia()}");
                Console.WriteLine($"Cantidad de viajes: {vehiculoEncontrado.Viajes.Count}");
                if (vehiculoEncontrado is Camion camion)
                {
                    Console.WriteLine($"Capacidad de carga: {camion.CapacidadCarga}");
                }
                else if (vehiculoEncontrado is Motocicleta motocicleta)
                {
                    Console.WriteLine($"Capacidad de pasajeros: {motocicleta.CapacidadPasajeros}");
                }
                else if (vehiculoEncontrado is Furgoneta furgoneta)
                {
                    Console.WriteLine($"Capacidad de pasajeros: {furgoneta.CapacidadPasajeros}");
                }
                int cargaTotal = 0;
                foreach (Viaje viaje in vehiculoEncontrado.Viajes)
                {
                    cargaTotal += viaje.CargaTransportada;
                }
                Console.WriteLine($"Carga total transportada: {cargaTotal}");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
            break;
        case 4:
            //MostrarPatentesYTipos(listaVehiculos);
            foreach (var vehiculo in listaVehiculos)
            {
                int CargaTotal = 0;
                foreach (Viaje viaje in vehiculo.Viajes)
                {
                    CargaTotal += viaje.CargaTransportada;
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Patente: {vehiculo.Patente}");
                Console.WriteLine($"Tipo: {vehiculo.GetType().Name}");
                Console.WriteLine($"Kilometraje: {vehiculo.Kilometraje}");
                Console.WriteLine($"Cantidad de viajes: {vehiculo.Viajes.Count}");
                Console.WriteLine($"Distancia total: {vehiculo.CalcularDistancia()}");
                Console.WriteLine($"Carga total: {CargaTotal}");
            }
            break;
    }
}
