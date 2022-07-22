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

int[,] SortArray(int[,] array)
{
    int temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = array.GetLength(1) - 1; k>j; k--)
            {
                if(array[i,k] < array[i,k-1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k-1];
                    array[i,k-1] = temp;
                }
            }
        }
    }
    
    return array;
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] NewArray1 = SquareArray(m,n);


Console.WriteLine("Array number 1");
ShowArray(NewArray1);

Console.WriteLine("Sorted array");
ShowArray(SortArray(NewArray1));
