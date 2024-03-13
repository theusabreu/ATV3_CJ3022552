// atividade 3
// 1

    {
        // Solicita ao usuário que insira um número
        Console.Write("Por favor, insira um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verifica se o número é par ou ímpar
        if (numero % 2 == 0)
        {
        Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
        Console.WriteLine($"O número {numero} é ímpar.");
        }
}


{
        //2
    { 
        Console.WriteLine("Insira os comprimentos dos três lados do triângulo:");

        // Solicita ao usuário que insira os comprimentos dos lados do triângulo
        Console.Write("Lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verifica se é possível formar um triângulo
        if (VerificarTriangulo(lado1, lado2, lado3))
        {
            // Classifica o triângulo
            if (lado1 == lado2 && lado2 == lado3)
            {
            Console.WriteLine("O triângulo é equilátero (três lados iguais).");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
            Console.WriteLine("O triângulo é isósceles (dois lados iguais).");
            }
            else
            {
            Console.WriteLine("O triângulo é escaleno (três lados diferentes).");
            }
        }
        else
        {
        Console.WriteLine("Não é possível formar um triângulo com os comprimentos fornecidos.");
        }
    }

    // Função para verificar se é possível formar um triângulo com os comprimentos dos lados
    static bool VerificarTriangulo(double lado1, double lado2, double lado3)
    {
        return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
    }
}
     //3
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int tentativasRestantes = 3;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número que estou pensando (entre 1 e 100).");

        while (tentativasRestantes > 0)
        {
            Console.Write("Digite o seu palpite: ");
            int palpite = Convert.ToInt32(Console.ReadLine());

            if (palpite == numeroAleatorio)
            {
                Console.WriteLine("Parabéns! Você acertou o número.");
                return;
            }
            else if (palpite < numeroAleatorio)
            {
                Console.WriteLine("O número que estou pensando é maior.");
            }
            else
            {
                Console.WriteLine("O número que estou pensando é menor.");
            }

            tentativasRestantes--;
        }

        Console.WriteLine($"Suas tentativas acabaram. O número que eu estava pensando era {numeroAleatorio}.");

 
        //4

    {
        // Solicita ao usuário que insira o nome de usuário
        Console.Write("Insira o nome de usuário: ");
        string nomeUsuario = Console.ReadLine();

        // Solicita ao usuário que insira a senha
        Console.Write("Insira a senha: ");
        string senha = Console.ReadLine();

        // Verifica se o nome de usuário e a senha correspondem às credenciais de administrador
        if (nomeUsuario == "THEUS" && senha == "123")
        {
            Console.WriteLine("Acesso concedido");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}          //5
 
        // Solicita ao usuário que insira a nota
        Console.Write("Insira a nota (de 0 a 100): ");
        int nota = Convert.ToInt32(Console.ReadLine());

        // Converte a nota para um conceito
        string conceito;
        if (nota >= 90 && nota <= 100)
        {
            conceito = "A";
        }
        else if (nota >= 80 && nota <= 89)
        {
            conceito = "B";
        }
        else if (nota >= 70 && nota <= 79)
        {
            conceito = "C";
        }
        else if (nota >= 60 && nota <= 69)
        {
            conceito = "D";
        }
        else
        {
            conceito = "F";
        }

        // Imprime o conceito correspondente
        Console.WriteLine($"Conceito: {conceito}");

    //6 



    {
        Random random = new Random();

        // Define as opções do jogo
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };

        // Solicita ao usuário que escolha uma opção
        Console.WriteLine("Escolha uma opção:\n1. Pedra\n2. Papel\n3. Tesoura");
        int escolhaUsuario = Convert.ToInt32(Console.ReadLine()) - 1;

        // Verifica se a escolha do usuário é válida
        if (escolhaUsuario < 0 || escolhaUsuario >= opcoes.Length)
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            return;
        }

        // O computador escolhe aleatoriamente uma opção
        int escolhaComputador = random.Next(opcoes.Length);

        // Imprime as escolhas do usuário e do computador
        Console.WriteLine($"Você escolheu: {opcoes[escolhaUsuario]}");
        Console.WriteLine($"O computador escolheu: {opcoes[escolhaComputador]}");

        // Determina o vencedor
        if (escolhaUsuario == escolhaComputador)
        {
            Console.WriteLine("Empate!");
        }
        else if ((escolhaUsuario == 0 && escolhaComputador == 2) ||
                 (escolhaUsuario == 1 && escolhaComputador == 0) ||
                 (escolhaUsuario == 2 && escolhaComputador == 1))
        {
            Console.WriteLine("Você ganhou!");
        }
        else
        {
            Console.WriteLine("Você perdeu!");
        }
}

    //7 
    

    {
        // Solicita ao usuário que insira o valor total da compra
        Console.Write("Insira o valor total da compra: ");
        double valorTotal = Convert.ToDouble(Console.ReadLine());

        // Define os descontos progressivos com base no valor total da compra
        double desconto = 0;
        if (valorTotal > 100 && valorTotal <= 200)
        {
            desconto = 0.1; // 10% de desconto
        }
        else if (valorTotal > 200 && valorTotal <= 300)
        {
            desconto = 0.2; // 20% de desconto
        }
        else if (valorTotal > 300 && valorTotal <= 400)
        {
            desconto = 0.3; // 30% de desconto
        }
        else if (valorTotal > 400)
        {
            desconto = 0.4; // 40% de desconto
        }

        // Calcula o valor com desconto
        double valorComDesconto = valorTotal - (valorTotal * desconto);

        // Imprime o valor com desconto
        Console.WriteLine($"Valor total com desconto: R${valorComDesconto:F2}");
}
    
    //8
     


    {
       // Solicita ao usuário que insira seu peso (em kg) e altura (em metros)
        Console.Write("Insira seu peso (em kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira sua altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calcula o Índice de Massa Corporal (IMC)
        double imc = peso / (altura * altura);

        // Determina a categoria do IMC
        string categoria;
        if (imc < 18.5)
        {
            categoria = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            categoria = "Peso normal";
        }
        else if (imc < 30)
        {
            categoria = "Sobrepeso";
        }
        else if (imc < 35)
        {
            categoria = "Obesidade grau I";
        }
        else if (imc < 40)
        {
            categoria = "Obesidade grau II";
        }
        else
        {
            categoria = "Obesidade grau III";
        }

        // Imprime o resultado
        Console.WriteLine($"Seu IMC é: {imc:F2}");
        Console.WriteLine($"Categoria: {categoria}");
    }
        














