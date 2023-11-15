using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1");

        Console.Write("Número ENTERO: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            if (numero > 0)
            {
                Console.WriteLine("RESULTADO: El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("RESULTADO: El número es negativo.");
            }
            else
            {
                Console.WriteLine("RESULTADO: El número es cero.");
            }
        }
        else
        {
            Console.WriteLine("ERROR: Ingrese un número entero válido.");
        }
        Console.WriteLine("Ejercicio 2");

        Console.Write("Ingrese el número de día: ");
        if (int.TryParse(Console.ReadLine(), out int numeroDia))
        {
            if (numeroDia >= 1 && numeroDia <= 7)
            {
                string diaSemana = "";

                switch (numeroDia)
                {
                    case 1:
                        diaSemana = "lunes";
                        break;
                    case 2:
                        diaSemana = "martes";
                        break;
                    case 3:
                        diaSemana = "miércoles";
                        break;
                    case 4:
                        diaSemana = "jueves";
                        break;
                    case 5:
                        diaSemana = "viernes";
                        break;
                    case 6:
                        diaSemana = "sábado";
                        break;
                    case 7:
                        diaSemana = "domingo";
                        break;
                }

                Console.WriteLine("DIA: " + diaSemana);
            }
            else
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
            }
        }
        else
        {
            Console.WriteLine("Error: Ingrese un número válido.");
        }
    }
}
//Ejercicio 2