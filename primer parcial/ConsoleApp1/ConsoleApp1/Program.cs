using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido!");

        string nombre, apellido, dominio, correoElectronico;

        Console.Write("fabian: ");
        nombre = Console.ReadLine();

        Console.Write("morales: ");
        apellido = Console.ReadLine();

        Console.Write("@gmail.com: ");
        dominio = Console.ReadLine();

        correoElectronico = GenerarCorreoElectronico(nombre, apellido, dominio);

        Console.WriteLine($"Su correo electrónico generado es: {correoElectronico}");
    }

    static string GenerarCorreoElectronico(string nombre, string apellido, string dominio)
    {
        string correo = $"{nombre.Substring(0, 3).ToLower()}{apellido.Substring(0, 3).ToLower()}@{dominio}";
        return correo;
    }
}