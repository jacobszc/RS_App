using System;
using myApp;

class Program
{
    static void Main()
    {
        // Create an instance of your Chance class
        Chance c = new Chance();

        // Call the PurpleChance method
        double purpleChance = c.PurpleChance();

        Console.WriteLine("your purple chance is: " + purpleChance);
    }
}




// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();
