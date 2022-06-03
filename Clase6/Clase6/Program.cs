var opcion = "s";

while (opcion.ToLower() == "s")
{
    Console.Clear();
    Console.WriteLine("Ingrese nombre: ");
    var nombre = Console.ReadLine();
    Console.WriteLine("¡Hola " + nombre + "!");
    Console.WriteLine("¿Quiere continuar? S/N");
    opcion = Console.ReadLine();

    while (opcion != "s" && opcion != "n")
    {
        Console.WriteLine("opción no válida, ingrese nuevamente");
        Console.WriteLine("¿Quiere continuar? S/N");
        opcion = Console.ReadLine();

        if (opcion.ToLower() == "n")
        {
            Console.WriteLine("Programa finalizado...");
        }
        else
        {
            continue;   
        }
    }
}

