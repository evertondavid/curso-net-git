using System;
using System.Runtime.Intrinsics.X86;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando Variáveis");
        double salario;
        salario = 3000.25;
        Console.WriteLine("Meu salário é de R$ " + salario);

        // short = guarta até 16 bites = 16k e um pouquinho
        short curto;
        curto = 15000;
        Console.WriteLine("curto " + curto);

        // int suport até 32 bites
        int salarioInteiro;
        salarioInteiro = 2000;
        Console.WriteLine("salario Inteiro " + salarioInteiro);

        //clong consegue guardar até 64 bites
        long valorLongo;
        valorLongo = 20000000000000;
        Console.WriteLine("valorLongo " + valorLongo);
        // Os tipos de dados float e double são usados para guardar números reais.A diferença entre eles é a precisão.O float tem uma precisão de 6 casas decimais
        // e o double tem uma precisão de 10 casas decimais.float trabalha com números que contém virgula, mas ela trabalha melhor com a virgula
        // quando usar o float, importante colocar a letra f ao final do valor
        float altura;
        altura = 1.66f;
        Console.WriteLine("altura " + altura);

  
        Console.WriteLine("Precione a teccla enter para avançar...");
        Console.WriteLine("Solution .NET Everton...");
        Console.WriteLine("Branch Everton...");
        Console.ReadLine();

    }
}

