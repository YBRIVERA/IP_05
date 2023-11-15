class progra
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Mi segundo Progra");
        string sNombre, sEdad, sCarrera, sCarne;

        //Ingreso de nombre
        Console.WriteLine(" Ingrese su nombre: ");
        sNombre = Console.ReadLine();

        //Ingreso de Edad
        Console.WriteLine(" Ingrese su Edad: ");
        sEdad = Console.ReadLine();

        //Ingreso de Carrera
        Console.WriteLine(" Ingrese su carrera: ");
        sCarrera = Console.ReadLine();

        //Ingreso de Carne
        Console.WriteLine(" Ingrese su Carne: ");
        sCarne = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Mi segundo programa ");
        Console.WriteLine("Nombre: " + sNombre);
        Console.WriteLine("Edad: " + sEdad);
        Console.WriteLine("Carrera: " + sCarrera);
        Console.WriteLine("Carne: " + sCarne);

        Console.WriteLine();
        Console.WriteLine(" Soy " + sNombre + " tengo "+ sEdad + " años y estudio " + sCarrera );
        Console.WriteLine(" Mi numero de carne es " + sCarne);
        Console.ReadKey();


    }
} 


