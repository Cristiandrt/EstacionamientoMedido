using EstacionamientoMedido;

Repositorio repo = new Repositorio();
Menu();

void Menu()
{
    int eleccion;

    Console.WriteLine("1 - Cargar un cliente");
    Console.WriteLine("2 - Ver Clientes Registrados");
    Console.WriteLine();
    Console.Write("Opcion: ");
    eleccion = int.Parse(Console.ReadLine());

    switch (eleccion)
    {
        case 1: //cargar un cliente

            repo.clientes.Add(CargarDatosCliente());
            Console.WriteLine();
            Menu();

            break;

        case 2: //veo clientes registrados
            Console.WriteLine("Listado de clientes cargados en el sistema");

            MostrarClientesRegistrados(repo.clientes);

            Menu();
            break;

        default:
            Console.Clear();
            Menu();
            break;
    }

        
}

Cliente CargarDatosCliente()
{
    Cliente clientenuevo = new Cliente(); //instanciamos el cliente para cargar datos

    Console.Write("Nombre: ");
    clientenuevo.nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    clientenuevo.apellido = Console.ReadLine();
    Console.Write("Telefono: ");
    clientenuevo.telefono = Console.ReadLine();
    Console.Write("Email: ");
    clientenuevo.correo = Console.ReadLine();

    return clientenuevo;
}

void MostrarClientesRegistrados(List<Cliente> listadoClientes)
{
    Console.WriteLine("Listado de clientes cargados en el sistema");

    foreach (var item in repo.clientes)
    {
        Console.WriteLine($">Nombre: {item.nombre} {item.apellido} -Tel: {item.telefono} -Email: {item.correo}");
    }
}
