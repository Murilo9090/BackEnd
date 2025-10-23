﻿using System.Collections;

Console.Clear();
Console.WriteLine($"Digite seu nome");
String nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome");
String sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a voce!!");

Console.WriteLine($"por favor escolha uma opção abaixo");
Console.WriteLine($"1 - Saudar com nome");// receba o nome por perimetro e digitar a saudação dentro da função
Console.WriteLine($"2 - Saudar com sobrenome");//receba sobrenome por paramentro e digitar saudação dentro da função
Console.WriteLine($"3 - Saudar com completo");//receba o nome e sobrenome e vai devolver o nome  completo do usuario
Console.WriteLine($"0 - Apenas  saudação genérica");//so devolve o texto de saudação generica
Console.Clear();

int opcao = 0;
switch (opcao)

{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudarComNome(nome);
        break;
    case 2:
        SaudarComSobrenome(sobrenome);
        break;
    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo {nomeCompleto}");
        break;
    default:
        break;
}
void SaudarComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Ola, Seja bem-vindo{sobrenomeRecebido}");
}
//Função que escreve uma saudação de forma genetica
void SaudacaoGenerica()
{
    Console.WriteLine($"Ola, seja bem vindo ao nosso programa, tenha um otimo dia :)");
}

//recebe dois paramentr e devolve um texto - recebe nome e sobrenome e devolve o nome completo
void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}