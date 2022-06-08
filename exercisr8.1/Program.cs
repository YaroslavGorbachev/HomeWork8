// 1.Найти произведение двух матриц.
int[,] firstArray = 
{
    {6,5,-7},
    {9,5,2},
    {9,1,5},
};
for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
        Console.Write($"{firstArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] secondArray = 
{
    {4,2,5},
    {4,2,7},
    {1,-1,0},
};
for (int i = 0; i < secondArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        Console.Write($"{secondArray[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] multiplicationOfArrays = new int [firstArray.GetLength(0),secondArray.GetLength(1)];
for (int i = 0; i < firstArray.GetLength(0); i++)
{   
    for (int j = 0; j < secondArray.GetLength(0); j++)
    {   
        //multiplicationOfArrays[i,j] = 0;
        for (int k = 0; k < secondArray.GetLength(1); k++)
        {
            multiplicationOfArrays[i,k] += (firstArray[i,j] * secondArray[j,k]);
        }
        Console.WriteLine(); 
             
    }
    
}
for (int i = 0; i < multiplicationOfArrays.GetLength(0); i++)
{
   for (int j = 0; j < multiplicationOfArrays.GetLength(1); j++)
   {
       Console.Write($"{ multiplicationOfArrays[i,j]} ");
   } 
   Console.WriteLine(); 
}
