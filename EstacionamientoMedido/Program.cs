using EstacionamientoMedido.Controladores;
using EstacionamientoMedido.Modelos;

ClienteController controladorCliente = new ClienteController();
VehiculoController controladorVehiculo = new VehiculoController();
EstacionamientoController controladorEstacionamiento = new EstacionamientoController();

Menu();

void Menu()
{
    int eleccion;

    Console.WriteLine("1 - Cargar un cliente");
    Console.WriteLine("2 - Ver Clientes Registrados");
    Console.WriteLine("3 - Cargar un Vehiculo");
    Console.WriteLine("4 - Cargar un Estacionamiento");
    Console.WriteLine();
    Console.Write("Opcion: ");
    eleccion = int.Parse(Console.ReadLine());

    switch (eleccion)
    {
        case 1: //cargar un cliente

            controladorCliente.GuardarCliente(CargarDatosCliente());
            Console.WriteLine();
            Menu();

            break;

        case 2: //veo clientes registrados
            Console.WriteLine("Listado de clientes cargados en el sistema");

            MostrarClientesRegistrados(controladorCliente.ObtenerClientes());

            Menu();
            break;

        case 3://cargar un vehiculo
            controladorVehiculo.GuardarVehiculo(CargarDatosVehiculo());

            Console.WriteLine();
            break;

        case 4: //cargar un estacionamiento
          //  controladorEstacionamiento
            
            Console.WriteLine();
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

    foreach (var item in listadoClientes)
    {
        Console.WriteLine($">Nombre: {item.nombre} {item.apellido} -Tel: {item.telefono} -Email: {item.correo}");
    }
}

Vehiculo CargarDatosVehiculo()
{
    Vehiculo vehiculonuevo = new Vehiculo();

    Console.Write("Patente: ");
    vehiculonuevo.patente = Console.ReadLine();
    Console.Write("Marca: ");
    vehiculonuevo.marca = Console.ReadLine();
    Console.Write("Modelo: ");
    vehiculonuevo.modelo = Console.ReadLine();
    Console.Write("Color: ");
    vehiculonuevo.color = Console.ReadLine();
    //como cargo el cliente?

    return vehiculonuevo;
}

Estacionamiento CargarEstacionamiento()
{
    Estacionamiento estacionamientonuevo = new Estacionamiento();

    //Console.Write("Hora de Entrada: ");
    //estacionamientonuevo.horaEntrada = Console.ReadLine();
    //Console.Write("Hora de Salida: ");
    //estacionamientonuevo.horaSalida = Console.ReadLine();
    //Console.Write("Modelo: ");
    //estacionamientonuevo.modelo = Console.ReadLine();
    //Console.Write("Color: ");
    //estacionamientonuevo.color = Console.ReadLine();
    //como cargo el estacionamiento?


    return estacionamientonuevo;

}
