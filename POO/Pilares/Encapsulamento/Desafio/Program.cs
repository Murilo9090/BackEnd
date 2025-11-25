using Desafio;
Console.Clear();

Carro fusca = new Carro();

fusca.DefinirMarca("VolksWagen");
fusca.DefinirModelo("Fusca 89 modificado");

fusca.Acelerar(100);
fusca.Acelerar(40);

fusca.Frear(20);

System.Console.WriteLine(@$"Marca: {fusca.ObterMarca()}
Modelo: {fusca.ObterModelo()}
Velocidade Atual: {fusca.ObterVelocidade()}");