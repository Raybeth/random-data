class Program1
{
    public static void Ejercicio1()
    {
        Console.Clear();
        Console.WriteLine("Programa que clasifica un triangulo segun sus lados");
        int A, B, C = 0;

        //Equilatero = 3 lados iguales//
        //Isosceles = 2 lados iguales//
        //Escaleno = 3 lafos desiguales//

        Console.WriteLine("Ingrese lado A:");
        int.TryParse(Console.ReadLine(), out A);
        Console.WriteLine("Ingrese lado B:");
        int.TryParse(Console.ReadLine(), out B);
        Console.WriteLine("Ingrese lado C:");
        int.TryParse(Console.ReadLine(), out C);



        if (A == B && B == C)
        {

            Console.WriteLine("Equilatero");
            Console.ReadKey();
        }
        else if (A == B && B != C)
        {
            Console.WriteLine("Isosceles");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Escaleno");
            Console.ReadKey();
        }
    }
}