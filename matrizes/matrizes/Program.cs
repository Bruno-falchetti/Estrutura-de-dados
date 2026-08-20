//vetores multidimensionais/


//vetor bi-dimensional//
int[,] numbersBi = new int [5 , 2];

//vetor tri-dimensional//
int[,,] numbersTri = new int [5, 4, 3];



//exemplo de um 4x3
int[,] newnumbersBi = new int[,] { 
 { 9 , 5 , -9 },
 { -11 , 4 , 0 },
 { 6 , 115 , 3 },
 { -12 , -9 , 71 },
 { 1 , -6 , -1 }
 };

//Percorrendo a matriz 
for(int i =0; i < newnumbersBi.GetLength(0); i++)
{
    for(int j = 0; j < newnumbersBi.GetLength(1); j++)
    {
        Console.Write($" [{newnumbersBi[i, j]}]");
    }
    Console.WriteLine("");
};

//vetor de vetores
int[][]  jaggedNumbers = new int[4][];


jaggedNumbers[0] = new int[] { 9, 5, -9 };
jaggedNumbers[1] = new int[] { 0, -3, 12, 91, -3 };
jaggedNumbers[2] = new int[] { };
jaggedNumbers[3] = new int[] { 51 };

//declaração com inicialização
int[][] jaggedNumbers2 = new int[][]
{
    new int[] {0, 1, 2 },
    new int[] {3, 4, 5, 6 },
    new int[] {7, 8, 9, 10 },
  
};
//para acessar uma posição especifica 
int num = jaggedNumbers[1][2];
jaggedNumbers[1][2] = 22;

Console.WriteLine(" n =" + num);
Console.WriteLine("JaggedNumbers[1][2] =" + jaggedNumbers[1][2]);



