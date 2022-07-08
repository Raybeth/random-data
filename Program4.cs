class Program4
{
    public static void Ejercicio4()
    {
        Console.Clear();
        Console.WriteLine("Tabla de multiblicar hasta el 13");
        int n;
        int n2;

        Console.WriteLine("Inserte el numero que desea consultar");
        int.TryParse(Console.ReadLine(), out n);

        for (n2 = 1; n2 <= 13; n2++)
        {

            Console.WriteLine(n + " x " + n2 + " = " + n2 * n);


        }
        Console.ReadKey();
    }

}