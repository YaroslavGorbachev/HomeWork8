//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.Write("Количество Строк: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Количество Столбцов: ");
int j = int.Parse(Console.ReadLine());
Console.Write("Глубина массива : ");
int k = int.Parse(Console.ReadLine());
void FillArray(int [,,]matr)
{
    for(int i =0; i<matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr .GetLength(1); j++)
        {
            for (int k = 0; k < matr .GetLength(2); k++)
            {
                matr[i,j,k] = new Random().Next(10,99);
            }
        }
    }
}
void PrintArray(int[,,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr .GetLength(1); j++)
        {
            for (int k = 0; k < matr .GetLength(2); k++)
            {Console.Write($"{matr[i,j,k]}"); 
            }
            Console.WriteLine();
        }
    }
}
int [,,] matrix = new int [i,j,k];
Console.WriteLine("Массив");
PrintArray(matrix);
FillArray(matrix);