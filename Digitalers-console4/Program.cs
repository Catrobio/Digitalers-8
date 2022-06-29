
void ejemplo()
{
    //declaramos
    int[] arreglo;
    //inicializamos
    arreglo = new int[5];
    // agregar valores
    arreglo[0] = 1;
    arreglo[1] = 3;
    arreglo[2] = 5;
    arreglo[3] = 10;
    arreglo[4] = 13;    

    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.WriteLine(arreglo[i]);
    }

    /*foreach (var numero in arreglo)
    {
        Console.WriteLine(numero);
    }*/

    string[] arregloString;
    arregloString = new string[3];
    arregloString[0] = "Hola";
    arregloString[1] = "a";
    arregloString[2] = "Todos";

    /*for (int i = 0; i < arregloString.Length; i++)
    {
        Console.WriteLine(arregloString[i]);
    }*/
    
    foreach (var letras in arregloString)
    {
        Console.WriteLine(letras);
    }
}

void ejemplo2()
{
    int[,] numeros;
    numeros = new int[3,5];
    numeros[0,0] = 1;
    numeros[0,1] = 5;
    numeros[0,2] = 7;
    numeros[0,3] = 9;
    numeros[0,4] = 11;

    //Asigno valores al resto de las filas
    for (int i = 0; i < 5; i++)
    {
        numeros[1, i] = numeros[0, i] * 2;
        numeros[2, i] = numeros[0, i] * 10;
    }
    //Recorremos la matriz
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(numeros[i,j]);
        }
        Console.WriteLine();
    }
}

void ejemplo3()
{
    const int x = 2;
    const int y = 10;
     
    Random objRandom = new Random();

    Console.WriteLine("Matriz");

    int[,] Matriz = new int[x, y];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Matriz[i, j] = objRandom.Next(100);
            Console.WriteLine("Matriz[{0},{1}] = {2}", i, j, Matriz[i, j]);
        }
    }
}

void ejemplo4()
{
    int x = 4;
    int y = 5;
    int z = 3;
    Random objRandom = new Random();

    Console.WriteLine("Cubo" + Environment.NewLine);

    int[,,] Cubo = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Cubo[i, j, k] = objRandom.Next(100);

                Console.Write("Cubo [{0},{1},{2}] = {3}", i, j, k, Cubo[i, j, k] + " ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// Dado el array 10,20,5,15,30,20
// - Mostrar los valores de cada indice X
// - Totalizar el array (sumar todos los valores)X
// - Indicar las posiciones de los imparesX
// - Mostrar el numero mayor X
// - Indicar cuantas veces se repite el numero 20
void ejercicio1()
{    
    int[] arr = {10,20,5,15,30,20};
    int total=0, max = arr[0], cont = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Arry[{0}] = {1}", i, arr[i]);
        total += arr[i];

        if(arr[i] % 2 != 0)
        {
            Console.WriteLine("La posicion {0}", i + " es impar");
        }

        if(arr[i] > max)
        {
            max = arr[i];
        }

        if (arr[i] == 20)
        {
            cont++;
        }

    }
    Console.WriteLine("El total es = {0}", total);
    Console.WriteLine("El mayor numero es = {0}", max);
    Console.WriteLine("El numero 20 se repite {0}", cont);
}

// Array {0.8,0.1,0.3,0.4,0.3,0.6,0.5,0.3,0.7,0.3,02,0.9}
//- Informar la inflacion anualX
//- Inflacion mas baja con el mes
//- Inflacion mas alta con el mes
//- Promedio de inflacion 

void ejercicio2()
{
    double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
    double inlfacionAnual = 0;      

    for (int i = 0; i < inflacion.Length; i ++)
    {
        inlfacionAnual += inflacion[i];
    }

    Console.WriteLine("La inflacion anual es de {0}", inlfacionAnual);

}


ejercicio2();
//ejercicio1();
//ejemplo4();
//ejemplo3();
//ejemplo2();
//ejemplo();
//int[,] arr2 = { { 1, 2 }, { 2, 3 } };
