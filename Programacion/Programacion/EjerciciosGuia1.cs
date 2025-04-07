//int num1 = 3;
//int num2 = 4;
//int num3 = 5;

////Ejercicio numero 1
//Console.WriteLine($"Los numeros son los siguientes: {num1}, {num2} y {num3}");


//b) Escribir un algoritmo que permita ingresar por teclado dos números e imprima su suma.
int num4;
//int num5;
//int suma;

//Console.Write("Ingrese el primer numero: "); 
//num4 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese el segundo numero:");
//num5 = Convert.ToInt32(Console.ReadLine());

//suma = num4 + num5;

//Console.WriteLine($"La suma es igual a: {suma} ");


//c) Realizar un algoritmo que permita a un usuario ingresar por teclado la BASE y el EXPONENTE de
//una potencia y que el resultado sea mostrado por pantalla.

//int bases;
//int expo;
//double resultado;

//Console.Write("Ingresa la base del numero: ");  
//bases = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ingrese el exponente: ");
//expo = Convert.ToInt32(Console.ReadLine());

//resultado =Math.Pow(bases, expo);

//Console.WriteLine($"El resultado es igual a: {resultado}");





//d) Realizar un algoritmo que permita a un usuario ingresar por teclado un número del 1 al 100 y que
//determine si es un número par o impar.


//int num;

//Console.Write("Ingrese un numero del 1 al 100: ");
//num = Convert.ToInt32(Console.ReadLine());

//if (num%2 ==0)
//{
//    Console.WriteLine("El numero es par");

//}
//else
//{
//    Console.WriteLine("El numero es impar");
//}

//e) Realizar un algoritmo que permita intercambiar el valor de dos variables. Por ejemplo, si la variable1
//vale 5 y la variable2 vale 12, hacer que la variable1 valga 12 y la variable2 valga 5. (Tener en
//cuenta que al asignar un valor a una variable se sobrescribe el valor anterior).

//int variable1 = 5;
//int variable2 = 12;

//Console.WriteLine("Antes del intercambio:");
//Console.WriteLine($"Variable1 = {variable1}");
//Console.WriteLine($"Variable2 = {variable2} ");


//int auxiliar = variable1;
//variable1 = variable2;
//variable2 = auxiliar;

//Console.WriteLine("\nDespués del intercambio:");
//Console.WriteLine($"Variable1 = {variable1}");
//Console.WriteLine($"Variable2 = {variable2}");

//f) Una clínica de obesidad necesita un programa que sea capaz de calcular el índice de masa
//corporal de una persona que requiera atención. Para ello, tener en cuenta que la fórmula para el
//IMC es:
//Peso / (Estatura)2
//.


//Console.Write("Ingrese su peso en kilogramos (kg): ");
//double peso = Convert.ToDouble(Console.ReadLine());

//Console.Write("Ingrese su estatura en metros (m): ");
//double estatura = Convert.ToDouble(Console.ReadLine());

//double imc = peso / (estatura * estatura);


//Console.WriteLine($"Su Índice de Masa Corporal (IMC) es: {imc} ");

//g) Una estudiante está dando sus primeros pasos en la programación y quiere realizar un algoritmo
//que permita calcular cualquier porcentaje de un número. Para ello necesita que el usuario ingrese
//por teclado el número a calcular el porcentaje (por ejemplo 2500) y también el porcentaje que se
//desea calcular (por ejemplo, si quiere calcular 10% debería ingresar 0,10). A partir de estos valores,
//necesita que el algoritmo calcule el porcentaje (multiplicar el primer número por el valor del
//porcentaje), lo guarde en una variable y se muestre por pantalla. ¿Podrías ayudarla a realizar el
//algoritmo?


//Console.Write("Ingrese el número al que desea calcular el porcentaje (por ejemplo, 2500): ");
//double numero = Convert.ToDouble(Console.ReadLine());


//Console.Write("Ingrese el porcentaje que desea calcular (por ejemplo, 0.10 para 10%): ");
//double porcentaje = Convert.ToDouble(Console.ReadLine());


//double resultado = numero * porcentaje;


//Console.WriteLine($"El porcentaje es {resultado}");

//h) Realizar un algoritmo que calcule el IVA de un producto. Para esto, el usuario debe poder ingresar
//por teclado el valor del producto y el algoritmo debe informarle por pantalla qué monto equivale al
//IVA. Recordar que el IVA es igual al 21% (0,21).


const double impuestoIva = 0.21;
Console.Write("Ingrese el valor del producto: ");
double valorProducto = Convert.ToDouble(Console.ReadLine());

double iva = valorProducto * impuestoIva;

Console.WriteLine($"El IVA (21%) del producto es: {iva}");

//i) Realizar un algoritmo que permita a un profesor calcular el promedio de un alumno. Para esto, el
//algoritmo debe permitir ingresar las 4 notas de un alumno (por ejemplo, 8, 7, 9.50 y 10), luego
//calcular el promedio de las mismas y mostrar el resultado por pantalla.

Console.Write("Ingrese la primera nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la cuarta nota: ");
double nota4 = Convert.ToDouble(Console.ReadLine());


double promedio = (nota1 + nota2 + nota3 + nota4) / 4;


Console.WriteLine($"El promedio del alumno es: {promedio}");

//j) Realizar un algoritmo que permita calcular el área de un triángulo. Se recuerda que la fórmula para
//calcular el área de un triángulo es: (base * altura) / 2.Se debe permitir al usuario ingresar la base y
//la altura, mientras que el algoritmo debe calcular el área y mostrar el resultado por pantalla.

Console.Write("Ingrese la base del triángulo: ");
double baseTriangulo = Convert.ToDouble(Console.ReadLine());


Console.Write("Ingrese la altura del triángulo: ");
double altura = Convert.ToDouble(Console.ReadLine());

double area = (baseTriangulo * altura) / 2;


Console.WriteLine($"El área del triángulo es: {area}");
