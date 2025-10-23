 double lado1, lado2, lado3;

        Console.Write("Digite o valor do primeiro lado: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        lado3 = double.Parse(Console.ReadLine());

        // Primeiro, verifica se as medidas formam um triângulo
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero (3 lados iguais).");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triângulo Isósceles (2 lados iguais).");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno (3 lados diferentes).");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo.");
        }