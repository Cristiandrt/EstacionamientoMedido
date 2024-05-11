using EstacionamientoMedido.Controladores;
using EstacionamientoMedido.Modelos;
using EstacionamientoMedido.Vistas;

EstacionamientoController controladorEstacionamiento = new EstacionamientoController();

Menu menuAplicacion = new Menu();
menuAplicacion.MostrarMenu();

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
