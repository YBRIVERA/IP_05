using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de conversión de quetzales a billetes y monedas");
        Console.WriteLine("Banelly Rivera - 1253123");

        Console.Write("Ingrese un número: ");
        if (!double.TryParse(Console.ReadLine(), out double cantidad) || cantidad < 0 || cantidad > 999.99)
        {
            Console.WriteLine("La cantidad no es válida.");
            return;
        }

        Console.WriteLine("Equivale en billetes y monedas a:");

        int billete100 = (int)cantidad / 100;
        cantidad %= 100;
        int billete50 = (int)cantidad / 50;
        cantidad %= 50;
        int billete20 = (int)cantidad / 20;
        cantidad %= 20;
        int billete10 = (int)cantidad / 10;
        cantidad %= 10;
        int billete5 = (int)cantidad / 5;
        cantidad %= 5;

        int moneda1 = (int)cantidad;
        cantidad -= moneda1;
        int moneda25centavos = (int)(cantidad / 0.25);
        cantidad -= moneda25centavos * 0.25;
        int moneda1centavo = (int)(cantidad / 0.01);

        Console.WriteLine("Billetes de 100 quetzales: " + billete100);
        Console.WriteLine("Billetes de 50 quetzales: " + billete50);
        Console.WriteLine("Billetes de 20 quetzales: " + billete20);
        Console.WriteLine("Billetes de 10 quetzales: " + billete10);
        Console.WriteLine("Billetes de 5 quetzales: " + billete5);
        Console.WriteLine("Monedas de 1 quetzal: " + moneda1);
        Console.WriteLine("Monedas de 25 centavos: " + moneda25centavos);
        Console.WriteLine("Monedas de 1 centavo: " + moneda1centavo);


        Console.ReadLine();

    }
}