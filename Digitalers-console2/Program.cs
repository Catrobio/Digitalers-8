
//Mostrar el numero mayor
void main()
{
    int a = 10;
    int b = 20;

    if (a > b)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(b);
    }
}

//dado tres numero indicar cual es el numero mayor
void ejemplo1()
{
    int a = 10;
    int b = 20;
    int c = 5;


    if (a > b && a > c)
    {
        Console.WriteLine(a);
    }
    else if (b > c && b > a)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}

//Ejemplo uno con condicional no perezoso
void ejemploPere()
{
    int a = 10;
    int b = 6;
    int c = 5;

    if (a > b & a > c)
    {
        Console.WriteLine(a);
    }
    if (b > c & b > a)
    {
        Console.WriteLine(b);
    }
    if (c > a & c > a)
    {
        Console.WriteLine(c);
    }
}

//Ingresar dos numeros y si son positivos mostrar la multiplicación por 10
void ejemplo2()
{
    string a, b;
    int c, d;
    try
    {
        Console.Write("ingrese primer numero: ");

        a = Console.ReadLine();

        Console.Write("ingrese segundo numero: ");
        b = Console.ReadLine();

        c = Convert.ToInt32(a);
        d = Convert.ToInt32(b);

        if (c > 0)
        {
            Console.WriteLine("Resultado: " + c * 10);
        }
        if (d > 0)
        {
            Console.WriteLine("Resultado: " + d * 10);
        }
        else
        {
            Console.WriteLine("No hay numero positivos");
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
    }

}
//Pedir dos variables usuario y contraseña. Sabiendo que el usuario correcto es "Pablo" y la contraseña "1234":
// devolver mensaje de usuario o contraseña incorrecto; Usuario no existe y Bienvenido
void ejemplo3()
{
    string usuario, contraseña;
    Console.Write("ingrese usuario: ");
    usuario = Console.ReadLine();

    Console.Write("ingrese contraseña: ");
    contraseña = Console.ReadLine();

    //usuario.Equals("Pablo");
    if (usuario == "Pablo" && contraseña == "1234")
    {
        Console.WriteLine("Bienvenido: " + usuario);
    }
    // !usuario.Equals("Pablo");
    else if (usuario != "Pablo" || contraseña != "1234")
    {
        Console.WriteLine("Usuario o contraseña incorrecta");
    }
    else if (usuario != "Pablo")
    {
        Console.WriteLine("Usuario no existe");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

void ejemplo3_1()
{
    string usuario, contraseña;
    Console.Write("ingrese usuario: ");
    usuario = Console.ReadLine();

    Console.Write("ingrese contraseña: ");
    contraseña = Console.ReadLine();

    //usuario.Equals("Pablo");
    if (usuario == "Pablo" && contraseña == "1234")
    {
        Console.WriteLine("Bienvenido: " + usuario);
    }
    // !usuario.Equals("Pablo");
    else if (usuario != "Pablo")
    {
        Console.WriteLine("Usuario incorrecto");
    }
    else
    {
        Console.WriteLine("Usuario o contraseña incorrecta");
    }
}

//Solicitar dos numeros y dado a la opcion del menu ejeuctar:
//a:Suma; b:Resta; c:Multiplicacion; d:Division; e:Potencia; f: Raiz cuadrada.

void ejemplo4()
{
    string a, b, f;
    decimal c, d, g;
    try
    {
        Console.Write("ingrese primer numero: ");

        a = Console.ReadLine();

        Console.Write("ingrese segundo numero: ");
        b = Console.ReadLine();

        c = Convert.ToDecimal(a);
        d = Convert.ToDecimal(b);
        do
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*                       *");
            Console.WriteLine("* Elija una opcion      *");
            Console.WriteLine("*                       *");
            Console.WriteLine("* a - Suma              *");
            Console.WriteLine("* b - Resta             *");
            Console.WriteLine("* c - Multipliacion     *");
            Console.WriteLine("* d - Division          *");
            Console.WriteLine("* e - Potencia          *");
            Console.WriteLine("* f - Raiz cuadrada     *");
            Console.WriteLine("* n - Salir             *");
            Console.WriteLine("*                       *");
            Console.WriteLine("*************************");
            Console.Write("ingrese una opcion: ");
            f = Console.ReadLine();
            //string.IsNullOrEmpty(f)
        } while(f == "");
        
        switch (f)
        {
            case "a":
                g = c + d;
                Console.WriteLine("Resultado: " + g);
                break;
            case "b":
                g = c - d;
                Console.WriteLine("Resultado: " + g);
                break;
            case "c":
                g = c * d;
                Console.WriteLine("Resultado: " + g);
                break;
            case "d":
                g = c / d;
                Console.WriteLine("Resultado: " + g);
                break;
            case "e":
                //potencia
                g = (decimal)Math.Pow((double)c, (double)d);
                Console.WriteLine("Resultado: " + g);
                break;
            case "f":
                //raiz cuadrada
                g = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(c)));

                Console.WriteLine("Resultado: " + g);

                var h = Math.Sqrt((double)d);

                Console.WriteLine("Resultado: " + h);

                break;
            case "n":
                Console.WriteLine("Adios");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.Message);
    }

}

ejemplo4();
//ejemplo3();
//ejemplo2();
//ejemplo1();
//main();
Console.ReadLine();