// EJERCICIO 1 

//PIDE LA EDAD DE UNA PERSONA 

/*using System.Diagnostics.Tracing;

Console.Write("introduce tu edad:    ");
int edad = Convert.ToInt32(Console.ReadLine());

//si tiene 18 o mas que muestre que es mayor de edad

if (edad >= 18)
{
    Console.Write("Es mayor de edad");
}*/




//EJERCICIO 2

//Pide un número entero

/*
Console.Write("introduce un número entero   ");
int numero = Convert.ToInt32(Console.ReadLine());

//Comprueba que es mayor que 0

if (numero > 0)
{
    Console.Write("El número es mayor que 0");
}
*/

//EJERCICIO 3

/*
// pide introducir una nota
Console.Write("introduce la nota:  ");
int Nota = Convert.ToInt32(Console.ReadLine());

//si la nota es mayor o igual a 5

if (Nota >= 5)
{
    Console.Write("APROBADO");
}
*/


//EJERCICIO 4

//Pedir temperatura

/*
Console.Write("Introduce una temperatura  ");
int temperatura = Convert.ToInt32(Console.ReadLine());

// Si es superior a 30 grados, muestra hace calor

if (temperatura > 30)
{
    Console.WriteLine("Hace calor");
}
 */

// EJERCICIO 5

/*
     //Pider UN NUMERO ENTERO
 Console.Write("INTRODUCE UN NUMERO ENTERO  ");
 int NUMERO = Convert.ToInt32(Console.ReadLine());

 if( NUMERO % 2 == 0)
{
  Console.Write("el numero es par ");
}

*/

//EJERCICIO 6

//PIDE UN NÚMERO ENTERO
/*
Console.Write("introduce un numero entero ");
int Numero = Convert.ToInt32(Console.ReadLine());

//Debes determinar si el número es positivo o no.


if( Numero >  0)

{
    Console.Write("si es positivo");
}
else if( Numero < 0)
{
    Console.Write("si es negativo");
}
else
{
    Console.Write("es 0");
}
*/


/*
// EJERCICIO 7 

//pedir contrseña al usuario
string contrseñaCorrecta ="1234";
Console.Write("introduce la contraseña:   ");
string contraseñaIntroducida = (Console.ReadLine());



if(contrseñaCorrecta == contraseñaIntroducida)
{
    Console.Write("contraseña correcta");
}
else
{
   Console.Write("contraseña incorrecta");  
}
*/


//EJERCICIO 8

//Pedimos una nota
/*Console.Write("Introduce la nota  ");
int Nota = Convert.ToInt32(Console.ReadLine());

if ( Nota < 0 || Nota > 10   )
{
Console.Write(" nota no valida");
} 

else if ( Nota < 5 )
{
    Console.Write("Suspenso");
}

else if ( Nota < 7  )
{
    Console.Write("aprobado");
}

else if( Nota  < 9  )
{
     Console.Write("notable");
}

else
{
    Console.Write("sobresaliente"); 
}
*/

//EJECICIO 9 

//PEDIMOS LA EDAD 

/*Console.Write("introduce la edad ");
int Edad =  Convert.ToInt32(Console.ReadLine());

//clasificacion segun persona

if ( Edad < 12 )
{
Console.Write(" niño");
} 

else if (Edad < 18 )
{
    Console.Write("adolescente");
}

else if ( Edad < 65 )
{
    Console.Write("adulto");
}

else
{
    Console.Write("persona mayor"); 
}
*/

//EJERCICIO 10

//Pedir el precio deun producto

/*Console.Write("Introduce el precio");
decimal Precio = Convert.ToDecimal(Console.ReadLine());


decimal descuento = 0;

if ( Precio < 50 )
{
 descuento = 0;
} 

else if ( Precio < 100 )
{
   
    descuento = Precio * 5 / 100 ;
}

else if ( Precio >= 100 )
{
    descuento = Precio * 10 / 100 ;
 
}


decimal PrecioFinal = Precio - descuento;

Console.Write("precio original :"   + Precio + "€");
Console.WriteLine("Descuento: " + descuento + " €");
Console.Write("Precio final"  + PrecioFinal + " €");*/




//EJERCICIO 11 

/*
//PEDIMOS EL NUMERO
using System.Collections;

Console.Write("introduce un numero ");
int Numero = Convert.ToInt32(Console.ReadLine());


switch (Numero)
{
    
case 1:
    Console.Write("LUNES ");
    break;


case 2:
    Console.Write("MARTES ");
    break;


case 3:

    Console.Write("MIERCOLES  ");
    break;

case 4:

    Console.Write("JUERVES");
    break;

case 5:

 Console.Write("VIERN4ES ");
break;


case 6:

    Console.Write("SABADO ");
    break;

case 7:

    Console.Write("DOMINGO ");
    break;

default:

    Console.Write("opcion no valida ");
    break;

}

*/

