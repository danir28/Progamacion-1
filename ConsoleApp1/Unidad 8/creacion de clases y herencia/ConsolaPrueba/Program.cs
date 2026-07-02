using MisClases;

//Clase persona
Persona p = new Persona("Daniel", 20, 47074216);
p.Saludar();

//Clase empleado hereda de persona
Empleado e = new Empleado("Daniel", 20, 43244324, "Programador");
e.Trabajar();

//Clases perros heredan de animal abstracta
Animal perro1 = new Perro("Chimuelo");
perro1.HacerSonido();
Animal perro2 = new Perro("Deisi");
perro2.HacerSonido();
Animal perro3 = new Perro("Elif");
perro3.HacerSonido();

//Clases gatos heredan de animal abstracta
Animal gato1 = new Gato("Michi");
Animal gato2 = new Gato("Mini miua");
Animal gato3 = new Gato("Negro");

//Lista para guardar a todos los animales en la lista
List<Animal> animales = new List<Animal>();
animales.Add(perro1);
animales.Add(perro2);
animales.Add(perro3);
animales.Add(gato1);
animales.Add(gato2);
animales.Add(gato3);

//Recorrer la lista de animales y hacer que cada uno haga su sonido
foreach (Animal animal in animales)
{
    animal.HacerSonido();
}

//Clase camion hereda de Automovil, Automovil hereda de Vehiculo
Camion camion = new Camion("Volvo", 10, 2);
camion.Conducir();
camion.Puertas();
camion.Cargar();

//Clase circulo hereda de figura, Figura es abstracta
Figura circulo = new Circulo("Circulo 1", 10);
circulo.CalcularArea();

//Clase Libro y LibroDigital, LibroDigital hereda de Libro
Libro libro1 = new Libro("El principito", "Antoine de Saint-Exupéry", 96);
LibroDigital ebook = new LibroDigital("1984", "George Orwell", 328, 5, "PDF");

//Clase productoPerecedero y productoElectronico, ambas heredan de producto
ProductoPerecedero productoP = new ProductoPerecedero("Leche", 2700, new DateTime (2026, 7, 1));
bool vencido = productoP.EstaVencido();
Console.WriteLine($"El producto {productoP.Nombre} está vencido: {vencido}");
ProductoElectronico productoE = new ProductoElectronico("Celular", 976000, 24, true);
Console.WriteLine($"El producto {productoE.Nombre} tiene un precio de {productoE.Precio}, un voltaje de {productoE.Voltaje}V y tiene garantía: {productoE.TieneGarantia}");

//Clase estudiante y profesor heredan de persona
Estudiante estudiante = new Estudiante("Juan", 20, 12345678, "2023-001");
estudiante.Estudiar();
Profesor profesor = new Profesor("María", 35, 87654321, "Matemáticas");
profesor.Enseñar();