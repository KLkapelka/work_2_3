// Заполните квадратную матрицу n x n так, чтобы все числа первого столбца и первой строки равны 1,
// а каждое из оставшихся чисел равно сумме верхнего и левого соседей. Выведите на экран получившеюся матрицу.


using System;
class work_2_3
{
  static void Main()
    {
        int n = 3; 
        int[,] matrix = new int[n, n]; 
        
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1; 
            matrix[i, 0] = 1; 
        }
        
        for (int iRow = 1; iRow < n; iRow++) 
        {
            for (int iCol = 1; iCol < n; iCol++) 
            {
                matrix[iRow, iCol] = matrix[iRow - 1, iCol] + matrix[iRow, iCol - 1]; 
            }
        }
        
        for (int iRow = 0; iRow < n; iRow++) 
        {
            for (int iCol = 0; iCol < n; iCol++) 
            {
                Console.Write($"{matrix[iRow, iCol]} "); 
            }
            Console.WriteLine(); 
        }
    }
}
