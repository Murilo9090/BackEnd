        int Corinthians, Santos;

        Console.Write("Digite o número de gols do primeiro time: ");
        Corinthians = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de gols do segundo time: ");
        Santos = int.Parse(Console.ReadLine());

        if (Corinthians > Santos)
        {
            Console.WriteLine("Vitória do Corinthians!");
        }
        else if (Santos > Corinthians)
        {
            Console.WriteLine("Vitória do Santos!");
        }
        else
        {
            Console.WriteLine("O jogo terminou empatado!");     
        }