class Program2
{
    public static void Ejercicio2()
    {

        Console.Clear();
        Console.WriteLine("Programa para calificar Triagulo segun sus angulos.");
        int A, B, C = 0;

        //Un angulo de 90 grados = Rectangulo//
        //Los 3 angulos son agudos = Acutangulo//
        //Un angulo obtuso = Obtusangulo//

        Console.WriteLine("Favor ingresar el angulo del primer lado:");
        int.TryParse(Console.ReadLine(), out A);
        Console.WriteLine("Favor ingresar el angulo del segundo lado:");
        int.TryParse(Console.ReadLine(), out B);
        Console.WriteLine("Favor ingresar el angulo del tercer lado:");
        int.TryParse(Console.ReadLine(), out C);

        if (A == 90 || B == 90 || C == 90)
        {
            Console.WriteLine("");
            Console.WriteLine("Esto es un triangulo Rectangulo");
            Console.ReadKey();
        }
        else if (A < 90 && B < 90 && C < 90)
        {
            Console.WriteLine("");
            Console.WriteLine("Esto es un triangulo Acutangulo");
            Console.ReadKey();
        }
        else if (A > 90 && B < 90 && C < 90)
        {
            Console.WriteLine("");
            Console.WriteLine("Esto es un triangulo Obtusangulo");
            Console.ReadKey();
        }
        else if (A + B + C > 180)
        {
            Console.WriteLine("La suma de los angulos NO puede ser mayor de 180");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Esto no es un triangulo, intente nuevamente.");
            Console.ReadKey();
        }


    }
}