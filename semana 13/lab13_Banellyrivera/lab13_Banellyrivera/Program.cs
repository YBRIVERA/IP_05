// Declarar un arreglo unidimensional de 10 posiciones
int[] numeros = new int[10];

// Pedir al usuario ingresar 10 números y guardarlos en el arreglo
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingrese el número {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        numeros[i] = numero;
    }
    else
    {
        Console.WriteLine("Entrada no válida. Ingrese un número entero.");
        i--;
    }
}

// Calcular el número más pequeño y el número más grande
int min = numeros[0];
int max = numeros[0];
int sumaTotal = 0;
int sumaPares = 0;
int sumaImpares = 0;

for (int i = 0; i < 10; i++)
{
    int num = numeros[i];
    sumaTotal += num;

    if (num < min)
    {
        min = num;
    }

    if (num > max)
    {
        max = num;
    }

    if (i % 2 == 0)
    {
        sumaPares += num;
    }
    else
    {
        sumaImpares += num;
    }
}

// Mostrar los resultados
Console.WriteLine($"El número más pequeño ingresado es: {min}");
Console.WriteLine($"El número más grande ingresado es: {max}");
Console.WriteLine($"La suma total de los números ingresados es: {sumaTotal}");

Console.WriteLine("Números ingresados ordenados por posición (0 a 9):");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();

Console.WriteLine("Números ingresados ordenados por posición (9 a 0):");
for (int i = 9; i >= 0; i--)
{
    Console.Write($"{numeros[i]} ");
}
Console.WriteLine();

double promedio = (double)sumaTotal / 10;
Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
Console.WriteLine($"La suma de posiciones pares es: {sumaPares}");
Console.WriteLine($"La suma de posiciones impares es: {sumaImpares}");
 