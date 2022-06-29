
//Programa que imprime los numero del 1 al 10 sin imprimir los numeros 2, 5 y 9
void ejemplo1()
{
    int a = 1;
    /*while (a <= 10)
    {
        if(a != 2 && a != 5  && a != 9)
        {
            Console.WriteLine(a);            
        }
        a++;

    }*/

    do
    {
        if (a != 2 && a != 5 && a != 9)
        {
            Console.WriteLine(a);
        }
        a++;
    } while (a <= 10);

}

//Mostrar los numeros del 1 al 30 excluyendo los numeros entre el 10 y 20
void ejemplo2()
{
    int a = 1;
    while(a <= 30)
    {
        if(a <= 10 || a >= 20)
        {
            Console.WriteLine(a);
        }            
        a++;
    }
}

//Mostrar la suma de los numero del 1 al 10
//1+2+3+4+5+6+7+8+9+10
void ejemplo3()
{
    int ac = 0;
    for (int i = 1; i <= 10; i++)
    {
        // Escribo 0 + 1 ó 1 + 2
        Console.WriteLine(ac + " + " + i);
        ac = ac + i;
        //ac += i;
        Console.WriteLine("resultado: " + ac);
    }
}

//Mostrar la suma de los numeros pares que hay desde el 1 hasta 25
void ejemplo4()
{
    int a = 1;
    int ac = 0;        
    while (a <= 25)
    {
        if(a % 2 == 0)
        {
            ac += a;
            Console.WriteLine(ac);
        }
        //a = a +1;
        //a+=1;
        a++;
       
    }
}

// Ejemplo de Mati
void ejemplo4_1()
{
    int i = 2;
    int ac = 0;
    while (i < 25)
    {
        ac += i;
        i += 2;
        Console.WriteLine("resultado: " + ac);
    }
}

void bucle()
{
    //Break
    /*for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine("00000000000000000");
        if(i == 3)
        {
            break;
        }
    }*/

    //Continue
    /*for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine("Inicio");
        if (i == 3)
        {
            continue;            
        }
        Console.WriteLine("Fin");
    }*/
    //

    //GOTO
    /*for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine("Inicio");
        if (i == 3)
        {
            goto nro3;
        }
        Console.WriteLine("Fin");        
    }
    nro3: Console.WriteLine("i vale 3");

    //Infinito
    /*while(true)
    {
        Console.WriteLine("00000000000000000");            
    }*/
}

//mostrar la resta de la multiplicacion de los numeros del 1 al 5 mas la suma los numeros del 1 al 5
//(1*2*3*4*5) - (1+2+3+4+5)
void ejemplo5()
{
    int a = 1;
    int mul=1, sum=0;
    do
    {
        mul *= a;
        sum += a;
        a++;        
    } while (a<=5);
    Console.WriteLine("Resultado: "+ (mul-sum));
}

/*
1 @ 
2 @@ 
3 @ 
4 @@ 
5 @
*/
void ejemplo6()
{
    for (int i = 1; i<= 5; i++)
    {
        if(i % 2 == 0)
        {
            Console.WriteLine("@@");
        }
        else
        {
            Console.WriteLine("@");
        }
    }    
}

/*
1 @
2 @@
3 @@@
4 @@@@
5 @@@@@
*/

void ejemplo7()
{
    int a = 1;
    string b = "";
    while (a <= 5)
    {
        //b = b + "@";
        b += "@";
        Console.WriteLine(b);
        a++;
    }    
}
/*
1@@@@@
2@@@@
3@@@
4@@
5@
 */
void ejemplo8()
{
    for (int i = 5; i >= 1 ; i--)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write("@");
        }
        Console.WriteLine("@");
    }   
}
ejemplo8();
//ejemplo7();
//ejemplo6();
//ejemplo5();
//bucle();
//ejemplo4();
//ejemplo4_1();
//ejemplo3();
//ejemplo2();
//ejemplo1();
Console.ReadLine();