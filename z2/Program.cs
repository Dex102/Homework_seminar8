int[,] SquareArray(int m, int n)
{   
    int[,] array = new int[m,n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(1, 10);

    return array;
}

void ShowArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
        }
}

void MinSumRow(int[,] array)
{
    int row = 0;
    int MinSum = 0;

    for(int i = 0; i < array.GetLength(0); i++) 
    {
        int TempSum = 0;

        for(int j = 0; j < array.GetLength(1); j++)
        {
            TempSum = TempSum + array[i,j];
        }

        if(i == 0) 
        {
            MinSum = TempSum;
        }

        if (TempSum <  MinSum)
        {
            MinSum = TempSum;
            row = i;
        }
    }

Console.Write($"Min sum - {MinSum}, Row - {row + 1}");

}

int[,] NewArray = SquareArray(4,4);
ShowArray(NewArray);

MinSumRow(NewArray);
   
