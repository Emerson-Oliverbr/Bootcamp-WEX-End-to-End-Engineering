int a = 5;
double b = a; //Conversão implicita "Automatica'
Console.WriteLine(b);

double c = 5.1;
//int d = c;

Console.WriteLine(c);
//Console.WriteLine(d); // Erro na saida conversão impossível de double para int

string valor1 = "20#";
int valor2 = 0; 

int.TryParse(valor1, out valor2);

Console.WriteLine(valor2);

Console.WriteLine("Conversão realizada com sucesso");

