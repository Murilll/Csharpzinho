Console.WriteLine("ATIVIDADES");

while (true)
{
    Console.WriteLine("\n1 --- Questão 1\n2 --- Questão 2\n3 --- Questão 3\n4 --- Questão 4\n5 --- Questão 5\n6 --- Questão 6\n");
    int escolhaQuestao = Convert.ToInt32(Console.ReadLine());

    switch (escolhaQuestao)
    {
        case 1:
            //Questão 1
            Console.WriteLine("1 --- converção Fahrenheit para Celsius\n2 --- converção Celsius para Fahrenheit");

            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Coloque a temperatura em Fahrenheit");
                float fahrenheit = float.Parse(Console.ReadLine());
                float celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"A temperatura em celsius fica: {celsius} °C");
            }

            else if (escolha == 2)
            {
                Console.WriteLine("Coloque a temperatura em Celsius");
                float celsius = float.Parse(Console.ReadLine());
                float fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"A temperatura em celsius fica: {fahrenheit} °F");
            }

            else
            {
                Console.WriteLine("ERRO");
            }

            Console.WriteLine("\n\n");
            break;

        case 2:
            //Questão 2

            Console.WriteLine("Informe a sua hora trabalhada, para descobrir seu salário mensal");
            float hora = float.Parse(Console.ReadLine());
            float salario = hora * 220;
            Console.WriteLine($"Seu salário mensal foi: R${salario}");

            Console.WriteLine("\n");
            break;

        case 3:
            //Questão 3

            Console.WriteLine("Descubra o valor da energia gasta");
            Console.WriteLine("Informe a potência em kW");
            float potencia = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe as horas");
            float horas = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do kWh");
            int Kwh = Convert.ToInt32(Console.ReadLine());
            float valor = potencia * horas * Kwh;
            Console.WriteLine($"O valor gasto é R${valor}");
            break;

        case 4:
            //Questão 4

            Console.WriteLine("Escreva um número para informar o dia da semana:");
            int semana = int.Parse(Console.ReadLine());
            switch (semana)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break ;
                case 2:
                    Console.WriteLine("Tuesday");
                    break ;
                case 3:
                    Console.WriteLine("Wednesday");
                    break ;
                case 4:
                    Console.WriteLine("Thursday");
                    break ;
                case 5:
                    Console.WriteLine("Friday");
                    break ;
                case 6:
                    Console.WriteLine("Saturday");
                    break ;
                case 7:
                    Console.WriteLine("Sunday");
                    break ;
                default:
                    Console.WriteLine("ERROR");
                    break ; 
            }
            break;

        case 5:
            //Questão 5

            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 16 && idade < 18)
                Console.WriteLine("O seu voto é facultativo");
            else if (idade < 16)
                Console.WriteLine("O voto não é obrigatório");
            else if (idade >= 18)
                Console.WriteLine("Voto obrigatório");

            break;

        case 6:
            //Questão 6

            Console.WriteLine("Informe 5 números para montar uma lista");
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }

            list.Sort();

            Console.WriteLine($"O maior número da lista é o {list.Max()}");
            Console.Write($"A lista em ordem fica:");
            foreach (int i in list)
                Console.Write(i + ", ");
            break;
    }
}