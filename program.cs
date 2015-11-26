using System;
using Npgsql;

public class Program
{
    public static void Main (string[] args)
    {
        using(var connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Pooling=true;Database=amdb;User Id=jonathan;Password=;"))
        {
            connection.Open();
        }
        Console.WriteLine("Hello, OS X");
        Console.WriteLine("Love from CoreCLR.");
    }
}
