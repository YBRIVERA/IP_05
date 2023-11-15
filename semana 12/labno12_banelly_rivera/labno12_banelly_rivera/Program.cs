using System;

class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    private double ObtenerPerimetro()
    {
        return 2 * Math.PI * radio;
    }

    private double ObtenerArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    private double ObtenerVolumen()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
    }

    public void CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
    {
        unPerimetro = ObtenerPerimetro();
        unArea = ObtenerArea();
        unVolumen = ObtenerVolumen();
    }
}

class Program
{
    static void Main()
    {
        double radioCirculo;
        Console.Write("Ingrese el radio del círculo: ");
        while (!double.TryParse(Console.ReadLine(), out radioCirculo) || radioCirculo <= 0)
        {
            Console.WriteLine("Ingrese un valor el cual sea válido para el radio.");
        }

        Circulo objCirculo = new Circulo(radioCirculo);

        double perimetro = 0, area = 0, volumen = 0;

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("El perímetro del círculo es: " + perimetro);
        Console.WriteLine("El área del círculo es: " + area);
        Console.WriteLine("El volumen del círculo es: " + volumen);

        Console.ReadLine();
    }
}