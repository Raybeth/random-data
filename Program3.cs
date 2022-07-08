class Program3
{
    public static void Ejercicio3()
    {
        Console.Clear();
        int A, B, C, D = 0;

        Console.WriteLine("Inserte lado A: ");
        int.TryParse(Console.ReadLine(), out A);
        Console.WriteLine("Inserte lado B: ");
        int.TryParse(Console.ReadLine(), out B);
        Console.WriteLine("Inserte lado C: ");
        int.TryParse(Console.ReadLine(), out C);
        Console.WriteLine("Inserte lado D: ");
        int.TryParse(Console.ReadLine(), out D);

        if (A == B && B == C && C == D)
        {
            Console.WriteLine("");
            Console.WriteLine("Esto es un cuadrado");
            Console.ReadKey();

        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Esto NO es un cuadrado.");
            Console.ReadKey();

        }

    }
}