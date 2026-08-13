// crie um programa que seja capaz de ler 10 numeros inteiros e separalos em dois vetores, um para numeros pares e outro para numeros impares. Ao final, imprima os pares e depois impares

 int[] pares = new int[10];
 int[] impares = new int[10];

int quantidadepar = 0;
int quantidadeimpar = 0;

 for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                pares[quantidadepar] = numero;
                quantidadepar++;
            }
            else
            {
                impares[quantidadeimpar] = numero;
                quantidadeimpar++;
            }
        };
       Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < quantidadepar; i++)
            {
                 Console.Write(pares[i] + " ");
}

                Console.WriteLine("\n\nNúmeros ímpares:");
        for (int i = 0; i < quantidadeimpar; i++)
            {
              Console.Write(impares[i] + " ");
}

Console.WriteLine("\n");
