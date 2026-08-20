//vetores multidimensionais/


//vetor bi-dimensional//
int[,] numbersBi = new int [5 , 2];

//vetor tri-dimensional//
int[,,] numbersTri = new int [5, 4, 3];



//exemplo de um 4x3
int[,] newnumbersBi = new int[,] { 
 { 9, 5, -9 },
 { -11, 4, 0 },
 { 6, 115, 3 },
 { -12, -9, 71 },
 { 1, -6, -1 }
 };

//Percorrendo a matriz 
for(int i =0; i < newnumbersBi.GetLength(0); i++)
{
    for(int j = 0; j < newnumbersBi.GetLength(1); j++)
    {
        Console.WriteLine($"Posição [{i}, {j}] = {newnumbersBi[i, j]}");
    }

};
