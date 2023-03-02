//using System.Collections.Generic;

//string[] arrayNomes = new string[0];
//arrayNomes.Add("Murilo");

//string arrayNames(string arrayNomes)
//{

//    return arrayNomes;
//}


// Questão2


//// Questão3

//int Fatorial(int num)
//{
//    int n = 1;
//    for (int i = 1; i <= num; i++)
//    {
//        n *= i;
//    }
//    return n;
//}

//int resultado = fatorial(5);
//Console.WriteLine(resultado);

//// Questão4 

//int Fibonacci(int n)
//{
//    int a = 0;
//    int b = 0;

//    for (int i = 1; i <= n; i++)
//    {
//        Console.Write(a);
//        int temp = a;
//        a = b;
//        b = temp + b;
//    }
//    return b;
//}

//Console.WriteLine(Fibonacci(10));


//// Questão5

//string[] arrayNomes = new string[] { "Murilo", "Flavio", "Marli", "Amanda", "Miguel", "Thyago" };

//string ArrayRandom(string[] arrayNomes)
//{
//    Random r = new Random();
//    string nomesAleatorios = arrayNomes[r.Next(arrayNomes.Length-1)];
//    return nomesAleatorios;
//}

//Console.WriteLine(ArrayRandom(arrayNomes));


//// Questão6

//float LeiaN(float N)
//{
//    float E = 1;
//    for (int i = 0; i < N; i++)
//    {
//        E = E + (1 + 1 / Fatorial(i) + 1);
//    }
//    return E;
//}

//Console.WriteLine(LeiaN(10));