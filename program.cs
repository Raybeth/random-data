bool continuar = true;

while (continuar)
{
    string opcion = "";
    Console.Clear();
    Console.WriteLine(@"
    
    Tarea 4
    Menu de opciones:
    1. Clasificacion de los Triangulos segun sus lados.
    2. Clasificacion de los Triangulos segun sus angulos.
    3. Programa para determinar si la figura es un cuadrado.
    4. Tabla de multiplicar hasta el 13.
    5. Programa que importa datos de 10 personas random.
    X. Salir
    
    ");
    Console.WriteLine("Que deseas hacer?");
    opcion = Console.ReadLine() ?? "";
    switch (opcion.ToLower())
    {
        case "1":
            Program1.Ejercicio1();
            break;
        case "2":
            Program2.Ejercicio2();
            break;
        case "3":
            Program3.Ejercicio3();
            break;
        case "4":
            Program4.Ejercicio4();
            break;
        case "5":
            Program5.Ejercicio5();
            break;
        case "x":
            continuar = false;
            Console.WriteLine("Gracias por usar este programa");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            Console.ReadKey();
            break;
    }
}