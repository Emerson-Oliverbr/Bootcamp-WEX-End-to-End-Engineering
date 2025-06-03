using System;
using OperadoresAritimeticos.Models;

Calculadora calculadora1 = new Calculadora();

calculadora1.Somar(10, 20);
calculadora1.Subtrair(10, 50);
calculadora1.Multiplicar(15, 2);
calculadora1.Dividir(10, 2);
calculadora1.Modulo(10, 3);
calculadora1.Potencia(3, 3);
calculadora1.RaizQuadrada(81);
calculadora1.Seno(30);
calculadora1.Coseno(30);
calculadora1.Tangente(30);

Console.WriteLine();

int numero = 10;
Console.WriteLine(numero);
numero++;
Console.WriteLine(numero);
numero--;
Console.WriteLine(numero);

Console.WriteLine();

int numero2 = 10;
Console.WriteLine(numero2);
numero2+=1;
Console.WriteLine(numero2);
numero2-=1;
Console.WriteLine(numero2);

Console.WriteLine();

int numero3 = 10;
Console.WriteLine(numero3);
numero3+=1;
Console.WriteLine(numero3);
numero3-=1;
Console.WriteLine(numero3);
numero3*=1;
Console.WriteLine(numero3);
numero3/=2;
Console.WriteLine(numero3);
numero3%=1;
Console.WriteLine(numero3);
