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

int[,] PrArray(int[,] array1, int[,] array2)
{
    int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {            
            matrix[i,j] = array1[i,j] * array2[i,j];
        }
    }
    
    return matrix;
}


Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] NewArray1 = SquareArray(m,n);
int[,] NewArray2 = SquareArray(m,n);

ShowArray(NewArray1);
Console.WriteLine("---------------------------------");
ShowArray(NewArray2);
Console.WriteLine("---------------------------------");

ShowArray((PrArray(NewArray1, NewArray2)));

