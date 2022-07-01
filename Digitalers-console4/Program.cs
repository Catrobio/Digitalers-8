
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
            Console.Write("{0}\t",numeros[i,j]);
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

    for (int i = 0; i < Matriz.GetLength(0); i++)
    {
        for (int j = 0; j < Matriz.GetLength(1); j++)
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
    double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.9, 0.9, 0.9 };
    string[] meses = { "enero","febrero","marzo","abril","mayo","junio",
                        "julio","agosto","septiembre","octubre","noviembre","diciembre"};
   
    double inlfacionAnual = 0, valorMin = inflacion[0], valorMax = inflacion[0];
    string mesMin= "", mesMax = "";  

    for (int i = 0; i < inflacion.Length; i ++)
    {
        inlfacionAnual += inflacion[i];

        if (inflacion[i] < valorMin)
        {
            valorMin = inflacion[i];
            mesMin = meses[i];
        }

        if (inflacion[i] > valorMax)
        {
            valorMax = inflacion[i];
            mesMax = meses[i];            
        }
    }
    

    Console.WriteLine("La inflacion anual es de {0}", inlfacionAnual);
    Console.WriteLine("La inflacion mas baja fue en el mes {0} y fue de {1}", mesMin, valorMin);
    Console.WriteLine("La inflacion mas alta fue en el mes {0} y fue de {1}", mesMax, valorMax);
    Console.WriteLine("El promedio de la inflacion {0}", inlfacionAnual/12);

    // Calcular las veces que se repite 
    //cuento las veces que se repite
    int contador = 0;
    //creo un array con los meses 
    string[] mesesRepite = new string[1];

    for (int i = 0; i < inflacion.Length; i++)
    {
        if (inflacion[i] == valorMax)
        {
            if(contador >= 1)
            {
                //Aca redimencionamos el array dinamicamente 
                Array.Resize(ref mesesRepite, contador + 1);
            }
            mesesRepite[contador] = meses[i];

            contador++;
        }
    }
    //recorro el array 
    foreach (var mes in mesesRepite)
    {
        Console.WriteLine("Mes de inflacion maxima {0}", mes);
    }
    

}

//Solucion Camila
void inflacionCami()
{
    double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
    string[] meses = { "enero","febrero","marzo","abril","mayo","junio",
                        "julio","agosto","septiembre","octubre","noviembre","diciembre"};

    //  ---IMPRIMIR INFLACION TOTAL---
    //var total = inflacion.Sum();
    //                                      total
    Console.WriteLine("Inflacion total: " + inflacion.Sum());

    //  ---OBTENER INDICES CON MENOR Y MAYOR INFLACION---
    int indice_menor = Array.IndexOf(inflacion, inflacion.Min());
    int indice_mayor = Array.IndexOf(inflacion, inflacion.Max());

    //  ---IMPRIMIR MESES CON MENOR Y MAYOR INFLACION---
    Console.WriteLine("Mes con menor inflacion: " + meses[indice_menor]);
    Console.WriteLine("Mes con mayor inflacion: " + meses[indice_mayor]);

    //  ---OBTENER E IMPRIMIR PROMEDIO---
    //                total
    double promedio = inflacion.Sum() / inflacion.Length;
    Console.WriteLine("Promedio de la inflacion: " + promedio);
}

//Ingresar 3 datos por teclado
//calcular facturacion total X
//el promedio de la facturacion
//Maxima y minima
void ejercicio3()
{
    double[] facturas = new double[3];
    string[] meses = { "enero","febrero","marzo","abril","mayo","junio",
                        "julio","agosto","septiembre","octubre","noviembre","diciembre"};

    for (int i = 0; i < facturas.Length; i++)
    {
        Console.Write("Ingrese el monto de {0}: ", meses[i]);
        facturas[i] = Convert.ToDouble(Console.ReadLine());
    }

    var Total = facturas.Sum();
    var promedio = Total / 3; //facturas.Length;
    var facturaMax = facturas.Max();
    var facturaMin = facturas.Min();
    var MesMax = Array.IndexOf(facturas, facturas.Max());
    var MesMin = Array.IndexOf(facturas, facturas.Min());

    Console.WriteLine("La facturacion total es: {0}", Total);
    Console.WriteLine("El promedio de la facturacion: {0}", promedio);
    Console.WriteLine("La facturacion maxima fue de: {0} en el mes de {1}", facturaMax, meses[MesMax]);
    Console.WriteLine("La facturacion Minima fue de: {0} en el mes de {1}", facturaMin, meses[MesMin]);
}





//inflacionCami();
//ejercicio3();
ejercicio2();
//ejercicio1();
//ejemplo4();
//ejemplo3();
//ejemplo2();
//ejemplo();
//int[,] arr2 = { { 1, 2 }, { 2, 3 } };
