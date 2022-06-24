// See https://aka.ms/new-console-template for more information



void hola()
{
    string nombre;    
    Console.WriteLine("Como me llamo");
    nombre = Console.ReadLine();
    Console.WriteLine("Mi nombre es: {0}", nombre);
}

void tiposVariables()
{
    //Cadenas
    string cadena = "Esto es una cadena de caracteres";
    char letra = 'L';
    //Numericas enteros
    byte bytevar = 2; //0 -> 255
    sbyte sbytevar = -120; // -128 -> 127
    short shortvar = -2500;  //-32768 -> 32767
    int intvar = 2000000; // -2147483648 -> 2147483647
    long longvar = 541131772895;//-92233372036854775808 -> 9223372036854775807
    //Nueros reales
    float floatvar = 0.25f;// 1.5X10-35 -> 3.4X1038
    double boublevar = 0.00000565; //5,0 X10-324 -> 1.7X10308    
    decimal decimalvar = -0.033m; //1.0X10-28 -> 7.9X1028
    //logica
    bool boolvar = false; // true o false
}

void cadenas() 
{    
    string cadena = "Esto es una cadena de caracteres";
    char letra = 'L';
    Console.WriteLine("Mi string: {0} y mi char: {1}", cadena,letra);

}

void numeros()
{
    byte bytevar = 2; //0 -> 255
    sbyte sbytevar = -120; // -128 -> 127
    short shortvar = -2500;  //-32768 -> 32767
    int intvar = 2000000; // -2147483648 -> 2147483647
    long longvar = 541131772895;//-92233372036854775808 -> 9223372036854775807
    var Total = bytevar + sbytevar + shortvar + intvar + longvar;
    Console.WriteLine(Total);
}

void numerosReales()
{
    float floatvar = 0.25f;// 1.5X10-35 -> 3.4X1038
    double doublevar = 0.00000565; //5,0 X10-324 -> 1.7X10308    
    decimal decimalvar = -0.033m; //1.0X10-28 -> 7.9X1028
    var total = Convert.ToDecimal(floatvar) + Convert.ToDecimal(doublevar) + decimalvar;

    Console.WriteLine(total);
}

void logica()
{
    bool boolvar = true;
    Console.WriteLine(boolvar);
}

logica();

//numerosReales();
//numeros();

//cadenas();

//hola();