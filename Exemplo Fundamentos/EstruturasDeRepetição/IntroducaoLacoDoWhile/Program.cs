﻿int soma = 0, numero = 0;

do
{
    Console.Write("Digite um numero, (0 para parar): ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine($"Soma dos numero digitados = {soma}");