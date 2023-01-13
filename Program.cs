/*Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в 
каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка*/


void FillArray(int [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
/*void GetSummOfRows(int[,]matr)
{
    int summ = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
        {
            for(int j = 0; j < matr.GetLength(1); j++)
            {
            summ+=matr[i, j];
            }
            Console.WriteLine(summ);  

        } 
    Console.WriteLine(summ);  
}*/
Random rand = new Random();
int row = rand.Next(5,10);
int column = rand.Next(3,5);
int[,]matrix = new int [row,column];
int [] arrayOfSumm = new int [row];
void GetSummOfRow(int getRow)
{
    int summ = 0;
    for (int j = 0; j < column ; j++)
    {
        summ+=matrix[getRow, j];
    }
    arrayOfSumm[getRow] = summ;
    
}   
FillArray(matrix);
PrintArray(matrix);

for (int j = 0; j < row; j++) 
{
    GetSummOfRow(j);
}

Console.WriteLine(string.Join(" ", arrayOfSumm));
int max = arrayOfSumm[0];
int count = 0;
for (int i = 1; i < row; i++)
{ 
    if (arrayOfSumm[i] < max)
    {
        max = arrayOfSumm[i];
        count = i;
    }
}
Console.WriteLine("строка с наименьшей суммой элементов: " + (count + 1));