//EJERCICIO 12

//PEDIR LA OPCIÓN
/*
Console.Write("Intrduce la opción    ");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{

case 1:
            Console.Write("Crear");
            break;

case 2:
            Console.Write("Consultar");

            break;
             
case 3:
            Console.Write("modificar");
            break;

case 4:
            Console.Write("Eliminar");
            break;

default:
            Console.Write("La opción no es valida");
            break;

}

  */


//EJECICIO 13

/*   //PEDIMOS EL PRIMER NUMERO
Console.Write("introduce el primer numero    ");
int num1 = Convert.ToInt32(Console.ReadLine());

    //PEDIOMOS EL SEGUNDO NUMERO 
     Console.Write("introduce el primer segundo  ");
int num2 = Convert.ToInt32(Console.ReadLine());

int oper = 1;

switch( oper )
{

case 1:
      Console.Write("   Suma:" +     (num1 + num2));
      Console.Write("   resta:" +   (num1 - num2));
      Console.Write("   multiplicacion:"     + (num1 * num2));
      Console.Write("   division:" +     (num1 / num2));
break;


}
/*


//EJERCICIO 14

Console.Write("introduce un numero de 1 al 12 :    ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{


case 1:

  Console.Write("ENERO");
  break;

case 2:

Console.Write("FEBRERO ");
break;


case 3:

  Console.Write("MARZO ");
  break;

case 4:

  Console.Write("ABRIL ");
  break;
case 5:
  Console.Write("MAYO ");
  break;

case 6:
  Console.Write("JUNIO ");
  break;


case 7:
  Console.Write("JULIO ");
  break;


case 8:

  Console.Write("AGOSTO  ");
  break;

case 9:

  Console.Write("SEPTIEMBRE");
  break;

case 10:

Console.Write("OCTIBRE ");
break;


case 11:

  Console.Write("NOVIEMBRE ");
  break;

case 12:

  Console.Write("DICIEMBRE");
  break;
default:


  Console.Write("OPCION NO DISPONIBLE");

  break;

}

*/


//EJECICIO 15

/* //PEDIMOS UN NUMERO DEL 1 AL 3
Console.Write("Itroduce un numero");
int nume = Convert.ToInt32(Console. ReadLine());

string resultado = nume switch 
{ 
1 => "Bajo", 
2 => "Medio", 
3 => "Alto" 
};

Console.Write(resultado); */



//EJERCICIO 16

/* // PIDE UN NUMERO DE 1 AL 7 

Console.Write("introduce un numero del 1 al 7     ");
int numero = Convert.ToInt32(Console.ReadLine());

string resultado = numero switch 
{ 
1 => "lun", 
2 => "mar", 
3 => "mie", 
4 => "jue", 
5 => "vie", 
6 => "sab",
7 => "dom",
_=> "???"
};

Console.WriteLine(resultado);
*/



//EJERCCIO 17

/*Object dato = 25;

if (dato is int)
{
    Console.Write("el numero es entero");
}
*/

/*//EJERCICIO 18

Object dato = 25;

if (dato is int numeroEntero && numeroEntero > 18)
{
    Console.Write("El numero es esntero y > 18");
}

*/




//EJERCICIO 19


/*
object dato1 = 25;
object dato2 = "hola";
object dato3 = 8.5;

if (dato1 is int)
{
    Console.Write("el dato1 es entero     ");
}
if (dato2 is string)
{
    Console.Write("el dato2 es texto      ");
}
if (dato3 is double)
{
    Console.Write("el dato3 es double     ");
}
*/


//EJERCICO 20

/*
for (int numero = 0; numero  <= 10; numero++) 
{ 
    Console.WriteLine(numero);
}
*/

//EJERCICIO 21

// for (int i = 2; i <= 20; i++)
// {
//     if (i%2==0)
//     {
//         Console.WriteLine($"El numero {i} es par");
//     }
// }

// EJERCCIO 22


/*
for (int i = 10; i  >= 1; i--) 
{ 
    Console.WriteLine(i);
}
*/

//EJERCICIO 23

//PEDIMOS UN NUMERO
/*
Console.Write("Introduce un número: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
}
*/


//EJERCICIO 24
//Utiliza un for para calcular la suma de los números del 1 al 100.
/*
int sumaNumeros = 0;
for (int i = 0;  i <= 100 ; i++)
{
   sumaNumeros = sumaNumeros +i;
   Console.WriteLine($"{sumaNumeros}");
}
*/



//EJERCICIO 25
/*
int contador = 1;

while (contador <=10)
{
    Console.WriteLine(contador);
    contador++;
}   
*/

//EJERCICIO 26

int contador = 10;

while (contador >= 0)
{
     Console.WriteLine(contador);
    contador--;
}