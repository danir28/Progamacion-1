using Clases;

List<CuentaBancaria> listaCuentas = new List<CuentaBancaria>();

Console.WriteLine("¡Bienvenido al Sistema Bancario!");
int opcion = 0;

while (true)
{
    Console.WriteLine("\n--- SISTEMA BANCARIO ---");
    Console.WriteLine("1. Crear una cuenta");
    Console.WriteLine("2. Realizar una operación");
    Console.WriteLine("3. Consultar una cuenta");
    Console.WriteLine("4. Mostrar todas las cuentas");
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
            Console.WriteLine("Ingrese el número de cuenta: ");
            string numeroCuenta = Console.ReadLine();
            if (listaCuentas.Any(c => c.NumeroCuenta == numeroCuenta))
            {
                Console.WriteLine("Ya existe una cuenta con ese número.");
                break;
            }
            Console.WriteLine("Ingrese el nombre del titular: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo inicial: ");
            decimal saldoInicial = decimal.Parse(Console.ReadLine());
            if (saldoInicial < 0)
            {
                Console.WriteLine("El saldo inicial no puede ser negativo. No se creó la cuenta.");
                break;
            }
            Console.WriteLine("Ingrese el tipo de cuenta (1: Estándar, 2: Plus): ");
            int tipoCuenta = int.Parse(Console.ReadLine());
            switch (tipoCuenta)
            {
                case 1:
                    CuentaEstandar cuentaEstandar = new CuentaEstandar(numeroCuenta, titular, saldoInicial);
                    listaCuentas.Add(cuentaEstandar);
                    Console.WriteLine("Cuenta estándar creada exitosamente.");
                    break;
                case 2:
                    CuentaPlus cuentaPlus = new CuentaPlus(numeroCuenta, titular, saldoInicial);
                    listaCuentas.Add(cuentaPlus);
                    Console.WriteLine("Cuenta plus creada exitosamente.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. No se creó ninguna cuenta.");
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Ingrese el número de cuenta: ");
            string numeroBuscado = Console.ReadLine();
            CuentaBancaria cuentaEncontrada = listaCuentas.Find(c => c.NumeroCuenta == numeroBuscado);
            if (cuentaEncontrada == null)
            {
                Console.WriteLine("Cuenta no encontrada.");
                break;
            }
            Console.WriteLine("Seleccione la operación (1: Depositar, 2: Retirar): ");
            int operacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe: ");
            decimal importe = decimal.Parse(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    if (cuentaEncontrada.Depositar(importe))
                    {
                        Console.WriteLine("Depósito realizado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("El importe debe ser mayor a cero.");
                    }
                    break;
                case 2:
                    if (cuentaEncontrada.Retirar(importe))
                    {
                        Console.WriteLine("Retiro realizado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo realizar el retiro. Verifique el importe, el límite permitido y el saldo disponible.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el número de cuenta: ");
            string numeroConsulta = Console.ReadLine();
            CuentaBancaria cuentaConsultada = listaCuentas.Find(c => c.NumeroCuenta == numeroConsulta);
            if (cuentaConsultada != null)
            {
                Console.WriteLine($"Número de cuenta: {cuentaConsultada.NumeroCuenta}");
                Console.WriteLine($"Titular: {cuentaConsultada.Titular}");
                Console.WriteLine($"Tipo: {cuentaConsultada.GetType().Name}");
                Console.WriteLine($"Saldo actual: {cuentaConsultada.Saldo}");
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada.");
            }
            break;
        case 4:
            foreach (var cuenta in listaCuentas)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Número: {cuenta.NumeroCuenta}");
                Console.WriteLine($"Titular: {cuenta.Titular}");
                Console.WriteLine($"Tipo: {cuenta.GetType().Name}");
                Console.WriteLine($"Saldo: {cuenta.Saldo}");
            }
            break;
    }
}
