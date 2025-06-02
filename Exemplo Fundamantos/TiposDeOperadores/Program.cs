using TiposDeOperadores.Models;

int A = 10;
int B = 20;

int C = A + B;

Console.WriteLine(C);
C = C + 5;
Console.WriteLine(C);
C = 5;
Console.WriteLine(C);
C+= 5;
Console.WriteLine(C);
C-= 5;
Console.WriteLine(C);

/*************************************************************************************************/
/*Aprendendo Casting*/

int a = Convert.ToInt32("5"); // "Convert" é uma classe "ToInt32" é um metodo que recebe uma string e converte em um inteiro 
int b = int.Parse("10");
double c = double.Parse("2.5");
decimal d = decimal.Parse("5.75");     

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(c.ToString("F1"));
Console.WriteLine(d.ToString("F2"));


