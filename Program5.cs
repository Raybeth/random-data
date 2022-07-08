class Program5
{
    public static void Ejercicio5()
    {
        Console.WriteLine("Mostrar 10 usuarios");
        string url = "https://randomuser.me/api/?results=10";
        System.Net.WebClient client = new System.Net.WebClient();
        string datos = client.DownloadString(url);

        Root Respuesta = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(datos) ?? new Root();

        string final = "";
        int cant_f = 0;
        int cant_m = 0;


        foreach (var item in Respuesta.results)
        {
            Console.WriteLine(item.gender + " " + item.name.first + " " + item.name.last + " " + item.picture.large);
            if (item.gender == "male")
            {
                cant_m++;
            }
            else
            {
                cant_f++;
            }
            final += @$"
            <tr>
                <td><img src='{item.picture.large}'/></td>
                <td>{item.name.first}</td>
                <td>{item.name.last}</td>
                <td>{item.gender}</td>
            </tr>
            
            ";
        }
        final = @$"
            <html>
                <body>
                    <table border='1'>
                        <tr>
                            <th>Foto</th>
                            <th>Nombre</th>
                            <th>Apellido</th>
                            <th>Genero</th>
                        </tr>
                        {final}
                    </table>
                    Femeninos: {cant_f}
                    Masculinos: {cant_m}
                </body>
            </html>
        ";

        System.IO.File.WriteAllText("usuario.html", final);
        var uri = "usuario.html";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);

        Console.ReadKey();



    }
}