using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        int anterior = 0;
        int atual = 1;

        while (atual < numero)
        {
            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        if (atual == numero)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci!");
            Console.WriteLine("Para verificar outro número, tecle enter e reinicie o programa");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci!");
            Console.WriteLine("Para verificar outro número, tecle enter e reinicie o programa");
        }
            Console.ReadKey();
    }        
}
