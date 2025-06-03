int numero = 10;
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador}ª Execução {numero} * {contador} = {numero * contador}");
    contador += 1;

    if (contador == 6)
    {
        break;
    }    
}