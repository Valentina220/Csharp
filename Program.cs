using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int line = int.Parse(Console.ReadLine());
            int size1 = line;
            Console.WriteLine("Введите количество столбцов:");
            int column = int.Parse(Console.ReadLine());
            int size2 = column;

            int[,] a = new int[size1, size2];

            ArrayOperation.Input(a);
            ArrayOperation.Summa(a, out double sum);
            ArrayOperation.AverageValue(a, out double mean);
            ArrayOperation.SignElements(a, out double NegativeAmount, out double PositiveAmount);
            ArrayOperation.AmountByNumbers(a, out double evenSum, out double oddSum);
            ArrayOperation.ArrayExtremum(a, out double MaxIndexLine, out double MaxIndexColumn, out double MinIndexLine, out double MinIndexColumn);

            Console.WriteLine("Сумма элементов массива = {0}\n", +sum) ;

            Console.WriteLine("Среднее значение массива = " + $"{mean:.##}\n");

            Console.WriteLine("Сумма положительных элементов массива = {0}\n", PositiveAmount); 
            Console.WriteLine("Сумма отрицательных элементов массива = {0}\n", NegativeAmount);

            Console.WriteLine("Сумма четных элементов массива = {0}\n", evenSum);
            Console.WriteLine("Сумма нечетных элементов массива = {0}\n", oddSum);

            Console.WriteLine("Максимальный элемент массива имеет индексы [{0},{1}]\n", MaxIndexLine, MaxIndexColumn);
            Console.WriteLine("Минимальный элемент массива имеет индексы [{0},{1}]\n", MinIndexLine, MinIndexColumn);
         
        }

        //private static void Input(int[,] arr)
        //{
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.Write("Enter value for [{0},{1}] : ", i, j);
        //            arr[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }
        //    Console.WriteLine();
        
        //}

        //public static double Summa(int[,] array, out double sum)
        //{
        //    sum = 0;
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {

        //            sum +=array[i, j];
                    
        //            //array[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    //Console.WriteLine(sum);
        //    return sum;

        //}

        //public static double AverageValue(int[,] array, out double mean)
        //{
        //    mean = 0;
        //    double sum = 0;
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {

        //            sum += array[i, j];                    
        //            //array[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    mean = sum / (array.GetLength(0) * array.GetLength(1));

        //    return mean;
        //    //Console.WriteLine(mean);
        //    //Console.WriteLine(array.GetLength(0));
        //    //Console.WriteLine(array.GetLength(1));
        //}

        //public static double SignElements(int[,] array, out double NegativeAmount, out double PositiveAmount)
        //{
        //    NegativeAmount = 0;
        //    PositiveAmount = 0;

        //    //double SumNeg = 0;
        //    //double SumPos = 0;

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            if (array[i, j] >= 0)
        //            {
        //                PositiveAmount += array[i, j];
        //            }
        //            else
        //            {
        //                NegativeAmount += array[i, j];
        //            }

        //        }

        //    }

        //    return PositiveAmount;
        //}

        //public static double AmountByNumbers(int[,] array, out double evenSum, out double oddSum)
        //{
        //    evenSum = 0;  //сумма по четным индексам
        //    oddSum = 0;  //сумма по нечетным индексам

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            if (i % 2 == 0 && j % 2 == 0)
        //            {
        //                evenSum += array[i, j];
        //            }
        //            else
        //            {
        //                oddSum += array[i, j];
        //            }
        //        }
        //    }

        //    return evenSum;
        //}

        //public static double ArrayExtremum(int[,] array, out double MaxIndexLine, out double MaxIndexColumn, out double MinIndexLine, out double MinIndexColumn)
        //{
        //    MaxIndexLine = 0;
        //    MaxIndexColumn = 0;
        //    MinIndexLine = 0;
        //    MinIndexColumn = 0;

        //    double ArrayMax = array[0,0];
        //    double ArrayMin = array[0,0];

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {


        //            //ArrayMax = (int) Enumerable.Max(array[i,j]); 

        //            if (ArrayMax < array[i,j])
        //            {
        //                ArrayMax = array[i, j];
        //                MaxIndexLine = i;
        //                MaxIndexColumn = j;
        //            }
        //            else if (ArrayMin > array[i, j])
        //            {
        //                ArrayMin = array[i, j];
        //                MinIndexLine = i;
        //                MinIndexColumn = j;
        //            }
        //        }
        //    }
        //    return MaxIndexLine;
        //}

    }
}
